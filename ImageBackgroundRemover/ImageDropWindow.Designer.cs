namespace ImageBackground_Remover
{
    partial class ImageDropWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageDropWindow));
            this.lblDragDrop = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhotoRoomAttributionLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoRoomAttributionLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDragDrop
            // 
            this.lblDragDrop.AllowDrop = true;
            this.lblDragDrop.BackColor = System.Drawing.Color.Transparent;
            this.lblDragDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDragDrop.ForeColor = System.Drawing.Color.Gray;
            this.lblDragDrop.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblDragDrop.Location = new System.Drawing.Point(9, 24);
            this.lblDragDrop.Name = "lblDragDrop";
            this.lblDragDrop.Size = new System.Drawing.Size(331, 191);
            this.lblDragDrop.TabIndex = 0;
            this.lblDragDrop.Text = "Drag && Drop";
            this.lblDragDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblDragDrop_DragDrop);
            this.lblDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblDragDrop_DragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewerToolStripMenuItem
            // 
            this.viewerToolStripMenuItem.Name = "viewerToolStripMenuItem";
            this.viewerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.viewerToolStripMenuItem.Text = "Viewer";
            this.viewerToolStripMenuItem.Click += new System.EventHandler(this.ViewerToolStripMenuItem_Click);
            // 
            // PhotoRoomAttributionLogo
            // 
            this.PhotoRoomAttributionLogo.Image = global::ImageBackground_Remover.Properties.Resources.PhotoRoom_API_Attribution_Default_English;
            this.PhotoRoomAttributionLogo.Location = new System.Drawing.Point(229, 177);
            this.PhotoRoomAttributionLogo.Name = "PhotoRoomAttributionLogo";
            this.PhotoRoomAttributionLogo.Size = new System.Drawing.Size(132, 54);
            this.PhotoRoomAttributionLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoRoomAttributionLogo.TabIndex = 1;
            this.PhotoRoomAttributionLogo.TabStop = false;
            this.PhotoRoomAttributionLogo.Click += new System.EventHandler(this.PhotoRoomAttributionLogo_Click);
            // 
            // ImageDropWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 221);
            this.Controls.Add(this.PhotoRoomAttributionLogo);
            this.Controls.Add(this.lblDragDrop);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ImageDropWindow";
            this.Text = "Background Remover";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageDropWindow_FormClosing);
            this.Load += new System.EventHandler(this.ImageDropWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoRoomAttributionLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDragDrop;
        private System.Windows.Forms.PictureBox PhotoRoomAttributionLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewerToolStripMenuItem;
    }
}

