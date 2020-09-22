namespace TechMWinAssignment
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUploadCSV = new System.Windows.Forms.Button();
            this.btnDownloadCSV = new System.Windows.Forms.Button();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnUploadCSV
            // 
            this.btnUploadCSV.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUploadCSV.Location = new System.Drawing.Point(85, 224);
            this.btnUploadCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUploadCSV.Name = "btnUploadCSV";
            this.btnUploadCSV.Size = new System.Drawing.Size(205, 43);
            this.btnUploadCSV.TabIndex = 0;
            this.btnUploadCSV.Text = "Upload CSV file";
            this.btnUploadCSV.UseVisualStyleBackColor = true;
            this.btnUploadCSV.Click += new System.EventHandler(this.btnUploadCSV_Click);
            // 
            // btnDownloadCSV
            // 
            this.btnDownloadCSV.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDownloadCSV.Location = new System.Drawing.Point(580, 224);
            this.btnDownloadCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDownloadCSV.Name = "btnDownloadCSV";
            this.btnDownloadCSV.Size = new System.Drawing.Size(205, 43);
            this.btnDownloadCSV.TabIndex = 0;
            this.btnDownloadCSV.Text = "Download CSV file";
            this.btnDownloadCSV.UseVisualStyleBackColor = true;
            this.btnDownloadCSV.Click += new System.EventHandler(this.btnDownloadCSV_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 512);
            this.Controls.Add(this.btnDownloadCSV);
            this.Controls.Add(this.btnUploadCSV);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Tech Mahindra Assignment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUploadCSV;
        private System.Windows.Forms.Button btnDownloadCSV;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
    }
}

