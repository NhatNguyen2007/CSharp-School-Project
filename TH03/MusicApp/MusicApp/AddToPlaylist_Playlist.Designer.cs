
namespace MusicApp
{
    partial class AddToPlaylist_Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToPlaylist_Playlist));
            this.ptr_PlaylistPhoto = new System.Windows.Forms.PictureBox();
            this.lbl_PlaylistName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_PlaylistCount = new System.Windows.Forms.Label();
            this.btn_AddToPlaylist = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_PlaylistPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptr_PlaylistPhoto
            // 
            this.ptr_PlaylistPhoto.Location = new System.Drawing.Point(2, 2);
            this.ptr_PlaylistPhoto.Name = "ptr_PlaylistPhoto";
            this.ptr_PlaylistPhoto.Size = new System.Drawing.Size(60, 60);
            this.ptr_PlaylistPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_PlaylistPhoto.TabIndex = 0;
            this.ptr_PlaylistPhoto.TabStop = false;
            // 
            // lbl_PlaylistName
            // 
            this.lbl_PlaylistName.AutoSize = true;
            this.lbl_PlaylistName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlaylistName.ForeColor = System.Drawing.Color.White;
            this.lbl_PlaylistName.Location = new System.Drawing.Point(68, 12);
            this.lbl_PlaylistName.Name = "lbl_PlaylistName";
            this.lbl_PlaylistName.Size = new System.Drawing.Size(95, 16);
            this.lbl_PlaylistName.TabIndex = 1;
            this.lbl_PlaylistName.Text = "Playlist Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_PlaylistCount
            // 
            this.lbl_PlaylistCount.AutoSize = true;
            this.lbl_PlaylistCount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlaylistCount.ForeColor = System.Drawing.Color.White;
            this.lbl_PlaylistCount.Location = new System.Drawing.Point(93, 37);
            this.lbl_PlaylistCount.Name = "lbl_PlaylistCount";
            this.lbl_PlaylistCount.Size = new System.Drawing.Size(40, 15);
            this.lbl_PlaylistCount.TabIndex = 1;
            this.lbl_PlaylistCount.Text = "Count";
            // 
            // btn_AddToPlaylist
            // 
            this.btn_AddToPlaylist.AutoSize = true;
            this.btn_AddToPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_AddToPlaylist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_AddToPlaylist.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_AddToPlaylist.BorderRadius = 0;
            this.btn_AddToPlaylist.BorderSize = 0;
            this.btn_AddToPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddToPlaylist.FlatAppearance.BorderSize = 0;
            this.btn_AddToPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddToPlaylist.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_AddToPlaylist.ForeColor = System.Drawing.Color.White;
            this.btn_AddToPlaylist.Location = new System.Drawing.Point(348, 18);
            this.btn_AddToPlaylist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddToPlaylist.Name = "btn_AddToPlaylist";
            this.btn_AddToPlaylist.Size = new System.Drawing.Size(108, 26);
            this.btn_AddToPlaylist.TabIndex = 3;
            this.btn_AddToPlaylist.Text = "Add to playlist";
            this.btn_AddToPlaylist.TextColor = System.Drawing.Color.White;
            this.btn_AddToPlaylist.UseVisualStyleBackColor = false;
            this.btn_AddToPlaylist.Click += new System.EventHandler(this.btn_AddToPlaylist_Click);
            // 
            // AddToPlaylist_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btn_AddToPlaylist);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_PlaylistName);
            this.Controls.Add(this.ptr_PlaylistPhoto);
            this.Controls.Add(this.lbl_PlaylistCount);
            this.Name = "AddToPlaylist_Playlist";
            this.Size = new System.Drawing.Size(475, 64);
            this.Load += new System.EventHandler(this.AddToPlaylist_Playlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_PlaylistPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptr_PlaylistPhoto;
        private System.Windows.Forms.Label lbl_PlaylistName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton btn_AddToPlaylist;
        public System.Windows.Forms.Label lbl_PlaylistCount;
    }
}
