namespace egyetemMan
{
    partial class Teendok_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teendok_Form));
            this.pnl_teendok_fejlec = new System.Windows.Forms.Panel();
            this.btn_teendok_hozzaad = new System.Windows.Forms.Button();
            this.lbl_megoldott = new System.Windows.Forms.Label();
            this.txt_teendo_hozzaadas = new System.Windows.Forms.TextBox();
            this.lbl_teendsok_hozzaad = new System.Windows.Forms.Label();
            this.lbl_teendok_cim = new System.Windows.Forms.Label();
            this.pnl_teendok_fo = new System.Windows.Forms.Panel();
            this.btn_kilepes = new System.Windows.Forms.Button();
            this.pnl_teendok_fejlec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_teendok_fejlec
            // 
            this.pnl_teendok_fejlec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.pnl_teendok_fejlec.Controls.Add(this.btn_kilepes);
            this.pnl_teendok_fejlec.Controls.Add(this.btn_teendok_hozzaad);
            this.pnl_teendok_fejlec.Controls.Add(this.lbl_megoldott);
            this.pnl_teendok_fejlec.Controls.Add(this.txt_teendo_hozzaadas);
            this.pnl_teendok_fejlec.Controls.Add(this.lbl_teendsok_hozzaad);
            this.pnl_teendok_fejlec.Controls.Add(this.lbl_teendok_cim);
            this.pnl_teendok_fejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_teendok_fejlec.Location = new System.Drawing.Point(0, 0);
            this.pnl_teendok_fejlec.Name = "pnl_teendok_fejlec";
            this.pnl_teendok_fejlec.Size = new System.Drawing.Size(365, 90);
            this.pnl_teendok_fejlec.TabIndex = 0;
            // 
            // btn_teendok_hozzaad
            // 
            this.btn_teendok_hozzaad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teendok_hozzaad.FlatAppearance.BorderSize = 0;
            this.btn_teendok_hozzaad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teendok_hozzaad.Image = ((System.Drawing.Image)(resources.GetObject("btn_teendok_hozzaad.Image")));
            this.btn_teendok_hozzaad.Location = new System.Drawing.Point(323, 46);
            this.btn_teendok_hozzaad.Name = "btn_teendok_hozzaad";
            this.btn_teendok_hozzaad.Size = new System.Drawing.Size(30, 30);
            this.btn_teendok_hozzaad.TabIndex = 3;
            this.btn_teendok_hozzaad.UseVisualStyleBackColor = true;
            this.btn_teendok_hozzaad.Click += new System.EventHandler(this.btn_teendok_hozzaad_Click);
            // 
            // lbl_megoldott
            // 
            this.lbl_megoldott.AutoSize = true;
            this.lbl_megoldott.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_megoldott.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.lbl_megoldott.Location = new System.Drawing.Point(129, 13);
            this.lbl_megoldott.Name = "lbl_megoldott";
            this.lbl_megoldott.Size = new System.Drawing.Size(112, 23);
            this.lbl_megoldott.TabIndex = 2;
            this.lbl_megoldott.Text = "megoldott:";
            // 
            // txt_teendo_hozzaadas
            // 
            this.txt_teendo_hozzaadas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_teendo_hozzaadas.Location = new System.Drawing.Point(139, 50);
            this.txt_teendo_hozzaadas.Name = "txt_teendo_hozzaadas";
            this.txt_teendo_hozzaadas.Size = new System.Drawing.Size(176, 23);
            this.txt_teendo_hozzaadas.TabIndex = 1;
            this.txt_teendo_hozzaadas.TextChanged += new System.EventHandler(this.txt_teendo_hozzaadas_TextChanged);
            // 
            // lbl_teendsok_hozzaad
            // 
            this.lbl_teendsok_hozzaad.AutoSize = true;
            this.lbl_teendsok_hozzaad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_teendsok_hozzaad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.lbl_teendsok_hozzaad.Location = new System.Drawing.Point(3, 48);
            this.lbl_teendsok_hozzaad.Name = "lbl_teendsok_hozzaad";
            this.lbl_teendsok_hozzaad.Size = new System.Drawing.Size(130, 25);
            this.lbl_teendsok_hozzaad.TabIndex = 0;
            this.lbl_teendsok_hozzaad.Text = "Hozzáadás:";
            // 
            // lbl_teendok_cim
            // 
            this.lbl_teendok_cim.AutoSize = true;
            this.lbl_teendok_cim.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_teendok_cim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.lbl_teendok_cim.Location = new System.Drawing.Point(12, 8);
            this.lbl_teendok_cim.Name = "lbl_teendok_cim";
            this.lbl_teendok_cim.Size = new System.Drawing.Size(111, 28);
            this.lbl_teendok_cim.TabIndex = 0;
            this.lbl_teendok_cim.Text = "Teendők";
            // 
            // pnl_teendok_fo
            // 
            this.pnl_teendok_fo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.pnl_teendok_fo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_teendok_fo.Location = new System.Drawing.Point(0, 90);
            this.pnl_teendok_fo.Name = "pnl_teendok_fo";
            this.pnl_teendok_fo.Size = new System.Drawing.Size(365, 360);
            this.pnl_teendok_fo.TabIndex = 1;
            // 
            // btn_kilepes
            // 
            this.btn_kilepes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kilepes.FlatAppearance.BorderSize = 0;
            this.btn_kilepes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kilepes.Image = ((System.Drawing.Image)(resources.GetObject("btn_kilepes.Image")));
            this.btn_kilepes.Location = new System.Drawing.Point(323, 8);
            this.btn_kilepes.Name = "btn_kilepes";
            this.btn_kilepes.Size = new System.Drawing.Size(30, 30);
            this.btn_kilepes.TabIndex = 4;
            this.btn_kilepes.UseVisualStyleBackColor = true;
            this.btn_kilepes.Click += new System.EventHandler(this.btn_kilepes_Click);
            // 
            // Teendok_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.pnl_teendok_fo);
            this.Controls.Add(this.pnl_teendok_fejlec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teendok_Form";
            this.Text = "Teendok_Form";
            this.Load += new System.EventHandler(this.Teendok_Form_Load);
            this.pnl_teendok_fejlec.ResumeLayout(false);
            this.pnl_teendok_fejlec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_teendok_fejlec;
        private System.Windows.Forms.TextBox txt_teendo_hozzaadas;
        private System.Windows.Forms.Label lbl_teendsok_hozzaad;
        private System.Windows.Forms.Label lbl_teendok_cim;
        private System.Windows.Forms.Panel pnl_teendok_fo;
        private System.Windows.Forms.Label lbl_megoldott;
        private System.Windows.Forms.Button btn_teendok_hozzaad;
        private System.Windows.Forms.Button btn_kilepes;
    }
}