namespace RestaurantOtomasyon
{
    partial class frmHesapOde
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMasaNumara = new System.Windows.Forms.TextBox();
            this.btnHesapAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnGuncelle.FlatAppearance.BorderSize = 3;
            this.btnGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Image = global::RestaurantOtomasyon.Properties.Resources.guncelle;
            this.btnGuncelle.Location = new System.Drawing.Point(1163, 587);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(297, 128);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1158, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Masa No:";
            // 
            // btnGeri
            // 
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnGeri.FlatAppearance.BorderSize = 3;
            this.btnGeri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnGeri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Image = global::RestaurantOtomasyon.Properties.Resources.geri;
            this.btnGeri.Location = new System.Drawing.Point(81, 859);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(312, 151);
            this.btnGeri.TabIndex = 9;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(81, 83);
            this.listView1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1031, 632);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Masa Numarası";
            this.columnHeader1.Width = 198;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hesap";
            this.columnHeader2.Width = 531;
            // 
            // txtMasaNumara
            // 
            this.txtMasaNumara.Location = new System.Drawing.Point(1163, 122);
            this.txtMasaNumara.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtMasaNumara.Name = "txtMasaNumara";
            this.txtMasaNumara.Size = new System.Drawing.Size(297, 37);
            this.txtMasaNumara.TabIndex = 7;
            // 
            // btnHesapAl
            // 
            this.btnHesapAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapAl.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnHesapAl.FlatAppearance.BorderSize = 3;
            this.btnHesapAl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnHesapAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnHesapAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapAl.Image = global::RestaurantOtomasyon.Properties.Resources.hesaplar;
            this.btnHesapAl.Location = new System.Drawing.Point(1163, 173);
            this.btnHesapAl.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnHesapAl.Name = "btnHesapAl";
            this.btnHesapAl.Size = new System.Drawing.Size(297, 151);
            this.btnHesapAl.TabIndex = 6;
            this.btnHesapAl.Text = "Hesap Al";
            this.btnHesapAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHesapAl.UseVisualStyleBackColor = true;
            this.btnHesapAl.Click += new System.EventHandler(this.btnHesapAl_Click);
            // 
            // frmHesapOde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestaurantOtomasyon.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtMasaNumara);
            this.Controls.Add(this.btnHesapAl);
            this.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "frmHesapOde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHesapOde";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHesapOde_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtMasaNumara;
        private System.Windows.Forms.Button btnHesapAl;
    }
}