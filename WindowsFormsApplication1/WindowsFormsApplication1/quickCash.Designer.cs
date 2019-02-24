namespace WindowsFormsApplication1
{
    partial class quickCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quickCash));
            this.quickCashBox1 = new System.Windows.Forms.GroupBox();
            this.quickReturnCard = new System.Windows.Forms.Button();
            this.quickCashClose = new System.Windows.Forms.Button();
            this.quickCashConfirm = new System.Windows.Forms.Label();
            this.quickCashBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quickCashBox1
            // 
            this.quickCashBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quickCashBox1.BackgroundImage")));
            this.quickCashBox1.Controls.Add(this.quickReturnCard);
            this.quickCashBox1.Controls.Add(this.quickCashClose);
            this.quickCashBox1.Controls.Add(this.quickCashConfirm);
            this.quickCashBox1.Location = new System.Drawing.Point(171, 12);
            this.quickCashBox1.Name = "quickCashBox1";
            this.quickCashBox1.Size = new System.Drawing.Size(998, 637);
            this.quickCashBox1.TabIndex = 0;
            this.quickCashBox1.TabStop = false;
            // 
            // quickReturnCard
            // 
            this.quickReturnCard.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickReturnCard.Location = new System.Drawing.Point(791, 432);
            this.quickReturnCard.Name = "quickReturnCard";
            this.quickReturnCard.Size = new System.Drawing.Size(201, 71);
            this.quickReturnCard.TabIndex = 2;
            this.quickReturnCard.Text = "Return Card";
            this.quickReturnCard.UseVisualStyleBackColor = true;
            this.quickReturnCard.Click += new System.EventHandler(this.quickReturnCard_Click);
            // 
            // quickCashClose
            // 
            this.quickCashClose.BackColor = System.Drawing.Color.Transparent;
            this.quickCashClose.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickCashClose.Location = new System.Drawing.Point(6, 432);
            this.quickCashClose.Name = "quickCashClose";
            this.quickCashClose.Size = new System.Drawing.Size(201, 71);
            this.quickCashClose.TabIndex = 1;
            this.quickCashClose.Text = "Main Menu";
            this.quickCashClose.UseVisualStyleBackColor = false;
            this.quickCashClose.Click += new System.EventHandler(this.quickCashClose_Click);
            // 
            // quickCashConfirm
            // 
            this.quickCashConfirm.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickCashConfirm.Location = new System.Drawing.Point(345, 222);
            this.quickCashConfirm.Name = "quickCashConfirm";
            this.quickCashConfirm.Size = new System.Drawing.Size(290, 116);
            this.quickCashConfirm.TabIndex = 0;
            this.quickCashConfirm.Text = "Please Take Your Cash";
            this.quickCashConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quickCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 661);
            this.Controls.Add(this.quickCashBox1);
            this.Name = "quickCash";
            this.Text = "quickCash";
            this.quickCashBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox quickCashBox1;
        private System.Windows.Forms.Label quickCashConfirm;
        private System.Windows.Forms.Button quickCashClose;
        private System.Windows.Forms.Button quickReturnCard;
    }
}