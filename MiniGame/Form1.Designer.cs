namespace MiniGame
{
    partial class Form1
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
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pllayer1 = new System.Windows.Forms.Panel();
            this.pllayer2 = new System.Windows.Forms.Panel();
            this.pllayer4 = new System.Windows.Forms.Panel();
            this.pllayer3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlCard.Location = new System.Drawing.Point(515, 26);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(250, 295);
            this.pnlCard.TabIndex = 0;
            // 
            // pllayer1
            // 
            this.pllayer1.BackColor = System.Drawing.Color.Ivory;
            this.pllayer1.Location = new System.Drawing.Point(33, 439);
            this.pllayer1.Name = "pllayer1";
            this.pllayer1.Size = new System.Drawing.Size(238, 291);
            this.pllayer1.TabIndex = 2;
            // 
            // pllayer2
            // 
            this.pllayer2.BackColor = System.Drawing.Color.Ivory;
            this.pllayer2.Location = new System.Drawing.Point(291, 439);
            this.pllayer2.Name = "pllayer2";
            this.pllayer2.Size = new System.Drawing.Size(238, 291);
            this.pllayer2.TabIndex = 3;
            // 
            // pllayer4
            // 
            this.pllayer4.BackColor = System.Drawing.Color.Ivory;
            this.pllayer4.Location = new System.Drawing.Point(1018, 439);
            this.pllayer4.Name = "pllayer4";
            this.pllayer4.Size = new System.Drawing.Size(238, 291);
            this.pllayer4.TabIndex = 5;
            // 
            // pllayer3
            // 
            this.pllayer3.BackColor = System.Drawing.Color.Ivory;
            this.pllayer3.Location = new System.Drawing.Point(743, 439);
            this.pllayer3.Name = "pllayer3";
            this.pllayer3.Size = new System.Drawing.Size(238, 291);
            this.pllayer3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 66);
            this.button1.TabIndex = 6;
            this.button1.Text = "Chơi lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniGame.Properties.Resources.coins;
            this.pictureBox1.Location = new System.Drawing.Point(775, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MiniGame.Properties.Resources.coins;
            this.pictureBox2.Location = new System.Drawing.Point(385, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1275, 742);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pllayer4);
            this.Controls.Add(this.pllayer3);
            this.Controls.Add(this.pllayer2);
            this.Controls.Add(this.pllayer1);
            this.Controls.Add(this.pnlCard);
            this.Name = "Form1";
            this.Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pllayer1;
        private System.Windows.Forms.Panel pllayer2;
        private System.Windows.Forms.Panel pllayer4;
        private System.Windows.Forms.Panel pllayer3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

