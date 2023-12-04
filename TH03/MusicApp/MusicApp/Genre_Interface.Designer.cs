
namespace MusicApp
{
    partial class Genre_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Genre_Interface));
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.FlLayout_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Header = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.PictureBox();
            this.btn_Back = new System.Windows.Forms.PictureBox();
            this.pnl_Container.SuspendLayout();
            this.FlLayout_Container.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackColor = System.Drawing.Color.Black;
            this.pnl_Container.Controls.Add(this.FlLayout_Container);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.ForeColor = System.Drawing.Color.Transparent;
            this.pnl_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(799, 423);
            this.pnl_Container.TabIndex = 8;
            // 
            // FlLayout_Container
            // 
            this.FlLayout_Container.AutoScroll = true;
            this.FlLayout_Container.BackColor = System.Drawing.Color.Transparent;
            this.FlLayout_Container.Controls.Add(this.pnl_Header);
            this.FlLayout_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlLayout_Container.Location = new System.Drawing.Point(0, 0);
            this.FlLayout_Container.Name = "FlLayout_Container";
            this.FlLayout_Container.Size = new System.Drawing.Size(799, 423);
            this.FlLayout_Container.TabIndex = 9;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Header.BackgroundImage")));
            this.pnl_Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Header.BorderRadius = 1;
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Controls.Add(this.btn_Next);
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.GradientBottomLeft = System.Drawing.Color.Black;
            this.pnl_Header.GradientBottomRight = System.Drawing.Color.Black;
            this.pnl_Header.GradientTopLeft = System.Drawing.Color.DimGray;
            this.pnl_Header.GradientTopRight = System.Drawing.Color.DimGray;
            this.pnl_Header.Location = new System.Drawing.Point(3, 3);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Quality = 10;
            this.pnl_Header.Size = new System.Drawing.Size(799, 160);
            this.pnl_Header.TabIndex = 9;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(12, 75);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(128, 44);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "Genre";
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
            this.btn_Next.TabIndex = 5;
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
            this.btn_Back.TabIndex = 4;
            this.btn_Back.TabStop = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            this.btn_Back.MouseLeave += new System.EventHandler(this.btn_Back_MouseLeave_1);
            this.btn_Back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Back_MouseMove_1);
            // 
            // Genre_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 423);
            this.Controls.Add(this.pnl_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Genre_Interface";
            this.Text = "Genre_Interface";
            this.Load += new System.EventHandler(this.Genre_Interface_Load);
            this.pnl_Container.ResumeLayout(false);
            this.FlLayout_Container.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.FlowLayoutPanel FlLayout_Container;
        public System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox btn_Next;
        private System.Windows.Forms.PictureBox btn_Back;
        public Bunifu.UI.WinForms.BunifuGradientPanel pnl_Header;
    }
}