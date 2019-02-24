namespace WindowsFormsApplication1
{
    partial class deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deposit));
            this.depositBox1 = new System.Windows.Forms.GroupBox();
            this.depoNumpad = new System.Windows.Forms.GroupBox();
            this.depoBack = new System.Windows.Forms.Button();
            this.depoM2 = new System.Windows.Forms.Button();
            this.depoNum0 = new System.Windows.Forms.Button();
            this.depoM1 = new System.Windows.Forms.Button();
            this.depoEnter = new System.Windows.Forms.Button();
            this.depoNum9 = new System.Windows.Forms.Button();
            this.depoNum8 = new System.Windows.Forms.Button();
            this.depoNum7 = new System.Windows.Forms.Button();
            this.depoClear = new System.Windows.Forms.Button();
            this.depoNum6 = new System.Windows.Forms.Button();
            this.depoNum5 = new System.Windows.Forms.Button();
            this.depoNum4 = new System.Windows.Forms.Button();
            this.depoCancel = new System.Windows.Forms.Button();
            this.depoNum3 = new System.Windows.Forms.Button();
            this.depoNum2 = new System.Windows.Forms.Button();
            this.depoNum1 = new System.Windows.Forms.Button();
            this.lblPin3 = new System.Windows.Forms.Label();
            this.EnterAmountDepo = new System.Windows.Forms.Label();
            this.depositBox1.SuspendLayout();
            this.depoNumpad.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositBox1
            // 
            this.depositBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("depositBox1.BackgroundImage")));
            this.depositBox1.Controls.Add(this.depoNumpad);
            this.depositBox1.Controls.Add(this.lblPin3);
            this.depositBox1.Controls.Add(this.EnterAmountDepo);
            this.depositBox1.Location = new System.Drawing.Point(177, 12);
            this.depositBox1.Name = "depositBox1";
            this.depositBox1.Size = new System.Drawing.Size(998, 637);
            this.depositBox1.TabIndex = 1;
            this.depositBox1.TabStop = false;
            // 
            // depoNumpad
            // 
            this.depoNumpad.BackColor = System.Drawing.Color.White;
            this.depoNumpad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("depoNumpad.BackgroundImage")));
            this.depoNumpad.Controls.Add(this.depoBack);
            this.depoNumpad.Controls.Add(this.depoM2);
            this.depoNumpad.Controls.Add(this.depoNum0);
            this.depoNumpad.Controls.Add(this.depoM1);
            this.depoNumpad.Controls.Add(this.depoEnter);
            this.depoNumpad.Controls.Add(this.depoNum9);
            this.depoNumpad.Controls.Add(this.depoNum8);
            this.depoNumpad.Controls.Add(this.depoNum7);
            this.depoNumpad.Controls.Add(this.depoClear);
            this.depoNumpad.Controls.Add(this.depoNum6);
            this.depoNumpad.Controls.Add(this.depoNum5);
            this.depoNumpad.Controls.Add(this.depoNum4);
            this.depoNumpad.Controls.Add(this.depoCancel);
            this.depoNumpad.Controls.Add(this.depoNum3);
            this.depoNumpad.Controls.Add(this.depoNum2);
            this.depoNumpad.Controls.Add(this.depoNum1);
            this.depoNumpad.Location = new System.Drawing.Point(328, 283);
            this.depoNumpad.Name = "depoNumpad";
            this.depoNumpad.Size = new System.Drawing.Size(359, 246);
            this.depoNumpad.TabIndex = 8;
            this.depoNumpad.TabStop = false;
            // 
            // depoBack
            // 
            this.depoBack.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoBack.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoBack.Location = new System.Drawing.Point(267, 185);
            this.depoBack.Name = "depoBack";
            this.depoBack.Size = new System.Drawing.Size(81, 49);
            this.depoBack.TabIndex = 0;
            this.depoBack.Text = "Backspace";
            this.depoBack.UseVisualStyleBackColor = false;
            this.depoBack.Click += new System.EventHandler(this.depoBack_Click);
            // 
            // depoM2
            // 
            this.depoM2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoM2.Location = new System.Drawing.Point(180, 185);
            this.depoM2.Name = "depoM2";
            this.depoM2.Size = new System.Drawing.Size(81, 49);
            this.depoM2.TabIndex = 0;
            this.depoM2.UseVisualStyleBackColor = false;
            // 
            // depoNum0
            // 
            this.depoNum0.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoNum0.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoNum0.Location = new System.Drawing.Point(93, 185);
            this.depoNum0.Name = "depoNum0";
            this.depoNum0.Size = new System.Drawing.Size(81, 49);
            this.depoNum0.TabIndex = 0;
            this.depoNum0.Text = "0";
            this.depoNum0.UseVisualStyleBackColor = false;
            this.depoNum0.Click += new System.EventHandler(this.depoNum0_Click);
            // 
            // depoM1
            // 
            this.depoM1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoM1.Location = new System.Drawing.Point(6, 185);
            this.depoM1.Name = "depoM1";
            this.depoM1.Size = new System.Drawing.Size(81, 49);
            this.depoM1.TabIndex = 0;
            this.depoM1.UseVisualStyleBackColor = false;
            // 
            // depoEnter
            // 
            this.depoEnter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoEnter.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoEnter.Location = new System.Drawing.Point(267, 130);
            this.depoEnter.Name = "depoEnter";
            this.depoEnter.Size = new System.Drawing.Size(81, 49);
            this.depoEnter.TabIndex = 0;
            this.depoEnter.Text = "Enter";
            this.depoEnter.UseVisualStyleBackColor = false;
            this.depoEnter.Click += new System.EventHandler(this.depoEnter_Click);
            // 
            // depoNum9
            // 
            this.depoNum9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoNum9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoNum9.Location = new System.Drawing.Point(180, 130);
            this.depoNum9.Name = "depoNum9";
            this.depoNum9.Size = new System.Drawing.Size(81, 49);
            this.depoNum9.TabIndex = 0;
            this.depoNum9.Text = "9";
            this.depoNum9.UseVisualStyleBackColor = false;
            this.depoNum9.Click += new System.EventHandler(this.depoNum9_Click);
            // 
            // depoNum8
            // 
            this.depoNum8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoNum8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoNum8.Location = new System.Drawing.Point(93, 130);
            this.depoNum8.Name = "depoNum8";
            this.depoNum8.Size = new System.Drawing.Size(81, 49);
            this.depoNum8.TabIndex = 0;
            this.depoNum8.Text = "8";
            this.depoNum8.UseVisualStyleBackColor = false;
            this.depoNum8.Click += new System.EventHandler(this.depoNum8_Click);
            // 
            // depoNum7
            // 
            this.depoNum7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoNum7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoNum7.Location = new System.Drawing.Point(6, 130);
            this.depoNum7.Name = "depoNum7";
            this.depoNum7.Size = new System.Drawing.Size(81, 49);
            this.depoNum7.TabIndex = 0;
            this.depoNum7.Text = "7";
            this.depoNum7.UseVisualStyleBackColor = false;
            this.depoNum7.Click += new System.EventHandler(this.depoNum7_Click);
            // 
            // depoClear
            // 
            this.depoClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoClear.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoClear.Location = new System.Drawing.Point(267, 75);
            this.depoClear.Name = "depoClear";
            this.depoClear.Size = new System.Drawing.Size(81, 49);
            this.depoClear.TabIndex = 0;
            this.depoClear.Text = "Clear";
            this.depoClear.UseVisualStyleBackColor = false;
            this.depoClear.Click += new System.EventHandler(this.depoClear_Click);
            // 
            // depoNum6
            // 
            this.depoNum6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoNum6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoNum6.Location = new System.Drawing.Point(180, 75);
            this.depoNum6.Name = "depoNum6";
            this.depoNum6.Size = new System.Drawing.Size(81, 49);
            this.depoNum6.TabIndex = 0;
            this.depoNum6.Text = "6";
            this.depoNum6.UseVisualStyleBackColor = false;
            this.depoNum6.Click += new System.EventHandler(this.depoNum6_Click);
            // 
            // depoNum5
            // 
            this.depoNum5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoNum5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoNum5.Location = new System.Drawing.Point(93, 75);
            this.depoNum5.Name = "depoNum5";
            this.depoNum5.Size = new System.Drawing.Size(81, 49);
            this.depoNum5.TabIndex = 0;
            this.depoNum5.Text = "5";
            this.depoNum5.UseVisualStyleBackColor = false;
            this.depoNum5.Click += new System.EventHandler(this.depoNum5_Click);
            // 
            // depoNum4
            // 
            this.depoNum4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoNum4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoNum4.Location = new System.Drawing.Point(6, 75);
            this.depoNum4.Name = "depoNum4";
            this.depoNum4.Size = new System.Drawing.Size(81, 49);
            this.depoNum4.TabIndex = 0;
            this.depoNum4.Text = "4";
            this.depoNum4.UseVisualStyleBackColor = false;
            this.depoNum4.Click += new System.EventHandler(this.depoNum4_Click);
            // 
            // depoCancel
            // 
            this.depoCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoCancel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoCancel.Location = new System.Drawing.Point(267, 20);
            this.depoCancel.Name = "depoCancel";
            this.depoCancel.Size = new System.Drawing.Size(81, 49);
            this.depoCancel.TabIndex = 0;
            this.depoCancel.Text = "Cancel";
            this.depoCancel.UseVisualStyleBackColor = false;
            this.depoCancel.Click += new System.EventHandler(this.depoCancel_Click);
            // 
            // depoNum3
            // 
            this.depoNum3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoNum3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoNum3.Location = new System.Drawing.Point(180, 20);
            this.depoNum3.Name = "depoNum3";
            this.depoNum3.Size = new System.Drawing.Size(81, 49);
            this.depoNum3.TabIndex = 0;
            this.depoNum3.Text = "3";
            this.depoNum3.UseVisualStyleBackColor = false;
            this.depoNum3.Click += new System.EventHandler(this.depoNum3_Click);
            // 
            // depoNum2
            // 
            this.depoNum2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoNum2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoNum2.Location = new System.Drawing.Point(93, 20);
            this.depoNum2.Name = "depoNum2";
            this.depoNum2.Size = new System.Drawing.Size(81, 49);
            this.depoNum2.TabIndex = 0;
            this.depoNum2.Text = "2";
            this.depoNum2.UseVisualStyleBackColor = false;
            this.depoNum2.Click += new System.EventHandler(this.depoNum2_Click);
            // 
            // depoNum1
            // 
            this.depoNum1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.depoNum1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoNum1.Location = new System.Drawing.Point(6, 20);
            this.depoNum1.Name = "depoNum1";
            this.depoNum1.Size = new System.Drawing.Size(81, 49);
            this.depoNum1.TabIndex = 0;
            this.depoNum1.Text = "1";
            this.depoNum1.UseVisualStyleBackColor = false;
            this.depoNum1.Click += new System.EventHandler(this.depoNum1_Click);
            // 
            // lblPin3
            // 
            this.lblPin3.BackColor = System.Drawing.Color.White;
            this.lblPin3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPin3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin3.Location = new System.Drawing.Point(329, 204);
            this.lblPin3.Name = "lblPin3";
            this.lblPin3.Size = new System.Drawing.Size(358, 50);
            this.lblPin3.TabIndex = 7;
            this.lblPin3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPin3.Click += new System.EventHandler(this.lblPin3_Click);
            // 
            // EnterAmountDepo
            // 
            this.EnterAmountDepo.BackColor = System.Drawing.Color.White;
            this.EnterAmountDepo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EnterAmountDepo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterAmountDepo.Location = new System.Drawing.Point(329, 113);
            this.EnterAmountDepo.Name = "EnterAmountDepo";
            this.EnterAmountDepo.Size = new System.Drawing.Size(359, 55);
            this.EnterAmountDepo.TabIndex = 6;
            this.EnterAmountDepo.Text = "Please Enter Amount";
            this.EnterAmountDepo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnterAmountDepo.Click += new System.EventHandler(this.EnterAmountDepo_Click);
            // 
            // deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 661);
            this.Controls.Add(this.depositBox1);
            this.Name = "deposit";
            this.Text = "deposit";
            this.depositBox1.ResumeLayout(false);
            this.depoNumpad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox depositBox1;
        private System.Windows.Forms.Label EnterAmountDepo;
        private System.Windows.Forms.Label lblPin3;
        private System.Windows.Forms.GroupBox depoNumpad;
        private System.Windows.Forms.Button depoBack;
        private System.Windows.Forms.Button depoM2;
        private System.Windows.Forms.Button depoNum0;
        private System.Windows.Forms.Button depoM1;
        private System.Windows.Forms.Button depoEnter;
        private System.Windows.Forms.Button depoNum9;
        private System.Windows.Forms.Button depoNum8;
        private System.Windows.Forms.Button depoNum7;
        private System.Windows.Forms.Button depoClear;
        private System.Windows.Forms.Button depoNum6;
        private System.Windows.Forms.Button depoNum5;
        private System.Windows.Forms.Button depoNum4;
        private System.Windows.Forms.Button depoCancel;
        private System.Windows.Forms.Button depoNum3;
        private System.Windows.Forms.Button depoNum2;
        private System.Windows.Forms.Button depoNum1;
    }
}