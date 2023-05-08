namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.userControl11 = new WindowsFormsApplication1.UserControl1();
            this.register1 = new WindowsFormsApplication1.Register();
            this.home1 = new WindowsFormsApplication1.Home();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.AccessibleName = "";
            this.userControl11.Location = new System.Drawing.Point(-12, -3);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(942, 538);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // register1
            // 
            this.register1.AccessibleName = "";
            this.register1.Location = new System.Drawing.Point(-12, -3);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(942, 538);
            this.register1.TabIndex = 1;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(-12, -3);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(942, 538);
            this.home1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 500);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.home1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        internal Register register1;
        internal UserControl1 userControl11;
        internal Home home1;
    }
}

