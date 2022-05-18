namespace RestaurantOtomasyon
{
    partial class frmSiparis
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMasaID = new System.Windows.Forms.TextBox();
            this.lbEklenenUrunler = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblHesap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHesap = new System.Windows.Forms.ListBox();
            this.clbSiparis = new System.Windows.Forms.CheckedListBox();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnMasaKapa = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(404, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Masa Numarası";
            // 
            // txtMasaID
            // 
            this.txtMasaID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMasaID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMasaID.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasaID.Location = new System.Drawing.Point(409, 115);
            this.txtMasaID.Margin = new System.Windows.Forms.Padding(5);
            this.txtMasaID.MaxLength = 5;
            this.txtMasaID.Multiline = true;
            this.txtMasaID.Name = "txtMasaID";
            this.txtMasaID.Size = new System.Drawing.Size(166, 77);
            this.txtMasaID.TabIndex = 20;
            this.txtMasaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbEklenenUrunler
            // 
            this.lbEklenenUrunler.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbEklenenUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbEklenenUrunler.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEklenenUrunler.FormattingEnabled = true;
            this.lbEklenenUrunler.ItemHeight = 29;
            this.lbEklenenUrunler.Location = new System.Drawing.Point(1309, 71);
            this.lbEklenenUrunler.Margin = new System.Windows.Forms.Padding(5);
            this.lbEklenenUrunler.Name = "lbEklenenUrunler";
            this.lbEklenenUrunler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbEklenenUrunler.Size = new System.Drawing.Size(555, 638);
            this.lbEklenenUrunler.TabIndex = 19;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapla.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnHesapla.FlatAppearance.BorderSize = 3;
            this.btnHesapla.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.btnHesapla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnHesapla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Location = new System.Drawing.Point(409, 225);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(5);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(164, 75);
            this.btnHesapla.TabIndex = 18;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblHesap
            // 
            this.lblHesap.AutoSize = true;
            this.lblHesap.BackColor = System.Drawing.Color.Transparent;
            this.lblHesap.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHesap.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblHesap.Location = new System.Drawing.Point(403, 340);
            this.lblHesap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHesap.Name = "lblHesap";
            this.lblHesap.Size = new System.Drawing.Size(94, 36);
            this.lblHesap.TabIndex = 17;
            this.lblHesap.Text = "Tutar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hesap";
            // 
            // lbHesap
            // 
            this.lbHesap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbHesap.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHesap.FormattingEnabled = true;
            this.lbHesap.ItemHeight = 29;
            this.lbHesap.Location = new System.Drawing.Point(19, 81);
            this.lbHesap.Margin = new System.Windows.Forms.Padding(5);
            this.lbHesap.Name = "lbHesap";
            this.lbHesap.Size = new System.Drawing.Size(347, 323);
            this.lbHesap.TabIndex = 15;
            // 
            // clbSiparis
            // 
            this.clbSiparis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clbSiparis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbSiparis.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSiparis.FormattingEnabled = true;
            this.clbSiparis.Location = new System.Drawing.Point(791, 65);
            this.clbSiparis.Margin = new System.Windows.Forms.Padding(5);
            this.clbSiparis.Name = "clbSiparis";
            this.clbSiparis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clbSiparis.Size = new System.Drawing.Size(508, 640);
            this.clbSiparis.TabIndex = 14;
            // 
            // btnSiparis
            // 
            this.btnSiparis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparis.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnSiparis.FlatAppearance.BorderSize = 3;
            this.btnSiparis.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.btnSiparis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnSiparis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparis.Image = global::RestaurantOtomasyon.Properties.Resources.ekle;
            this.btnSiparis.Location = new System.Drawing.Point(791, 747);
            this.btnSiparis.Margin = new System.Windows.Forms.Padding(5);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(508, 117);
            this.btnSiparis.TabIndex = 13;
            this.btnSiparis.Text = "Siparis Ekle";
            this.btnSiparis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // btnMasaKapa
            // 
            this.btnMasaKapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasaKapa.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnMasaKapa.FlatAppearance.BorderSize = 3;
            this.btnMasaKapa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.btnMasaKapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnMasaKapa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMasaKapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasaKapa.Image = global::RestaurantOtomasyon.Properties.Resources.kapat;
            this.btnMasaKapa.Location = new System.Drawing.Point(1309, 747);
            this.btnMasaKapa.Margin = new System.Windows.Forms.Padding(5);
            this.btnMasaKapa.Name = "btnMasaKapa";
            this.btnMasaKapa.Size = new System.Drawing.Size(555, 117);
            this.btnMasaKapa.TabIndex = 12;
            this.btnMasaKapa.Text = "Masa Kapat";
            this.btnMasaKapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMasaKapa.UseVisualStyleBackColor = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnGeri.FlatAppearance.BorderSize = 3;
            this.btnGeri.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.btnGeri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnGeri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Image = global::RestaurantOtomasyon.Properties.Resources.geri;
            this.btnGeri.Location = new System.Drawing.Point(19, 909);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(5);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(249, 138);
            this.btnGeri.TabIndex = 22;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestaurantOtomasyon.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMasaID);
            this.Controls.Add(this.lbEklenenUrunler);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblHesap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHesap);
            this.Controls.Add(this.clbSiparis);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnMasaKapa);
            this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSiparis";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSiparis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMasaID;
        private System.Windows.Forms.ListBox lbEklenenUrunler;
        private System.Windows.Forms.Button btnHesapla;
        public System.Windows.Forms.Label lblHesap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbHesap;
        private System.Windows.Forms.CheckedListBox clbSiparis;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnMasaKapa;
        private System.Windows.Forms.Button btnGeri;
    }
}