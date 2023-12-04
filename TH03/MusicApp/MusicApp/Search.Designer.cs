
namespace MusicApp
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnl_Header = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.txt_Search = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Header.BackgroundImage")));
            this.pnl_Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Header.BorderRadius = 1;
            this.pnl_Header.Controls.Add(this.txt_Search);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.GradientBottomLeft = System.Drawing.Color.Black;
            this.pnl_Header.GradientBottomRight = System.Drawing.Color.Black;
            this.pnl_Header.GradientTopLeft = System.Drawing.Color.DimGray;
            this.pnl_Header.GradientTopRight = System.Drawing.Color.DimGray;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Quality = 10;
            this.pnl_Header.Size = new System.Drawing.Size(1198, 78);
            this.pnl_Header.TabIndex = 0;
            // 
            // txt_Search
            // 
            this.txt_Search.AcceptsReturn = false;
            this.txt_Search.AcceptsTab = false;
            this.txt_Search.AnimationSpeed = 200;
            this.txt_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Search.BackColor = System.Drawing.Color.Transparent;
            this.txt_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Search.BackgroundImage")));
            this.txt_Search.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_Search.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Search.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_Search.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_Search.BorderRadius = 30;
            this.txt_Search.BorderThickness = 1;
            this.txt_Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.DefaultText = "";
            this.txt_Search.FillColor = System.Drawing.Color.White;
            this.txt_Search.ForeColor = System.Drawing.Color.Black;
            this.txt_Search.HideSelection = true;
            this.txt_Search.IconLeft = null;
            this.txt_Search.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.IconPadding = 10;
            this.txt_Search.IconRight = ((System.Drawing.Image)(resources.GetObject("txt_Search.IconRight")));
            this.txt_Search.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.Lines = new string[0];
            this.txt_Search.Location = new System.Drawing.Point(300, 12);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.MaxLength = 32767;
            this.txt_Search.MinimumSize = new System.Drawing.Size(2, 2);
            this.txt_Search.Modified = false;
            this.txt_Search.Multiline = false;
            this.txt_Search.Name = "txt_Search";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Search.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_Search.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Search.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Search.OnIdleState = stateProperties4;
            this.txt_Search.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_Search.PlaceholderText = "What do you want to listen to?";
            this.txt_Search.ReadOnly = false;
            this.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Search.SelectedText = "";
            this.txt_Search.SelectionLength = 0;
            this.txt_Search.SelectionStart = 0;
            this.txt_Search.ShortcutsEnabled = true;
            this.txt_Search.Size = new System.Drawing.Size(600, 54);
            this.txt_Search.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_Search.TabIndex = 8;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.TextMarginBottom = 0;
            this.txt_Search.TextMarginLeft = 3;
            this.txt_Search.TextMarginTop = 0;
            this.txt_Search.TextPlaceholder = "What do you want to listen to?";
            this.txt_Search.UseSystemPasswordChar = false;
            this.txt_Search.WordWrap = true;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackColor = System.Drawing.Color.Black;
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 78);
            this.pnl_Container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(1198, 651);
            this.pnl_Container.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 729);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.pnl_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel pnl_Header;
        public System.Windows.Forms.Panel pnl_Container;
        public Bunifu.UI.WinForms.BunifuTextBox txt_Search;
        private System.Windows.Forms.Timer timer1;
    }
}