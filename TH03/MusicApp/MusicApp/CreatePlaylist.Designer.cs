
namespace MusicApp
{
    partial class CreatePlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePlaylist));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.ptr_Playlist = new System.Windows.Forms.PictureBox();
            this.txt_PlaylistName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_PlaylistDescription = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btn_Create = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Close = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Playlist)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(30, 31);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(216, 34);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Playlist details";
            // 
            // ptr_Playlist
            // 
            this.ptr_Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ptr_Playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptr_Playlist.Image = ((System.Drawing.Image)(resources.GetObject("ptr_Playlist.Image")));
            this.ptr_Playlist.Location = new System.Drawing.Point(36, 103);
            this.ptr_Playlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptr_Playlist.Name = "ptr_Playlist";
            this.ptr_Playlist.Size = new System.Drawing.Size(270, 277);
            this.ptr_Playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_Playlist.TabIndex = 2;
            this.ptr_Playlist.TabStop = false;
            this.ptr_Playlist.Click += new System.EventHandler(this.ptr_Playlist_Click);
            this.ptr_Playlist.MouseLeave += new System.EventHandler(this.ptr_Playlist_MouseLeave);
            this.ptr_Playlist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptr_Playlist_MouseMove);
            // 
            // txt_PlaylistName
            // 
            this.txt_PlaylistName.AcceptsReturn = false;
            this.txt_PlaylistName.AcceptsTab = false;
            this.txt_PlaylistName.AnimationSpeed = 200;
            this.txt_PlaylistName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_PlaylistName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_PlaylistName.BackColor = System.Drawing.Color.Transparent;
            this.txt_PlaylistName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_PlaylistName.BackgroundImage")));
            this.txt_PlaylistName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_PlaylistName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_PlaylistName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_PlaylistName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_PlaylistName.BorderRadius = 1;
            this.txt_PlaylistName.BorderThickness = 1;
            this.txt_PlaylistName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_PlaylistName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PlaylistName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_PlaylistName.DefaultText = "";
            this.txt_PlaylistName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.txt_PlaylistName.ForeColor = System.Drawing.Color.White;
            this.txt_PlaylistName.HideSelection = true;
            this.txt_PlaylistName.IconLeft = null;
            this.txt_PlaylistName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PlaylistName.IconPadding = 10;
            this.txt_PlaylistName.IconRight = null;
            this.txt_PlaylistName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PlaylistName.Lines = new string[0];
            this.txt_PlaylistName.Location = new System.Drawing.Point(333, 103);
            this.txt_PlaylistName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PlaylistName.MaxLength = 32767;
            this.txt_PlaylistName.MinimumSize = new System.Drawing.Size(2, 2);
            this.txt_PlaylistName.Modified = false;
            this.txt_PlaylistName.Multiline = false;
            this.txt_PlaylistName.Name = "txt_PlaylistName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_PlaylistName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_PlaylistName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_PlaylistName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_PlaylistName.OnIdleState = stateProperties4;
            this.txt_PlaylistName.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PlaylistName.PasswordChar = '\0';
            this.txt_PlaylistName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_PlaylistName.PlaceholderText = "Add a name";
            this.txt_PlaylistName.ReadOnly = false;
            this.txt_PlaylistName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_PlaylistName.SelectedText = "";
            this.txt_PlaylistName.SelectionLength = 0;
            this.txt_PlaylistName.SelectionStart = 0;
            this.txt_PlaylistName.ShortcutsEnabled = true;
            this.txt_PlaylistName.Size = new System.Drawing.Size(423, 63);
            this.txt_PlaylistName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_PlaylistName.TabIndex = 3;
            this.txt_PlaylistName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_PlaylistName.TextMarginBottom = 0;
            this.txt_PlaylistName.TextMarginLeft = 3;
            this.txt_PlaylistName.TextMarginTop = 0;
            this.txt_PlaylistName.TextPlaceholder = "Add a name";
            this.txt_PlaylistName.UseSystemPasswordChar = false;
            this.txt_PlaylistName.WordWrap = true;
            // 
            // txt_PlaylistDescription
            // 
            this.txt_PlaylistDescription.AcceptsReturn = false;
            this.txt_PlaylistDescription.AcceptsTab = false;
            this.txt_PlaylistDescription.AnimationSpeed = 200;
            this.txt_PlaylistDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_PlaylistDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_PlaylistDescription.BackColor = System.Drawing.Color.Transparent;
            this.txt_PlaylistDescription.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_PlaylistDescription.BackgroundImage")));
            this.txt_PlaylistDescription.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_PlaylistDescription.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_PlaylistDescription.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_PlaylistDescription.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_PlaylistDescription.BorderRadius = 1;
            this.txt_PlaylistDescription.BorderThickness = 1;
            this.txt_PlaylistDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_PlaylistDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PlaylistDescription.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_PlaylistDescription.DefaultText = "";
            this.txt_PlaylistDescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.txt_PlaylistDescription.ForeColor = System.Drawing.Color.White;
            this.txt_PlaylistDescription.HideSelection = true;
            this.txt_PlaylistDescription.IconLeft = null;
            this.txt_PlaylistDescription.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PlaylistDescription.IconPadding = 10;
            this.txt_PlaylistDescription.IconRight = null;
            this.txt_PlaylistDescription.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PlaylistDescription.Lines = new string[0];
            this.txt_PlaylistDescription.Location = new System.Drawing.Point(333, 192);
            this.txt_PlaylistDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PlaylistDescription.MaxLength = 32767;
            this.txt_PlaylistDescription.MinimumSize = new System.Drawing.Size(2, 2);
            this.txt_PlaylistDescription.Modified = false;
            this.txt_PlaylistDescription.Multiline = true;
            this.txt_PlaylistDescription.Name = "txt_PlaylistDescription";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_PlaylistDescription.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_PlaylistDescription.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_PlaylistDescription.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_PlaylistDescription.OnIdleState = stateProperties8;
            this.txt_PlaylistDescription.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PlaylistDescription.PasswordChar = '\0';
            this.txt_PlaylistDescription.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_PlaylistDescription.PlaceholderText = "Add an optional description";
            this.txt_PlaylistDescription.ReadOnly = false;
            this.txt_PlaylistDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_PlaylistDescription.SelectedText = "";
            this.txt_PlaylistDescription.SelectionLength = 0;
            this.txt_PlaylistDescription.SelectionStart = 0;
            this.txt_PlaylistDescription.ShortcutsEnabled = true;
            this.txt_PlaylistDescription.Size = new System.Drawing.Size(423, 188);
            this.txt_PlaylistDescription.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_PlaylistDescription.TabIndex = 5;
            this.txt_PlaylistDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_PlaylistDescription.TextMarginBottom = 0;
            this.txt_PlaylistDescription.TextMarginLeft = 3;
            this.txt_PlaylistDescription.TextMarginTop = 6;
            this.txt_PlaylistDescription.TextPlaceholder = "Add an optional description";
            this.txt_PlaylistDescription.UseSystemPasswordChar = false;
            this.txt_PlaylistDescription.WordWrap = true;
            // 
            // btn_Create
            // 
            this.btn_Create.AllowAnimations = true;
            this.btn_Create.AllowMouseEffects = true;
            this.btn_Create.AllowToggling = false;
            this.btn_Create.AnimationSpeed = 200;
            this.btn_Create.AutoGenerateColors = false;
            this.btn_Create.AutoRoundBorders = false;
            this.btn_Create.AutoSizeLeftIcon = true;
            this.btn_Create.AutoSizeRightIcon = true;
            this.btn_Create.BackColor = System.Drawing.Color.Transparent;
            this.btn_Create.BackColor1 = System.Drawing.Color.White;
            this.btn_Create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Create.BackgroundImage")));
            this.btn_Create.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Create.ButtonText = "CREATE";
            this.btn_Create.ButtonTextMarginLeft = 0;
            this.btn_Create.ColorContrastOnClick = 45;
            this.btn_Create.ColorContrastOnHover = 45;
            this.btn_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Create.CustomizableEdges = borderEdges1;
            this.btn_Create.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Create.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Create.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Create.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Create.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Create.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Create.ForeColor = System.Drawing.Color.Black;
            this.btn_Create.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Create.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Create.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Create.IconMarginLeft = 11;
            this.btn_Create.IconPadding = 10;
            this.btn_Create.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Create.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Create.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Create.IconSize = 25;
            this.btn_Create.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Create.IdleBorderRadius = 40;
            this.btn_Create.IdleBorderThickness = 1;
            this.btn_Create.IdleFillColor = System.Drawing.Color.White;
            this.btn_Create.IdleIconLeftImage = null;
            this.btn_Create.IdleIconRightImage = null;
            this.btn_Create.IndicateFocus = false;
            this.btn_Create.Location = new System.Drawing.Point(621, 406);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Create.OnDisabledState.BorderRadius = 40;
            this.btn_Create.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Create.OnDisabledState.BorderThickness = 1;
            this.btn_Create.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Create.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Create.OnDisabledState.IconLeftImage = null;
            this.btn_Create.OnDisabledState.IconRightImage = null;
            this.btn_Create.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_Create.onHoverState.BorderRadius = 40;
            this.btn_Create.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Create.onHoverState.BorderThickness = 1;
            this.btn_Create.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_Create.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Create.onHoverState.IconLeftImage = null;
            this.btn_Create.onHoverState.IconRightImage = null;
            this.btn_Create.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Create.OnIdleState.BorderRadius = 40;
            this.btn_Create.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Create.OnIdleState.BorderThickness = 1;
            this.btn_Create.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btn_Create.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_Create.OnIdleState.IconLeftImage = null;
            this.btn_Create.OnIdleState.IconRightImage = null;
            this.btn_Create.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Create.OnPressedState.BorderRadius = 40;
            this.btn_Create.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Create.OnPressedState.BorderThickness = 1;
            this.btn_Create.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Create.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Create.OnPressedState.IconLeftImage = null;
            this.btn_Create.OnPressedState.IconRightImage = null;
            this.btn_Create.Size = new System.Drawing.Size(135, 62);
            this.btn_Create.TabIndex = 7;
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Create.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Create.TextMarginLeft = 0;
            this.btn_Create.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Create.UseDefaultRadiusAndThickness = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Close.BorderRadius = 15;
            this.btn_Close.BorderSize = 0;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.Silver;
            this.btn_Close.Location = new System.Drawing.Point(723, 18);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(45, 46);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.TextColor = System.Drawing.Color.Silver;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Close_MouseLeave);
            this.btn_Close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Close_MouseMove);
            // 
            // CreatePlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(786, 495);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.txt_PlaylistDescription);
            this.Controls.Add(this.txt_PlaylistName);
            this.Controls.Add(this.ptr_Playlist);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreatePlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePlaylist";
            this.Load += new System.EventHandler(this.CreatePlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Playlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox ptr_Playlist;
        private Bunifu.UI.WinForms.BunifuTextBox txt_PlaylistName;
        private Bunifu.UI.WinForms.BunifuTextBox txt_PlaylistDescription;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Create;
        private CustomControls.RJControls.RJButton btn_Close;
    }
}