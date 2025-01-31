namespace MiniGame.UC
{
    partial class Card
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
            this.lblNameCard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameCard
            // 
            this.lblNameCard.AutoSize = true;
            this.lblNameCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNameCard.ForeColor = System.Drawing.Color.Red;
            this.lblNameCard.Location = new System.Drawing.Point(75, 86);
            this.lblNameCard.Name = "lblNameCard";
            this.lblNameCard.Size = new System.Drawing.Size(79, 91);
            this.lblNameCard.TabIndex = 0;
            this.lblNameCard.Text = "J";
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.lblNameCard);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(237, 279);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameCard;
    }
}
