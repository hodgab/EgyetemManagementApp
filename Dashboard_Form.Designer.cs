namespace egyetemMan
{
    partial class Dashboard_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Form));
            this.pnl_oldal_menu = new System.Windows.Forms.Panel();
            this.pnl_active_btn = new System.Windows.Forms.Panel();
            this.btn_fajlok = new System.Windows.Forms.Button();
            this.btn_profil = new System.Windows.Forms.Button();
            this.btn_hataridok = new System.Windows.Forms.Button();
            this.btn_attekintes = new System.Windows.Forms.Button();
            this.pnl_db_fejlec = new System.Windows.Forms.Panel();
            this.lbl_cim = new System.Windows.Forms.Label();
            this.btn_dashboard_kilepes = new System.Windows.Forms.Button();
            this.lbl_osszpontszam = new System.Windows.Forms.Label();
            this.btn_pont_frissit = new System.Windows.Forms.Button();
            this.ctrl_hataridok = new egyetemMan.HataridokControl();
            this.ctrl_attekintes = new egyetemMan.AttekintesControl();
            this.pnl_oldal_menu.SuspendLayout();
            this.pnl_db_fejlec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_oldal_menu
            // 
            this.pnl_oldal_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.pnl_oldal_menu.Controls.Add(this.pnl_active_btn);
            this.pnl_oldal_menu.Controls.Add(this.btn_fajlok);
            this.pnl_oldal_menu.Controls.Add(this.btn_profil);
            this.pnl_oldal_menu.Controls.Add(this.btn_hataridok);
            this.pnl_oldal_menu.Controls.Add(this.btn_attekintes);
            this.pnl_oldal_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_oldal_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_oldal_menu.Name = "pnl_oldal_menu";
            this.pnl_oldal_menu.Size = new System.Drawing.Size(100, 486);
            this.pnl_oldal_menu.TabIndex = 0;
            // 
            // pnl_active_btn
            // 
            this.pnl_active_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.pnl_active_btn.Location = new System.Drawing.Point(0, 77);
            this.pnl_active_btn.Name = "pnl_active_btn";
            this.pnl_active_btn.Size = new System.Drawing.Size(15, 50);
            this.pnl_active_btn.TabIndex = 0;
            // 
            // btn_fajlok
            // 
            this.btn_fajlok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fajlok.FlatAppearance.BorderSize = 0;
            this.btn_fajlok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fajlok.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_fajlok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.btn_fajlok.Location = new System.Drawing.Point(15, 245);
            this.btn_fajlok.Name = "btn_fajlok";
            this.btn_fajlok.Size = new System.Drawing.Size(85, 50);
            this.btn_fajlok.TabIndex = 0;
            this.btn_fajlok.Text = "Fájlok";
            this.btn_fajlok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fajlok.UseVisualStyleBackColor = true;
            this.btn_fajlok.Click += new System.EventHandler(this.btn_fajlok_Click);
            // 
            // btn_profil
            // 
            this.btn_profil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profil.FlatAppearance.BorderSize = 0;
            this.btn_profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_profil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.btn_profil.Location = new System.Drawing.Point(15, 189);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(85, 50);
            this.btn_profil.TabIndex = 0;
            this.btn_profil.Text = "Profil";
            this.btn_profil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // btn_hataridok
            // 
            this.btn_hataridok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hataridok.FlatAppearance.BorderSize = 0;
            this.btn_hataridok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hataridok.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_hataridok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.btn_hataridok.Location = new System.Drawing.Point(15, 133);
            this.btn_hataridok.Name = "btn_hataridok";
            this.btn_hataridok.Size = new System.Drawing.Size(85, 50);
            this.btn_hataridok.TabIndex = 0;
            this.btn_hataridok.Text = "Határidők";
            this.btn_hataridok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hataridok.UseVisualStyleBackColor = true;
            this.btn_hataridok.Click += new System.EventHandler(this.btn_hataridok_Click);
            // 
            // btn_attekintes
            // 
            this.btn_attekintes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_attekintes.FlatAppearance.BorderSize = 0;
            this.btn_attekintes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attekintes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_attekintes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.btn_attekintes.Location = new System.Drawing.Point(15, 77);
            this.btn_attekintes.Name = "btn_attekintes";
            this.btn_attekintes.Size = new System.Drawing.Size(85, 50);
            this.btn_attekintes.TabIndex = 0;
            this.btn_attekintes.Text = "Áttekintés";
            this.btn_attekintes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_attekintes.UseVisualStyleBackColor = true;
            this.btn_attekintes.Click += new System.EventHandler(this.btn_attekintes_Click);
            // 
            // pnl_db_fejlec
            // 
            this.pnl_db_fejlec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(202)))));
            this.pnl_db_fejlec.Controls.Add(this.btn_pont_frissit);
            this.pnl_db_fejlec.Controls.Add(this.lbl_osszpontszam);
            this.pnl_db_fejlec.Controls.Add(this.btn_dashboard_kilepes);
            this.pnl_db_fejlec.Controls.Add(this.lbl_cim);
            this.pnl_db_fejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_db_fejlec.Location = new System.Drawing.Point(100, 0);
            this.pnl_db_fejlec.Name = "pnl_db_fejlec";
            this.pnl_db_fejlec.Size = new System.Drawing.Size(757, 59);
            this.pnl_db_fejlec.TabIndex = 1;
            // 
            // lbl_cim
            // 
            this.lbl_cim.AutoSize = true;
            this.lbl_cim.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_cim.Location = new System.Drawing.Point(306, 9);
            this.lbl_cim.Name = "lbl_cim";
            this.lbl_cim.Size = new System.Drawing.Size(155, 36);
            this.lbl_cim.TabIndex = 0;
            this.lbl_cim.Text = "Áttekintés";
            // 
            // btn_dashboard_kilepes
            // 
            this.btn_dashboard_kilepes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard_kilepes.FlatAppearance.BorderSize = 0;
            this.btn_dashboard_kilepes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard_kilepes.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashboard_kilepes.Image")));
            this.btn_dashboard_kilepes.Location = new System.Drawing.Point(715, 9);
            this.btn_dashboard_kilepes.Name = "btn_dashboard_kilepes";
            this.btn_dashboard_kilepes.Size = new System.Drawing.Size(30, 30);
            this.btn_dashboard_kilepes.TabIndex = 1;
            this.btn_dashboard_kilepes.UseVisualStyleBackColor = true;
            this.btn_dashboard_kilepes.Click += new System.EventHandler(this.btn_dashboard_kilepes_Click);
            // 
            // lbl_osszpontszam
            // 
            this.lbl_osszpontszam.AutoSize = true;
            this.lbl_osszpontszam.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_osszpontszam.Location = new System.Drawing.Point(57, 20);
            this.lbl_osszpontszam.Name = "lbl_osszpontszam";
            this.lbl_osszpontszam.Size = new System.Drawing.Size(146, 23);
            this.lbl_osszpontszam.TabIndex = 2;
            this.lbl_osszpontszam.Text = "Összpontszám:";
            // 
            // btn_pont_frissit
            // 
            this.btn_pont_frissit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pont_frissit.FlatAppearance.BorderSize = 0;
            this.btn_pont_frissit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pont_frissit.Image = ((System.Drawing.Image)(resources.GetObject("btn_pont_frissit.Image")));
            this.btn_pont_frissit.Location = new System.Drawing.Point(21, 15);
            this.btn_pont_frissit.Name = "btn_pont_frissit";
            this.btn_pont_frissit.Size = new System.Drawing.Size(30, 30);
            this.btn_pont_frissit.TabIndex = 3;
            this.btn_pont_frissit.UseVisualStyleBackColor = true;
            this.btn_pont_frissit.Click += new System.EventHandler(this.btn_pont_frissit_Click);
            // 
            // ctrl_hataridok
            // 
            this.ctrl_hataridok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(202)))));
            this.ctrl_hataridok.Location = new System.Drawing.Point(100, 59);
            this.ctrl_hataridok.Name = "ctrl_hataridok";
            this.ctrl_hataridok.Size = new System.Drawing.Size(757, 427);
            this.ctrl_hataridok.TabIndex = 3;
            // 
            // ctrl_attekintes
            // 
            this.ctrl_attekintes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(202)))));
            this.ctrl_attekintes.Location = new System.Drawing.Point(100, 59);
            this.ctrl_attekintes.Name = "ctrl_attekintes";
            this.ctrl_attekintes.Size = new System.Drawing.Size(757, 427);
            this.ctrl_attekintes.TabIndex = 2;
            // 
            // Dashboard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 486);
            this.Controls.Add(this.ctrl_hataridok);
            this.Controls.Add(this.ctrl_attekintes);
            this.Controls.Add(this.pnl_db_fejlec);
            this.Controls.Add(this.pnl_oldal_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Form_Load);
            this.pnl_oldal_menu.ResumeLayout(false);
            this.pnl_db_fejlec.ResumeLayout(false);
            this.pnl_db_fejlec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_oldal_menu;
        private System.Windows.Forms.Panel pnl_db_fejlec;
        private System.Windows.Forms.Panel pnl_active_btn;
        private System.Windows.Forms.Button btn_attekintes;
        private System.Windows.Forms.Label lbl_cim;
        private System.Windows.Forms.Button btn_fajlok;
        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Button btn_hataridok;
        private AttekintesControl ctrl_attekintes;
        private System.Windows.Forms.Button btn_dashboard_kilepes;
        private System.Windows.Forms.Label lbl_osszpontszam;
        private System.Windows.Forms.Button btn_pont_frissit;
        private HataridokControl ctrl_hataridok;
    }
}