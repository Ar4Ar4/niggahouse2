namespace WindowsFormsApplication1
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usercon = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.planBtn = new System.Windows.Forms.Button();
            this.TaxCalBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.conpan = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.LinkLabel();
            this.settings = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.conpan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(942, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.usercon);
            this.panel1.Location = new System.Drawing.Point(166, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 53);
            this.panel1.TabIndex = 1;
            // 
            // usercon
            // 
            this.usercon.AutoSize = true;
            this.usercon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usercon.LinkColor = System.Drawing.Color.White;
            this.usercon.Location = new System.Drawing.Point(652, 21);
            this.usercon.Name = "usercon";
            this.usercon.Size = new System.Drawing.Size(103, 16);
            this.usercon.TabIndex = 0;
            this.usercon.TabStop = true;
            this.usercon.Text = "Welcome, User!";
            this.usercon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.usercon_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 53);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "PERTISE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "TAX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "PERTISE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(343, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 55);
            this.label4.TabIndex = 6;
            this.label4.Text = "TAX";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(230, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 227);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // planBtn
            // 
            this.planBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.planBtn.Location = new System.Drawing.Point(616, 187);
            this.planBtn.Name = "planBtn";
            this.planBtn.Size = new System.Drawing.Size(115, 37);
            this.planBtn.TabIndex = 9;
            this.planBtn.Text = "TAX PLANNER";
            this.planBtn.UseVisualStyleBackColor = false;
            this.planBtn.Click += new System.EventHandler(this.planBtn_Click);
            // 
            // TaxCalBtn
            // 
            this.TaxCalBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TaxCalBtn.Location = new System.Drawing.Point(616, 255);
            this.TaxCalBtn.Name = "TaxCalBtn";
            this.TaxCalBtn.Size = new System.Drawing.Size(115, 37);
            this.TaxCalBtn.TabIndex = 10;
            this.TaxCalBtn.Text = "TAX\r\nCALCULATION";
            this.TaxCalBtn.UseVisualStyleBackColor = false;
            this.TaxCalBtn.Click += new System.EventHandler(this.TaxCalBtn_Click);
            // 
            // conpan
            // 
            this.conpan.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.conpan.Controls.Add(this.logout);
            this.conpan.Controls.Add(this.settings);
            this.conpan.Location = new System.Drawing.Point(794, 37);
            this.conpan.Name = "conpan";
            this.conpan.Size = new System.Drawing.Size(145, 125);
            this.conpan.TabIndex = 12;
            this.conpan.Visible = false;
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.LinkColor = System.Drawing.Color.Black;
            this.logout.Location = new System.Drawing.Point(48, 60);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(48, 16);
            this.logout.TabIndex = 1;
            this.logout.TabStop = true;
            this.logout.Text = "Logout";
            this.logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_LinkClicked);
            // 
            // settings
            // 
            this.settings.AutoSize = true;
            this.settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.LinkColor = System.Drawing.Color.Black;
            this.settings.Location = new System.Drawing.Point(48, 28);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(55, 16);
            this.settings.TabIndex = 0;
            this.settings.TabStop = true;
            this.settings.Text = "Settings";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.conpan);
            this.Controls.Add(this.TaxCalBtn);
            this.Controls.Add(this.planBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(942, 538);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.conpan.ResumeLayout(false);
            this.conpan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel usercon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button planBtn;
        private System.Windows.Forms.Button TaxCalBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel conpan;
        private System.Windows.Forms.LinkLabel logout;
        private System.Windows.Forms.LinkLabel settings;
    }
}
