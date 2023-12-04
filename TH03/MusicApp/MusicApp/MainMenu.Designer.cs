
namespace MusicApp
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_MyPlaylist = new System.Windows.Forms.Panel();
            this.FlLayout_Playlist = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_CreateNewPlaylist = new System.Windows.Forms.Panel();
            this.select_CreateNewPlaylist = new CustomControls.RJControls.RJButton();
            this.ptr_CreateNewPlaylist = new System.Windows.Forms.PictureBox();
            this.btn_CreateNewPlaylist = new CustomControls.RJControls.RJButton();
            this.pnl_LikedSongs = new System.Windows.Forms.Panel();
            this.select_LikedSongs = new CustomControls.RJControls.RJButton();
            this.ptr_LikedSongs = new System.Windows.Forms.PictureBox();
            this.btn_LikedSongs = new CustomControls.RJControls.RJButton();
            this.pnl = new System.Windows.Forms.Panel();
            this.btn_MyPlaylists = new CustomControls.RJControls.RJButton();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.select_Search = new CustomControls.RJControls.RJButton();
            this.ptr_Search = new System.Windows.Forms.PictureBox();
            this.btn_Search = new CustomControls.RJControls.RJButton();
            this.pnl_Home = new System.Windows.Forms.Panel();
            this.select_Home = new CustomControls.RJControls.RJButton();
            this.ptr_Home = new System.Windows.Forms.PictureBox();
            this.btn_Home = new CustomControls.RJControls.RJButton();
            this.btn_Menu = new CustomControls.RJControls.RJButton();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pnl_bi = new System.Windows.Forms.Panel();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.btn_Like = new System.Windows.Forms.PictureBox();
            this.lbl_CurrentMusicArtist = new System.Windows.Forms.Label();
            this.lbl_CurrentMusicSong = new System.Windows.Forms.Label();
            this.ptr_CurrentMusic = new System.Windows.Forms.PictureBox();
            this.lbl_TrackEnd = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_TrackStart = new Bunifu.UI.WinForms.BunifuLabel();
            this.VolumeBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btn_PreviousTrack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ProgressBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btn_Volume = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_NextTrack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_PlayPause = new Bunifu.UI.WinForms.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pnl_MyPlaylist.SuspendLayout();
            this.pnl_CreateNewPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_CreateNewPlaylist)).BeginInit();
            this.pnl_LikedSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_LikedSongs)).BeginInit();
            this.pnl.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Search)).BeginInit();
            this.pnl_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Home)).BeginInit();
            this.pnl_Header.SuspendLayout();
            this.pnl_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.pnl_bi.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            this.pnl_Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_CurrentMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.panel1.Controls.Add(this.pnl_MyPlaylist);
            this.panel1.Controls.Add(this.pnl);
            this.panel1.Controls.Add(this.pnl_Menu);
            this.panel1.Controls.Add(this.btn_Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 515);
            this.panel1.TabIndex = 0;
            // 
            // pnl_MyPlaylist
            // 
            this.pnl_MyPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.pnl_MyPlaylist.Controls.Add(this.FlLayout_Playlist);
            this.pnl_MyPlaylist.Controls.Add(this.pnl_CreateNewPlaylist);
            this.pnl_MyPlaylist.Controls.Add(this.pnl_LikedSongs);
            this.pnl_MyPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MyPlaylist.Location = new System.Drawing.Point(0, 163);
            this.pnl_MyPlaylist.Name = "pnl_MyPlaylist";
            this.pnl_MyPlaylist.Size = new System.Drawing.Size(245, 300);
            this.pnl_MyPlaylist.TabIndex = 4;
            // 
            // FlLayout_Playlist
            // 
            this.FlLayout_Playlist.AutoScroll = true;
            this.FlLayout_Playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlLayout_Playlist.Location = new System.Drawing.Point(0, 80);
            this.FlLayout_Playlist.Name = "FlLayout_Playlist";
            this.FlLayout_Playlist.Size = new System.Drawing.Size(245, 220);
            this.FlLayout_Playlist.TabIndex = 3;
            // 
            // pnl_CreateNewPlaylist
            // 
            this.pnl_CreateNewPlaylist.Controls.Add(this.select_CreateNewPlaylist);
            this.pnl_CreateNewPlaylist.Controls.Add(this.ptr_CreateNewPlaylist);
            this.pnl_CreateNewPlaylist.Controls.Add(this.btn_CreateNewPlaylist);
            this.pnl_CreateNewPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_CreateNewPlaylist.Location = new System.Drawing.Point(0, 40);
            this.pnl_CreateNewPlaylist.Name = "pnl_CreateNewPlaylist";
            this.pnl_CreateNewPlaylist.Size = new System.Drawing.Size(245, 40);
            this.pnl_CreateNewPlaylist.TabIndex = 2;
            // 
            // select_CreateNewPlaylist
            // 
            this.select_CreateNewPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.select_CreateNewPlaylist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.select_CreateNewPlaylist.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.select_CreateNewPlaylist.BorderRadius = 5;
            this.select_CreateNewPlaylist.BorderSize = 0;
            this.select_CreateNewPlaylist.Dock = System.Windows.Forms.DockStyle.Right;
            this.select_CreateNewPlaylist.FlatAppearance.BorderSize = 0;
            this.select_CreateNewPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_CreateNewPlaylist.ForeColor = System.Drawing.Color.White;
            this.select_CreateNewPlaylist.Location = new System.Drawing.Point(240, 0);
            this.select_CreateNewPlaylist.Name = "select_CreateNewPlaylist";
            this.select_CreateNewPlaylist.Size = new System.Drawing.Size(5, 40);
            this.select_CreateNewPlaylist.TabIndex = 4;
            this.select_CreateNewPlaylist.TextColor = System.Drawing.Color.White;
            this.select_CreateNewPlaylist.UseVisualStyleBackColor = false;
            // 
            // ptr_CreateNewPlaylist
            // 
            this.ptr_CreateNewPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ptr_CreateNewPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptr_CreateNewPlaylist.BackgroundImage")));
            this.ptr_CreateNewPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptr_CreateNewPlaylist.Location = new System.Drawing.Point(18, 0);
            this.ptr_CreateNewPlaylist.Name = "ptr_CreateNewPlaylist";
            this.ptr_CreateNewPlaylist.Size = new System.Drawing.Size(25, 40);
            this.ptr_CreateNewPlaylist.TabIndex = 3;
            this.ptr_CreateNewPlaylist.TabStop = false;
            // 
            // btn_CreateNewPlaylist
            // 
            this.btn_CreateNewPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.btn_CreateNewPlaylist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.btn_CreateNewPlaylist.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_CreateNewPlaylist.BorderRadius = 0;
            this.btn_CreateNewPlaylist.BorderSize = 0;
            this.btn_CreateNewPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateNewPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_CreateNewPlaylist.FlatAppearance.BorderSize = 0;
            this.btn_CreateNewPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateNewPlaylist.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btn_CreateNewPlaylist.ForeColor = System.Drawing.Color.Silver;
            this.btn_CreateNewPlaylist.Location = new System.Drawing.Point(0, 0);
            this.btn_CreateNewPlaylist.Name = "btn_CreateNewPlaylist";
            this.btn_CreateNewPlaylist.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btn_CreateNewPlaylist.Size = new System.Drawing.Size(245, 40);
            this.btn_CreateNewPlaylist.TabIndex = 1;
            this.btn_CreateNewPlaylist.Text = "Create new playlist";
            this.btn_CreateNewPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateNewPlaylist.TextColor = System.Drawing.Color.Silver;
            this.btn_CreateNewPlaylist.UseVisualStyleBackColor = false;
            this.btn_CreateNewPlaylist.Click += new System.EventHandler(this.btn_CreateNewPlaylist_Click);
            this.btn_CreateNewPlaylist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_CreateNewPlaylist_MouseDown);
            this.btn_CreateNewPlaylist.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_CreateNewPlaylist_MouseUp);
            // 
            // pnl_LikedSongs
            // 
            this.pnl_LikedSongs.Controls.Add(this.select_LikedSongs);
            this.pnl_LikedSongs.Controls.Add(this.ptr_LikedSongs);
            this.pnl_LikedSongs.Controls.Add(this.btn_LikedSongs);
            this.pnl_LikedSongs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_LikedSongs.Location = new System.Drawing.Point(0, 0);
            this.pnl_LikedSongs.Name = "pnl_LikedSongs";
            this.pnl_LikedSongs.Size = new System.Drawing.Size(245, 40);
            this.pnl_LikedSongs.TabIndex = 1;
            // 
            // select_LikedSongs
            // 
            this.select_LikedSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.select_LikedSongs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.select_LikedSongs.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.select_LikedSongs.BorderRadius = 5;
            this.select_LikedSongs.BorderSize = 0;
            this.select_LikedSongs.Dock = System.Windows.Forms.DockStyle.Right;
            this.select_LikedSongs.FlatAppearance.BorderSize = 0;
            this.select_LikedSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_LikedSongs.ForeColor = System.Drawing.Color.White;
            this.select_LikedSongs.Location = new System.Drawing.Point(240, 0);
            this.select_LikedSongs.Name = "select_LikedSongs";
            this.select_LikedSongs.Size = new System.Drawing.Size(5, 40);
            this.select_LikedSongs.TabIndex = 4;
            this.select_LikedSongs.TextColor = System.Drawing.Color.White;
            this.select_LikedSongs.UseVisualStyleBackColor = false;
            // 
            // ptr_LikedSongs
            // 
            this.ptr_LikedSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ptr_LikedSongs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptr_LikedSongs.BackgroundImage")));
            this.ptr_LikedSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptr_LikedSongs.Location = new System.Drawing.Point(18, 0);
            this.ptr_LikedSongs.Name = "ptr_LikedSongs";
            this.ptr_LikedSongs.Size = new System.Drawing.Size(25, 40);
            this.ptr_LikedSongs.TabIndex = 3;
            this.ptr_LikedSongs.TabStop = false;
            // 
            // btn_LikedSongs
            // 
            this.btn_LikedSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.btn_LikedSongs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.btn_LikedSongs.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_LikedSongs.BorderRadius = 0;
            this.btn_LikedSongs.BorderSize = 0;
            this.btn_LikedSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LikedSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_LikedSongs.FlatAppearance.BorderSize = 0;
            this.btn_LikedSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LikedSongs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btn_LikedSongs.ForeColor = System.Drawing.Color.Silver;
            this.btn_LikedSongs.Location = new System.Drawing.Point(0, 0);
            this.btn_LikedSongs.Name = "btn_LikedSongs";
            this.btn_LikedSongs.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btn_LikedSongs.Size = new System.Drawing.Size(245, 40);
            this.btn_LikedSongs.TabIndex = 1;
            this.btn_LikedSongs.Text = "Liked Songs";
            this.btn_LikedSongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LikedSongs.TextColor = System.Drawing.Color.Silver;
            this.btn_LikedSongs.UseVisualStyleBackColor = false;
            this.btn_LikedSongs.Click += new System.EventHandler(this.btn_LikedSongs_Click);
            this.btn_LikedSongs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_LikedSongs_MouseDown);
            this.btn_LikedSongs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_LikedSongs_MouseUp);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.btn_MyPlaylists);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 123);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(245, 40);
            this.pnl.TabIndex = 3;
            // 
            // btn_MyPlaylists
            // 
            this.btn_MyPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.btn_MyPlaylists.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.btn_MyPlaylists.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_MyPlaylists.BorderRadius = 0;
            this.btn_MyPlaylists.BorderSize = 1;
            this.btn_MyPlaylists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MyPlaylists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_MyPlaylists.FlatAppearance.BorderSize = 0;
            this.btn_MyPlaylists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MyPlaylists.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_MyPlaylists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_MyPlaylists.Location = new System.Drawing.Point(0, 0);
            this.btn_MyPlaylists.Name = "btn_MyPlaylists";
            this.btn_MyPlaylists.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_MyPlaylists.Size = new System.Drawing.Size(245, 40);
            this.btn_MyPlaylists.TabIndex = 0;
            this.btn_MyPlaylists.Text = "MY PLAYLISTS";
            this.btn_MyPlaylists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MyPlaylists.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_MyPlaylists.UseVisualStyleBackColor = false;
            this.btn_MyPlaylists.Click += new System.EventHandler(this.btn_MyPlaylists_Click);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.Black;
            this.pnl_Menu.Controls.Add(this.pnl_Search);
            this.pnl_Menu.Controls.Add(this.pnl_Home);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 40);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(245, 83);
            this.pnl_Menu.TabIndex = 2;
            // 
            // pnl_Search
            // 
            this.pnl_Search.Controls.Add(this.select_Search);
            this.pnl_Search.Controls.Add(this.ptr_Search);
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Location = new System.Drawing.Point(0, 40);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(245, 40);
            this.pnl_Search.TabIndex = 0;
            // 
            // select_Search
            // 
            this.select_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.select_Search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.select_Search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.select_Search.BorderRadius = 5;
            this.select_Search.BorderSize = 0;
            this.select_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.select_Search.FlatAppearance.BorderSize = 0;
            this.select_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_Search.ForeColor = System.Drawing.Color.White;
            this.select_Search.Location = new System.Drawing.Point(240, 0);
            this.select_Search.Name = "select_Search";
            this.select_Search.Size = new System.Drawing.Size(5, 40);
            this.select_Search.TabIndex = 3;
            this.select_Search.TextColor = System.Drawing.Color.White;
            this.select_Search.UseVisualStyleBackColor = false;
            // 
            // ptr_Search
            // 
            this.ptr_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ptr_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptr_Search.BackgroundImage")));
            this.ptr_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptr_Search.Location = new System.Drawing.Point(18, 0);
            this.ptr_Search.Name = "ptr_Search";
            this.ptr_Search.Size = new System.Drawing.Size(25, 40);
            this.ptr_Search.TabIndex = 2;
            this.ptr_Search.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.btn_Search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.btn_Search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Search.BorderRadius = 0;
            this.btn_Search.BorderSize = 0;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btn_Search.ForeColor = System.Drawing.Color.Silver;
            this.btn_Search.Location = new System.Drawing.Point(0, 0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btn_Search.Size = new System.Drawing.Size(245, 40);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.TextColor = System.Drawing.Color.Silver;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Search_MouseDown);
            this.btn_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Search_MouseUp);
            // 
            // pnl_Home
            // 
            this.pnl_Home.Controls.Add(this.select_Home);
            this.pnl_Home.Controls.Add(this.ptr_Home);
            this.pnl_Home.Controls.Add(this.btn_Home);
            this.pnl_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Home.Location = new System.Drawing.Point(0, 0);
            this.pnl_Home.Name = "pnl_Home";
            this.pnl_Home.Size = new System.Drawing.Size(245, 40);
            this.pnl_Home.TabIndex = 0;
            // 
            // select_Home
            // 
            this.select_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.select_Home.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.select_Home.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.select_Home.BorderRadius = 5;
            this.select_Home.BorderSize = 0;
            this.select_Home.Dock = System.Windows.Forms.DockStyle.Right;
            this.select_Home.FlatAppearance.BorderSize = 0;
            this.select_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_Home.ForeColor = System.Drawing.Color.White;
            this.select_Home.Location = new System.Drawing.Point(240, 0);
            this.select_Home.Name = "select_Home";
            this.select_Home.Size = new System.Drawing.Size(5, 40);
            this.select_Home.TabIndex = 0;
            this.select_Home.TextColor = System.Drawing.Color.White;
            this.select_Home.UseVisualStyleBackColor = false;
            // 
            // ptr_Home
            // 
            this.ptr_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ptr_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptr_Home.BackgroundImage")));
            this.ptr_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptr_Home.Location = new System.Drawing.Point(18, 0);
            this.ptr_Home.Name = "ptr_Home";
            this.ptr_Home.Size = new System.Drawing.Size(25, 40);
            this.ptr_Home.TabIndex = 1;
            this.ptr_Home.TabStop = false;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.btn_Home.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.btn_Home.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Home.BorderRadius = 0;
            this.btn_Home.BorderSize = 0;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btn_Home.ForeColor = System.Drawing.Color.Silver;
            this.btn_Home.Location = new System.Drawing.Point(0, 0);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btn_Home.Size = new System.Drawing.Size(245, 40);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.TextColor = System.Drawing.Color.Silver;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            this.btn_Home.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rjButton1_MouseDown);
            this.btn_Home.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Home_MouseUp);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.btn_Menu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.btn_Menu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_Menu.BorderRadius = 0;
            this.btn_Menu.BorderSize = 1;
            this.btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_Menu.Location = new System.Drawing.Point(0, 0);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Menu.Size = new System.Drawing.Size(245, 40);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.Text = "MENU";
            this.btn_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Menu.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.pnl_Header.Controls.Add(this.pnl_Logo);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1289, 70);
            this.pnl_Header.TabIndex = 1;
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.pnl_Logo.Controls.Add(this.label1);
            this.pnl_Logo.Controls.Add(this.bunifuPictureBox1);
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(245, 70);
            this.pnl_Logo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Musify";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 29;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(6, 7);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(58, 58);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // pnl_bi
            // 
            this.pnl_bi.BackColor = System.Drawing.Color.White;
            this.pnl_bi.Controls.Add(this.pnl_Body);
            this.pnl_bi.Controls.Add(this.panel2);
            this.pnl_bi.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_bi.Location = new System.Drawing.Point(245, 70);
            this.pnl_bi.Name = "pnl_bi";
            this.pnl_bi.Size = new System.Drawing.Size(1044, 515);
            this.pnl_bi.TabIndex = 2;
            // 
            // pnl_Body
            // 
            this.pnl_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.pnl_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Body.Location = new System.Drawing.Point(0, 0);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(799, 515);
            this.pnl_Body.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.panel2.Controls.Add(this.MusicPlayer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(799, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 515);
            this.panel2.TabIndex = 0;
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.Enabled = true;
            this.MusicPlayer.Location = new System.Drawing.Point(6, 417);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
            this.MusicPlayer.Size = new System.Drawing.Size(227, 101);
            this.MusicPlayer.TabIndex = 0;
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.pnl_Footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Footer.Controls.Add(this.btn_Like);
            this.pnl_Footer.Controls.Add(this.lbl_CurrentMusicArtist);
            this.pnl_Footer.Controls.Add(this.lbl_CurrentMusicSong);
            this.pnl_Footer.Controls.Add(this.ptr_CurrentMusic);
            this.pnl_Footer.Controls.Add(this.lbl_TrackEnd);
            this.pnl_Footer.Controls.Add(this.lbl_TrackStart);
            this.pnl_Footer.Controls.Add(this.VolumeBar);
            this.pnl_Footer.Controls.Add(this.btn_PreviousTrack);
            this.pnl_Footer.Controls.Add(this.ProgressBar);
            this.pnl_Footer.Controls.Add(this.btn_Volume);
            this.pnl_Footer.Controls.Add(this.btn_NextTrack);
            this.pnl_Footer.Controls.Add(this.btn_PlayPause);
            this.pnl_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Footer.Location = new System.Drawing.Point(0, 585);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1289, 90);
            this.pnl_Footer.TabIndex = 3;
            // 
            // btn_Like
            // 
            this.btn_Like.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Like.Image = ((System.Drawing.Image)(resources.GetObject("btn_Like.Image")));
            this.btn_Like.Location = new System.Drawing.Point(1059, 31);
            this.btn_Like.Name = "btn_Like";
            this.btn_Like.Size = new System.Drawing.Size(25, 25);
            this.btn_Like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Like.TabIndex = 5;
            this.btn_Like.TabStop = false;
            this.btn_Like.Click += new System.EventHandler(this.btn_Like_Click);
            this.btn_Like.MouseLeave += new System.EventHandler(this.btn_Like_MouseLeave);
            this.btn_Like.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Like_MouseMove);
            // 
            // lbl_CurrentMusicArtist
            // 
            this.lbl_CurrentMusicArtist.AutoSize = true;
            this.lbl_CurrentMusicArtist.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CurrentMusicArtist.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentMusicArtist.ForeColor = System.Drawing.Color.White;
            this.lbl_CurrentMusicArtist.Location = new System.Drawing.Point(100, 49);
            this.lbl_CurrentMusicArtist.Name = "lbl_CurrentMusicArtist";
            this.lbl_CurrentMusicArtist.Size = new System.Drawing.Size(131, 26);
            this.lbl_CurrentMusicArtist.TabIndex = 4;
            this.lbl_CurrentMusicArtist.Text = "Artist Name";
            this.lbl_CurrentMusicArtist.Visible = false;
            // 
            // lbl_CurrentMusicSong
            // 
            this.lbl_CurrentMusicSong.AutoSize = true;
            this.lbl_CurrentMusicSong.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CurrentMusicSong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_CurrentMusicSong.ForeColor = System.Drawing.Color.White;
            this.lbl_CurrentMusicSong.Location = new System.Drawing.Point(100, 22);
            this.lbl_CurrentMusicSong.Name = "lbl_CurrentMusicSong";
            this.lbl_CurrentMusicSong.Size = new System.Drawing.Size(138, 27);
            this.lbl_CurrentMusicSong.TabIndex = 4;
            this.lbl_CurrentMusicSong.Text = "Song Name";
            this.lbl_CurrentMusicSong.Visible = false;
            // 
            // ptr_CurrentMusic
            // 
            this.ptr_CurrentMusic.BackColor = System.Drawing.Color.Transparent;
            this.ptr_CurrentMusic.Location = new System.Drawing.Point(3, 3);
            this.ptr_CurrentMusic.Name = "ptr_CurrentMusic";
            this.ptr_CurrentMusic.Size = new System.Drawing.Size(82, 82);
            this.ptr_CurrentMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_CurrentMusic.TabIndex = 3;
            this.ptr_CurrentMusic.TabStop = false;
            // 
            // lbl_TrackEnd
            // 
            this.lbl_TrackEnd.AllowParentOverrides = false;
            this.lbl_TrackEnd.AutoEllipsis = false;
            this.lbl_TrackEnd.CursorType = null;
            this.lbl_TrackEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_TrackEnd.ForeColor = System.Drawing.Color.White;
            this.lbl_TrackEnd.Location = new System.Drawing.Point(853, 62);
            this.lbl_TrackEnd.Name = "lbl_TrackEnd";
            this.lbl_TrackEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_TrackEnd.Size = new System.Drawing.Size(44, 25);
            this.lbl_TrackEnd.TabIndex = 2;
            this.lbl_TrackEnd.Text = "00:00";
            this.lbl_TrackEnd.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_TrackEnd.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_TrackStart
            // 
            this.lbl_TrackStart.AllowParentOverrides = false;
            this.lbl_TrackStart.AutoEllipsis = false;
            this.lbl_TrackStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_TrackStart.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_TrackStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_TrackStart.ForeColor = System.Drawing.Color.White;
            this.lbl_TrackStart.Location = new System.Drawing.Point(410, 62);
            this.lbl_TrackStart.Name = "lbl_TrackStart";
            this.lbl_TrackStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_TrackStart.Size = new System.Drawing.Size(44, 25);
            this.lbl_TrackStart.TabIndex = 2;
            this.lbl_TrackStart.Text = "00:00";
            this.lbl_TrackStart.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_TrackStart.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // VolumeBar
            // 
            this.VolumeBar.AllowCursorChanges = true;
            this.VolumeBar.AllowHomeEndKeysDetection = false;
            this.VolumeBar.AllowIncrementalClickMoves = true;
            this.VolumeBar.AllowMouseDownEffects = false;
            this.VolumeBar.AllowMouseHoverEffects = false;
            this.VolumeBar.AllowScrollingAnimations = true;
            this.VolumeBar.AllowScrollKeysDetection = true;
            this.VolumeBar.AllowScrollOptionsMenu = true;
            this.VolumeBar.AllowShrinkingOnFocusLost = false;
            this.VolumeBar.BackColor = System.Drawing.Color.Transparent;
            this.VolumeBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VolumeBar.BackgroundImage")));
            this.VolumeBar.BindingContainer = null;
            this.VolumeBar.BorderRadius = 2;
            this.VolumeBar.BorderThickness = 1;
            this.VolumeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolumeBar.DrawThickBorder = false;
            this.VolumeBar.DurationBeforeShrink = 2000;
            this.VolumeBar.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.VolumeBar.LargeChange = 10;
            this.VolumeBar.Location = new System.Drawing.Point(1141, 28);
            this.VolumeBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Minimum = 0;
            this.VolumeBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.VolumeBar.MinimumThumbLength = 18;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.VolumeBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.VolumeBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.VolumeBar.ScrollBarBorderColor = System.Drawing.Color.White;
            this.VolumeBar.ScrollBarColor = System.Drawing.Color.White;
            this.VolumeBar.ShrinkSizeLimit = 3;
            this.VolumeBar.Size = new System.Drawing.Size(100, 31);
            this.VolumeBar.SliderColor = System.Drawing.Color.White;
            this.VolumeBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.VolumeBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.VolumeBar.SmallChange = 1;
            this.VolumeBar.TabIndex = 1;
            this.VolumeBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.VolumeBar.ThumbFillColor = System.Drawing.Color.White;
            this.VolumeBar.ThumbLength = 18;
            this.VolumeBar.ThumbMargin = 1;
            this.VolumeBar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.VolumeBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.VolumeBar.Value = 50;
            this.VolumeBar.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.VolumeBar_Scroll);
            // 
            // btn_PreviousTrack
            // 
            this.btn_PreviousTrack.ActiveImage = null;
            this.btn_PreviousTrack.AllowAnimations = true;
            this.btn_PreviousTrack.AllowBuffering = false;
            this.btn_PreviousTrack.AllowToggling = false;
            this.btn_PreviousTrack.AllowZooming = true;
            this.btn_PreviousTrack.AllowZoomingOnFocus = false;
            this.btn_PreviousTrack.BackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousTrack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_PreviousTrack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_PreviousTrack.ErrorImage")));
            this.btn_PreviousTrack.FadeWhenInactive = false;
            this.btn_PreviousTrack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_PreviousTrack.Image = ((System.Drawing.Image)(resources.GetObject("btn_PreviousTrack.Image")));
            this.btn_PreviousTrack.ImageActive = null;
            this.btn_PreviousTrack.ImageLocation = null;
            this.btn_PreviousTrack.ImageMargin = 10;
            this.btn_PreviousTrack.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_PreviousTrack.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btn_PreviousTrack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_PreviousTrack.InitialImage")));
            this.btn_PreviousTrack.Location = new System.Drawing.Point(590, 14);
            this.btn_PreviousTrack.Name = "btn_PreviousTrack";
            this.btn_PreviousTrack.Rotation = 0;
            this.btn_PreviousTrack.ShowActiveImage = true;
            this.btn_PreviousTrack.ShowCursorChanges = true;
            this.btn_PreviousTrack.ShowImageBorders = true;
            this.btn_PreviousTrack.ShowSizeMarkers = false;
            this.btn_PreviousTrack.Size = new System.Drawing.Size(30, 30);
            this.btn_PreviousTrack.TabIndex = 0;
            this.btn_PreviousTrack.ToolTipText = "";
            this.btn_PreviousTrack.WaitOnLoad = false;
            this.btn_PreviousTrack.Zoom = 10;
            this.btn_PreviousTrack.ZoomSpeed = 10;
            this.btn_PreviousTrack.Click += new System.EventHandler(this.btn_PreviousTrack_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.AllowCursorChanges = true;
            this.ProgressBar.AllowHomeEndKeysDetection = false;
            this.ProgressBar.AllowIncrementalClickMoves = true;
            this.ProgressBar.AllowMouseDownEffects = false;
            this.ProgressBar.AllowMouseHoverEffects = false;
            this.ProgressBar.AllowScrollingAnimations = true;
            this.ProgressBar.AllowScrollKeysDetection = true;
            this.ProgressBar.AllowScrollOptionsMenu = true;
            this.ProgressBar.AllowShrinkingOnFocusLost = false;
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgressBar.BackgroundImage")));
            this.ProgressBar.BindingContainer = null;
            this.ProgressBar.BorderRadius = 2;
            this.ProgressBar.BorderThickness = 1;
            this.ProgressBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProgressBar.DrawThickBorder = false;
            this.ProgressBar.DurationBeforeShrink = 2000;
            this.ProgressBar.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.ProgressBar.LargeChange = 10;
            this.ProgressBar.Location = new System.Drawing.Point(446, 55);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProgressBar.Maximum = 100;
            this.ProgressBar.Minimum = 0;
            this.ProgressBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.ProgressBar.MinimumThumbLength = 18;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.ProgressBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.ProgressBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.ProgressBar.ScrollBarBorderColor = System.Drawing.Color.White;
            this.ProgressBar.ScrollBarColor = System.Drawing.Color.White;
            this.ProgressBar.ShrinkSizeLimit = 3;
            this.ProgressBar.Size = new System.Drawing.Size(400, 31);
            this.ProgressBar.SliderColor = System.Drawing.Color.White;
            this.ProgressBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.ProgressBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.ProgressBar.SmallChange = 1;
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.ProgressBar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.ProgressBar.ThumbLength = 39;
            this.ProgressBar.ThumbMargin = 1;
            this.ProgressBar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.ProgressBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.ProgressBar.Value = 0;
            this.ProgressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBar_MouseDown);
            // 
            // btn_Volume
            // 
            this.btn_Volume.ActiveImage = null;
            this.btn_Volume.AllowAnimations = true;
            this.btn_Volume.AllowBuffering = false;
            this.btn_Volume.AllowToggling = false;
            this.btn_Volume.AllowZooming = true;
            this.btn_Volume.AllowZoomingOnFocus = false;
            this.btn_Volume.BackColor = System.Drawing.Color.Transparent;
            this.btn_Volume.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Volume.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_Volume.ErrorImage")));
            this.btn_Volume.FadeWhenInactive = false;
            this.btn_Volume.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_Volume.Image = ((System.Drawing.Image)(resources.GetObject("btn_Volume.Image")));
            this.btn_Volume.ImageActive = null;
            this.btn_Volume.ImageLocation = null;
            this.btn_Volume.ImageMargin = 10;
            this.btn_Volume.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_Volume.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.btn_Volume.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_Volume.InitialImage")));
            this.btn_Volume.Location = new System.Drawing.Point(1109, 31);
            this.btn_Volume.Name = "btn_Volume";
            this.btn_Volume.Rotation = 0;
            this.btn_Volume.ShowActiveImage = true;
            this.btn_Volume.ShowCursorChanges = true;
            this.btn_Volume.ShowImageBorders = true;
            this.btn_Volume.ShowSizeMarkers = false;
            this.btn_Volume.Size = new System.Drawing.Size(25, 25);
            this.btn_Volume.TabIndex = 0;
            this.btn_Volume.ToolTipText = "";
            this.btn_Volume.WaitOnLoad = false;
            this.btn_Volume.Zoom = 10;
            this.btn_Volume.ZoomSpeed = 10;
            this.btn_Volume.Click += new System.EventHandler(this.btn_Volume_Click);
            // 
            // btn_NextTrack
            // 
            this.btn_NextTrack.ActiveImage = null;
            this.btn_NextTrack.AllowAnimations = true;
            this.btn_NextTrack.AllowBuffering = false;
            this.btn_NextTrack.AllowToggling = false;
            this.btn_NextTrack.AllowZooming = true;
            this.btn_NextTrack.AllowZoomingOnFocus = false;
            this.btn_NextTrack.BackColor = System.Drawing.Color.Transparent;
            this.btn_NextTrack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_NextTrack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_NextTrack.ErrorImage")));
            this.btn_NextTrack.FadeWhenInactive = false;
            this.btn_NextTrack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_NextTrack.Image = ((System.Drawing.Image)(resources.GetObject("btn_NextTrack.Image")));
            this.btn_NextTrack.ImageActive = null;
            this.btn_NextTrack.ImageLocation = null;
            this.btn_NextTrack.ImageMargin = 10;
            this.btn_NextTrack.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_NextTrack.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btn_NextTrack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_NextTrack.InitialImage")));
            this.btn_NextTrack.Location = new System.Drawing.Point(672, 14);
            this.btn_NextTrack.Name = "btn_NextTrack";
            this.btn_NextTrack.Rotation = 0;
            this.btn_NextTrack.ShowActiveImage = true;
            this.btn_NextTrack.ShowCursorChanges = true;
            this.btn_NextTrack.ShowImageBorders = true;
            this.btn_NextTrack.ShowSizeMarkers = false;
            this.btn_NextTrack.Size = new System.Drawing.Size(30, 30);
            this.btn_NextTrack.TabIndex = 0;
            this.btn_NextTrack.ToolTipText = "";
            this.btn_NextTrack.WaitOnLoad = false;
            this.btn_NextTrack.Zoom = 10;
            this.btn_NextTrack.ZoomSpeed = 10;
            this.btn_NextTrack.Click += new System.EventHandler(this.btn_NextTrack_Click);
            // 
            // btn_PlayPause
            // 
            this.btn_PlayPause.ActiveImage = null;
            this.btn_PlayPause.AllowAnimations = true;
            this.btn_PlayPause.AllowBuffering = false;
            this.btn_PlayPause.AllowToggling = false;
            this.btn_PlayPause.AllowZooming = true;
            this.btn_PlayPause.AllowZoomingOnFocus = false;
            this.btn_PlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlayPause.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_PlayPause.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_PlayPause.ErrorImage")));
            this.btn_PlayPause.FadeWhenInactive = false;
            this.btn_PlayPause.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_PlayPause.Image = ((System.Drawing.Image)(resources.GetObject("btn_PlayPause.Image")));
            this.btn_PlayPause.ImageActive = null;
            this.btn_PlayPause.ImageLocation = null;
            this.btn_PlayPause.ImageMargin = 10;
            this.btn_PlayPause.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_PlayPause.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btn_PlayPause.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_PlayPause.InitialImage")));
            this.btn_PlayPause.Location = new System.Drawing.Point(626, 9);
            this.btn_PlayPause.Name = "btn_PlayPause";
            this.btn_PlayPause.Rotation = 0;
            this.btn_PlayPause.ShowActiveImage = true;
            this.btn_PlayPause.ShowCursorChanges = true;
            this.btn_PlayPause.ShowImageBorders = true;
            this.btn_PlayPause.ShowSizeMarkers = false;
            this.btn_PlayPause.Size = new System.Drawing.Size(40, 40);
            this.btn_PlayPause.TabIndex = 0;
            this.btn_PlayPause.ToolTipText = "";
            this.btn_PlayPause.WaitOnLoad = false;
            this.btn_PlayPause.Zoom = 10;
            this.btn_PlayPause.ZoomSpeed = 10;
            this.btn_PlayPause.Click += new System.EventHandler(this.btn_PlayStop_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_bi);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.pnl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musify";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_MyPlaylist.ResumeLayout(false);
            this.pnl_CreateNewPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_CreateNewPlaylist)).EndInit();
            this.pnl_LikedSongs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_LikedSongs)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Search)).EndInit();
            this.pnl_Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Home)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Logo.ResumeLayout(false);
            this.pnl_Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.pnl_bi.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).EndInit();
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_CurrentMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_Search;
        private CustomControls.RJControls.RJButton btn_Search;
        private System.Windows.Forms.Panel pnl_Home;
        private CustomControls.RJControls.RJButton btn_Home;
        private CustomControls.RJControls.RJButton btn_Menu;
        private System.Windows.Forms.Panel pnl_MyPlaylist;
        private System.Windows.Forms.Panel pnl_CreateNewPlaylist;
        private CustomControls.RJControls.RJButton btn_CreateNewPlaylist;
        private System.Windows.Forms.Panel pnl_LikedSongs;
        private CustomControls.RJControls.RJButton btn_LikedSongs;
        private System.Windows.Forms.Panel pnl;
        private CustomControls.RJControls.RJButton btn_MyPlaylists;
        private System.Windows.Forms.PictureBox ptr_Home;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_bi;
        private System.Windows.Forms.PictureBox ptr_Search;
        private System.Windows.Forms.PictureBox ptr_CreateNewPlaylist;
        private System.Windows.Forms.PictureBox ptr_LikedSongs;
        private CustomControls.RJControls.RJButton select_Home;
        private CustomControls.RJControls.RJButton select_CreateNewPlaylist;
        private CustomControls.RJControls.RJButton select_LikedSongs;
        private CustomControls.RJControls.RJButton select_Search;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Panel pnl_Logo;
        private Bunifu.UI.WinForms.BunifuHSlider ProgressBar;
        private Bunifu.UI.WinForms.BunifuImageButton btn_PreviousTrack;
        private Bunifu.UI.WinForms.BunifuImageButton btn_NextTrack;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel pnl_Body;
        private Bunifu.UI.WinForms.BunifuHSlider VolumeBar;
        private Bunifu.UI.WinForms.BunifuLabel lbl_TrackEnd;
        private Bunifu.UI.WinForms.BunifuLabel lbl_TrackStart;
        public AxWMPLib.AxWindowsMediaPlayer MusicPlayer;
        public System.Windows.Forms.PictureBox ptr_CurrentMusic;
        public System.Windows.Forms.Label lbl_CurrentMusicSong;
        public System.Windows.Forms.Label lbl_CurrentMusicArtist;
        public Bunifu.UI.WinForms.BunifuImageButton btn_PlayPause;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuImageButton btn_Volume;
        public System.Windows.Forms.FlowLayoutPanel FlLayout_Playlist;
        public System.Windows.Forms.PictureBox btn_Like;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

