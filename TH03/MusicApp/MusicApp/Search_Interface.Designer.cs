
namespace MusicApp
{
    partial class Search_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Interface));
            this.pnl_RecentSearches = new Bunifu.UI.WinForms.BunifuPanel();
            this.FlLayout_Searches = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_RecentSearches.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_RecentSearches
            // 
            this.pnl_RecentSearches.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))));
            this.pnl_RecentSearches.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_RecentSearches.BackgroundImage")));
            this.pnl_RecentSearches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_RecentSearches.BorderColor = System.Drawing.Color.Transparent;
            this.pnl_RecentSearches.BorderRadius = 30;
            this.pnl_RecentSearches.BorderThickness = 1;
            this.pnl_RecentSearches.Controls.Add(this.FlLayout_Searches);
            this.pnl_RecentSearches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_RecentSearches.Location = new System.Drawing.Point(0, 0);
            this.pnl_RecentSearches.Name = "pnl_RecentSearches";
            this.pnl_RecentSearches.ShowBorders = true;
            this.pnl_RecentSearches.Size = new System.Drawing.Size(799, 423);
            this.pnl_RecentSearches.TabIndex = 4;
            // 
            // FlLayout_Searches
            // 
            this.FlLayout_Searches.AutoScroll = true;
            this.FlLayout_Searches.BackColor = System.Drawing.Color.Transparent;
            this.FlLayout_Searches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlLayout_Searches.Location = new System.Drawing.Point(0, 0);
            this.FlLayout_Searches.Name = "FlLayout_Searches";
            this.FlLayout_Searches.Size = new System.Drawing.Size(799, 423);
            this.FlLayout_Searches.TabIndex = 1;
            // 
            // Search_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(799, 423);
            this.Controls.Add(this.pnl_RecentSearches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search_Interface";
            this.Text = "Search_Interface";
            this.Load += new System.EventHandler(this.Search_Interface_Load);
            this.pnl_RecentSearches.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnl_RecentSearches;
        public System.Windows.Forms.FlowLayoutPanel FlLayout_Searches;
    }
}