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
            this.planner1 = new WindowsFormsApplication1.Planner();
            this.withheldCalc1 = new WindowsFormsApplication1.withheldCalc();
            this.calculator1 = new WindowsFormsApplication1.Calculator();
            this.userControl11 = new WindowsFormsApplication1.UserControl1();
            this.register1 = new WindowsFormsApplication1.Register();
            this.home1 = new WindowsFormsApplication1.Home();
            this.SuspendLayout();
            // 
            // planner1
            // 
            this.planner1.Location = new System.Drawing.Point(-2, -3);
            this.planner1.Name = "planner1";
            this.planner1.Size = new System.Drawing.Size(942, 538);
            this.planner1.TabIndex = 5;
            this.planner1.Visible = false;
            // 
            // withheldCalc1
            // 
            this.withheldCalc1.Location = new System.Drawing.Point(-2, -3);
            this.withheldCalc1.Name = "withheldCalc1";
            this.withheldCalc1.Size = new System.Drawing.Size(942, 538);
            this.withheldCalc1.TabIndex = 4;
            this.withheldCalc1.Visible = false;
            // 
            // calculator1
            // 
            this.calculator1.Location = new System.Drawing.Point(-12, -9);
            this.calculator1.Name = "calculator1";
            this.calculator1.Size = new System.Drawing.Size(942, 538);
            this.calculator1.TabIndex = 3;
            this.calculator1.Visible = false;
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
            this.Controls.Add(this.planner1);
            this.Controls.Add(this.withheldCalc1);
            this.Controls.Add(this.calculator1);
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
        internal Calculator calculator1;
        internal withheldCalc withheldCalc1;
        internal Planner planner1;
    }
}

