namespace Sifre_Olusturucu
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ustpanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKucuk = new System.Windows.Forms.CheckBox();
            this.cbSayi = new System.Windows.Forms.CheckBox();
            this.cbBuyuk = new System.Windows.Forms.CheckBox();
            this.cbOzel = new System.Windows.Forms.CheckBox();
            this.listPass = new System.Windows.Forms.ListBox();
            this.btnPanoKopyala = new System.Windows.Forms.Button();
            this.nupUzunluk = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ustpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUzunluk)).BeginInit();
            this.SuspendLayout();
            // 
            // ustpanel
            // 
            this.ustpanel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ustpanel.Controls.Add(this.pictureBox2);
            this.ustpanel.Controls.Add(this.pictureBox1);
            this.ustpanel.Controls.Add(this.label1);
            this.ustpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustpanel.Location = new System.Drawing.Point(0, 0);
            this.ustpanel.Name = "ustpanel";
            this.ustpanel.Size = new System.Drawing.Size(800, 35);
            this.ustpanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::Sifre_Olusturucu.Properties.Resources.pass;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Sifre_Olusturucu.Properties.Resources.White_Close_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(764, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifre Oluşturucu";
            // 
            // cbKucuk
            // 
            this.cbKucuk.AutoSize = true;
            this.cbKucuk.Checked = true;
            this.cbKucuk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKucuk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKucuk.Location = new System.Drawing.Point(12, 45);
            this.cbKucuk.Name = "cbKucuk";
            this.cbKucuk.Size = new System.Drawing.Size(88, 21);
            this.cbKucuk.TabIndex = 1;
            this.cbKucuk.Text = "Küçük harf";
            this.cbKucuk.UseVisualStyleBackColor = true;
            // 
            // cbSayi
            // 
            this.cbSayi.AutoSize = true;
            this.cbSayi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSayi.Location = new System.Drawing.Point(12, 99);
            this.cbSayi.Name = "cbSayi";
            this.cbSayi.Size = new System.Drawing.Size(50, 21);
            this.cbSayi.TabIndex = 2;
            this.cbSayi.Text = "Sayı";
            this.cbSayi.UseVisualStyleBackColor = true;
            // 
            // cbBuyuk
            // 
            this.cbBuyuk.AutoSize = true;
            this.cbBuyuk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBuyuk.Location = new System.Drawing.Point(12, 72);
            this.cbBuyuk.Name = "cbBuyuk";
            this.cbBuyuk.Size = new System.Drawing.Size(87, 21);
            this.cbBuyuk.TabIndex = 3;
            this.cbBuyuk.Text = "Büyük harf";
            this.cbBuyuk.UseVisualStyleBackColor = true;
            // 
            // cbOzel
            // 
            this.cbOzel.AutoSize = true;
            this.cbOzel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOzel.Location = new System.Drawing.Point(12, 126);
            this.cbOzel.Name = "cbOzel";
            this.cbOzel.Size = new System.Drawing.Size(156, 21);
            this.cbOzel.TabIndex = 4;
            this.cbOzel.Text = "Özel karakterler (!,?,&...)";
            this.cbOzel.UseVisualStyleBackColor = true;
            // 
            // listPass
            // 
            this.listPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listPass.FormattingEnabled = true;
            this.listPass.Location = new System.Drawing.Point(12, 199);
            this.listPass.Name = "listPass";
            this.listPass.Size = new System.Drawing.Size(776, 147);
            this.listPass.TabIndex = 5;
            // 
            // btnPanoKopyala
            // 
            this.btnPanoKopyala.BackColor = System.Drawing.Color.Firebrick;
            this.btnPanoKopyala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanoKopyala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanoKopyala.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPanoKopyala.ForeColor = System.Drawing.Color.White;
            this.btnPanoKopyala.Location = new System.Drawing.Point(12, 352);
            this.btnPanoKopyala.Name = "btnPanoKopyala";
            this.btnPanoKopyala.Size = new System.Drawing.Size(776, 36);
            this.btnPanoKopyala.TabIndex = 6;
            this.btnPanoKopyala.Text = "Panoya Kopyala";
            this.btnPanoKopyala.UseVisualStyleBackColor = false;
            this.btnPanoKopyala.Click += new System.EventHandler(this.btnPanoKopyala_Click);
            // 
            // nupUzunluk
            // 
            this.nupUzunluk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupUzunluk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupUzunluk.Location = new System.Drawing.Point(274, 41);
            this.nupUzunluk.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nupUzunluk.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupUzunluk.Name = "nupUzunluk";
            this.nupUzunluk.Size = new System.Drawing.Size(42, 25);
            this.nupUzunluk.TabIndex = 7;
            this.nupUzunluk.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(170, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre Uzunluğu";
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlustur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.ForeColor = System.Drawing.Color.White;
            this.btnOlustur.Location = new System.Drawing.Point(12, 157);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(304, 36);
            this.btnOlustur.TabIndex = 9;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.White;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.Location = new System.Drawing.Point(484, 157);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(304, 36);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nupUzunluk);
            this.Controls.Add(this.btnPanoKopyala);
            this.Controls.Add(this.listPass);
            this.Controls.Add(this.cbOzel);
            this.Controls.Add(this.cbBuyuk);
            this.Controls.Add(this.cbSayi);
            this.Controls.Add(this.cbKucuk);
            this.Controls.Add(this.ustpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Oluşturucu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ustpanel.ResumeLayout(false);
            this.ustpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUzunluk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ustpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbKucuk;
        private System.Windows.Forms.CheckBox cbSayi;
        private System.Windows.Forms.CheckBox cbBuyuk;
        private System.Windows.Forms.CheckBox cbOzel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listPass;
        private System.Windows.Forms.Button btnPanoKopyala;
        private System.Windows.Forms.NumericUpDown nupUzunluk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnTemizle;
    }
}

