namespace egyetemMan
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.pnl_login_fejlec = new System.Windows.Forms.Panel();
            this.lbl_login_cim = new System.Windows.Forms.Label();
            this.pnl_login_fo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_jelszo = new System.Windows.Forms.TextBox();
            this.lbl_jelszo = new System.Windows.Forms.Label();
            this.txt_nkod = new System.Windows.Forms.TextBox();
            this.lbl_nkod = new System.Windows.Forms.Label();
            this.lbl_login_be = new System.Windows.Forms.Label();
            this.btn_uj_felh = new System.Windows.Forms.Button();
            this.btn_login_kilep = new System.Windows.Forms.Button();
            this.pnl_login_fejlec.SuspendLayout();
            this.pnl_login_fo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_login_fejlec
            // 
            this.pnl_login_fejlec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(202)))));
            this.pnl_login_fejlec.Controls.Add(this.btn_login_kilep);
            this.pnl_login_fejlec.Controls.Add(this.lbl_login_cim);
            this.pnl_login_fejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_login_fejlec.Location = new System.Drawing.Point(0, 0);
            this.pnl_login_fejlec.Name = "pnl_login_fejlec";
            this.pnl_login_fejlec.Size = new System.Drawing.Size(314, 69);
            this.pnl_login_fejlec.TabIndex = 0;
            // 
            // lbl_login_cim
            // 
            this.lbl_login_cim.AutoSize = true;
            this.lbl_login_cim.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_login_cim.Location = new System.Drawing.Point(30, 29);
            this.lbl_login_cim.Name = "lbl_login_cim";
            this.lbl_login_cim.Size = new System.Drawing.Size(250, 28);
            this.lbl_login_cim.TabIndex = 0;
            this.lbl_login_cim.Text = "Kurzus Management";
            // 
            // pnl_login_fo
            // 
            this.pnl_login_fo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.pnl_login_fo.Controls.Add(this.label1);
            this.pnl_login_fo.Controls.Add(this.btn_uj_felh);
            this.pnl_login_fo.Controls.Add(this.btn_login);
            this.pnl_login_fo.Controls.Add(this.txt_jelszo);
            this.pnl_login_fo.Controls.Add(this.lbl_jelszo);
            this.pnl_login_fo.Controls.Add(this.txt_nkod);
            this.pnl_login_fo.Controls.Add(this.lbl_nkod);
            this.pnl_login_fo.Controls.Add(this.lbl_login_be);
            this.pnl_login_fo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_login_fo.Location = new System.Drawing.Point(0, 69);
            this.pnl_login_fo.Name = "pnl_login_fo";
            this.pnl_login_fo.Size = new System.Drawing.Size(314, 381);
            this.pnl_login_fo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(46, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "(Nkód: Admin, Jelszó: Admin123)";
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 2;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.btn_login.Location = new System.Drawing.Point(90, 215);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(142, 33);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Bejelentkezés";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_jelszo
            // 
            this.txt_jelszo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_jelszo.Location = new System.Drawing.Point(90, 170);
            this.txt_jelszo.MaxLength = 16;
            this.txt_jelszo.Name = "txt_jelszo";
            this.txt_jelszo.PasswordChar = '*';
            this.txt_jelszo.Size = new System.Drawing.Size(141, 27);
            this.txt_jelszo.TabIndex = 2;
            // 
            // lbl_jelszo
            // 
            this.lbl_jelszo.AutoSize = true;
            this.lbl_jelszo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_jelszo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.lbl_jelszo.Location = new System.Drawing.Point(87, 139);
            this.lbl_jelszo.Name = "lbl_jelszo";
            this.lbl_jelszo.Size = new System.Drawing.Size(70, 23);
            this.lbl_jelszo.TabIndex = 1;
            this.lbl_jelszo.Text = "Jelszó:";
            // 
            // txt_nkod
            // 
            this.txt_nkod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_nkod.Location = new System.Drawing.Point(89, 101);
            this.txt_nkod.Name = "txt_nkod";
            this.txt_nkod.Size = new System.Drawing.Size(141, 27);
            this.txt_nkod.TabIndex = 2;
            // 
            // lbl_nkod
            // 
            this.lbl_nkod.AutoSize = true;
            this.lbl_nkod.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_nkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.lbl_nkod.Location = new System.Drawing.Point(86, 70);
            this.lbl_nkod.Name = "lbl_nkod";
            this.lbl_nkod.Size = new System.Drawing.Size(123, 23);
            this.lbl_nkod.TabIndex = 1;
            this.lbl_nkod.Text = "Neptun kód:";
            // 
            // lbl_login_be
            // 
            this.lbl_login_be.AutoSize = true;
            this.lbl_login_be.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_login_be.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.lbl_login_be.Location = new System.Drawing.Point(85, 23);
            this.lbl_login_be.Name = "lbl_login_be";
            this.lbl_login_be.Size = new System.Drawing.Size(149, 25);
            this.lbl_login_be.TabIndex = 0;
            this.lbl_login_be.Text = "Bejelentkezés";
            // 
            // btn_uj_felh
            // 
            this.btn_uj_felh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uj_felh.FlatAppearance.BorderSize = 2;
            this.btn_uj_felh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uj_felh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_uj_felh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.btn_uj_felh.Location = new System.Drawing.Point(90, 254);
            this.btn_uj_felh.Name = "btn_uj_felh";
            this.btn_uj_felh.Size = new System.Drawing.Size(142, 33);
            this.btn_uj_felh.TabIndex = 3;
            this.btn_uj_felh.Text = "Új felhasználó";
            this.btn_uj_felh.UseVisualStyleBackColor = true;
            this.btn_uj_felh.Click += new System.EventHandler(this.btn_uj_felh_Click);
            // 
            // btn_login_kilep
            // 
            this.btn_login_kilep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_kilep.FlatAppearance.BorderSize = 0;
            this.btn_login_kilep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_kilep.Image = ((System.Drawing.Image)(resources.GetObject("btn_login_kilep.Image")));
            this.btn_login_kilep.Location = new System.Drawing.Point(281, 0);
            this.btn_login_kilep.Name = "btn_login_kilep";
            this.btn_login_kilep.Size = new System.Drawing.Size(30, 30);
            this.btn_login_kilep.TabIndex = 1;
            this.btn_login_kilep.UseVisualStyleBackColor = true;
            this.btn_login_kilep.Click += new System.EventHandler(this.btn_login_kilep_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 450);
            this.Controls.Add(this.pnl_login_fo);
            this.Controls.Add(this.pnl_login_fejlec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.pnl_login_fejlec.ResumeLayout(false);
            this.pnl_login_fejlec.PerformLayout();
            this.pnl_login_fo.ResumeLayout(false);
            this.pnl_login_fo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_login_fejlec;
        private System.Windows.Forms.Label lbl_login_cim;
        private System.Windows.Forms.Panel pnl_login_fo;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_jelszo;
        private System.Windows.Forms.Label lbl_jelszo;
        private System.Windows.Forms.TextBox txt_nkod;
        private System.Windows.Forms.Label lbl_nkod;
        private System.Windows.Forms.Label lbl_login_be;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_uj_felh;
        private System.Windows.Forms.Button btn_login_kilep;
    }
}

