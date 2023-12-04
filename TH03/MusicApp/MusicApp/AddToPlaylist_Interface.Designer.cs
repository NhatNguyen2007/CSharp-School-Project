
namespace MusicApp
{
    partial class AddToPlaylist_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToPlaylist_Interface));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.FlLayout_Playlist = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Close = new CustomControls.RJControls.RJButton();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(20, 20);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(143, 22);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Playlist details";
            // 
            // pnl_Header
            // 
            this.pnl_Header.Controls.Add(this.btn_Close);
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(500, 80);
            this.pnl_Header.TabIndex = 3;
            // 
            // FlLayout_Playlist
            // 
            this.FlLayout_Playlist.AutoScroll = true;
            this.FlLayout_Playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlLayout_Playlist.Location = new System.Drawing.Point(0, 80);
            this.FlLayout_Playlist.Name = "FlLayout_Playlist";
            this.FlLayout_Playlist.Size = new System.Drawing.Size(500, 212);
            this.FlLayout_Playlist.TabIndex = 4;
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
            this.btn_Close.Location = new System.Drawing.Point(458, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.TextColor = System.Drawing.Color.Silver;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Close_MouseLeave);
            this.btn_Close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Close_MouseMove);
            // 
            // AddToPlaylist_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(500, 292);
            this.Controls.Add(this.FlLayout_Playlist);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddToPlaylist_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToPlaylist_Interface";
            this.Load += new System.EventHandler(this.AddToPlaylist_Interface_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.FlowLayoutPanel FlLayout_Playlist;
        private CustomControls.RJControls.RJButton btn_Close;
    }
}