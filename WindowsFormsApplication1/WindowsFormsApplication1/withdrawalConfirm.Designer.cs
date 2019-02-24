namespace WindowsFormsApplication1
{
    partial class withdrawalConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(withdrawalConfirm));
            this.withdrawalConfirmBox1 = new System.Windows.Forms.GroupBox();
            this.withdrawConfirmReturnCard = new System.Windows.Forms.Button();
            this.withdrawConfirmBalance = new System.Windows.Forms.Button();
            this.withdrawalConfirmClose = new System.Windows.Forms.Button();
            this.withdrawalConfirm1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.withdrawalConfirmBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // withdrawalConfirmBox1
            // 
            this.withdrawalConfirmBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("withdrawalConfirmBox1.BackgroundImage")));
            this.withdrawalConfirmBox1.Controls.Add(this.button1);
            this.withdrawalConfirmBox1.Controls.Add(this.withdrawConfirmReturnCard);
            this.withdrawalConfirmBox1.Controls.Add(this.withdrawConfirmBalance);
            this.withdrawalConfirmBox1.Controls.Add(this.withdrawalConfirmClose);
            this.withdrawalConfirmBox1.Controls.Add(this.withdrawalConfirm1);
            this.withdrawalConfirmBox1.Location = new System.Drawing.Point(177, 12);
            this.withdrawalConfirmBox1.Name = "withdrawalConfirmBox1";
            this.withdrawalConfirmBox1.Size = new System.Drawing.Size(998, 637);
            this.withdrawalConfirmBox1.TabIndex = 1;
            this.withdrawalConfirmBox1.TabStop = false;
            // 
            // withdrawConfirmReturnCard
            // 
            this.withdrawConfirmReturnCard.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawConfirmReturnCard.Location = new System.Drawing.Point(778, 528);
            this.withdrawConfirmReturnCard.Name = "withdrawConfirmReturnCard";
            this.withdrawConfirmReturnCard.Size = new System.Drawing.Size(214, 70);
            this.withdrawConfirmReturnCard.TabIndex = 2;
            this.withdrawConfirmReturnCard.Text = "Return Card";
            this.withdrawConfirmReturnCard.UseVisualStyleBackColor = true;
            this.withdrawConfirmReturnCard.Click += new System.EventHandler(this.withdrawConfirmReturnCard_Click);
            // 
            // withdrawConfirmBalance
            // 
            this.withdrawConfirmBalance.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawConfirmBalance.Location = new System.Drawing.Point(778, 435);
            this.withdrawConfirmBalance.Name = "withdrawConfirmBalance";
            this.withdrawConfirmBalance.Size = new System.Drawing.Size(214, 70);
            this.withdrawConfirmBalance.TabIndex = 2;
            this.withdrawConfirmBalance.Text = "Show Balance";
            this.withdrawConfirmBalance.UseVisualStyleBackColor = true;
            this.withdrawConfirmBalance.Click += new System.EventHandler(this.withdrawConfirmBalance_Click);
            // 
            // withdrawalConfirmClose
            // 
            this.withdrawalConfirmClose.BackColor = System.Drawing.Color.Transparent;
            this.withdrawalConfirmClose.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawalConfirmClose.Location = new System.Drawing.Point(6, 435);
            this.withdrawalConfirmClose.Name = "withdrawalConfirmClose";
            this.withdrawalConfirmClose.Size = new System.Drawing.Size(281, 71);
            this.withdrawalConfirmClose.TabIndex = 1;
            this.withdrawalConfirmClose.Text = "Request Another Withdrawal";
            this.withdrawalConfirmClose.UseVisualStyleBackColor = false;
            this.withdrawalConfirmClose.Click += new System.EventHandler(this.withdrawalConfirmClose_Click);
            // 
            // withdrawalConfirm1
            // 
            this.withdrawalConfirm1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawalConfirm1.Location = new System.Drawing.Point(345, 222);
            this.withdrawalConfirm1.Name = "withdrawalConfirm1";
            this.withdrawalConfirm1.Size = new System.Drawing.Size(290, 116);
            this.withdrawalConfirm1.TabIndex = 0;
            this.withdrawalConfirm1.Text = "Please Take Your Cash";
            this.withdrawalConfirm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // withdrawalConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 661);
            this.Controls.Add(this.withdrawalConfirmBox1);
            this.Name = "withdrawalConfirm";
            this.Text = "withdrawalConfirm";
            this.withdrawalConfirmBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox withdrawalConfirmBox1;
        private System.Windows.Forms.Button withdrawalConfirmClose;
        private System.Windows.Forms.Label withdrawalConfirm1;
        private System.Windows.Forms.Button withdrawConfirmReturnCard;
        private System.Windows.Forms.Button withdrawConfirmBalance;
        private System.Windows.Forms.Button button1;
    }
}