using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ReverseImageSearch
{
    public partial class Form1 : Form
    {
        private Bitmap bmpSearchImage;
        private Bitmap bmpSearchImageProcessed;
        private List<Color> _centroidColor;
        private string[] _fileArray;

        private ImageSearchAlgorithm _algorithm;
        private SearchImage _searchImage;

        private List<KeyValuePair<string, double>> similarityList;
        public Form1()
        {
            InitializeComponent();
            _centroidColor = new List<Color>();
            _algorithm = new ImageSearchAlgorithm();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog()== DialogResult.OK)
                {
                    bmpSearchImage = new Bitmap(ofd.FileName);
                    picSearchImage.Image = bmpSearchImage;
                }
            }
        }

        private void btnProcessImage_Click(object sender, EventArgs e)
        {
            _algorithm.RunAlgorithm(bmpSearchImage,_centroidColor.Count);
            bmpSearchImageProcessed = _algorithm.ProcessImage(bmpSearchImage, _centroidColor);
        }

        private void btnAddCentroid_Click(object sender, EventArgs e)
        {
            using (ColorDialog colDialog = new ColorDialog())
            {
                if (colDialog.ShowDialog()== DialogResult.OK)
                {
                    _centroidColor.Add(colDialog.Color);
                    txtCentroids.Text = _centroidColor.Count.ToString();
                }
            }
        }

        private void chkPreviewProcessedImage_CheckedChanged(object sender, EventArgs e)
        {
            if (bmpSearchImage == null) return;
            if (bmpSearchImageProcessed == null) picSearchImage.Image = bmpSearchImage;
            else
            picSearchImage.Image = chkPreviewProcessedImage.Checked ? bmpSearchImageProcessed : bmpSearchImage;
        }

        private void btnSearchImageList_Click(object sender, EventArgs e)
        {
            _searchImage = new SearchImage(_algorithm);
            similarityList = _searchImage.SortBySimilarity(bmpSearchImageProcessed, _fileArray, _centroidColor);
            fileList.Items.Clear();
            List<string> tempList = new List<string>();
            foreach (var imagePath in similarityList)
                tempList.Add(imagePath.Key);
            _fileArray = tempList.ToArray();
            foreach (var imagePath in _fileArray)
                fileList.Items.Add(System.IO.Path.GetFileNameWithoutExtension(imagePath));

            fileList.SelectedIndex = 0;
        }

        private void btnLoadFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog()== DialogResult.OK)
                {
                    _fileArray = System.IO.Directory.GetFiles(fbd.SelectedPath, "*.jpg");
                    foreach (string image in _fileArray)
                        fileList.Items.Add(System.IO.Path.GetFileNameWithoutExtension(image));
                }
            }
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            picResultImage.Image = Image.FromFile(_fileArray[fileList.SelectedIndex]);
            if (similarityList == null) return;

            var similarityItem = similarityList.FirstOrDefault(x => x.Key == _fileArray[fileList.SelectedIndex]);
            lblSimilarity.Text = String.Format("Similarity: {0}%", Math.Round(similarityItem.Value, 2));
            progressBar1.Value = (int)similarityItem.Value;
        }

        private void btnCalculateSimilarity_Click(object sender, EventArgs e)
        {
            using (Bitmap bmpCurrentImage = new Bitmap(Image.FromFile(_fileArray[fileList.SelectedIndex]), bmpSearchImageProcessed.Width, bmpSearchImageProcessed.Height))
            {
                if (_searchImage == null) _searchImage = new SearchImage(_algorithm);
                using (Bitmap bmpCurrentImageProcessed = _algorithm.ProcessImage(bmpCurrentImage, _centroidColor))
                {
                    double similarity = _searchImage.CalculateSimilarity(bmpSearchImageProcessed, bmpCurrentImageProcessed);
                    lblSimilarity.Text = String.Format("Similarity: {0}%", Math.Round(similarity, 2));
                    progressBar1.Value = (int)similarity;
                }
            }
        }
    }
}
