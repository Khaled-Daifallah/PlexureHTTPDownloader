using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTPDownloader
{
    public partial class MainForm : Form
    {
        private AsyncDownloader myAsyncDownloader;
        private CancellationTokenSource _cancelTokenSource = new CancellationTokenSource();
        public MainForm()
        {
            InitializeComponent();
            myAsyncDownloader = new AsyncDownloader();
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            resultTextBox.Text = "";

            _cancelTokenSource = new CancellationTokenSource();

            // No need to pass and handle CancellationTokenSource in the main task runner, since all internal async code handle cancellation
            string result = await Task.Run(() =>
               myAsyncDownloader.DoDownload(URLTextBox1.Text, URLTextBox2.Text, URLTextBox3.Text,_cancelTokenSource.Token));

            resultTextBox.Text = result;

            startBtn.Enabled = true;
            stopBtn.Enabled = false;

            _cancelTokenSource.Dispose();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            _cancelTokenSource.Cancel();
        }
        
    }
}
