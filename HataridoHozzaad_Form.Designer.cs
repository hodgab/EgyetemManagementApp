namespace egyetemMan
{
    partial class HataridoHozzaad_Form
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
            this.lbl_targy = new System.Windows.Forms.Label();
            this.txt_targy_hozzaad = new System.Windows.Forms.TextBox();
            this.lbl_idopont = new System.Windows.Forms.Label();
            this.dtp_idopont_hozzaad = new System.Windows.Forms.DateTimePicker();
            this.btn_hatarido_hozzaad = new System.Windows.Forms.Button();
            this.btn_megse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_targy
            // 
            this.lbl_targy.AutoSize = true;
            this.lbl_targy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_targy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.lbl_targy.Location = new System.Drawing.Point(131, 46);
            this.lbl_targy.Name = "lbl_targy";
            this.lbl_targy.Size = new System.Drawing.Size(52, 19);
            this.lbl_targy.TabIndex = 0;
            this.lbl_targy.Text = "Tárgy";
            // 
            // txt_targy_hozzaad
            // 
            this.txt_targy_hozzaad.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_targy_hozzaad.Location = new System.Drawing.Point(81, 84);
            this.txt_targy_hozzaad.Name = "txt_targy_hozzaad";
            this.txt_targy_hozzaad.Size = new System.Drawing.Size(150, 23);
            this.txt_targy_hozzaad.TabIndex = 1;
            // 
            // lbl_idopont
            // 
            this.lbl_idopont.AutoSize = true;
            this.lbl_idopont.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_idopont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.lbl_idopont.Location = new System.Drawing.Point(114, 187);
            this.lbl_idopont.Name = "lbl_idopont";
            this.lbl_idopont.Size = new System.Drawing.Size(69, 19);
            this.lbl_idopont.TabIndex = 0;
            this.lbl_idopont.Text = "Időpont";
            // 
            // dtp_idopont_hozzaad
            // 
            this.dtp_idopont_hozzaad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtp_idopont_hozzaad.Location = new System.Drawing.Point(12, 222);
            this.dtp_idopont_hozzaad.Name = "dtp_idopont_hozzaad";
            this.dtp_idopont_hozzaad.Size = new System.Drawing.Size(274, 23);
            this.dtp_idopont_hozzaad.TabIndex = 2;
            // 
            // btn_hatarido_hozzaad
            // 
            this.btn_hatarido_hozzaad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hatarido_hozzaad.FlatAppearance.BorderSize = 3;
            this.btn_hatarido_hozzaad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hatarido_hozzaad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hatarido_hozzaad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.btn_hatarido_hozzaad.Location = new System.Drawing.Point(28, 287);
            this.btn_hatarido_hozzaad.Name = "btn_hatarido_hozzaad";
            this.btn_hatarido_hozzaad.Size = new System.Drawing.Size(109, 36);
            this.btn_hatarido_hozzaad.TabIndex = 3;
            this.btn_hatarido_hozzaad.Text = "Hozzáad";
            this.btn_hatarido_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hatarido_hozzaad.Click += new System.EventHandler(this.btn_hatarido_hozzaad_Click);
            // 
            // btn_megse
            // 
            this.btn_megse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_megse.FlatAppearance.BorderSize = 3;
            this.btn_megse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_megse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_megse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(146)))), ((int)(((byte)(86)))));
            this.btn_megse.Location = new System.Drawing.Point(156, 287);
            this.btn_megse.Name = "btn_megse";
            this.btn_megse.Size = new System.Drawing.Size(109, 36);
            this.btn_megse.TabIndex = 3;
            this.btn_megse.Text = "Mégse";
            this.btn_megse.UseVisualStyleBackColor = true;
            this.btn_megse.Click += new System.EventHandler(this.btn_megse_Click);
            // 
            // HataridoHozzaad_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(314, 347);
            this.Controls.Add(this.btn_megse);
            this.Controls.Add(this.btn_hatarido_hozzaad);
            this.Controls.Add(this.dtp_idopont_hozzaad);
            this.Controls.Add(this.txt_targy_hozzaad);
            this.Controls.Add(this.lbl_idopont);
            this.Controls.Add(this.lbl_targy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HataridoHozzaad_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HataridoHozzaad_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_targy;
        private System.Windows.Forms.TextBox txt_targy_hozzaad;
        private System.Windows.Forms.Label lbl_idopont;
        private System.Windows.Forms.DateTimePicker dtp_idopont_hozzaad;
        private System.Windows.Forms.Button btn_hatarido_hozzaad;
        private System.Windows.Forms.Button btn_megse;
    }
}