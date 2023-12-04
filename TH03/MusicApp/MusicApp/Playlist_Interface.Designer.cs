
namespace MusicApp
{
    partial class Playlist_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist_Interface));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnl_Header = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_PlaylistName = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.PictureBox();
            this.btn_Back = new System.Windows.Forms.PictureBox();
            this.pnl_PlaylistPhoto = new System.Windows.Forms.Panel();
            this.ptr_PlaylistPhoto3 = new System.Windows.Forms.PictureBox();
            this.ptr_PlaylistPhoto2 = new System.Windows.Forms.PictureBox();
            this.ptr_PlaylistPhoto4 = new System.Windows.Forms.PictureBox();
            this.ptr_PlaylistPhoto1 = new System.Windows.Forms.PictureBox();
            this.pnl_Middler = new System.Windows.Forms.Panel();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btn_PlayPause = new Bunifu.UI.WinForms.BunifuImageButton();
            this.FlLayout_PlaylistSong = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_PlaylistDescrip = new System.Windows.Forms.Label();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            this.pnl_PlaylistPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_PlaylistPhoto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_PlaylistPhoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_PlaylistPhoto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_PlaylistPhoto1)).BeginInit();
            this.pnl_Middler.SuspendLayout();
            this.FlLayout_PlaylistSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Header.BackgroundImage")));
            this.pnl_Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Header.BorderRadius = 1;
            this.pnl_Header.Controls.Add(this.lbl_PlaylistDescrip);
            this.pnl_Header.Controls.Add(this.lbl_Count);
            this.pnl_Header.Controls.Add(this.label2);
            this.pnl_Header.Controls.Add(this.lbl_PlaylistName);
            this.pnl_Header.Controls.Add(this.btn_Next);
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.pnl_PlaylistPhoto);
            this.pnl_Header.GradientBottomLeft = System.Drawing.Color.Black;
            this.pnl_Header.GradientBottomRight = System.Drawing.Color.Black;
            this.pnl_Header.GradientTopLeft = System.Drawing.Color.DimGray;
            this.pnl_Header.GradientTopRight = System.Drawing.Color.DimGray;
            this.pnl_Header.Location = new System.Drawing.Point(3, 3);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Quality = 10;
            this.pnl_Header.Size = new System.Drawing.Size(799, 261);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Count.ForeColor = System.Drawing.Color.White;
            this.lbl_Count.Location = new System.Drawing.Point(226, 242);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(45, 16);
            this.lbl_Count.TabIndex = 6;
            this.lbl_Count.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "PRIVATE PLAYLIST";
            // 
            // lbl_PlaylistName
            // 
            this.lbl_PlaylistName.AutoSize = true;
            this.lbl_PlaylistName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlaylistName.ForeColor = System.Drawing.Color.White;
            this.lbl_PlaylistName.Location = new System.Drawing.Point(222, 121);
            this.lbl_PlaylistName.Name = "lbl_PlaylistName";
            this.lbl_PlaylistName.Size = new System.Drawing.Size(226, 37);
            this.lbl_PlaylistName.TabIndex = 6;
            this.lbl_PlaylistName.Text = "Playlist Name";
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.Transparent;
            this.btn_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Next.BackgroundImage")));
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_Next.Location = new System.Drawing.Point(57, 8);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(35, 35);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.TabStop = false;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Location = new System.Drawing.Point(16, 8);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(35, 35);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.TabStop = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            this.btn_Back.MouseLeave += new System.EventHandler(this.btn_Back_MouseLeave);
            this.btn_Back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Back_MouseMove);
            // 
            // pnl_PlaylistPhoto
            // 
            this.pnl_PlaylistPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_PlaylistPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_PlaylistPhoto.Controls.Add(this.ptr_PlaylistPhoto3);
            this.pnl_PlaylistPhoto.Controls.Add(this.ptr_PlaylistPhoto2);
            this.pnl_PlaylistPhoto.Controls.Add(this.ptr_PlaylistPhoto4);
            this.pnl_PlaylistPhoto.Controls.Add(this.ptr_PlaylistPhoto1);
            this.pnl_PlaylistPhoto.Location = new System.Drawing.Point(16, 58);
            this.pnl_PlaylistPhoto.Name = "pnl_PlaylistPhoto";
            this.pnl_PlaylistPhoto.Size = new System.Drawing.Size(200, 200);
            this.pnl_PlaylistPhoto.TabIndex = 0;
            // 
            // ptr_PlaylistPhoto3
            // 
            this.ptr_PlaylistPhoto3.Location = new System.Drawing.Point(-1, 99);
            this.ptr_PlaylistPhoto3.Name = "ptr_PlaylistPhoto3";
            this.ptr_PlaylistPhoto3.Size = new System.Drawing.Size(100, 100);
            this.ptr_PlaylistPhoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_PlaylistPhoto3.TabIndex = 2;
            this.ptr_PlaylistPhoto3.TabStop = false;
            // 
            // ptr_PlaylistPhoto2
            // 
            this.ptr_PlaylistPhoto2.Location = new System.Drawing.Point(99, -1);
            this.ptr_PlaylistPhoto2.Name = "ptr_PlaylistPhoto2";
            this.ptr_PlaylistPhoto2.Size = new System.Drawing.Size(100, 100);
            this.ptr_PlaylistPhoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_PlaylistPhoto2.TabIndex = 2;
            this.ptr_PlaylistPhoto2.TabStop = false;
            // 
            // ptr_PlaylistPhoto4
            // 
            this.ptr_PlaylistPhoto4.Location = new System.Drawing.Point(99, 99);
            this.ptr_PlaylistPhoto4.Name = "ptr_PlaylistPhoto4";
            this.ptr_PlaylistPhoto4.Size = new System.Drawing.Size(100, 100);
            this.ptr_PlaylistPhoto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_PlaylistPhoto4.TabIndex = 2;
            this.ptr_PlaylistPhoto4.TabStop = false;
            // 
            // ptr_PlaylistPhoto1
            // 
            this.ptr_PlaylistPhoto1.Location = new System.Drawing.Point(-1, -1);
            this.ptr_PlaylistPhoto1.Name = "ptr_PlaylistPhoto1";
            this.ptr_PlaylistPhoto1.Size = new System.Drawing.Size(100, 100);
            this.ptr_PlaylistPhoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_PlaylistPhoto1.TabIndex = 1;
            this.ptr_PlaylistPhoto1.TabStop = false;
            // 
            // pnl_Middler
            // 
            this.pnl_Middler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.pnl_Middler.Controls.Add(this.bunifuTextBox1);
            this.pnl_Middler.Controls.Add(this.btn_PlayPause);
            this.pnl_Middler.Location = new System.Drawing.Point(3, 270);
            this.pnl_Middler.Name = "pnl_Middler";
            this.pnl_Middler.Size = new System.Drawing.Size(799, 52);
            this.pnl_Middler.TabIndex = 2;
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBox1.BorderRadius = 20;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.IconRight")));
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(585, 6);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.PlaceholderText = "Search in playlist";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(200, 35);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 4;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 3;
            this.bunifuTextBox1.TextMarginTop = 0;
            this.bunifuTextBox1.TextPlaceholder = "Search in playlist";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
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
            this.btn_PlayPause.Location = new System.Drawing.Point(16, 6);
            this.btn_PlayPause.Name = "btn_PlayPause";
            this.btn_PlayPause.Rotation = 0;
            this.btn_PlayPause.ShowActiveImage = true;
            this.btn_PlayPause.ShowCursorChanges = true;
            this.btn_PlayPause.ShowImageBorders = true;
            this.btn_PlayPause.ShowSizeMarkers = false;
            this.btn_PlayPause.Size = new System.Drawing.Size(40, 40);
            this.btn_PlayPause.TabIndex = 3;
            this.btn_PlayPause.ToolTipText = "";
            this.btn_PlayPause.WaitOnLoad = false;
            this.btn_PlayPause.Zoom = 10;
            this.btn_PlayPause.ZoomSpeed = 10;
            // 
            // FlLayout_PlaylistSong
            // 
            this.FlLayout_PlaylistSong.AutoScroll = true;
            this.FlLayout_PlaylistSong.BackColor = System.Drawing.Color.Black;
            this.FlLayout_PlaylistSong.Controls.Add(this.pnl_Header);
            this.FlLayout_PlaylistSong.Controls.Add(this.pnl_Middler);
            this.FlLayout_PlaylistSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlLayout_PlaylistSong.Location = new System.Drawing.Point(0, 0);
            this.FlLayout_PlaylistSong.Name = "FlLayout_PlaylistSong";
            this.FlLayout_PlaylistSong.Size = new System.Drawing.Size(799, 474);
            this.FlLayout_PlaylistSong.TabIndex = 3;
            // 
            // lbl_PlaylistDescrip
            // 
            this.lbl_PlaylistDescrip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlaylistDescrip.ForeColor = System.Drawing.Color.White;
            this.lbl_PlaylistDescrip.Location = new System.Drawing.Point(226, 165);
            this.lbl_PlaylistDescrip.Name = "lbl_PlaylistDescrip";
            this.lbl_PlaylistDescrip.Size = new System.Drawing.Size(560, 70);
            this.lbl_PlaylistDescrip.TabIndex = 6;
            // 
            // Playlist_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(799, 474);
            this.Controls.Add(this.FlLayout_PlaylistSong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Playlist_Interface";
            this.Text = "Playlist_Interface";
            this.Load += new System.EventHandler(this.Playlist_Interface_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            this.pnl_PlaylistPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_PlaylistPhoto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_PlaylistPhoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_PlaylistPhoto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_PlaylistPhoto1)).EndInit();
            this.pnl_Middler.ResumeLayout(false);
            this.FlLayout_PlaylistSong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel pnl_Header;
        private System.Windows.Forms.PictureBox ptr_PlaylistPhoto1;
        private System.Windows.Forms.PictureBox ptr_PlaylistPhoto4;
        private System.Windows.Forms.PictureBox ptr_PlaylistPhoto3;
        private System.Windows.Forms.PictureBox ptr_PlaylistPhoto2;
        private System.Windows.Forms.PictureBox btn_Next;
        private System.Windows.Forms.PictureBox btn_Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_Middler;
        public Bunifu.UI.WinForms.BunifuImageButton btn_PlayPause;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        public System.Windows.Forms.Panel pnl_PlaylistPhoto;
        public System.Windows.Forms.Label lbl_PlaylistName;
        public System.Windows.Forms.Label lbl_Count;
        public System.Windows.Forms.FlowLayoutPanel FlLayout_PlaylistSong;
        public System.Windows.Forms.Label lbl_PlaylistDescrip;
    }
}