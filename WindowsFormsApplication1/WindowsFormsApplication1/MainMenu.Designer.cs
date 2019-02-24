namespace WindowsFormsApplication1
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.MainMenuBox1 = new System.Windows.Forms.GroupBox();
            this.mainReturnCard = new System.Windows.Forms.Button();
            this.mainWelcome = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Button();
            this.lblTransfer = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Button();
            this.lblWith = new System.Windows.Forms.Button();
            this.lblCash = new System.Windows.Forms.Button();
            this.lblFast = new System.Windows.Forms.Button();
            this.lblPrint = new System.Windows.Forms.Button();
            this.lblDep = new System.Windows.Forms.Button();
            this.MainMenuBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuBox1
            // 
            this.MainMenuBox1.BackColor = System.Drawing.Color.Green;
            this.MainMenuBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainMenuBox1.BackgroundImage")));
            this.MainMenuBox1.Controls.Add(this.mainReturnCard);
            this.MainMenuBox1.Controls.Add(this.mainWelcome);
            this.MainMenuBox1.Controls.Add(this.lblLoan);
            this.MainMenuBox1.Controls.Add(this.lblTransfer);
            this.MainMenuBox1.Controls.Add(this.lblBalance);
            this.MainMenuBox1.Controls.Add(this.lblWith);
            this.MainMenuBox1.Controls.Add(this.lblCash);
            this.MainMenuBox1.Controls.Add(this.lblFast);
            this.MainMenuBox1.Controls.Add(this.lblPrint);
            this.MainMenuBox1.Controls.Add(this.lblDep);
            this.MainMenuBox1.Location = new System.Drawing.Point(171, 12);
            this.MainMenuBox1.Name = "MainMenuBox1";
            this.MainMenuBox1.Size = new System.Drawing.Size(998, 637);
            this.MainMenuBox1.TabIndex = 0;
            this.MainMenuBox1.TabStop = false;
            this.MainMenuBox1.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // mainReturnCard
            // 
            this.mainReturnCard.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mainReturnCard.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainReturnCard.Location = new System.Drawing.Point(747, 507);
            this.mainReturnCard.Name = "mainReturnCard";
            this.mainReturnCard.Size = new System.Drawing.Size(245, 59);
            this.mainReturnCard.TabIndex = 2;
            this.mainReturnCard.Text = "Return Card";
            this.mainReturnCard.UseVisualStyleBackColor = false;
            this.mainReturnCard.Click += new System.EventHandler(this.mainReturnCard_Click);
            // 
            // mainWelcome
            // 
            this.mainWelcome.BackColor = System.Drawing.Color.White;
            this.mainWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainWelcome.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainWelcome.Location = new System.Drawing.Point(282, 53);
            this.mainWelcome.Name = "mainWelcome";
            this.mainWelcome.Size = new System.Drawing.Size(434, 129);
            this.mainWelcome.TabIndex = 1;
            this.mainWelcome.Text = "Welcome Back, Geneva";
            this.mainWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoan
            // 
            this.lblLoan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblLoan.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoan.Location = new System.Drawing.Point(6, 140);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(245, 59);
            this.lblLoan.TabIndex = 0;
            this.lblLoan.Text = "Loan";
            this.lblLoan.UseVisualStyleBackColor = false;
            this.lblLoan.Click += new System.EventHandler(this.lblLoan_Click);
            // 
            // lblTransfer
            // 
            this.lblTransfer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblTransfer.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfer.Location = new System.Drawing.Point(747, 411);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(245, 59);
            this.lblTransfer.TabIndex = 0;
            this.lblTransfer.Text = "Transfer";
            this.lblTransfer.UseVisualStyleBackColor = false;
            this.lblTransfer.Click += new System.EventHandler(this.lblTransfer_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblBalance.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(6, 474);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(245, 59);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance";
            this.lblBalance.UseVisualStyleBackColor = false;
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // lblWith
            // 
            this.lblWith.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblWith.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWith.Location = new System.Drawing.Point(747, 140);
            this.lblWith.Name = "lblWith";
            this.lblWith.Size = new System.Drawing.Size(245, 59);
            this.lblWith.TabIndex = 0;
            this.lblWith.Text = "Withdrawal";
            this.lblWith.UseVisualStyleBackColor = false;
            this.lblWith.Click += new System.EventHandler(this.lblWith_Click);
            // 
            // lblCash
            // 
            this.lblCash.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblCash.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(6, 359);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(245, 59);
            this.lblCash.TabIndex = 0;
            this.lblCash.Text = "Cash a Cheque";
            this.lblCash.UseVisualStyleBackColor = false;
            this.lblCash.Click += new System.EventHandler(this.lblCash_Click);
            // 
            // lblFast
            // 
            this.lblFast.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblFast.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFast.Location = new System.Drawing.Point(747, 324);
            this.lblFast.Name = "lblFast";
            this.lblFast.Size = new System.Drawing.Size(245, 59);
            this.lblFast.TabIndex = 0;
            this.lblFast.Text = "Fast Cash ($40)";
            this.lblFast.UseVisualStyleBackColor = false;
            this.lblFast.Click += new System.EventHandler(this.lblFast_Click);
            // 
            // lblPrint
            // 
            this.lblPrint.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPrint.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrint.Location = new System.Drawing.Point(6, 249);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(245, 59);
            this.lblPrint.TabIndex = 0;
            this.lblPrint.Text = "Print a Cheque";
            this.lblPrint.UseVisualStyleBackColor = false;
            this.lblPrint.Click += new System.EventHandler(this.lblPrint_Click);
            // 
            // lblDep
            // 
            this.lblDep.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblDep.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(747, 229);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(245, 59);
            this.lblDep.TabIndex = 0;
            this.lblDep.Text = "Deposit";
            this.lblDep.UseVisualStyleBackColor = false;
            this.lblDep.Click += new System.EventHandler(this.lblDep_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 661);
            this.Controls.Add(this.MainMenuBox1);
            this.Name = "mainMenu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenuBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox MainMenuBox1;
        private System.Windows.Forms.Button lblLoan;
        private System.Windows.Forms.Button lblTransfer;
        private System.Windows.Forms.Button lblBalance;
        private System.Windows.Forms.Button lblWith;
        private System.Windows.Forms.Button lblCash;
        private System.Windows.Forms.Button lblFast;
        private System.Windows.Forms.Button lblPrint;
        private System.Windows.Forms.Button lblDep;
        private System.Windows.Forms.Label mainWelcome;
        private System.Windows.Forms.Button mainReturnCard;
    }
}

