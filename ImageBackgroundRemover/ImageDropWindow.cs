using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ImageBackground_Remover
{
    public partial class ImageDropWindow : Form
    {
        public ImageDropWindow()
        {
            InitializeComponent();
        }
        public static string adres = string.Empty;
        string[] file = new string[1];
        public static string FileAddress = string.Empty;
        string[] _dragDropFile = new string[1];
        
        public void saveDirectory()
        {
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "No-Bg Images");

            if (!System.IO.Directory.Exists(path))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                catch (IOException ie)
                {
                    Console.WriteLine("IO Error: " + ie.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("General Error: " + e.Message);
                }

            }
        }

        private void lblDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        public string IndexedFilename(string Name)
        {
            int ix = new Random().Next(100000000);
            string filename = null;
            char[] trimChar = {'.', 'p', 'n', 'g'};
            string trimmedFileName = Name.TrimEnd(trimChar);
            do
            {
                ix++;
                filename = String.Format("{0}{1}.png", trimmedFileName, ix);
            } while (File.Exists(filename));
            return filename;
        }

        public void moveFile()
        {
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "No-Bg Images");
            if (Directory.Exists(Application.StartupPath))
            {
                foreach (var file in new DirectoryInfo(Application.StartupPath).GetFiles())
                {
                    if(file.Name== "no-bgImage.png")
                    { 
                        string fileName = IndexedFilename(file.Name);
                        file.MoveTo($@"{path}\{fileName}");
                    }
                }
            }
        }

        private void lblDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                //Drag drop
                _dragDropFile = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                foreach (string dragDrop in _dragDropFile)
                FileAddress = dragDrop;
                //Drag drop

                //Api 
                using (var client = new HttpClient())
                using (var formData = new MultipartFormDataContent())
                {
                    //add in your api key to access service
                    formData.Headers.Add("X-Api-Key", " ");
                    formData.Add(new ByteArrayContent(File.ReadAllBytes(FileAddress)), "image_file", FileAddress);
                    formData.Add(new StringContent("auto"), "size");
                    var response = client.PostAsync("https://sdk.photoroom.com/v1/segment", formData).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "No-Bg Images");

                        FileStream fileStream = new FileStream("no-bgImage.png", FileMode.Create, FileAccess.Write, FileShare.None);
                        response.Content.CopyToAsync(fileStream).ContinueWith((copyTask) => { fileStream.Close(); });
                        
                        //move the file to Desktop directory
                        moveFile();
                        MessageBox.Show("Process Complete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
                        //Process.Start(Application.StartupPath);
                        Process.Start(path);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.Content.ReadAsStringAsync().Result);
                    }
                }
                //Api 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PhotoRoomAttributionLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://photoroom.com/");
        }

        private void ImageDropWindow_Load(object sender, EventArgs e)
        {
            this.saveDirectory();
        }

        private void ViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewer viewer = new Viewer();
            this.Hide();
            viewer.Show();
        }

        private void ImageDropWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
