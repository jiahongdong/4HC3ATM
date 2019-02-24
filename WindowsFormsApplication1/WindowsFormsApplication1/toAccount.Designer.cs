namespace WindowsFormsApplication1
{
    partial class toAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(toAccount));
            this.quickCashBox1 = new System.Windows.Forms.GroupBox();
            this.toSaving = new System.Windows.Forms.Button();
            this.toChecking = new System.Windows.Forms.Button();
            this.quickCashBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quickCashBox1
            // 
            this.quickCashBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quickCashBox1.BackgroundImage")));
            this.quickCashBox1.Controls.Add(this.toChecking);
            this.quickCashBox1.Controls.Add(this.toSaving);
            this.quickCashBox1.Location = new System.Drawing.Point(177, 12);
            this.quickCashBox1.Name = "quickCashBox1";
            this.quickCashBox1.Size = new System.Drawing.Size(998, 637);
            this.quickCashBox1.TabIndex = 1;
            this.quickCashBox1.TabStop = false;
            this.quickCashBox1.Enter += new System.EventHandler(this.quickCashBox1_Enter);
            // 
            // toSaving
            // 
            this.toSaving.BackColor = System.Drawing.Color.Transparent;
            this.toSaving.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSaving.Location = new System.Drawing.Point(6, 435);
            this.toSaving.Name = "toSaving";
            this.toSaving.Size = new System.Drawing.Size(208, 70);
            this.toSaving.TabIndex = 1;
            this.toSaving.Text = "To Saving Account";
            this.toSaving.UseVisualStyleBackColor = false;
            this.toSaving.Click += new System.EventHandler(this.toSaving_Click);
            // 
            // toChecking
            // 
            this.toChecking.BackColor = System.Drawing.Color.Transparent;
            this.toChecking.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toChecking.Location = new System.Drawing.Point(784, 435);
            this.toChecking.Name = "toChecking";
            this.toChecking.Size = new System.Drawing.Size(208, 70);
            this.toChecking.TabIndex = 1;
            this.toChecking.Text = "To Chequing Account";
            this.toChecking.UseVisualStyleBackColor = false;
            this.toChecking.Click += new System.EventHandler(this.toChecking_Click);
            // 
            // toAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 661);
            this.Controls.Add(this.quickCashBox1);
            this.Name = "toAccount";
            this.Text = "toAccount";
            this.quickCashBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox quickCashBox1;
        private System.Windows.Forms.Button toSaving;
        private System.Windows.Forms.Button toChecking;
    }
}