namespace WindowsFormsApplication1
{
    partial class password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(password));
            this.passwordBox1 = new System.Windows.Forms.GroupBox();
            this.EnterPassword = new System.Windows.Forms.Label();
            this.lblPin1 = new System.Windows.Forms.Label();
            this.passwordNumpad = new System.Windows.Forms.GroupBox();
            this.passwordNum1 = new System.Windows.Forms.Button();
            this.passwordNum4 = new System.Windows.Forms.Button();
            this.passwordNum7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.passwordNum2 = new System.Windows.Forms.Button();
            this.passwordNum5 = new System.Windows.Forms.Button();
            this.passwordNum8 = new System.Windows.Forms.Button();
            this.passwordNum0 = new System.Windows.Forms.Button();
            this.passwordNum3 = new System.Windows.Forms.Button();
            this.passwordNum6 = new System.Windows.Forms.Button();
            this.passwordNum9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.passwordCancel = new System.Windows.Forms.Button();
            this.passwordClear = new System.Windows.Forms.Button();
            this.passwordEnter = new System.Windows.Forms.Button();
            this.passwordback = new System.Windows.Forms.Button();
            this.passwordBox1.SuspendLayout();
            this.passwordNumpad.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordBox1
            // 
            this.passwordBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordBox1.BackgroundImage")));
            this.passwordBox1.Controls.Add(this.passwordNumpad);
            this.passwordBox1.Controls.Add(this.lblPin1);
            this.passwordBox1.Controls.Add(this.EnterPassword);
            this.passwordBox1.Location = new System.Drawing.Point(171, 12);
            this.passwordBox1.Name = "passwordBox1";
            this.passwordBox1.Size = new System.Drawing.Size(998, 637);
            this.passwordBox1.TabIndex = 0;
            this.passwordBox1.TabStop = false;
            // 
            // EnterPassword
            // 
            this.EnterPassword.BackColor = System.Drawing.Color.White;
            this.EnterPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EnterPassword.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPassword.Location = new System.Drawing.Point(309, 169);
            this.EnterPassword.Name = "EnterPassword";
            this.EnterPassword.Size = new System.Drawing.Size(359, 55);
            this.EnterPassword.TabIndex = 1;
            this.EnterPassword.Text = "Please Enter Password";
            this.EnterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnterPassword.Click += new System.EventHandler(this.EnterPassword_Click);
            // 
            // lblPin1
            // 
            this.lblPin1.BackColor = System.Drawing.Color.White;
            this.lblPin1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPin1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin1.Location = new System.Drawing.Point(310, 249);
            this.lblPin1.Name = "lblPin1";
            this.lblPin1.Size = new System.Drawing.Size(358, 50);
            this.lblPin1.TabIndex = 2;
            this.lblPin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPin1.Click += new System.EventHandler(this.lblPin1_Click);
            // 
            // passwordNumpad
            // 
            this.passwordNumpad.BackColor = System.Drawing.Color.White;
            this.passwordNumpad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordNumpad.BackgroundImage")));
            this.passwordNumpad.Controls.Add(this.passwordback);
            this.passwordNumpad.Controls.Add(this.button11);
            this.passwordNumpad.Controls.Add(this.passwordNum0);
            this.passwordNumpad.Controls.Add(this.button3);
            this.passwordNumpad.Controls.Add(this.passwordEnter);
            this.passwordNumpad.Controls.Add(this.passwordNum9);
            this.passwordNumpad.Controls.Add(this.passwordNum8);
            this.passwordNumpad.Controls.Add(this.passwordNum7);
            this.passwordNumpad.Controls.Add(this.passwordClear);
            this.passwordNumpad.Controls.Add(this.passwordNum6);
            this.passwordNumpad.Controls.Add(this.passwordNum5);
            this.passwordNumpad.Controls.Add(this.passwordNum4);
            this.passwordNumpad.Controls.Add(this.passwordCancel);
            this.passwordNumpad.Controls.Add(this.passwordNum3);
            this.passwordNumpad.Controls.Add(this.passwordNum2);
            this.passwordNumpad.Controls.Add(this.passwordNum1);
            this.passwordNumpad.Location = new System.Drawing.Point(309, 325);
            this.passwordNumpad.Name = "passwordNumpad";
            this.passwordNumpad.Size = new System.Drawing.Size(359, 246);
            this.passwordNumpad.TabIndex = 3;
            this.passwordNumpad.TabStop = false;
            // 
            // passwordNum1
            // 
            this.passwordNum1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordNum1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNum1.Location = new System.Drawing.Point(6, 20);
            this.passwordNum1.Name = "passwordNum1";
            this.passwordNum1.Size = new System.Drawing.Size(81, 49);
            this.passwordNum1.TabIndex = 0;
            this.passwordNum1.Text = "1";
            this.passwordNum1.UseVisualStyleBackColor = false;
            this.passwordNum1.Click += new System.EventHandler(this.passwordNum1_Click);
            // 
            // passwordNum4
            // 
            this.passwordNum4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordNum4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNum4.Location = new System.Drawing.Point(6, 75);
            this.passwordNum4.Name = "passwordNum4";
            this.passwordNum4.Size = new System.Drawing.Size(81, 49);
            this.passwordNum4.TabIndex = 0;
            this.passwordNum4.Text = "4";
            this.passwordNum4.UseVisualStyleBackColor = false;
            this.passwordNum4.Click += new System.EventHandler(this.passwordNum4_Click);
            // 
            // passwordNum7
            // 
            this.passwordNum7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordNum7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNum7.Location = new System.Drawing.Point(6, 130);
            this.passwordNum7.Name = "passwordNum7";
            this.passwordNum7.Size = new System.Drawing.Size(81, 49);
            this.passwordNum7.TabIndex = 0;
            this.passwordNum7.Text = "7";
            this.passwordNum7.UseVisualStyleBackColor = false;
            this.passwordNum7.Click += new System.EventHandler(this.passwordNum7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Location = new System.Drawing.Point(6, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 49);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // passwordNum2
            // 
            this.passwordNum2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordNum2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNum2.Location = new System.Drawing.Point(93, 20);
            this.passwordNum2.Name = "passwordNum2";
            this.passwordNum2.Size = new System.Drawing.Size(81, 49);
            this.passwordNum2.TabIndex = 0;
            this.passwordNum2.Text = "2";
            this.passwordNum2.UseVisualStyleBackColor = false;
            this.passwordNum2.Click += new System.EventHandler(this.passwordNum2_Click);
            // 
            // passwordNum5
            // 
            this.passwordNum5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordNum5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNum5.Location = new System.Drawing.Point(93, 75);
            this.passwordNum5.Name = "passwordNum5";
            this.passwordNum5.Size = new System.Drawing.Size(81, 49);
            this.passwordNum5.TabIndex = 0;
            this.passwordNum5.Text = "5";
            this.passwordNum5.UseVisualStyleBackColor = false;
            this.passwordNum5.Click += new System.EventHandler(this.passwordNum5_Click);
            // 
            // passwordNum8
            // 
            this.passwordNum8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordNum8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNum8.Location = new System.Drawing.Point(93, 130);
            this.passwordNum8.Name = "passwordNum8";
            this.passwordNum8.Size = new System.Drawing.Size(81, 49);
            this.passwordNum8.TabIndex = 0;
            this.passwordNum8.Text = "8";
            this.passwordNum8.UseVisualStyleBackColor = false;
            this.passwordNum8.Click += new System.EventHandler(this.passwordNum8_Click);
            // 
            // passwordNum0
            // 
            this.passwordNum0.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordNum0.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNum0.Location = new System.Drawing.Point(93, 185);
            this.passwordNum0.Name = "passwordNum0";
            this.passwordNum0.Size = new System.Drawing.Size(81, 49);
            this.passwordNum0.TabIndex = 0;
            this.passwordNum0.Text = "0";
            this.passwordNum0.UseVisualStyleBackColor = false;
            this.passwordNum0.Click += new System.EventHandler(this.passwordNum0_Click);
            // 
            // passwordNum3
            // 
            this.passwordNum3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordNum3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNum3.Location = new System.Drawing.Point(180, 20);
            this.passwordNum3.Name = "passwordNum3";
            this.passwordNum3.Size = new System.Drawing.Size(81, 49);
            this.passwordNum3.TabIndex = 0;
            this.passwordNum3.Text = "3";
            this.passwordNum3.UseVisualStyleBackColor = false;
            this.passwordNum3.Click += new System.EventHandler(this.passwordNum3_Click);
            // 
            // passwordNum6
            // 
            this.passwordNum6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordNum6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNum6.Location = new System.Drawing.Point(180, 75);
            this.passwordNum6.Name = "passwordNum6";
            this.passwordNum6.Size = new System.Drawing.Size(81, 49);
            this.passwordNum6.TabIndex = 0;
            this.passwordNum6.Text = "6";
            this.passwordNum6.UseVisualStyleBackColor = false;
            this.passwordNum6.Click += new System.EventHandler(this.passwordNum6_Click);
            // 
            // passwordNum9
            // 
            this.passwordNum9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordNum9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNum9.Location = new System.Drawing.Point(180, 130);
            this.passwordNum9.Name = "passwordNum9";
            this.passwordNum9.Size = new System.Drawing.Size(81, 49);
            this.passwordNum9.TabIndex = 0;
            this.passwordNum9.Text = "9";
            this.passwordNum9.UseVisualStyleBackColor = false;
            this.passwordNum9.Click += new System.EventHandler(this.passwordNum9_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button11.Location = new System.Drawing.Point(180, 185);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(81, 49);
            this.button11.TabIndex = 0;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // passwordCancel
            // 
            this.passwordCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordCancel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCancel.Location = new System.Drawing.Point(267, 20);
            this.passwordCancel.Name = "passwordCancel";
            this.passwordCancel.Size = new System.Drawing.Size(81, 49);
            this.passwordCancel.TabIndex = 0;
            this.passwordCancel.Text = "Cancel";
            this.passwordCancel.UseVisualStyleBackColor = false;
            this.passwordCancel.Click += new System.EventHandler(this.passwordCancel_Click);
            // 
            // passwordClear
            // 
            this.passwordClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordClear.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordClear.Location = new System.Drawing.Point(267, 75);
            this.passwordClear.Name = "passwordClear";
            this.passwordClear.Size = new System.Drawing.Size(81, 49);
            this.passwordClear.TabIndex = 0;
            this.passwordClear.Text = "Clear";
            this.passwordClear.UseVisualStyleBackColor = false;
            this.passwordClear.Click += new System.EventHandler(this.passwordClear_Click);
            // 
            // passwordEnter
            // 
            this.passwordEnter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordEnter.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordEnter.Location = new System.Drawing.Point(267, 130);
            this.passwordEnter.Name = "passwordEnter";
            this.passwordEnter.Size = new System.Drawing.Size(81, 49);
            this.passwordEnter.TabIndex = 0;
            this.passwordEnter.Text = "Enter";
            this.passwordEnter.UseVisualStyleBackColor = false;
            this.passwordEnter.Click += new System.EventHandler(this.passwordEnter_Click);
            // 
            // passwordback
            // 
            this.passwordback.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordback.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordback.Location = new System.Drawing.Point(267, 185);
            this.passwordback.Name = "passwordback";
            this.passwordback.Size = new System.Drawing.Size(81, 49);
            this.passwordback.TabIndex = 0;
            this.passwordback.Text = "Backspace";
            this.passwordback.UseVisualStyleBackColor = false;
            this.passwordback.Click += new System.EventHandler(this.passwordback_Click);
            // 
            // password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 661);
            this.Controls.Add(this.passwordBox1);
            this.Name = "password";
            this.Text = "password";
            this.passwordBox1.ResumeLayout(false);
            this.passwordNumpad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox passwordBox1;
        private System.Windows.Forms.Label EnterPassword;
        private System.Windows.Forms.Label lblPin1;
        private System.Windows.Forms.GroupBox passwordNumpad;
        private System.Windows.Forms.Button passwordNum1;
        private System.Windows.Forms.Button passwordback;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button passwordNum0;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button passwordEnter;
        private System.Windows.Forms.Button passwordNum9;
        private System.Windows.Forms.Button passwordNum8;
        private System.Windows.Forms.Button passwordNum7;
        private System.Windows.Forms.Button passwordClear;
        private System.Windows.Forms.Button passwordNum6;
        private System.Windows.Forms.Button passwordNum5;
        private System.Windows.Forms.Button passwordNum4;
        private System.Windows.Forms.Button passwordCancel;
        private System.Windows.Forms.Button passwordNum3;
        private System.Windows.Forms.Button passwordNum2;
    }
}