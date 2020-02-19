namespace HTTPDownloader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.URLLabel1 = new System.Windows.Forms.Label();
            this.URLTextBox1 = new System.Windows.Forms.TextBox();
            this.URLTextBox2 = new System.Windows.Forms.TextBox();
            this.URLLabel2 = new System.Windows.Forms.Label();
            this.URLTextBox3 = new System.Windows.Forms.TextBox();
            this.URLLabel3 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // URLLabel1
            // 
            this.URLLabel1.AutoSize = true;
            this.URLLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLLabel1.Location = new System.Drawing.Point(12, 45);
            this.URLLabel1.Name = "URLLabel1";
            this.URLLabel1.Size = new System.Drawing.Size(61, 24);
            this.URLLabel1.TabIndex = 0;
            this.URLLabel1.Text = "URL 1";
            // 
            // URLTextBox1
            // 
            this.URLTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLTextBox1.Location = new System.Drawing.Point(137, 42);
            this.URLTextBox1.Name = "URLTextBox1";
            this.URLTextBox1.Size = new System.Drawing.Size(976, 29);
            this.URLTextBox1.TabIndex = 1;
            // 
            // URLTextBox2
            // 
            this.URLTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLTextBox2.Location = new System.Drawing.Point(137, 113);
            this.URLTextBox2.Name = "URLTextBox2";
            this.URLTextBox2.Size = new System.Drawing.Size(976, 29);
            this.URLTextBox2.TabIndex = 3;
            // 
            // URLLabel2
            // 
            this.URLLabel2.AutoSize = true;
            this.URLLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLLabel2.Location = new System.Drawing.Point(12, 116);
            this.URLLabel2.Name = "URLLabel2";
            this.URLLabel2.Size = new System.Drawing.Size(61, 24);
            this.URLLabel2.TabIndex = 2;
            this.URLLabel2.Text = "URL 2";
            // 
            // URLTextBox3
            // 
            this.URLTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLTextBox3.Location = new System.Drawing.Point(137, 190);
            this.URLTextBox3.Name = "URLTextBox3";
            this.URLTextBox3.Size = new System.Drawing.Size(976, 29);
            this.URLTextBox3.TabIndex = 5;
            // 
            // URLLabel3
            // 
            this.URLLabel3.AutoSize = true;
            this.URLLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLLabel3.Location = new System.Drawing.Point(12, 193);
            this.URLLabel3.Name = "URLLabel3";
            this.URLLabel3.Size = new System.Drawing.Size(61, 24);
            this.URLLabel3.TabIndex = 4;
            this.URLLabel3.Text = "URL 3";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(137, 283);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(122, 38);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(335, 283);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(122, 38);
            this.stopBtn.TabIndex = 7;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(16, 377);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTextBox.Size = new System.Drawing.Size(1097, 131);
            this.resultTextBox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 537);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.URLTextBox3);
            this.Controls.Add(this.URLLabel3);
            this.Controls.Add(this.URLTextBox2);
            this.Controls.Add(this.URLLabel2);
            this.Controls.Add(this.URLTextBox1);
            this.Controls.Add(this.URLLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTTPDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label URLLabel1;
        private System.Windows.Forms.TextBox URLTextBox1;
        private System.Windows.Forms.TextBox URLTextBox2;
        private System.Windows.Forms.Label URLLabel2;
        private System.Windows.Forms.TextBox URLTextBox3;
        private System.Windows.Forms.Label URLLabel3;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

