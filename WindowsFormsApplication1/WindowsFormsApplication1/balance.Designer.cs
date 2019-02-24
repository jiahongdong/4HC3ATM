namespace WindowsFormsApplication1
{
    partial class balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(balance));
            this.quickCashBox1 = new System.Windows.Forms.GroupBox();
            this.balanceGoBack = new System.Windows.Forms.Button();
            this.balanceReturnCard = new System.Windows.Forms.Button();
            this.quickCashBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quickCashBox1
            // 
            this.quickCashBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quickCashBox1.BackgroundImage")));
            this.quickCashBox1.Controls.Add(this.balanceReturnCard);
            this.quickCashBox1.Controls.Add(this.balanceGoBack);
            this.quickCashBox1.Location = new System.Drawing.Point(177, 12);
            this.quickCashBox1.Name = "quickCashBox1";
            this.quickCashBox1.Size = new System.Drawing.Size(998, 637);
            this.quickCashBox1.TabIndex = 2;
            this.quickCashBox1.TabStop = false;
            // 
            // balanceGoBack
            // 
            this.balanceGoBack.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceGoBack.Location = new System.Drawing.Point(6, 432);
            this.balanceGoBack.Name = "balanceGoBack";
            this.balanceGoBack.Size = new System.Drawing.Size(201, 70);
            this.balanceGoBack.TabIndex = 0;
            this.balanceGoBack.Text = "Main Menu";
            this.balanceGoBack.UseVisualStyleBackColor = true;
            this.balanceGoBack.Click += new System.EventHandler(this.balanceGoBack_Click);
            // 
            // balanceReturnCard
            // 
            this.balanceReturnCard.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceReturnCard.Location = new System.Drawing.Point(791, 432);
            this.balanceReturnCard.Name = "balanceReturnCard";
            this.balanceReturnCard.Size = new System.Drawing.Size(201, 71);
            this.balanceReturnCard.TabIndex = 1;
            this.balanceReturnCard.Text = "Return Card";
            this.balanceReturnCard.UseVisualStyleBackColor = true;
            this.balanceReturnCard.Click += new System.EventHandler(this.balanceReturnCard_Click);
            // 
            // balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 661);
            this.Controls.Add(this.quickCashBox1);
            this.Name = "balance";
            this.Text = "balance";
            this.quickCashBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox quickCashBox1;
        private System.Windows.Forms.Button balanceGoBack;
        private System.Windows.Forms.Button balanceReturnCard;
    }
}