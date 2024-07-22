namespace AracKiralama
{
    partial class AnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.btnMusterilist = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnAraclist = new System.Windows.Forms.Button();
            this.btnSozlesme = new System.Windows.Forms.Button();
            this.btnSatıs = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusterilist
            // 
            this.btnMusterilist.AutoSize = true;
            this.btnMusterilist.BackColor = System.Drawing.Color.White;
            this.btnMusterilist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusterilist.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnMusterilist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusterilist.ImageKey = "müşteri listele.png";
            this.btnMusterilist.ImageList = this.ımageList1;
            this.btnMusterilist.Location = new System.Drawing.Point(141, -1);
            this.btnMusterilist.Name = "btnMusterilist";
            this.btnMusterilist.Size = new System.Drawing.Size(145, 110);
            this.btnMusterilist.TabIndex = 1;
            this.btnMusterilist.Text = "Müşteri Listele";
            this.btnMusterilist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusterilist.UseVisualStyleBackColor = false;
            this.btnMusterilist.Click += new System.EventHandler(this.btnMusterilist_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "araba.jpg");
            this.ımageList1.Images.SetKeyName(1, "araba ekle.png");
            this.ımageList1.Images.SetKeyName(2, "çıkıl.png");
            this.ımageList1.Images.SetKeyName(3, "indir.png");
            this.ımageList1.Images.SetKeyName(4, "müşteri ekle.png");
            this.ımageList1.Images.SetKeyName(5, "müşteri listele.png");
            this.ımageList1.Images.SetKeyName(6, "satış.png");
            this.ımageList1.Images.SetKeyName(7, "sözleşmee.png");
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.AutoSize = true;
            this.btnAracEkle.BackColor = System.Drawing.Color.White;
            this.btnAracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracEkle.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnAracEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAracEkle.ImageKey = "araba ekle.png";
            this.btnAracEkle.ImageList = this.ımageList1;
            this.btnAracEkle.Location = new System.Drawing.Point(279, -1);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(143, 110);
            this.btnAracEkle.TabIndex = 1;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracEkle.UseVisualStyleBackColor = false;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnAraclist
            // 
            this.btnAraclist.AutoSize = true;
            this.btnAraclist.BackColor = System.Drawing.Color.White;
            this.btnAraclist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAraclist.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnAraclist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAraclist.ImageKey = "indir.png";
            this.btnAraclist.ImageList = this.ımageList1;
            this.btnAraclist.Location = new System.Drawing.Point(415, -1);
            this.btnAraclist.Name = "btnAraclist";
            this.btnAraclist.Size = new System.Drawing.Size(143, 110);
            this.btnAraclist.TabIndex = 1;
            this.btnAraclist.Text = "Araç Listele";
            this.btnAraclist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAraclist.UseVisualStyleBackColor = false;
            this.btnAraclist.Click += new System.EventHandler(this.btnAraclist_Click);
            // 
            // btnSozlesme
            // 
            this.btnSozlesme.AutoSize = true;
            this.btnSozlesme.BackColor = System.Drawing.Color.White;
            this.btnSozlesme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSozlesme.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnSozlesme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSozlesme.ImageKey = "sözleşmee.png";
            this.btnSozlesme.ImageList = this.ımageList1;
            this.btnSozlesme.Location = new System.Drawing.Point(552, -2);
            this.btnSozlesme.Name = "btnSozlesme";
            this.btnSozlesme.Size = new System.Drawing.Size(143, 111);
            this.btnSozlesme.TabIndex = 1;
            this.btnSozlesme.Text = "Sözleşme";
            this.btnSozlesme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSozlesme.UseVisualStyleBackColor = false;
            this.btnSozlesme.Click += new System.EventHandler(this.btnSozlesme_Click);
            // 
            // btnSatıs
            // 
            this.btnSatıs.AutoSize = true;
            this.btnSatıs.BackColor = System.Drawing.Color.White;
            this.btnSatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatıs.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnSatıs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatıs.ImageKey = "satış.png";
            this.btnSatıs.ImageList = this.ımageList1;
            this.btnSatıs.Location = new System.Drawing.Point(691, -2);
            this.btnSatıs.Name = "btnSatıs";
            this.btnSatıs.Size = new System.Drawing.Size(143, 111);
            this.btnSatıs.TabIndex = 1;
            this.btnSatıs.Text = "Satış";
            this.btnSatıs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatıs.UseVisualStyleBackColor = false;
            this.btnSatıs.Click += new System.EventHandler(this.btnSatıs_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.AutoSize = true;
            this.btnCıkıs.BackColor = System.Drawing.Color.White;
            this.btnCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkıs.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnCıkıs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCıkıs.ImageKey = "çıkıl.png";
            this.btnCıkıs.ImageList = this.ımageList1;
            this.btnCıkıs.Location = new System.Drawing.Point(829, -1);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(143, 111);
            this.btnCıkıs.TabIndex = 1;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.White;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnMusteriEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteriEkle.ImageKey = "müşteri ekle.png";
            this.btnMusteriEkle.ImageList = this.ımageList1;
            this.btnMusteriEkle.Location = new System.Drawing.Point(-2, -1);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(146, 111);
            this.btnMusteriEkle.TabIndex = 1;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = global::AracKiralama.Properties.Resources.araba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 472);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnSatıs);
            this.Controls.Add(this.btnSozlesme);
            this.Controls.Add(this.btnAraclist);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnMusterilist);
            this.Controls.Add(this.btnMusteriEkle);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusterilist;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Button btnAraclist;
        private System.Windows.Forms.Button btnSozlesme;
        private System.Windows.Forms.Button btnSatıs;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

