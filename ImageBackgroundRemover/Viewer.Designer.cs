namespace ImageBackground_Remover
{
    partial class Viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewer));
            this.ImageViewer = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageViewer
            // 
            this.ImageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageViewer.Location = new System.Drawing.Point(0, 0);
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.Size = new System.Drawing.Size(1047, 640);
            this.ImageViewer.TabIndex = 0;
            this.ImageViewer.TabStop = false;
            this.ImageViewer.Click += new System.EventHandler(this.ImageViewer_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Location = new System.Drawing.Point(8, 8);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(27, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "<";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 640);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.ImageViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Viewer";
            this.Text = "Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageViewer;
        private System.Windows.Forms.Button btnReturn;
    }
}