namespace WindowsFormsApplication1
{
    partial class start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.startBox1 = new System.Windows.Forms.GroupBox();
            this.startPressAnywhere = new System.Windows.Forms.Button();
            this.startBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBox1
            // 
            this.startBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startBox1.BackgroundImage")));
            this.startBox1.Controls.Add(this.startPressAnywhere);
            this.startBox1.Location = new System.Drawing.Point(177, 12);
            this.startBox1.Name = "startBox1";
            this.startBox1.Size = new System.Drawing.Size(998, 637);
            this.startBox1.TabIndex = 3;
            this.startBox1.TabStop = false;
            // 
            // startPressAnywhere
            // 
            this.startPressAnywhere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startPressAnywhere.BackgroundImage")));
            this.startPressAnywhere.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPressAnywhere.Location = new System.Drawing.Point(0, 0);
            this.startPressAnywhere.Name = "startPressAnywhere";
            this.startPressAnywhere.Size = new System.Drawing.Size(998, 637);
            this.startPressAnywhere.TabIndex = 0;
            this.startPressAnywhere.Text = "Welcome to XYZ Central Bank, Press Anywhere To Start";
            this.startPressAnywhere.UseVisualStyleBackColor = true;
            this.startPressAnywhere.Click += new System.EventHandler(this.startPressAnywhere_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 661);
            this.Controls.Add(this.startBox1);
            this.Name = "start";
            this.Text = "start";
            this.startBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox startBox1;
        private System.Windows.Forms.Button startPressAnywhere;
    }
}