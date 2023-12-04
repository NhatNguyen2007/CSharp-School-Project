
namespace MusicApp
{
    partial class Playlist_Song
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
            this.ptr_SongImg = new System.Windows.Forms.PictureBox();
            this.lbl_SongName = new System.Windows.Forms.Label();
            this.lbl_ArtistName = new System.Windows.Forms.Label();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.rjDropDownMenu1 = new MusicApp.RJDropDownMenu(this.components);
            this.removeFromThisPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_SongImg)).BeginInit();
            this.rjDropDownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptr_SongImg
            // 
            this.ptr_SongImg.Location = new System.Drawing.Point(2, 2);
            this.ptr_SongImg.Name = "ptr_SongImg";
            this.ptr_SongImg.Size = new System.Drawing.Size(50, 50);
            this.ptr_SongImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_SongImg.TabIndex = 0;
            this.ptr_SongImg.TabStop = false;
            this.ptr_SongImg.Click += new System.EventHandler(this.ptr_SongImg_Click);
            this.ptr_SongImg.MouseLeave += new System.EventHandler(this.ptr_SongImg_MouseLeave);
            this.ptr_SongImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptr_SongImg_MouseMove);
            // 
            // lbl_SongName
            // 
            this.lbl_SongName.AutoSize = true;
            this.lbl_SongName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SongName.ForeColor = System.Drawing.Color.White;
            this.lbl_SongName.Location = new System.Drawing.Point(58, 18);
            this.lbl_SongName.Name = "lbl_SongName";
            this.lbl_SongName.Size = new System.Drawing.Size(89, 18);
            this.lbl_SongName.TabIndex = 3;
            this.lbl_SongName.Text = "Song Name";
            this.lbl_SongName.Click += new System.EventHandler(this.lbl_SongName_Click);
            this.lbl_SongName.MouseLeave += new System.EventHandler(this.lbl_SongName_MouseLeave);
            this.lbl_SongName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_SongName_MouseMove);
            // 
            // lbl_ArtistName
            // 
            this.lbl_ArtistName.AutoSize = true;
            this.lbl_ArtistName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ArtistName.ForeColor = System.Drawing.Color.White;
            this.lbl_ArtistName.Location = new System.Drawing.Point(348, 19);
            this.lbl_ArtistName.Name = "lbl_ArtistName";
            this.lbl_ArtistName.Size = new System.Drawing.Size(84, 17);
            this.lbl_ArtistName.TabIndex = 3;
            this.lbl_ArtistName.Text = "Artist Name";
            this.lbl_ArtistName.MouseLeave += new System.EventHandler(this.lbl_ArtistName_MouseLeave);
            this.lbl_ArtistName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_ArtistName_MouseMove);
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.ForeColor = System.Drawing.Color.White;
            this.lbl_Duration.Location = new System.Drawing.Point(693, 19);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(63, 17);
            this.lbl_Duration.TabIndex = 3;
            this.lbl_Duration.Text = "Duration";
            // 
            // rjDropDownMenu1
            // 
            this.rjDropDownMenu1.IsMainMenu = false;
            this.rjDropDownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromThisPlaylistToolStripMenuItem});
            this.rjDropDownMenu1.MenuItemHeight = 25;
            this.rjDropDownMenu1.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.rjDropDownMenu1.Name = "rjDropDownMenu1";
            this.rjDropDownMenu1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.rjDropDownMenu1.Size = new System.Drawing.Size(236, 26);
            // 
            // removeFromThisPlaylistToolStripMenuItem
            // 
            this.removeFromThisPlaylistToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.removeFromThisPlaylistToolStripMenuItem.Name = "removeFromThisPlaylistToolStripMenuItem";
            this.removeFromThisPlaylistToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.removeFromThisPlaylistToolStripMenuItem.Text = "Remove from this playlist";
            this.removeFromThisPlaylistToolStripMenuItem.Click += new System.EventHandler(this.removeFromThisPlaylistToolStripMenuItem_Click);
            // 
            // Playlist_Song
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ContextMenuStrip = this.rjDropDownMenu1;
            this.Controls.Add(this.lbl_Duration);
            this.Controls.Add(this.lbl_ArtistName);
            this.Controls.Add(this.lbl_SongName);
            this.Controls.Add(this.ptr_SongImg);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Playlist_Song";
            this.Size = new System.Drawing.Size(779, 54);
            this.Load += new System.EventHandler(this.Playlist_Song_Load);
            this.Click += new System.EventHandler(this.Playlist_Song_Click);
            this.Leave += new System.EventHandler(this.Playlist_Song_Leave);
            this.MouseLeave += new System.EventHandler(this.Playlist_Song_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Playlist_Song_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_SongImg)).EndInit();
            this.rjDropDownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptr_SongImg;
        private System.Windows.Forms.Label lbl_SongName;
        private System.Windows.Forms.Label lbl_ArtistName;
        private System.Windows.Forms.Label lbl_Duration;
        private RJDropDownMenu rjDropDownMenu1;
        private System.Windows.Forms.ToolStripMenuItem removeFromThisPlaylistToolStripMenuItem;
    }
}
