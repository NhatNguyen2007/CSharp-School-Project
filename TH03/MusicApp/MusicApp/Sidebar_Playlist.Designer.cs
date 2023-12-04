
namespace MusicApp
{
    partial class Sidebar_Playlist
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
            this.lbl_PlaylistName = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.rjDropDownMenu1 = new MusicApp.RJDropDownMenu(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rjDropDownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_PlaylistName
            // 
            this.lbl_PlaylistName.AutoSize = true;
            this.lbl_PlaylistName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlaylistName.ForeColor = System.Drawing.Color.White;
            this.lbl_PlaylistName.Location = new System.Drawing.Point(12, 8);
            this.lbl_PlaylistName.Name = "lbl_PlaylistName";
            this.lbl_PlaylistName.Size = new System.Drawing.Size(95, 16);
            this.lbl_PlaylistName.TabIndex = 0;
            this.lbl_PlaylistName.Text = "Playlist Name";
            this.lbl_PlaylistName.Click += new System.EventHandler(this.lbl_PlaylistName_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Beige;
            this.line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line.Cursor = System.Windows.Forms.Cursors.Default;
            this.line.ForeColor = System.Drawing.Color.DimGray;
            this.line.Location = new System.Drawing.Point(0, 31);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(222, 2);
            this.line.TabIndex = 1;
            // 
            // rjDropDownMenu1
            // 
            this.rjDropDownMenu1.IsMainMenu = false;
            this.rjDropDownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.rjDropDownMenu1.MenuItemHeight = 25;
            this.rjDropDownMenu1.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.rjDropDownMenu1.Name = "rjDropDownMenu1";
            this.rjDropDownMenu1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.rjDropDownMenu1.Size = new System.Drawing.Size(181, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Sidebar_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ContextMenuStrip = this.rjDropDownMenu1;
            this.Controls.Add(this.line);
            this.Controls.Add(this.lbl_PlaylistName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Sidebar_Playlist";
            this.Size = new System.Drawing.Size(222, 32);
            this.Load += new System.EventHandler(this.MyPlaylist_Load);
            this.Click += new System.EventHandler(this.MyPlaylist_Click);
            this.rjDropDownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PlaylistName;
        private System.Windows.Forms.Label line;
        private RJDropDownMenu rjDropDownMenu1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
