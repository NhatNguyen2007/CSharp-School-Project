
namespace Vocab_English
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptr_Lets = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Play = new CustomControls.RJControls.RJButton();
            this.btn_unmute = new CustomControls.RJControls.RJButton();
            this.btn_mute = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Lets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(325, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 490);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ptr_Lets
            // 
            this.ptr_Lets.BackColor = System.Drawing.Color.Transparent;
            this.ptr_Lets.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptr_Lets.BackgroundImage")));
            this.ptr_Lets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptr_Lets.Location = new System.Drawing.Point(78, 270);
            this.ptr_Lets.Name = "ptr_Lets";
            this.ptr_Lets.Size = new System.Drawing.Size(258, 153);
            this.ptr_Lets.TabIndex = 2;
            this.ptr_Lets.TabStop = false;
            this.ptr_Lets.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(851, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 153);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.btn_Play.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Play.BackgroundImage")));
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Play.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Play.BorderRadius = 50;
            this.btn_Play.BorderSize = 0;
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.ForeColor = System.Drawing.Color.White;
            this.btn_Play.Location = new System.Drawing.Point(406, 547);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(356, 114);
            this.btn_Play.TabIndex = 3;
            this.btn_Play.TextColor = System.Drawing.Color.White;
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            this.btn_Play.MouseLeave += new System.EventHandler(this.btn_Play_MouseLeave);
            this.btn_Play.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Play_MouseMove);
            // 
            // btn_unmute
            // 
            this.btn_unmute.BackColor = System.Drawing.Color.Transparent;
            this.btn_unmute.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_unmute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_unmute.BackgroundImage")));
            this.btn_unmute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_unmute.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_unmute.BorderRadius = 20;
            this.btn_unmute.BorderSize = 0;
            this.btn_unmute.FlatAppearance.BorderSize = 0;
            this.btn_unmute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_unmute.ForeColor = System.Drawing.Color.White;
            this.btn_unmute.Location = new System.Drawing.Point(1111, 0);
            this.btn_unmute.Name = "btn_unmute";
            this.btn_unmute.Size = new System.Drawing.Size(60, 60);
            this.btn_unmute.TabIndex = 7;
            this.btn_unmute.TextColor = System.Drawing.Color.White;
            this.btn_unmute.UseVisualStyleBackColor = false;
            this.btn_unmute.Click += new System.EventHandler(this.btn_unmute_Click);
            // 
            // btn_mute
            // 
            this.btn_mute.BackColor = System.Drawing.Color.Transparent;
            this.btn_mute.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_mute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_mute.BackgroundImage")));
            this.btn_mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_mute.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_mute.BorderRadius = 20;
            this.btn_mute.BorderSize = 0;
            this.btn_mute.FlatAppearance.BorderSize = 0;
            this.btn_mute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mute.ForeColor = System.Drawing.Color.White;
            this.btn_mute.Location = new System.Drawing.Point(1111, 0);
            this.btn_mute.Name = "btn_mute";
            this.btn_mute.Size = new System.Drawing.Size(60, 60);
            this.btn_mute.TabIndex = 8;
            this.btn_mute.TextColor = System.Drawing.Color.White;
            this.btn_mute.UseVisualStyleBackColor = false;
            this.btn_mute.Visible = false;
            this.btn_mute.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 701);
            this.Controls.Add(this.btn_unmute);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.ptr_Lets);
            this.Controls.Add(this.btn_mute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duolingo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Lets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptr_Lets;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.RJControls.RJButton btn_Play;
        private CustomControls.RJControls.RJButton btn_unmute;
        private CustomControls.RJControls.RJButton btn_mute;
    }
}

