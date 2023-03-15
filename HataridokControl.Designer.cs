namespace egyetemMan
{
    partial class HataridokControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HataridokControl));
            this.pnl_hataridok_fejlec = new System.Windows.Forms.Panel();
            this.lbl_targy = new System.Windows.Forms.Label();
            this.lbl__hatido_datum = new System.Windows.Forms.Label();
            this.lbl_vissza_ido = new System.Windows.Forms.Label();
            this.btn_hatarido_hozzaad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_hataridok_fejlec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_hataridok_fejlec
            // 
            this.pnl_hataridok_fejlec.Controls.Add(this.btn_hatarido_hozzaad);
            this.pnl_hataridok_fejlec.Controls.Add(this.lbl_vissza_ido);
            this.pnl_hataridok_fejlec.Controls.Add(this.lbl__hatido_datum);
            this.pnl_hataridok_fejlec.Controls.Add(this.lbl_targy);
            this.pnl_hataridok_fejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_hataridok_fejlec.Location = new System.Drawing.Point(0, 0);
            this.pnl_hataridok_fejlec.Name = "pnl_hataridok_fejlec";
            this.pnl_hataridok_fejlec.Size = new System.Drawing.Size(757, 77);
            this.pnl_hataridok_fejlec.TabIndex = 0;
            // 
            // lbl_targy
            // 
            this.lbl_targy.AutoSize = true;
            this.lbl_targy.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_targy.Location = new System.Drawing.Point(28, 29);
            this.lbl_targy.Name = "lbl_targy";
            this.lbl_targy.Size = new System.Drawing.Size(61, 23);
            this.lbl_targy.TabIndex = 0;
            this.lbl_targy.Text = "Tárgy";
            // 
            // lbl__hatido_datum
            // 
            this.lbl__hatido_datum.AutoSize = true;
            this.lbl__hatido_datum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__hatido_datum.Location = new System.Drawing.Point(115, 29);
            this.lbl__hatido_datum.Name = "lbl__hatido_datum";
            this.lbl__hatido_datum.Size = new System.Drawing.Size(91, 23);
            this.lbl__hatido_datum.TabIndex = 0;
            this.lbl__hatido_datum.Text = "Határidő";
            // 
            // lbl_vissza_ido
            // 
            this.lbl_vissza_ido.AutoSize = true;
            this.lbl_vissza_ido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vissza_ido.Location = new System.Drawing.Point(236, 29);
            this.lbl_vissza_ido.Name = "lbl_vissza_ido";
            this.lbl_vissza_ido.Size = new System.Drawing.Size(176, 23);
            this.lbl_vissza_ido.TabIndex = 0;
            this.lbl_vissza_ido.Text = "Visszamaradó idő";
            // 
            // btn_hatarido_hozzaad
            // 
            this.btn_hatarido_hozzaad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.btn_hatarido_hozzaad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hatarido_hozzaad.FlatAppearance.BorderSize = 0;
            this.btn_hatarido_hozzaad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hatarido_hozzaad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_hatarido_hozzaad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.btn_hatarido_hozzaad.Image = ((System.Drawing.Image)(resources.GetObject("btn_hatarido_hozzaad.Image")));
            this.btn_hatarido_hozzaad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hatarido_hozzaad.Location = new System.Drawing.Point(485, 26);
            this.btn_hatarido_hozzaad.Name = "btn_hatarido_hozzaad";
            this.btn_hatarido_hozzaad.Size = new System.Drawing.Size(212, 34);
            this.btn_hatarido_hozzaad.TabIndex = 1;
            this.btn_hatarido_hozzaad.Text = "Határidő hozzáadása";
            this.btn_hatarido_hozzaad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hatarido_hozzaad.UseVisualStyleBackColor = false;
            this.btn_hatarido_hozzaad.Click += new System.EventHandler(this.btn_hatarido_hozzaad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fejlesztés alatt...";
            // 
            // HataridokControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(202)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_hataridok_fejlec);
            this.Name = "HataridokControl";
            this.Size = new System.Drawing.Size(757, 427);
            this.pnl_hataridok_fejlec.ResumeLayout(false);
            this.pnl_hataridok_fejlec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_hataridok_fejlec;
        private System.Windows.Forms.Label lbl_vissza_ido;
        private System.Windows.Forms.Label lbl__hatido_datum;
        private System.Windows.Forms.Label lbl_targy;
        private System.Windows.Forms.Button btn_hatarido_hozzaad;
        private System.Windows.Forms.Label label1;
    }
}
