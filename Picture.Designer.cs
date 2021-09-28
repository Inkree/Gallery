
namespace Gallery
{
    partial class Picture
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureList = new System.Windows.Forms.ImageList(this.components);
            this.buttonForwardImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureList
            // 
            this.pictureList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.pictureList.ImageSize = new System.Drawing.Size(16, 16);
            this.pictureList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonForwardImg
            // 
            this.buttonForwardImg.Location = new System.Drawing.Point(813, 251);
            this.buttonForwardImg.Name = "buttonForwardImg";
            this.buttonForwardImg.Size = new System.Drawing.Size(51, 29);
            this.buttonForwardImg.TabIndex = 1;
            this.buttonForwardImg.Text = ">";
            this.buttonForwardImg.UseVisualStyleBackColor = true;
            this.buttonForwardImg.Click += new System.EventHandler(this.buttonForwardImg_Click);
            // 
            // Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 535);
            this.Controls.Add(this.buttonForwardImg);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Picture";
            this.Text = "Picture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList pictureList;
        private System.Windows.Forms.Button buttonForwardImg;
    }
}