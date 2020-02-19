using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HTTPDownloader
{
    class AsyncDownloader:IDisposable
    {

        // No need for collections, it's only 3 tasks. Pre-defined number of tasks.
        // It's faster than using collections.
        private Task<string> urlTask1;
        private Task<string> urlTask2;
        private Task<string> urlTask3;


        /// <summary>
        /// Validating the input passed to AsyncDownloader class constructor
        /// </summary>
        /// <param name="url1">url1 string</param>
        /// <param name="url2">url2 string</param>
        /// <param name="url3">url3 string</param>
        /// <returns>True if the input is valid</returns>
        private bool IsValidInput(string url1, string url2, string url3)
        {
            // Here I am demonstrating a simple validation of the URLs.
            // This can be expanded to check if they have proper HTTP(s) URL format.
            if (string.IsNullOrEmpty(url1) || string.IsNullOrEmpty(url2) || string.IsNullOrEmpty(url3))
            {
                return false;
            }
            
            return true;
        }

        /// <summary>
        /// Method to download passed URLs
        /// </summary>
        /// <param name="url1">url1 string</param>
        /// <param name="url2">url2 string</param>
        /// <param name="url3">url3 string</param>
        /// <param name="cancelToken">Optional: CancellationToken to handle cancellation</param>
        /// <returns>Length of the downloaded content of all URLs</returns>
        public async Task<string> DoDownload(string url1, string url2, string url3, CancellationToken cancelToken = default)
        {
            if (!IsValidInput(url1, url2, url3))
            {
                return "Error ---- Not valid input";
            }

            CleanUP();

            // No need for collections, it's only 3 tasks. Pre-defined number of tasks.
            urlTask1 = DownloadURL(url1, cancelToken);
            urlTask2 = DownloadURL(url2, cancelToken);
            urlTask3 = DownloadURL(url3, cancelToken);
            try
            {
                await Task.WhenAll(new Task<string>[] { urlTask1, urlTask2, urlTask3 });
                return (urlTask1.Result.Length + urlTask2.Result.Length + urlTask3.Result.Length).ToString();
            }
            catch (OperationCanceledException)
            {
                return "Error ---- Operations canceled";
            }
            catch (Exception ex)
            {
                return "Error ---- unknown error " + ex;
            }
        }


        /// <summary>
        /// Download the content of a URL
        /// </summary>
        /// <param name="url">URL to download</param>
        /// <param name="cancelToken">Optional: CancellationToken to handle cancellation</param>
        /// <returns>String content of downloaded resource</returns>
        private async Task<string> DownloadURL(string url, CancellationToken cancelToken = default)
        {
            // First, check if the task is canceled before starting.
            cancelToken.ThrowIfCancellationRequested();

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url, cancelToken);
            
            cancelToken.ThrowIfCancellationRequested();

            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Clean up tasks objects
        /// </summary>
        private void CleanUP()
        {
            if (urlTask1 != null)
            {
                urlTask1.Dispose();
            }
            if (urlTask2 != null)
            {
                urlTask2.Dispose();
            }
            if (urlTask3 != null)
            {
                urlTask3.Dispose();
            }
            
        }

        public void Dispose()
        {
            CleanUP();            
        }
    }
}
