
namespace MusicApp
{
    partial class MusicBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicBox));
            this.pnl_wrapper = new Bunifu.UI.WinForms.BunifuPanel();
            this.rjDropDownMenu1 = new MusicApp.RJDropDownMenu(this.components);
            this.addToPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ArtistName = new System.Windows.Forms.Label();
            this.lbl_SongName = new System.Windows.Forms.Label();
            this.ptr_SongImg = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnl_wrapper.SuspendLayout();
            this.rjDropDownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_SongImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_wrapper
            // 
            this.pnl_wrapper.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.pnl_wrapper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_wrapper.BackgroundImage")));
            this.pnl_wrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_wrapper.BorderColor = System.Drawing.Color.Transparent;
            this.pnl_wrapper.BorderRadius = 10;
            this.pnl_wrapper.BorderThickness = 1;
            this.pnl_wrapper.ContextMenuStrip = this.rjDropDownMenu1;
            this.pnl_wrapper.Controls.Add(this.lbl_ArtistName);
            this.pnl_wrapper.Controls.Add(this.lbl_SongName);
            this.pnl_wrapper.Controls.Add(this.ptr_SongImg);
            this.pnl_wrapper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_wrapper.Location = new System.Drawing.Point(0, 0);
            this.pnl_wrapper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_wrapper.Name = "pnl_wrapper";
            this.pnl_wrapper.ShowBorders = true;
            this.pnl_wrapper.Size = new System.Drawing.Size(222, 331);
            this.pnl_wrapper.TabIndex = 1;
            this.pnl_wrapper.Click += new System.EventHandler(this.pnl_wrapper_Click);
            this.pnl_wrapper.MouseLeave += new System.EventHandler(this.pnl_wrapper_MouseLeave);
            this.pnl_wrapper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_wrapper_MouseMove);
            // 
            // rjDropDownMenu1
            // 
            this.rjDropDownMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.rjDropDownMenu1.IsMainMenu = false;
            this.rjDropDownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToPlaylistToolStripMenuItem,
            this.downloadToolStripMenuItem});
            this.rjDropDownMenu1.MenuItemHeight = 25;
            this.rjDropDownMenu1.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.rjDropDownMenu1.Name = "rjDropDownMenu1";
            this.rjDropDownMenu1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.rjDropDownMenu1.Size = new System.Drawing.Size(218, 64);
            // 
            // addToPlaylistToolStripMenuItem
            // 
            this.addToPlaylistToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToPlaylistToolStripMenuItem.Name = "addToPlaylistToolStripMenuItem";
            this.addToPlaylistToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.addToPlaylistToolStripMenuItem.Text = "Add to playlist";
            this.addToPlaylistToolStripMenuItem.Click += new System.EventHandler(this.addToPlaylistToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // lbl_ArtistName
            // 
            this.lbl_ArtistName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArtistName.ForeColor = System.Drawing.Color.White;
            this.lbl_ArtistName.Location = new System.Drawing.Point(14, 251);
            this.lbl_ArtistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ArtistName.Name = "lbl_ArtistName";
            this.lbl_ArtistName.Size = new System.Drawing.Size(200, 55);
            this.lbl_ArtistName.TabIndex = 2;
            this.lbl_ArtistName.Text = "Artist Name";
            this.lbl_ArtistName.Click += new System.EventHandler(this.lbl_ArtistName_Click);
            this.lbl_ArtistName.MouseLeave += new System.EventHandler(this.lbl_ArtistName_MouseLeave);
            this.lbl_ArtistName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_ArtistName_MouseMove);
            // 
            // lbl_SongName
            // 
            this.lbl_SongName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SongName.ForeColor = System.Drawing.Color.White;
            this.lbl_SongName.Location = new System.Drawing.Point(14, 218);
            this.lbl_SongName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SongName.Name = "lbl_SongName";
            this.lbl_SongName.Size = new System.Drawing.Size(200, 35);
            this.lbl_SongName.TabIndex = 2;
            this.lbl_SongName.Text = "Song Name";
            this.lbl_SongName.MouseLeave += new System.EventHandler(this.lbl_SongName_MouseLeave);
            this.lbl_SongName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_SongName_MouseMove);
            // 
            // ptr_SongImg
            // 
            this.ptr_SongImg.AllowFocused = false;
            this.ptr_SongImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptr_SongImg.AutoSizeHeight = true;
            this.ptr_SongImg.BorderRadius = 0;
            this.ptr_SongImg.ContextMenuStrip = this.rjDropDownMenu1;
            this.ptr_SongImg.Image = ((System.Drawing.Image)(resources.GetObject("ptr_SongImg.Image")));
            this.ptr_SongImg.IsCircle = true;
            this.ptr_SongImg.Location = new System.Drawing.Point(18, 17);
            this.ptr_SongImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptr_SongImg.Name = "ptr_SongImg";
            this.ptr_SongImg.Size = new System.Drawing.Size(186, 186);
            this.ptr_SongImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_SongImg.TabIndex = 1;
            this.ptr_SongImg.TabStop = false;
            this.ptr_SongImg.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.ptr_SongImg.Click += new System.EventHandler(this.ptr_SongImg_Click);
            this.ptr_SongImg.DoubleClick += new System.EventHandler(this.ptr_SongImg_DoubleClick);
            this.ptr_SongImg.MouseLeave += new System.EventHandler(this.ptr_SongImg_MouseLeave);
            this.ptr_SongImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptr_SongImg_MouseMove);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MusicBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_wrapper);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MusicBox";
            this.Size = new System.Drawing.Size(222, 331);
            this.Load += new System.EventHandler(this.MusicBox_Load);
            this.pnl_wrapper.ResumeLayout(false);
            this.rjDropDownMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_SongImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnl_wrapper;
        private Bunifu.UI.WinForms.BunifuPictureBox ptr_SongImg;
        private System.Windows.Forms.Label lbl_SongName;
        private System.Windows.Forms.Label lbl_ArtistName;
        private RJDropDownMenu rjDropDownMenu1;
        private System.Windows.Forms.ToolStripMenuItem addToPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
