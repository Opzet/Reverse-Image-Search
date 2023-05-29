namespace ReverseImageSearch
{
    partial class Form1
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
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.picSearchImage = new System.Windows.Forms.PictureBox();
            this.btnProcessImage = new System.Windows.Forms.Button();
            this.btnLoadFolder = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListBox();
            this.picResultImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCentroids = new System.Windows.Forms.TextBox();
            this.btnAddCentroid = new System.Windows.Forms.Button();
            this.chkPreviewProcessedImage = new System.Windows.Forms.CheckBox();
            this.btnSearchImageList = new System.Windows.Forms.Button();
            this.lblSimilarity = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCalculateSimilarity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(13, 3);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(243, 33);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // picSearchImage
            // 
            this.picSearchImage.Location = new System.Drawing.Point(13, 42);
            this.picSearchImage.Name = "picSearchImage";
            this.picSearchImage.Size = new System.Drawing.Size(243, 243);
            this.picSearchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearchImage.TabIndex = 1;
            this.picSearchImage.TabStop = false;
            // 
            // btnProcessImage
            // 
            this.btnProcessImage.Location = new System.Drawing.Point(12, 291);
            this.btnProcessImage.Name = "btnProcessImage";
            this.btnProcessImage.Size = new System.Drawing.Size(244, 33);
            this.btnProcessImage.TabIndex = 2;
            this.btnProcessImage.Text = "Process Image";
            this.btnProcessImage.UseVisualStyleBackColor = true;
            this.btnProcessImage.Click += new System.EventHandler(this.btnProcessImage_Click);
            // 
            // btnLoadFolder
            // 
            this.btnLoadFolder.Location = new System.Drawing.Point(262, 3);
            this.btnLoadFolder.Name = "btnLoadFolder";
            this.btnLoadFolder.Size = new System.Drawing.Size(243, 33);
            this.btnLoadFolder.TabIndex = 3;
            this.btnLoadFolder.Text = "Load Folder";
            this.btnLoadFolder.UseVisualStyleBackColor = true;
            this.btnLoadFolder.Click += new System.EventHandler(this.btnLoadFolder_Click);
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.ItemHeight = 16;
            this.fileList.Location = new System.Drawing.Point(262, 42);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(243, 244);
            this.fileList.TabIndex = 4;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            // 
            // picResultImage
            // 
            this.picResultImage.Location = new System.Drawing.Point(511, 42);
            this.picResultImage.Name = "picResultImage";
            this.picResultImage.Size = new System.Drawing.Size(243, 243);
            this.picResultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResultImage.TabIndex = 5;
            this.picResultImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Centroids:";
            // 
            // txtCentroids
            // 
            this.txtCentroids.Enabled = false;
            this.txtCentroids.Location = new System.Drawing.Point(93, 335);
            this.txtCentroids.Name = "txtCentroids";
            this.txtCentroids.Size = new System.Drawing.Size(116, 22);
            this.txtCentroids.TabIndex = 7;
            this.txtCentroids.Text = "0";
            // 
            // btnAddCentroid
            // 
            this.btnAddCentroid.Location = new System.Drawing.Point(215, 330);
            this.btnAddCentroid.Name = "btnAddCentroid";
            this.btnAddCentroid.Size = new System.Drawing.Size(41, 33);
            this.btnAddCentroid.TabIndex = 8;
            this.btnAddCentroid.Text = "+";
            this.btnAddCentroid.UseVisualStyleBackColor = true;
            this.btnAddCentroid.Click += new System.EventHandler(this.btnAddCentroid_Click);
            // 
            // chkPreviewProcessedImage
            // 
            this.chkPreviewProcessedImage.AutoSize = true;
            this.chkPreviewProcessedImage.Location = new System.Drawing.Point(13, 363);
            this.chkPreviewProcessedImage.Name = "chkPreviewProcessedImage";
            this.chkPreviewProcessedImage.Size = new System.Drawing.Size(192, 21);
            this.chkPreviewProcessedImage.TabIndex = 9;
            this.chkPreviewProcessedImage.Text = "Preview Processed Image";
            this.chkPreviewProcessedImage.UseVisualStyleBackColor = true;
            this.chkPreviewProcessedImage.CheckedChanged += new System.EventHandler(this.chkPreviewProcessedImage_CheckedChanged);
            // 
            // btnSearchImageList
            // 
            this.btnSearchImageList.Location = new System.Drawing.Point(262, 291);
            this.btnSearchImageList.Name = "btnSearchImageList";
            this.btnSearchImageList.Size = new System.Drawing.Size(244, 33);
            this.btnSearchImageList.TabIndex = 10;
            this.btnSearchImageList.Text = "Search";
            this.btnSearchImageList.UseVisualStyleBackColor = true;
            this.btnSearchImageList.Click += new System.EventHandler(this.btnSearchImageList_Click);
            // 
            // lblSimilarity
            // 
            this.lblSimilarity.AutoSize = true;
            this.lblSimilarity.Location = new System.Drawing.Point(511, 11);
            this.lblSimilarity.Name = "lblSimilarity";
            this.lblSimilarity.Size = new System.Drawing.Size(68, 17);
            this.lblSimilarity.TabIndex = 11;
            this.lblSimilarity.Text = "Similarity:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(511, 291);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(243, 33);
            this.progressBar1.TabIndex = 12;
            // 
            // btnCalculateSimilarity
            // 
            this.btnCalculateSimilarity.Location = new System.Drawing.Point(511, 330);
            this.btnCalculateSimilarity.Name = "btnCalculateSimilarity";
            this.btnCalculateSimilarity.Size = new System.Drawing.Size(243, 33);
            this.btnCalculateSimilarity.TabIndex = 13;
            this.btnCalculateSimilarity.Text = "Calculate Similarity";
            this.btnCalculateSimilarity.UseVisualStyleBackColor = true;
            this.btnCalculateSimilarity.Click += new System.EventHandler(this.btnCalculateSimilarity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 394);
            this.Controls.Add(this.btnCalculateSimilarity);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblSimilarity);
            this.Controls.Add(this.btnSearchImageList);
            this.Controls.Add(this.chkPreviewProcessedImage);
            this.Controls.Add(this.btnAddCentroid);
            this.Controls.Add(this.txtCentroids);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picResultImage);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.btnLoadFolder);
            this.Controls.Add(this.btnProcessImage);
            this.Controls.Add(this.picSearchImage);
            this.Controls.Add(this.btnLoadImage);
            this.Name = "Form1";
            this.Text = "Reverse Image Search";
            ((System.ComponentModel.ISupportInitialize)(this.picSearchImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox picSearchImage;
        private System.Windows.Forms.Button btnProcessImage;
        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.PictureBox picResultImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCentroids;
        private System.Windows.Forms.Button btnAddCentroid;
        private System.Windows.Forms.CheckBox chkPreviewProcessedImage;
        private System.Windows.Forms.Button btnSearchImageList;
        private System.Windows.Forms.Label lblSimilarity;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCalculateSimilarity;
    }
}

