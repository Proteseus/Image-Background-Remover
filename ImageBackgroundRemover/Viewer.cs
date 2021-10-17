using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageBackground_Remover
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        private void ImageViewer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "No-Bg Images");
            openFile.Filter = "Image Files(*.jpeg; *.jpg; *.png; *.bmp) | *.jpeg; *.jpg; *.png; *.bmp";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ImageViewer.BackgroundImage = Image.FromFile(openFile.FileName);
                //this.directory = openFile.FileName;
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ImageDropWindow dropWindow = new ImageDropWindow();
            dropWindow.Show();
        }
    }
}
