namespace WindowsFormsApplication1
{
    partial class depositSuccessful
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depositSuccessful));
            this.depoSuccBox1 = new System.Windows.Forms.GroupBox();
            this.depoSucShowBalance = new System.Windows.Forms.Button();
            this.depoSucToMainMenu = new System.Windows.Forms.Button();
            this.depoSuccToAnother = new System.Windows.Forms.Button();
            this.depoConfirm1 = new System.Windows.Forms.Label();
            this.depoSucReturnCard = new System.Windows.Forms.Button();
            this.depoSuccBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depoSuccBox1
            // 
            this.depoSuccBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("depoSuccBox1.BackgroundImage")));
            this.depoSuccBox1.Controls.Add(this.depoConfirm1);
            this.depoSuccBox1.Controls.Add(this.depoSuccToAnother);
            this.depoSuccBox1.Controls.Add(this.depoSucReturnCard);
            this.depoSuccBox1.Controls.Add(this.depoSucShowBalance);
            this.depoSuccBox1.Controls.Add(this.depoSucToMainMenu);
            this.depoSuccBox1.Location = new System.Drawing.Point(177, 12);
            this.depoSuccBox1.Name = "depoSuccBox1";
            this.depoSuccBox1.Size = new System.Drawing.Size(998, 637);
            this.depoSuccBox1.TabIndex = 2;
            this.depoSuccBox1.TabStop = false;
            // 
            // depoSucShowBalance
            // 
            this.depoSucShowBalance.BackColor = System.Drawing.Color.Transparent;
            this.depoSucShowBalance.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoSucShowBalance.Location = new System.Drawing.Point(784, 432);
            this.depoSucShowBalance.Name = "depoSucShowBalance";
            this.depoSucShowBalance.Size = new System.Drawing.Size(208, 70);
            this.depoSucShowBalance.TabIndex = 1;
            this.depoSucShowBalance.Text = "Show Balance";
            this.depoSucShowBalance.UseVisualStyleBackColor = false;
            this.depoSucShowBalance.Click += new System.EventHandler(this.depoSucShowBalance_Click);
            // 
            // depoSucToMainMenu
            // 
            this.depoSucToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.depoSucToMainMenu.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoSucToMainMenu.Location = new System.Drawing.Point(6, 527);
            this.depoSucToMainMenu.Name = "depoSucToMainMenu";
            this.depoSucToMainMenu.Size = new System.Drawing.Size(281, 70);
            this.depoSucToMainMenu.TabIndex = 1;
            this.depoSucToMainMenu.Text = "Main Menu";
            this.depoSucToMainMenu.UseVisualStyleBackColor = false;
            this.depoSucToMainMenu.Click += new System.EventHandler(this.depoSucToMainMenu_Click);
            // 
            // depoSuccToAnother
            // 
            this.depoSuccToAnother.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoSuccToAnother.Location = new System.Drawing.Point(6, 435);
            this.depoSuccToAnother.Name = "depoSuccToAnother";
            this.depoSuccToAnother.Size = new System.Drawing.Size(281, 71);
            this.depoSuccToAnother.TabIndex = 2;
            this.depoSuccToAnother.Text = "Request Another Deposit";
            this.depoSuccToAnother.UseVisualStyleBackColor = true;
            this.depoSuccToAnother.Click += new System.EventHandler(this.depoSuccToAnother_Click);
            // 
            // depoConfirm1
            // 
            this.depoConfirm1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoConfirm1.Location = new System.Drawing.Point(296, 222);
            this.depoConfirm1.Name = "depoConfirm1";
            this.depoConfirm1.Size = new System.Drawing.Size(460, 116);
            this.depoConfirm1.TabIndex = 3;
            this.depoConfirm1.Text = "Fund has been successfully deposited";
            this.depoConfirm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depoSucReturnCard
            // 
            this.depoSucReturnCard.BackColor = System.Drawing.Color.Transparent;
            this.depoSucReturnCard.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoSucReturnCard.Location = new System.Drawing.Point(784, 527);
            this.depoSucReturnCard.Name = "depoSucReturnCard";
            this.depoSucReturnCard.Size = new System.Drawing.Size(208, 70);
            this.depoSucReturnCard.TabIndex = 1;
            this.depoSucReturnCard.Text = "Return Card";
            this.depoSucReturnCard.UseVisualStyleBackColor = false;
            this.depoSucReturnCard.Click += new System.EventHandler(this.depoSucReturnCard_Click);
            // 
            // depositSuccessful
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 661);
            this.Controls.Add(this.depoSuccBox1);
            this.Name = "depositSuccessful";
            this.Text = "depositSuccessful";
            this.depoSuccBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox depoSuccBox1;
        private System.Windows.Forms.Button depoSucShowBalance;
        private System.Windows.Forms.Button depoSucToMainMenu;
        private System.Windows.Forms.Button depoSuccToAnother;
        private System.Windows.Forms.Label depoConfirm1;
        private System.Windows.Forms.Button depoSucReturnCard;
    }
}