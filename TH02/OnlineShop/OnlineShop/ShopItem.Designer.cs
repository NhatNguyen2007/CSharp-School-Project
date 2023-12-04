
namespace OnlineShop
{
    partial class ShopItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopItem));
            this.ptr_Item = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.lbl_Rating = new Bunifu.UI.WinForms.BunifuRating();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // ptr_Item
            // 
            this.ptr_Item.BackColor = System.Drawing.Color.Transparent;
            this.ptr_Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptr_Item.Location = new System.Drawing.Point(50, 5);
            this.ptr_Item.Name = "ptr_Item";
            this.ptr_Item.Size = new System.Drawing.Size(180, 180);
            this.ptr_Item.TabIndex = 0;
            this.ptr_Item.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(3, 213);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(93, 38);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(3, 251);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(78, 38);
            this.lbl_Price.TabIndex = 1;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Buy
            // 
            this.btn_Buy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Buy.BackgroundImage")));
            this.btn_Buy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Buy.Location = new System.Drawing.Point(231, 3);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(55, 55);
            this.btn_Buy.TabIndex = 2;
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // lbl_Rating
            // 
            this.lbl_Rating.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Rating.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lbl_Rating.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.lbl_Rating.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lbl_Rating.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lbl_Rating.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.lbl_Rating.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.lbl_Rating.InnerRadius = 2F;
            this.lbl_Rating.Location = new System.Drawing.Point(50, 301);
            this.lbl_Rating.Name = "lbl_Rating";
            this.lbl_Rating.OuterRadius = 10F;
            this.lbl_Rating.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.lbl_Rating.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.lbl_Rating.ReadOnly = false;
            this.lbl_Rating.RightClickToClear = true;
            this.lbl_Rating.Size = new System.Drawing.Size(121, 22);
            this.lbl_Rating.TabIndex = 3;
            this.lbl_Rating.Text = "bunifuRating1";
            this.lbl_Rating.Value = 2;
            // 
            // ShopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_Rating);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.ptr_Item);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ShopItem";
            this.Size = new System.Drawing.Size(289, 343);
            this.Load += new System.EventHandler(this.ShopItem_Load);
            this.Click += new System.EventHandler(this.ShopItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_Item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptr_Item;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Buy;
        private Bunifu.UI.WinForms.BunifuRating lbl_Rating;
    }
}
