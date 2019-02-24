namespace WindowsFormsApplication1
{
    partial class cardNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardNumber));
            this.CardNumBox1 = new System.Windows.Forms.GroupBox();
            this.cardNumpad = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.cardNum1 = new System.Windows.Forms.Button();
            this.cardNum7 = new System.Windows.Forms.Button();
            this.cardNum4 = new System.Windows.Forms.Button();
            this.cardBack = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.cardNum0 = new System.Windows.Forms.Button();
            this.cardCancel = new System.Windows.Forms.Button();
            this.cardClear = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.cardNum9 = new System.Windows.Forms.Button();
            this.cardNum8 = new System.Windows.Forms.Button();
            this.cardNum6 = new System.Windows.Forms.Button();
            this.cardNum3 = new System.Windows.Forms.Button();
            this.cardNum5 = new System.Windows.Forms.Button();
            this.cardNum2 = new System.Windows.Forms.Button();
            this.EnterCard = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.CardNumBox1.SuspendLayout();
            this.cardNumpad.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardNumBox1
            // 
            this.CardNumBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CardNumBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CardNumBox1.BackgroundImage")));
            this.CardNumBox1.Controls.Add(this.cardNumpad);
            this.CardNumBox1.Controls.Add(this.EnterCard);
            this.CardNumBox1.Controls.Add(this.lblPin);
            this.CardNumBox1.Location = new System.Drawing.Point(171, 12);
            this.CardNumBox1.Name = "CardNumBox1";
            this.CardNumBox1.Size = new System.Drawing.Size(998, 637);
            this.CardNumBox1.TabIndex = 0;
            this.CardNumBox1.TabStop = false;
            this.CardNumBox1.Enter += new System.EventHandler(this.cardNumBox1_Enter);
            // 
            // cardNumpad
            // 
            this.cardNumpad.BackColor = System.Drawing.Color.White;
            this.cardNumpad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardNumpad.BackgroundImage")));
            this.cardNumpad.Controls.Add(this.button5);
            this.cardNumpad.Controls.Add(this.cardNum1);
            this.cardNumpad.Controls.Add(this.cardNum7);
            this.cardNumpad.Controls.Add(this.cardNum4);
            this.cardNumpad.Controls.Add(this.cardBack);
            this.cardNumpad.Controls.Add(this.button11);
            this.cardNumpad.Controls.Add(this.cardNum0);
            this.cardNumpad.Controls.Add(this.cardCancel);
            this.cardNumpad.Controls.Add(this.cardClear);
            this.cardNumpad.Controls.Add(this.btnPassword);
            this.cardNumpad.Controls.Add(this.cardNum9);
            this.cardNumpad.Controls.Add(this.cardNum8);
            this.cardNumpad.Controls.Add(this.cardNum6);
            this.cardNumpad.Controls.Add(this.cardNum3);
            this.cardNumpad.Controls.Add(this.cardNum5);
            this.cardNumpad.Controls.Add(this.cardNum2);
            this.cardNumpad.Location = new System.Drawing.Point(309, 325);
            this.cardNumpad.Name = "cardNumpad";
            this.cardNumpad.Size = new System.Drawing.Size(359, 246);
            this.cardNumpad.TabIndex = 1;
            this.cardNumpad.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(6, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 49);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cardNum1
            // 
            this.cardNum1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cardNum1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNum1.Location = new System.Drawing.Point(6, 20);
            this.cardNum1.Name = "cardNum1";
            this.cardNum1.Size = new System.Drawing.Size(81, 49);
            this.cardNum1.TabIndex = 0;
            this.cardNum1.Text = "1";
            this.cardNum1.UseVisualStyleBackColor = false;
            this.cardNum1.Click += new System.EventHandler(this.cardNum1_Click);
            // 
            // cardNum7
            // 
            this.cardNum7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cardNum7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNum7.Location = new System.Drawing.Point(6, 130);
            this.cardNum7.Name = "cardNum7";
            this.cardNum7.Size = new System.Drawing.Size(81, 49);
            this.cardNum7.TabIndex = 0;
            this.cardNum7.Text = "7";
            this.cardNum7.UseVisualStyleBackColor = false;
            this.cardNum7.Click += new System.EventHandler(this.cardNum7_Click);
            // 
            // cardNum4
            // 
            this.cardNum4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cardNum4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNum4.Location = new System.Drawing.Point(6, 75);
            this.cardNum4.Name = "cardNum4";
            this.cardNum4.Size = new System.Drawing.Size(81, 49);
            this.cardNum4.TabIndex = 0;
            this.cardNum4.Text = "4";
            this.cardNum4.UseVisualStyleBackColor = false;
            this.cardNum4.Click += new System.EventHandler(this.cardNum4_Click);
            // 
            // cardBack
            // 
            this.cardBack.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cardBack.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardBack.Location = new System.Drawing.Point(267, 185);
            this.cardBack.Name = "cardBack";
            this.cardBack.Size = new System.Drawing.Size(81, 49);
            this.cardBack.TabIndex = 0;
            this.cardBack.Text = "Backspace";
            this.cardBack.UseVisualStyleBackColor = false;
            this.cardBack.Click += new System.EventHandler(this.cardBack_Click);
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
            // cardNum0
            // 
            this.cardNum0.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cardNum0.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNum0.Location = new System.Drawing.Point(93, 185);
            this.cardNum0.Name = "cardNum0";
            this.cardNum0.Size = new System.Drawing.Size(81, 49);
            this.cardNum0.TabIndex = 0;
            this.cardNum0.Text = "0";
            this.cardNum0.UseVisualStyleBackColor = false;
            this.cardNum0.Click += new System.EventHandler(this.cardNum0_Click);
            // 
            // cardCancel
            // 
            this.cardCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cardCancel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardCancel.Location = new System.Drawing.Point(267, 20);
            this.cardCancel.Name = "cardCancel";
            this.cardCancel.Size = new System.Drawing.Size(81, 49);
            this.cardCancel.TabIndex = 0;
            this.cardCancel.Text = "Cancel";
            this.cardCancel.UseVisualStyleBackColor = false;
            this.cardCancel.Click += new System.EventHandler(this.cardCancel_Click);
            // 
            // cardClear
            // 
            this.cardClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cardClear.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardClear.Location = new System.Drawing.Point(267, 75);
            this.cardClear.Name = "cardClear";
            this.cardClear.Size = new System.Drawing.Size(81, 49);
            this.cardClear.TabIndex = 0;
            this.cardClear.Text = "Clear";
            this.cardClear.UseVisualStyleBackColor = false;
            this.cardClear.Click += new System.EventHandler(this.cardClear_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPassword.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassword.Location = new System.Drawing.Point(267, 130);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(81, 49);
            this.btnPassword.TabIndex = 0;
            this.btnPassword.Text = "Enter";
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // cardNum9
            // 
            this.cardNum9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cardNum9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNum9.Location = new System.Drawing.Point(180, 130);
            this.cardNum9.Name = "cardNum9";
            this.cardNum9.Size = new System.Drawing.Size(81, 49);
            this.cardNum9.TabIndex = 0;
            this.cardNum9.Text = "9";
            this.cardNum9.UseVisualStyleBackColor = false;
            this.cardNum9.Click += new System.EventHandler(this.cardNum9_Click);
            // 
            // cardNum8
            // 
            this.cardNum8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cardNum8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNum8.Location = new System.Drawing.Point(93, 130);
            this.cardNum8.Name = "cardNum8";
            this.cardNum8.Size = new System.Drawing.Size(81, 49);
            this.cardNum8.TabIndex = 0;
            this.cardNum8.Text = "8";
            this.cardNum8.UseVisualStyleBackColor = false;
            this.cardNum8.Click += new System.EventHandler(this.cardNum8_Click);
            // 
            // cardNum6
            // 
            this.cardNum6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cardNum6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNum6.Location = new System.Drawing.Point(180, 75);
            this.cardNum6.Name = "cardNum6";
            this.cardNum6.Size = new System.Drawing.Size(81, 49);
            this.cardNum6.TabIndex = 0;
            this.cardNum6.Text = "6";
            this.cardNum6.UseVisualStyleBackColor = false;
            this.cardNum6.Click += new System.EventHandler(this.cardNum6_Click);
            // 
            // cardNum3
            // 
            this.cardNum3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cardNum3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNum3.Location = new System.Drawing.Point(180, 20);
            this.cardNum3.Name = "cardNum3";
            this.cardNum3.Size = new System.Drawing.Size(81, 49);
            this.cardNum3.TabIndex = 0;
            this.cardNum3.Text = "3";
            this.cardNum3.UseVisualStyleBackColor = false;
            this.cardNum3.Click += new System.EventHandler(this.cardNum3_Click);
            // 
            // cardNum5
            // 
            this.cardNum5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cardNum5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNum5.Location = new System.Drawing.Point(93, 75);
            this.cardNum5.Name = "cardNum5";
            this.cardNum5.Size = new System.Drawing.Size(81, 49);
            this.cardNum5.TabIndex = 0;
            this.cardNum5.Text = "5";
            this.cardNum5.UseVisualStyleBackColor = false;
            this.cardNum5.Click += new System.EventHandler(this.cardNum5_Click);
            // 
            // cardNum2
            // 
            this.cardNum2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cardNum2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNum2.Location = new System.Drawing.Point(93, 20);
            this.cardNum2.Name = "cardNum2";
            this.cardNum2.Size = new System.Drawing.Size(81, 49);
            this.cardNum2.TabIndex = 0;
            this.cardNum2.Text = "2";
            this.cardNum2.UseVisualStyleBackColor = false;
            this.cardNum2.Click += new System.EventHandler(this.cardNum2_Click);
            // 
            // EnterCard
            // 
            this.EnterCard.BackColor = System.Drawing.Color.White;
            this.EnterCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EnterCard.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCard.Location = new System.Drawing.Point(294, 170);
            this.EnterCard.Name = "EnterCard";
            this.EnterCard.Size = new System.Drawing.Size(391, 55);
            this.EnterCard.TabIndex = 1;
            this.EnterCard.Text = "Please Enter Card Number";
            this.EnterCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnterCard.Click += new System.EventHandler(this.EnterCard_Click);
            // 
            // lblPin
            // 
            this.lblPin.BackColor = System.Drawing.Color.White;
            this.lblPin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPin.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(310, 249);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(358, 50);
            this.lblPin.TabIndex = 0;
            this.lblPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPin.Click += new System.EventHandler(this.lblPin_Click);
            // 
            // cardNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 661);
            this.Controls.Add(this.CardNumBox1);
            this.Name = "cardNumber";
            this.Text = "Form1";
            this.CardNumBox1.ResumeLayout(false);
            this.cardNumpad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CardNumBox1;
        private System.Windows.Forms.GroupBox cardNumpad;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button cardNum7;
        private System.Windows.Forms.Button cardNum4;
        private System.Windows.Forms.Button cardBack;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button cardNum0;
        private System.Windows.Forms.Button cardCancel;
        private System.Windows.Forms.Button cardClear;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button cardNum9;
        private System.Windows.Forms.Button cardNum8;
        private System.Windows.Forms.Button cardNum6;
        private System.Windows.Forms.Button cardNum3;
        private System.Windows.Forms.Button cardNum5;
        private System.Windows.Forms.Button cardNum2;
        private System.Windows.Forms.Button cardNum1;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label EnterCard;
    }
}