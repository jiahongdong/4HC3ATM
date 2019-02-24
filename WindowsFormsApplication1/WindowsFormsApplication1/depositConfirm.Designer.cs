namespace WindowsFormsApplication1
{
    partial class depositConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depositConfirm));
            this.depositConfirmBox1 = new System.Windows.Forms.GroupBox();
            this.depositConfirmAnother = new System.Windows.Forms.Button();
            this.depositConfirm1 = new System.Windows.Forms.Label();
            this.depositConfirmBalance = new System.Windows.Forms.Button();
            this.depositConfirmReturnCard = new System.Windows.Forms.Button();
            this.depositConfirmBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositConfirmBox1
            // 
            this.depositConfirmBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("depositConfirmBox1.BackgroundImage")));
            this.depositConfirmBox1.Controls.Add(this.depositConfirmReturnCard);
            this.depositConfirmBox1.Controls.Add(this.depositConfirmBalance);
            this.depositConfirmBox1.Controls.Add(this.depositConfirmAnother);
            this.depositConfirmBox1.Controls.Add(this.depositConfirm1);
            this.depositConfirmBox1.Location = new System.Drawing.Point(177, 12);
            this.depositConfirmBox1.Name = "depositConfirmBox1";
            this.depositConfirmBox1.Size = new System.Drawing.Size(998, 637);
            this.depositConfirmBox1.TabIndex = 2;
            this.depositConfirmBox1.TabStop = false;
            // 
            // depositConfirmAnother
            // 
            this.depositConfirmAnother.BackColor = System.Drawing.Color.Transparent;
            this.depositConfirmAnother.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositConfirmAnother.Location = new System.Drawing.Point(6, 419);
            this.depositConfirmAnother.Name = "depositConfirmAnother";
            this.depositConfirmAnother.Size = new System.Drawing.Size(214, 71);
            this.depositConfirmAnother.TabIndex = 1;
            this.depositConfirmAnother.Text = "Deposit Another Fund";
            this.depositConfirmAnother.UseVisualStyleBackColor = false;
            this.depositConfirmAnother.Click += new System.EventHandler(this.depositConfirmAnother_Click);
            // 
            // depositConfirm1
            // 
            this.depositConfirm1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositConfirm1.Location = new System.Drawing.Point(256, 227);
            this.depositConfirm1.Name = "depositConfirm1";
            this.depositConfirm1.Size = new System.Drawing.Size(473, 116);
            this.depositConfirm1.TabIndex = 0;
            this.depositConfirm1.Text = "Fund has been successfully deposited";
            this.depositConfirm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depositConfirmBalance
            // 
            this.depositConfirmBalance.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositConfirmBalance.Location = new System.Drawing.Point(778, 419);
            this.depositConfirmBalance.Name = "depositConfirmBalance";
            this.depositConfirmBalance.Size = new System.Drawing.Size(214, 70);
            this.depositConfirmBalance.TabIndex = 2;
            this.depositConfirmBalance.Text = "Show Balance";
            this.depositConfirmBalance.UseVisualStyleBackColor = true;
            this.depositConfirmBalance.Click += new System.EventHandler(this.depositConfirmBalance_Click);
            // 
            // depositConfirmReturnCard
            // 
            this.depositConfirmReturnCard.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositConfirmReturnCard.Location = new System.Drawing.Point(778, 508);
            this.depositConfirmReturnCard.Name = "depositConfirmReturnCard";
            this.depositConfirmReturnCard.Size = new System.Drawing.Size(214, 70);
            this.depositConfirmReturnCard.TabIndex = 3;
            this.depositConfirmReturnCard.Text = "Return Card";
            this.depositConfirmReturnCard.UseVisualStyleBackColor = true;
            this.depositConfirmReturnCard.Click += new System.EventHandler(this.depositConfirmReturnCard_Click);
            // 
            // depositConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 661);
            this.Controls.Add(this.depositConfirmBox1);
            this.Name = "depositConfirm";
            this.Text = "depositConfirm";
            this.depositConfirmBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox depositConfirmBox1;
        private System.Windows.Forms.Button depositConfirmAnother;
        private System.Windows.Forms.Label depositConfirm1;
        private System.Windows.Forms.Button depositConfirmReturnCard;
        private System.Windows.Forms.Button depositConfirmBalance;
    }
}