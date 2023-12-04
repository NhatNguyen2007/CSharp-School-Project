
namespace MusicApp
{
    partial class GenreBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenreBox));
            this.pnl_Container = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.ptr_Genre = new System.Windows.Forms.PictureBox();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Genre)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.pnl_Container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Container.BackgroundImage")));
            this.pnl_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Container.BorderColor = System.Drawing.Color.Transparent;
            this.pnl_Container.BorderRadius = 15;
            this.pnl_Container.BorderThickness = 1;
            this.pnl_Container.Controls.Add(this.ptr_Genre);
            this.pnl_Container.Controls.Add(this.lbl_Genre);
            this.pnl_Container.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.ShowBorders = true;
            this.pnl_Container.Size = new System.Drawing.Size(148, 148);
            this.pnl_Container.TabIndex = 0;
            this.pnl_Container.Click += new System.EventHandler(this.pnl_Container_Click);
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genre.ForeColor = System.Drawing.Color.White;
            this.lbl_Genre.Location = new System.Drawing.Point(9, 5);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(130, 40);
            this.lbl_Genre.TabIndex = 3;
            this.lbl_Genre.Text = "EDM";
            this.lbl_Genre.Click += new System.EventHandler(this.lbl_Genre_Click);
            // 
            // ptr_Genre
            // 
            this.ptr_Genre.Image = ((System.Drawing.Image)(resources.GetObject("ptr_Genre.Image")));
            this.ptr_Genre.Location = new System.Drawing.Point(46, 43);
            this.ptr_Genre.Name = "ptr_Genre";
            this.ptr_Genre.Size = new System.Drawing.Size(120, 120);
            this.ptr_Genre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_Genre.TabIndex = 4;
            this.ptr_Genre.TabStop = false;
            this.ptr_Genre.Click += new System.EventHandler(this.ptr_Genre_Click);
            // 
            // GenreBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_Container);
            this.Name = "GenreBox";
            this.Size = new System.Drawing.Size(148, 148);
            this.pnl_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Genre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnl_Container;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.PictureBox ptr_Genre;
    }
}
