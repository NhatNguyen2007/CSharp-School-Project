
namespace MusicApp
{
    partial class Default_Search_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default_Search_Interface));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.FlLayout_BrowseAll = new System.Windows.Forms.FlowLayoutPanel();
            this.genre_VietnameseMusic = new MusicApp.GenreBox();
            this.genre_VietRap = new MusicApp.GenreBox();
            this.genre_USUK = new MusicApp.GenreBox();
            this.genre_Rock = new MusicApp.GenreBox();
            this.genre_Pop = new MusicApp.GenreBox();
            this.genre_EDM = new MusicApp.GenreBox();
            this.genre_Indie = new MusicApp.GenreBox();
            this.genre_KPop = new MusicApp.GenreBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_BrowseAll = new System.Windows.Forms.Label();
            this.pnl_RecentSearches = new Bunifu.UI.WinForms.BunifuPanel();
            this.FlLayout_RecentSearches = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SeeAll_RecentSearches = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbl_RecentSearches = new System.Windows.Forms.Label();
            this.pnl_Container.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.FlLayout_BrowseAll.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_RecentSearches.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackColor = System.Drawing.Color.Black;
            this.pnl_Container.Controls.Add(this.bunifuPanel2);
            this.pnl_Container.Controls.Add(this.panel1);
            this.pnl_Container.Controls.Add(this.pnl_RecentSearches);
            this.pnl_Container.Controls.Add(this.panel2);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(1326, 1058);
            this.pnl_Container.TabIndex = 2;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 30;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.FlLayout_BrowseAll);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 504);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1326, 554);
            this.bunifuPanel2.TabIndex = 5;
            // 
            // FlLayout_BrowseAll
            // 
            this.FlLayout_BrowseAll.BackColor = System.Drawing.Color.Transparent;
            this.FlLayout_BrowseAll.Controls.Add(this.genre_VietnameseMusic);
            this.FlLayout_BrowseAll.Controls.Add(this.genre_VietRap);
            this.FlLayout_BrowseAll.Controls.Add(this.genre_USUK);
            this.FlLayout_BrowseAll.Controls.Add(this.genre_Rock);
            this.FlLayout_BrowseAll.Controls.Add(this.genre_Pop);
            this.FlLayout_BrowseAll.Controls.Add(this.genre_EDM);
            this.FlLayout_BrowseAll.Controls.Add(this.genre_Indie);
            this.FlLayout_BrowseAll.Controls.Add(this.genre_KPop);
            this.FlLayout_BrowseAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlLayout_BrowseAll.Location = new System.Drawing.Point(0, 0);
            this.FlLayout_BrowseAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FlLayout_BrowseAll.Name = "FlLayout_BrowseAll";
            this.FlLayout_BrowseAll.Size = new System.Drawing.Size(1326, 554);
            this.FlLayout_BrowseAll.TabIndex = 0;
            // 
            // genre_VietnameseMusic
            // 
            this.genre_VietnameseMusic.BackColor = System.Drawing.Color.Transparent;
            this.genre_VietnameseMusic.getset_ContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.genre_VietnameseMusic.getset_GenreImg = ((System.Drawing.Image)(resources.GetObject("genre_VietnameseMusic.getset_GenreImg")));
            this.genre_VietnameseMusic.getset_GenreName = "EDM";
            this.genre_VietnameseMusic.Location = new System.Drawing.Point(6, 8);
            this.genre_VietnameseMusic.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.genre_VietnameseMusic.Name = "genre_VietnameseMusic";
            this.genre_VietnameseMusic.Size = new System.Drawing.Size(222, 228);
            this.genre_VietnameseMusic.TabIndex = 0;
            // 
            // genre_VietRap
            // 
            this.genre_VietRap.BackColor = System.Drawing.Color.Transparent;
            this.genre_VietRap.getset_ContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.genre_VietRap.getset_GenreImg = ((System.Drawing.Image)(resources.GetObject("genre_VietRap.getset_GenreImg")));
            this.genre_VietRap.getset_GenreName = "EDM";
            this.genre_VietRap.Location = new System.Drawing.Point(240, 8);
            this.genre_VietRap.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.genre_VietRap.Name = "genre_VietRap";
            this.genre_VietRap.Size = new System.Drawing.Size(222, 228);
            this.genre_VietRap.TabIndex = 1;
            // 
            // genre_USUK
            // 
            this.genre_USUK.BackColor = System.Drawing.Color.Transparent;
            this.genre_USUK.getset_ContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.genre_USUK.getset_GenreImg = ((System.Drawing.Image)(resources.GetObject("genre_USUK.getset_GenreImg")));
            this.genre_USUK.getset_GenreName = "EDM";
            this.genre_USUK.Location = new System.Drawing.Point(474, 8);
            this.genre_USUK.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.genre_USUK.Name = "genre_USUK";
            this.genre_USUK.Size = new System.Drawing.Size(222, 228);
            this.genre_USUK.TabIndex = 2;
            // 
            // genre_Rock
            // 
            this.genre_Rock.BackColor = System.Drawing.Color.Transparent;
            this.genre_Rock.getset_ContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.genre_Rock.getset_GenreImg = ((System.Drawing.Image)(resources.GetObject("genre_Rock.getset_GenreImg")));
            this.genre_Rock.getset_GenreName = "EDM";
            this.genre_Rock.Location = new System.Drawing.Point(708, 8);
            this.genre_Rock.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.genre_Rock.Name = "genre_Rock";
            this.genre_Rock.Size = new System.Drawing.Size(222, 228);
            this.genre_Rock.TabIndex = 3;
            // 
            // genre_Pop
            // 
            this.genre_Pop.BackColor = System.Drawing.Color.Transparent;
            this.genre_Pop.getset_ContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.genre_Pop.getset_GenreImg = ((System.Drawing.Image)(resources.GetObject("genre_Pop.getset_GenreImg")));
            this.genre_Pop.getset_GenreName = "EDM";
            this.genre_Pop.Location = new System.Drawing.Point(942, 8);
            this.genre_Pop.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.genre_Pop.Name = "genre_Pop";
            this.genre_Pop.Size = new System.Drawing.Size(222, 228);
            this.genre_Pop.TabIndex = 4;
            // 
            // genre_EDM
            // 
            this.genre_EDM.BackColor = System.Drawing.Color.Transparent;
            this.genre_EDM.getset_ContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.genre_EDM.getset_GenreImg = ((System.Drawing.Image)(resources.GetObject("genre_EDM.getset_GenreImg")));
            this.genre_EDM.getset_GenreName = "EDM";
            this.genre_EDM.Location = new System.Drawing.Point(6, 252);
            this.genre_EDM.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.genre_EDM.Name = "genre_EDM";
            this.genre_EDM.Size = new System.Drawing.Size(222, 228);
            this.genre_EDM.TabIndex = 5;
            // 
            // genre_Indie
            // 
            this.genre_Indie.BackColor = System.Drawing.Color.Transparent;
            this.genre_Indie.getset_ContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.genre_Indie.getset_GenreImg = ((System.Drawing.Image)(resources.GetObject("genre_Indie.getset_GenreImg")));
            this.genre_Indie.getset_GenreName = "EDM";
            this.genre_Indie.Location = new System.Drawing.Point(240, 252);
            this.genre_Indie.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.genre_Indie.Name = "genre_Indie";
            this.genre_Indie.Size = new System.Drawing.Size(222, 228);
            this.genre_Indie.TabIndex = 6;
            // 
            // genre_KPop
            // 
            this.genre_KPop.BackColor = System.Drawing.Color.Transparent;
            this.genre_KPop.getset_ContainerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.genre_KPop.getset_GenreImg = ((System.Drawing.Image)(resources.GetObject("genre_KPop.getset_GenreImg")));
            this.genre_KPop.getset_GenreName = "EDM";
            this.genre_KPop.Location = new System.Drawing.Point(474, 252);
            this.genre_KPop.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.genre_KPop.Name = "genre_KPop";
            this.genre_KPop.Size = new System.Drawing.Size(222, 228);
            this.genre_KPop.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.panel1.Controls.Add(this.lbl_BrowseAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 92);
            this.panel1.TabIndex = 4;
            // 
            // lbl_BrowseAll
            // 
            this.lbl_BrowseAll.AutoSize = true;
            this.lbl_BrowseAll.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BrowseAll.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BrowseAll.ForeColor = System.Drawing.Color.White;
            this.lbl_BrowseAll.Location = new System.Drawing.Point(18, 40);
            this.lbl_BrowseAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BrowseAll.Name = "lbl_BrowseAll";
            this.lbl_BrowseAll.Size = new System.Drawing.Size(161, 34);
            this.lbl_BrowseAll.TabIndex = 0;
            this.lbl_BrowseAll.Text = "Browse All";
            // 
            // pnl_RecentSearches
            // 
            this.pnl_RecentSearches.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.pnl_RecentSearches.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_RecentSearches.BackgroundImage")));
            this.pnl_RecentSearches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_RecentSearches.BorderColor = System.Drawing.Color.Transparent;
            this.pnl_RecentSearches.BorderRadius = 30;
            this.pnl_RecentSearches.BorderThickness = 1;
            this.pnl_RecentSearches.Controls.Add(this.FlLayout_RecentSearches);
            this.pnl_RecentSearches.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_RecentSearches.Location = new System.Drawing.Point(0, 74);
            this.pnl_RecentSearches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_RecentSearches.Name = "pnl_RecentSearches";
            this.pnl_RecentSearches.ShowBorders = true;
            this.pnl_RecentSearches.Size = new System.Drawing.Size(1326, 338);
            this.pnl_RecentSearches.TabIndex = 3;
            // 
            // FlLayout_RecentSearches
            // 
            this.FlLayout_RecentSearches.BackColor = System.Drawing.Color.Transparent;
            this.FlLayout_RecentSearches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlLayout_RecentSearches.Location = new System.Drawing.Point(0, 0);
            this.FlLayout_RecentSearches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FlLayout_RecentSearches.Name = "FlLayout_RecentSearches";
            this.FlLayout_RecentSearches.Size = new System.Drawing.Size(1326, 338);
            this.FlLayout_RecentSearches.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.panel2.Controls.Add(this.btn_SeeAll_RecentSearches);
            this.panel2.Controls.Add(this.lbl_RecentSearches);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 74);
            this.panel2.TabIndex = 2;
            // 
            // btn_SeeAll_RecentSearches
            // 
            this.btn_SeeAll_RecentSearches.AllowAnimations = true;
            this.btn_SeeAll_RecentSearches.AllowMouseEffects = true;
            this.btn_SeeAll_RecentSearches.AllowToggling = false;
            this.btn_SeeAll_RecentSearches.AnimationSpeed = 200;
            this.btn_SeeAll_RecentSearches.AutoGenerateColors = false;
            this.btn_SeeAll_RecentSearches.AutoRoundBorders = false;
            this.btn_SeeAll_RecentSearches.AutoSizeLeftIcon = true;
            this.btn_SeeAll_RecentSearches.AutoSizeRightIcon = true;
            this.btn_SeeAll_RecentSearches.BackColor = System.Drawing.Color.Transparent;
            this.btn_SeeAll_RecentSearches.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_SeeAll_RecentSearches.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SeeAll_RecentSearches.BackgroundImage")));
            this.btn_SeeAll_RecentSearches.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SeeAll_RecentSearches.ButtonText = "SEE ALL";
            this.btn_SeeAll_RecentSearches.ButtonTextMarginLeft = 0;
            this.btn_SeeAll_RecentSearches.ColorContrastOnClick = 45;
            this.btn_SeeAll_RecentSearches.ColorContrastOnHover = 45;
            this.btn_SeeAll_RecentSearches.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_SeeAll_RecentSearches.CustomizableEdges = borderEdges1;
            this.btn_SeeAll_RecentSearches.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_SeeAll_RecentSearches.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_SeeAll_RecentSearches.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_SeeAll_RecentSearches.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_SeeAll_RecentSearches.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_SeeAll_RecentSearches.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_SeeAll_RecentSearches.ForeColor = System.Drawing.Color.White;
            this.btn_SeeAll_RecentSearches.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeeAll_RecentSearches.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SeeAll_RecentSearches.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_SeeAll_RecentSearches.IconMarginLeft = 11;
            this.btn_SeeAll_RecentSearches.IconPadding = 10;
            this.btn_SeeAll_RecentSearches.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SeeAll_RecentSearches.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_SeeAll_RecentSearches.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_SeeAll_RecentSearches.IconSize = 25;
            this.btn_SeeAll_RecentSearches.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_SeeAll_RecentSearches.IdleBorderRadius = 10;
            this.btn_SeeAll_RecentSearches.IdleBorderThickness = 1;
            this.btn_SeeAll_RecentSearches.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_SeeAll_RecentSearches.IdleIconLeftImage = null;
            this.btn_SeeAll_RecentSearches.IdleIconRightImage = null;
            this.btn_SeeAll_RecentSearches.IndicateFocus = false;
            this.btn_SeeAll_RecentSearches.Location = new System.Drawing.Point(1035, 18);
            this.btn_SeeAll_RecentSearches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SeeAll_RecentSearches.Name = "btn_SeeAll_RecentSearches";
            this.btn_SeeAll_RecentSearches.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_SeeAll_RecentSearches.OnDisabledState.BorderRadius = 10;
            this.btn_SeeAll_RecentSearches.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SeeAll_RecentSearches.OnDisabledState.BorderThickness = 1;
            this.btn_SeeAll_RecentSearches.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_SeeAll_RecentSearches.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_SeeAll_RecentSearches.OnDisabledState.IconLeftImage = null;
            this.btn_SeeAll_RecentSearches.OnDisabledState.IconRightImage = null;
            this.btn_SeeAll_RecentSearches.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_SeeAll_RecentSearches.onHoverState.BorderRadius = 10;
            this.btn_SeeAll_RecentSearches.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SeeAll_RecentSearches.onHoverState.BorderThickness = 1;
            this.btn_SeeAll_RecentSearches.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_SeeAll_RecentSearches.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_SeeAll_RecentSearches.onHoverState.IconLeftImage = null;
            this.btn_SeeAll_RecentSearches.onHoverState.IconRightImage = null;
            this.btn_SeeAll_RecentSearches.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_SeeAll_RecentSearches.OnIdleState.BorderRadius = 10;
            this.btn_SeeAll_RecentSearches.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SeeAll_RecentSearches.OnIdleState.BorderThickness = 1;
            this.btn_SeeAll_RecentSearches.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btn_SeeAll_RecentSearches.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_SeeAll_RecentSearches.OnIdleState.IconLeftImage = null;
            this.btn_SeeAll_RecentSearches.OnIdleState.IconRightImage = null;
            this.btn_SeeAll_RecentSearches.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_SeeAll_RecentSearches.OnPressedState.BorderRadius = 10;
            this.btn_SeeAll_RecentSearches.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_SeeAll_RecentSearches.OnPressedState.BorderThickness = 1;
            this.btn_SeeAll_RecentSearches.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_SeeAll_RecentSearches.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_SeeAll_RecentSearches.OnPressedState.IconLeftImage = null;
            this.btn_SeeAll_RecentSearches.OnPressedState.IconRightImage = null;
            this.btn_SeeAll_RecentSearches.Size = new System.Drawing.Size(120, 46);
            this.btn_SeeAll_RecentSearches.TabIndex = 4;
            this.btn_SeeAll_RecentSearches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SeeAll_RecentSearches.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_SeeAll_RecentSearches.TextMarginLeft = 0;
            this.btn_SeeAll_RecentSearches.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_SeeAll_RecentSearches.UseDefaultRadiusAndThickness = true;
            this.btn_SeeAll_RecentSearches.Click += new System.EventHandler(this.btn_SeeAll_RecentSearches_Click);
            // 
            // lbl_RecentSearches
            // 
            this.lbl_RecentSearches.AutoSize = true;
            this.lbl_RecentSearches.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RecentSearches.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecentSearches.ForeColor = System.Drawing.Color.White;
            this.lbl_RecentSearches.Location = new System.Drawing.Point(18, 18);
            this.lbl_RecentSearches.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RecentSearches.Name = "lbl_RecentSearches";
            this.lbl_RecentSearches.Size = new System.Drawing.Size(248, 34);
            this.lbl_RecentSearches.TabIndex = 0;
            this.lbl_RecentSearches.Text = "Recent Searches";
            // 
            // Default_Search_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1352, 651);
            this.Controls.Add(this.pnl_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Default_Search_Interface";
            this.Text = "Default_Search_Interface";
            this.Load += new System.EventHandler(this.Default_Search_Interface_Load);
            this.pnl_Container.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.FlLayout_BrowseAll.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_RecentSearches.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
        private Bunifu.UI.WinForms.BunifuPanel pnl_RecentSearches;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_SeeAll_RecentSearches;
        private System.Windows.Forms.Label lbl_RecentSearches;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_BrowseAll;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        public System.Windows.Forms.FlowLayoutPanel FlLayout_BrowseAll;
        public System.Windows.Forms.FlowLayoutPanel FlLayout_RecentSearches;
        private GenreBox genre_VietnameseMusic;
        private GenreBox genre_VietRap;
        private GenreBox genre_USUK;
        private GenreBox genre_Rock;
        private GenreBox genre_Pop;
        private GenreBox genre_EDM;
        private GenreBox genre_Indie;
        private GenreBox genre_KPop;
    }
}