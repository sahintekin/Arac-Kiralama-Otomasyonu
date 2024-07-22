namespace AracKiralama
{
    partial class AracListele
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ımageList4 = new System.Windows.Forms.ImageList(this.components);
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.cbxSeri = new System.Windows.Forms.ComboBox();
            this.cbxMarka = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtKilometre = new System.Windows.Forms.TextBox();
            this.txtKira = new System.Windows.Forms.TextBox();
            this.cxbYakıt = new System.Windows.Forms.ComboBox();
            this.cxbDurumu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.btnSill = new System.Windows.Forms.Button();
            this.btnGuncellee = new System.Windows.Forms.Button();
            this.btnCıkıs4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(337, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 380);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ımageList4
            // 
            this.ımageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList4.ImageStream")));
            this.ımageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList4.Images.SetKeyName(0, "çıkış2.png");
            this.ımageList4.Images.SetKeyName(1, "sil.png");
            this.ımageList4.Images.SetKeyName(2, "güncelle.jpeg");
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(194, 204);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(121, 22);
            this.txtRenk.TabIndex = 51;
            // 
            // cbxSeri
            // 
            this.cbxSeri.FormattingEnabled = true;
            this.cbxSeri.Location = new System.Drawing.Point(194, 108);
            this.cbxSeri.Name = "cbxSeri";
            this.cbxSeri.Size = new System.Drawing.Size(121, 24);
            this.cbxSeri.TabIndex = 50;
            // 
            // cbxMarka
            // 
            this.cbxMarka.FormattingEnabled = true;
            this.cbxMarka.Items.AddRange(new object[] {
            "Lamborghini",
            "Toog",
            "Mercedes",
            "Porsche"});
            this.cbxMarka.Location = new System.Drawing.Point(194, 61);
            this.cbxMarka.Name = "cbxMarka";
            this.cbxMarka.Size = new System.Drawing.Size(121, 24);
            this.cbxMarka.TabIndex = 49;
            this.cbxMarka.SelectedIndexChanged += new System.EventHandler(this.cbxMarka_SelectedIndexChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(194, 157);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 22);
            this.txtModel.TabIndex = 48;
            // 
            // txtKilometre
            // 
            this.txtKilometre.Location = new System.Drawing.Point(194, 251);
            this.txtKilometre.Name = "txtKilometre";
            this.txtKilometre.Size = new System.Drawing.Size(121, 22);
            this.txtKilometre.TabIndex = 47;
            // 
            // txtKira
            // 
            this.txtKira.Location = new System.Drawing.Point(194, 345);
            this.txtKira.Name = "txtKira";
            this.txtKira.Size = new System.Drawing.Size(121, 22);
            this.txtKira.TabIndex = 46;
            // 
            // cxbYakıt
            // 
            this.cxbYakıt.FormattingEnabled = true;
            this.cxbYakıt.Items.AddRange(new object[] {
            "Elektrik",
            "Benzin",
            "Dizel"});
            this.cxbYakıt.Location = new System.Drawing.Point(194, 296);
            this.cxbYakıt.Name = "cxbYakıt";
            this.cxbYakıt.Size = new System.Drawing.Size(121, 24);
            this.cxbYakıt.TabIndex = 45;
            // 
            // cxbDurumu
            // 
            this.cxbDurumu.FormattingEnabled = true;
            this.cxbDurumu.Items.AddRange(new object[] {
            "Bos",
            "Dolu"});
            this.cxbDurumu.Location = new System.Drawing.Point(194, 390);
            this.cxbDurumu.Name = "cxbDurumu";
            this.cxbDurumu.Size = new System.Drawing.Size(121, 24);
            this.cxbDurumu.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(33, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 42;
            this.label9.Text = "Durumu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(33, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(33, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(33, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Kilometre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Model(Yıl)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Plaka";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(194, 16);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(121, 22);
            this.txtPlaka.TabIndex = 52;
            // 
            // btnSill
            // 
            this.btnSill.BackColor = System.Drawing.Color.White;
            this.btnSill.ImageKey = "sil.png";
            this.btnSill.ImageList = this.ımageList4;
            this.btnSill.Location = new System.Drawing.Point(228, 433);
            this.btnSill.Name = "btnSill";
            this.btnSill.Size = new System.Drawing.Size(60, 59);
            this.btnSill.TabIndex = 32;
            this.btnSill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSill.UseVisualStyleBackColor = false;
            this.btnSill.Click += new System.EventHandler(this.btnSill_Click);
            // 
            // btnGuncellee
            // 
            this.btnGuncellee.BackColor = System.Drawing.Color.White;
            this.btnGuncellee.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnGuncellee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncellee.ImageKey = "güncelle.jpeg";
            this.btnGuncellee.ImageList = this.ımageList4;
            this.btnGuncellee.Location = new System.Drawing.Point(38, 433);
            this.btnGuncellee.Name = "btnGuncellee";
            this.btnGuncellee.Size = new System.Drawing.Size(116, 77);
            this.btnGuncellee.TabIndex = 31;
            this.btnGuncellee.Text = "GÜNCELLE";
            this.btnGuncellee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncellee.UseVisualStyleBackColor = false;
            this.btnGuncellee.Click += new System.EventHandler(this.btnGuncellee_Click);
            // 
            // btnCıkıs4
            // 
            this.btnCıkıs4.ImageKey = "çıkış2.png";
            this.btnCıkıs4.ImageList = this.ımageList4;
            this.btnCıkıs4.Location = new System.Drawing.Point(1062, -1);
            this.btnCıkıs4.Name = "btnCıkıs4";
            this.btnCıkıs4.Size = new System.Drawing.Size(60, 40);
            this.btnCıkıs4.TabIndex = 30;
            this.btnCıkıs4.UseVisualStyleBackColor = true;
            this.btnCıkıs4.Click += new System.EventHandler(this.button1_Click);
            // 
            // AracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1122, 593);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.cbxSeri);
            this.Controls.Add(this.cbxMarka);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtKilometre);
            this.Controls.Add(this.txtKira);
            this.Controls.Add(this.cxbYakıt);
            this.Controls.Add(this.cxbDurumu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSill);
            this.Controls.Add(this.btnGuncellee);
            this.Controls.Add(this.btnCıkıs4);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AracListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracListele";
            this.Load += new System.EventHandler(this.AracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCıkıs4;
        private System.Windows.Forms.ImageList ımageList4;
        private System.Windows.Forms.Button btnGuncellee;
        private System.Windows.Forms.Button btnSill;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.ComboBox cbxSeri;
        private System.Windows.Forms.ComboBox cbxMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtKilometre;
        private System.Windows.Forms.TextBox txtKira;
        private System.Windows.Forms.ComboBox cxbYakıt;
        private System.Windows.Forms.ComboBox cxbDurumu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaka;
    }
}