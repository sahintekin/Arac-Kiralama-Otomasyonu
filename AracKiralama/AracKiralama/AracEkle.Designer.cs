namespace AracKiralama
{
    partial class AracEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracEkle));
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnCıkıs3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cxbDurumu = new System.Windows.Forms.ComboBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.cxbYakıt = new System.Windows.Forms.ComboBox();
            this.txtKira = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cbxMarka = new System.Windows.Forms.ComboBox();
            this.cbxSeri = new System.Windows.Forms.ComboBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "çıkış2.png");
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.BackColor = System.Drawing.Color.White;
            this.btnAracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracEkle.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAracEkle.Location = new System.Drawing.Point(174, 463);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(105, 63);
            this.btnAracEkle.TabIndex = 21;
            this.btnAracEkle.Text = "Kaydet";
            this.btnAracEkle.UseVisualStyleBackColor = false;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnCıkıs3
            // 
            this.btnCıkıs3.ImageKey = "çıkış2.png";
            this.btnCıkıs3.ImageList = this.ımageList3;
            this.btnCıkıs3.Location = new System.Drawing.Point(465, 3);
            this.btnCıkıs3.Name = "btnCıkıs3";
            this.btnCıkıs3.Size = new System.Drawing.Size(60, 40);
            this.btnCıkıs3.TabIndex = 20;
            this.btnCıkıs3.UseVisualStyleBackColor = true;
            this.btnCıkıs3.Click += new System.EventHandler(this.btnCıkıs3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model(Yıl)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kilometre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Yakıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(24, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kira Ücreti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(24, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Durumu";
            // 
            // cxbDurumu
            // 
            this.cxbDurumu.FormattingEnabled = true;
            this.cxbDurumu.Items.AddRange(new object[] {
            "Bos",
            "Dolu"});
            this.cxbDurumu.Location = new System.Drawing.Point(185, 415);
            this.cxbDurumu.Name = "cxbDurumu";
            this.cxbDurumu.Size = new System.Drawing.Size(121, 24);
            this.cxbDurumu.TabIndex = 22;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(185, 229);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(121, 22);
            this.txtRenk.TabIndex = 33;
            // 
            // cxbYakıt
            // 
            this.cxbYakıt.FormattingEnabled = true;
            this.cxbYakıt.Items.AddRange(new object[] {
            "Elektrik",
            "Benzin",
            "Dizel"});
            this.cxbYakıt.Location = new System.Drawing.Point(185, 321);
            this.cxbYakıt.Name = "cxbYakıt";
            this.cxbYakıt.Size = new System.Drawing.Size(121, 24);
            this.cxbYakıt.TabIndex = 25;
            // 
            // txtKira
            // 
            this.txtKira.Location = new System.Drawing.Point(185, 370);
            this.txtKira.Name = "txtKira";
            this.txtKira.Size = new System.Drawing.Size(121, 22);
            this.txtKira.TabIndex = 26;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(185, 276);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(121, 22);
            this.txtKm.TabIndex = 27;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(185, 182);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 22);
            this.txtModel.TabIndex = 30;
            // 
            // cbxMarka
            // 
            this.cbxMarka.FormattingEnabled = true;
            this.cbxMarka.Items.AddRange(new object[] {
            "Lamborghini",
            "Toog",
            "Mercedes",
            "Porsche"});
            this.cbxMarka.Location = new System.Drawing.Point(185, 86);
            this.cbxMarka.Name = "cbxMarka";
            this.cbxMarka.Size = new System.Drawing.Size(121, 24);
            this.cbxMarka.TabIndex = 31;
            this.cbxMarka.SelectedIndexChanged += new System.EventHandler(this.cbxMarka_SelectedIndexChanged);
            // 
            // cbxSeri
            // 
            this.cbxSeri.FormattingEnabled = true;
            this.cbxSeri.Location = new System.Drawing.Point(185, 133);
            this.cbxSeri.Name = "cbxSeri";
            this.cbxSeri.Size = new System.Drawing.Size(121, 24);
            this.cbxSeri.TabIndex = 32;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(185, 39);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(121, 22);
            this.txtPlaka.TabIndex = 34;
            this.txtPlaka.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtPlaka_MouseDoubleClick);
            // 
            // AracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(525, 568);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.cbxSeri);
            this.Controls.Add(this.cbxMarka);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtKira);
            this.Controls.Add(this.cxbYakıt);
            this.Controls.Add(this.cxbDurumu);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnCıkıs3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AracEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCıkıs3;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cxbDurumu;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.ComboBox cxbYakıt;
        private System.Windows.Forms.TextBox txtKira;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cbxMarka;
        private System.Windows.Forms.ComboBox cbxSeri;
        private System.Windows.Forms.TextBox txtPlaka;
    }
}