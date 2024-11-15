namespace Panel_C_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kln_lbl = new System.Windows.Forms.Label();
            this.kln_txt = new System.Windows.Forms.TextBox();
            this.baslat_btn = new System.Windows.Forms.Button();
            this.sfr_txt = new System.Windows.Forms.TextBox();
            this.sfr_lbl = new System.Windows.Forms.Label();
            this.syc_lbl = new System.Windows.Forms.Label();
            this.ana_btn = new System.Windows.Forms.Button();
            this.msj_btn = new System.Windows.Forms.Button();
            this.bgn_btn = new System.Windows.Forms.Button();
            this.yrm_btn = new System.Windows.Forms.Button();
            this.msj_txt = new System.Windows.Forms.TextBox();
            this.msj_chkbox = new System.Windows.Forms.CheckedListBox();
            this.yrm_ekl_btn = new System.Windows.Forms.Button();
            this.insta_txt = new System.Windows.Forms.TextBox();
            this.insta_lbl = new System.Windows.Forms.Label();
            this.tkp_btn = new System.Windows.Forms.Button();
            this.gnd_cmbbox = new System.Windows.Forms.ComboBox();
            this.yrm_tmz_btn = new System.Windows.Forms.Button();
            this.yrm_ckr_btn = new System.Windows.Forms.Button();
            this.yrm_syc_txt = new System.Windows.Forms.TextBox();
            this.yrm_syc_lbl = new System.Windows.Forms.Label();
            this.yrm_syc_chk = new System.Windows.Forms.CheckBox();
            this.kyt_btn = new System.Windows.Forms.Button();
            this.bgn_ckb = new System.Windows.Forms.CheckBox();
            this.yrm_ckb = new System.Windows.Forms.CheckBox();
            this.tkp_ckb = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kln_lbl
            // 
            this.kln_lbl.AutoSize = true;
            this.kln_lbl.ForeColor = System.Drawing.Color.White;
            this.kln_lbl.Location = new System.Drawing.Point(12, 9);
            this.kln_lbl.Name = "kln_lbl";
            this.kln_lbl.Size = new System.Drawing.Size(83, 13);
            this.kln_lbl.TabIndex = 0;
            this.kln_lbl.Text = "KULLANICI ADI";
            // 
            // kln_txt
            // 
            this.kln_txt.Location = new System.Drawing.Point(12, 25);
            this.kln_txt.Multiline = true;
            this.kln_txt.Name = "kln_txt";
            this.kln_txt.Size = new System.Drawing.Size(198, 286);
            this.kln_txt.TabIndex = 1;
            this.kln_txt.WordWrap = false;
            this.kln_txt.TextChanged += new System.EventHandler(this.kln_txt_TextChanged);
            // 
            // baslat_btn
            // 
            this.baslat_btn.BackColor = System.Drawing.Color.White;
            this.baslat_btn.FlatAppearance.BorderSize = 0;
            this.baslat_btn.Image = ((System.Drawing.Image)(resources.GetObject("baslat_btn.Image")));
            this.baslat_btn.Location = new System.Drawing.Point(12, 422);
            this.baslat_btn.Name = "baslat_btn";
            this.baslat_btn.Size = new System.Drawing.Size(201, 137);
            this.baslat_btn.TabIndex = 2;
            this.baslat_btn.Tag = "";
            this.baslat_btn.UseVisualStyleBackColor = false;
            this.baslat_btn.Click += new System.EventHandler(this.baslat_btn_Click);
            // 
            // sfr_txt
            // 
            this.sfr_txt.Location = new System.Drawing.Point(219, 25);
            this.sfr_txt.Multiline = true;
            this.sfr_txt.Name = "sfr_txt";
            this.sfr_txt.Size = new System.Drawing.Size(201, 286);
            this.sfr_txt.TabIndex = 3;
            this.sfr_txt.WordWrap = false;
            this.sfr_txt.TextChanged += new System.EventHandler(this.sfr_text_TextChanged);
            // 
            // sfr_lbl
            // 
            this.sfr_lbl.AutoSize = true;
            this.sfr_lbl.ForeColor = System.Drawing.Color.White;
            this.sfr_lbl.Location = new System.Drawing.Point(216, 9);
            this.sfr_lbl.Name = "sfr_lbl";
            this.sfr_lbl.Size = new System.Drawing.Size(38, 13);
            this.sfr_lbl.TabIndex = 4;
            this.sfr_lbl.Text = "ŞİFRE";
            // 
            // syc_lbl
            // 
            this.syc_lbl.AutoSize = true;
            this.syc_lbl.Font = new System.Drawing.Font("MS Reference Specialty", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.syc_lbl.ForeColor = System.Drawing.Color.White;
            this.syc_lbl.Location = new System.Drawing.Point(12, 378);
            this.syc_lbl.Name = "syc_lbl";
            this.syc_lbl.Size = new System.Drawing.Size(0, 26);
            this.syc_lbl.TabIndex = 5;
            // 
            // ana_btn
            // 
            this.ana_btn.BackColor = System.Drawing.Color.LightGray;
            this.ana_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ana_btn.FlatAppearance.BorderSize = 0;
            this.ana_btn.Image = ((System.Drawing.Image)(resources.GetObject("ana_btn.Image")));
            this.ana_btn.Location = new System.Drawing.Point(462, 45);
            this.ana_btn.Name = "ana_btn";
            this.ana_btn.Size = new System.Drawing.Size(163, 62);
            this.ana_btn.TabIndex = 6;
            this.ana_btn.Tag = "";
            this.ana_btn.UseVisualStyleBackColor = false;
            this.ana_btn.Click += new System.EventHandler(this.ana_btn_Click);
            // 
            // msj_btn
            // 
            this.msj_btn.BackColor = System.Drawing.Color.White;
            this.msj_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.msj_btn.FlatAppearance.BorderSize = 0;
            this.msj_btn.Image = ((System.Drawing.Image)(resources.GetObject("msj_btn.Image")));
            this.msj_btn.Location = new System.Drawing.Point(462, 113);
            this.msj_btn.Name = "msj_btn";
            this.msj_btn.Size = new System.Drawing.Size(163, 62);
            this.msj_btn.TabIndex = 7;
            this.msj_btn.Tag = "";
            this.msj_btn.UseVisualStyleBackColor = false;
            this.msj_btn.Click += new System.EventHandler(this.msj_btn_Click);
            // 
            // bgn_btn
            // 
            this.bgn_btn.BackColor = System.Drawing.Color.White;
            this.bgn_btn.FlatAppearance.BorderSize = 0;
            this.bgn_btn.Image = ((System.Drawing.Image)(resources.GetObject("bgn_btn.Image")));
            this.bgn_btn.Location = new System.Drawing.Point(219, 422);
            this.bgn_btn.Name = "bgn_btn";
            this.bgn_btn.Size = new System.Drawing.Size(193, 45);
            this.bgn_btn.TabIndex = 8;
            this.bgn_btn.Tag = "";
            this.bgn_btn.UseVisualStyleBackColor = false;
            this.bgn_btn.Click += new System.EventHandler(this.bgn_btn_Click);
            // 
            // yrm_btn
            // 
            this.yrm_btn.BackColor = System.Drawing.Color.White;
            this.yrm_btn.FlatAppearance.BorderSize = 0;
            this.yrm_btn.Image = ((System.Drawing.Image)(resources.GetObject("yrm_btn.Image")));
            this.yrm_btn.Location = new System.Drawing.Point(219, 467);
            this.yrm_btn.Name = "yrm_btn";
            this.yrm_btn.Size = new System.Drawing.Size(193, 45);
            this.yrm_btn.TabIndex = 9;
            this.yrm_btn.Tag = "";
            this.yrm_btn.UseVisualStyleBackColor = false;
            this.yrm_btn.Click += new System.EventHandler(this.yrm_btn_Click);
            // 
            // msj_txt
            // 
            this.msj_txt.Location = new System.Drawing.Point(12, 19);
            this.msj_txt.Name = "msj_txt";
            this.msj_txt.Size = new System.Drawing.Size(304, 20);
            this.msj_txt.TabIndex = 10;
            this.msj_txt.Visible = false;
            // 
            // msj_chkbox
            // 
            this.msj_chkbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msj_chkbox.FormattingEnabled = true;
            this.msj_chkbox.HorizontalScrollbar = true;
            this.msj_chkbox.Location = new System.Drawing.Point(12, 45);
            this.msj_chkbox.Name = "msj_chkbox";
            this.msj_chkbox.Size = new System.Drawing.Size(417, 499);
            this.msj_chkbox.TabIndex = 11;
            this.msj_chkbox.Visible = false;
            // 
            // yrm_ekl_btn
            // 
            this.yrm_ekl_btn.BackColor = System.Drawing.Color.White;
            this.yrm_ekl_btn.Location = new System.Drawing.Point(332, 19);
            this.yrm_ekl_btn.Name = "yrm_ekl_btn";
            this.yrm_ekl_btn.Size = new System.Drawing.Size(97, 20);
            this.yrm_ekl_btn.TabIndex = 12;
            this.yrm_ekl_btn.Text = "EKLE";
            this.yrm_ekl_btn.UseVisualStyleBackColor = false;
            this.yrm_ekl_btn.Visible = false;
            this.yrm_ekl_btn.Click += new System.EventHandler(this.yrm_ekl_btn_Click_1);
            // 
            // insta_txt
            // 
            this.insta_txt.Location = new System.Drawing.Point(12, 342);
            this.insta_txt.Name = "insta_txt";
            this.insta_txt.Size = new System.Drawing.Size(408, 20);
            this.insta_txt.TabIndex = 13;
            // 
            // insta_lbl
            // 
            this.insta_lbl.AutoSize = true;
            this.insta_lbl.ForeColor = System.Drawing.Color.White;
            this.insta_lbl.Location = new System.Drawing.Point(9, 326);
            this.insta_lbl.Name = "insta_lbl";
            this.insta_lbl.Size = new System.Drawing.Size(0, 13);
            this.insta_lbl.TabIndex = 14;
            // 
            // tkp_btn
            // 
            this.tkp_btn.BackColor = System.Drawing.Color.White;
            this.tkp_btn.Image = ((System.Drawing.Image)(resources.GetObject("tkp_btn.Image")));
            this.tkp_btn.Location = new System.Drawing.Point(219, 514);
            this.tkp_btn.Name = "tkp_btn";
            this.tkp_btn.Size = new System.Drawing.Size(193, 45);
            this.tkp_btn.TabIndex = 15;
            this.tkp_btn.Tag = "";
            this.tkp_btn.UseVisualStyleBackColor = false;
            this.tkp_btn.Click += new System.EventHandler(this.tkp_btn_Click);
            // 
            // gnd_cmbbox
            // 
            this.gnd_cmbbox.FormattingEnabled = true;
            this.gnd_cmbbox.Items.AddRange(new object[] {
            "En son gönderiyi seç",
            "Girilen URL\'den seç"});
            this.gnd_cmbbox.Location = new System.Drawing.Point(219, 318);
            this.gnd_cmbbox.Name = "gnd_cmbbox";
            this.gnd_cmbbox.Size = new System.Drawing.Size(161, 21);
            this.gnd_cmbbox.TabIndex = 16;
            this.gnd_cmbbox.Text = "Nasıl Girileceğini Seçin";
            this.gnd_cmbbox.SelectedIndexChanged += new System.EventHandler(this.gnd_cmbbox_SelectedIndexChanged);
            // 
            // yrm_tmz_btn
            // 
            this.yrm_tmz_btn.BackColor = System.Drawing.Color.White;
            this.yrm_tmz_btn.Location = new System.Drawing.Point(538, 19);
            this.yrm_tmz_btn.Name = "yrm_tmz_btn";
            this.yrm_tmz_btn.Size = new System.Drawing.Size(117, 20);
            this.yrm_tmz_btn.TabIndex = 17;
            this.yrm_tmz_btn.Text = "TÜMÜNÜ TEMİZLE";
            this.yrm_tmz_btn.UseVisualStyleBackColor = false;
            this.yrm_tmz_btn.Visible = false;
            this.yrm_tmz_btn.Click += new System.EventHandler(this.yrm_tmz_btn_Click);
            // 
            // yrm_ckr_btn
            // 
            this.yrm_ckr_btn.BackColor = System.Drawing.Color.White;
            this.yrm_ckr_btn.Location = new System.Drawing.Point(435, 19);
            this.yrm_ckr_btn.Name = "yrm_ckr_btn";
            this.yrm_ckr_btn.Size = new System.Drawing.Size(97, 20);
            this.yrm_ckr_btn.TabIndex = 18;
            this.yrm_ckr_btn.Text = "ÇIKAR";
            this.yrm_ckr_btn.UseVisualStyleBackColor = false;
            this.yrm_ckr_btn.Visible = false;
            this.yrm_ckr_btn.Click += new System.EventHandler(this.yrm_ckr_btn_Click);
            // 
            // yrm_syc_txt
            // 
            this.yrm_syc_txt.Location = new System.Drawing.Point(418, 482);
            this.yrm_syc_txt.Name = "yrm_syc_txt";
            this.yrm_syc_txt.Size = new System.Drawing.Size(61, 20);
            this.yrm_syc_txt.TabIndex = 20;
            this.yrm_syc_txt.Visible = false;
            // 
            // yrm_syc_lbl
            // 
            this.yrm_syc_lbl.AutoSize = true;
            this.yrm_syc_lbl.ForeColor = System.Drawing.Color.White;
            this.yrm_syc_lbl.Location = new System.Drawing.Point(415, 465);
            this.yrm_syc_lbl.Name = "yrm_syc_lbl";
            this.yrm_syc_lbl.Size = new System.Drawing.Size(0, 13);
            this.yrm_syc_lbl.TabIndex = 21;
            this.yrm_syc_lbl.Visible = false;
            // 
            // yrm_syc_chk
            // 
            this.yrm_syc_chk.AutoSize = true;
            this.yrm_syc_chk.ForeColor = System.Drawing.Color.White;
            this.yrm_syc_chk.Location = new System.Drawing.Point(485, 485);
            this.yrm_syc_chk.Name = "yrm_syc_chk";
            this.yrm_syc_chk.Size = new System.Drawing.Size(58, 17);
            this.yrm_syc_chk.TabIndex = 22;
            this.yrm_syc_chk.Text = "HEPSİ";
            this.yrm_syc_chk.UseVisualStyleBackColor = true;
            this.yrm_syc_chk.Visible = false;
            this.yrm_syc_chk.CheckedChanged += new System.EventHandler(this.yrm_syc_chk_CheckedChanged);
            // 
            // kyt_btn
            // 
            this.kyt_btn.BackColor = System.Drawing.Color.White;
            this.kyt_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.kyt_btn.FlatAppearance.BorderSize = 0;
            this.kyt_btn.Image = ((System.Drawing.Image)(resources.GetObject("kyt_btn.Image")));
            this.kyt_btn.Location = new System.Drawing.Point(462, 181);
            this.kyt_btn.Name = "kyt_btn";
            this.kyt_btn.Size = new System.Drawing.Size(163, 62);
            this.kyt_btn.TabIndex = 23;
            this.kyt_btn.Tag = "";
            this.kyt_btn.UseVisualStyleBackColor = false;
            this.kyt_btn.Click += new System.EventHandler(this.kyt_btn_Click);
            // 
            // bgn_ckb
            // 
            this.bgn_ckb.AutoSize = true;
            this.bgn_ckb.Location = new System.Drawing.Point(219, 422);
            this.bgn_ckb.Name = "bgn_ckb";
            this.bgn_ckb.Size = new System.Drawing.Size(15, 14);
            this.bgn_ckb.TabIndex = 24;
            this.bgn_ckb.UseVisualStyleBackColor = true;
            // 
            // yrm_ckb
            // 
            this.yrm_ckb.AutoSize = true;
            this.yrm_ckb.Location = new System.Drawing.Point(219, 467);
            this.yrm_ckb.Name = "yrm_ckb";
            this.yrm_ckb.Size = new System.Drawing.Size(15, 14);
            this.yrm_ckb.TabIndex = 25;
            this.yrm_ckb.UseVisualStyleBackColor = true;
            // 
            // tkp_ckb
            // 
            this.tkp_ckb.AutoSize = true;
            this.tkp_ckb.Location = new System.Drawing.Point(219, 514);
            this.tkp_ckb.Name = "tkp_ckb";
            this.tkp_ckb.Size = new System.Drawing.Size(15, 14);
            this.tkp_ckb.TabIndex = 26;
            this.tkp_ckb.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(462, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 62);
            this.button1.TabIndex = 27;
            this.button1.Tag = "";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(667, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tkp_ckb);
            this.Controls.Add(this.yrm_ckb);
            this.Controls.Add(this.bgn_ckb);
            this.Controls.Add(this.kyt_btn);
            this.Controls.Add(this.yrm_syc_chk);
            this.Controls.Add(this.yrm_syc_lbl);
            this.Controls.Add(this.yrm_syc_txt);
            this.Controls.Add(this.yrm_tmz_btn);
            this.Controls.Add(this.yrm_ckr_btn);
            this.Controls.Add(this.gnd_cmbbox);
            this.Controls.Add(this.tkp_btn);
            this.Controls.Add(this.insta_lbl);
            this.Controls.Add(this.insta_txt);
            this.Controls.Add(this.yrm_btn);
            this.Controls.Add(this.bgn_btn);
            this.Controls.Add(this.msj_btn);
            this.Controls.Add(this.ana_btn);
            this.Controls.Add(this.syc_lbl);
            this.Controls.Add(this.sfr_lbl);
            this.Controls.Add(this.sfr_txt);
            this.Controls.Add(this.baslat_btn);
            this.Controls.Add(this.kln_txt);
            this.Controls.Add(this.kln_lbl);
            this.Controls.Add(this.msj_chkbox);
            this.Controls.Add(this.msj_txt);
            this.Controls.Add(this.yrm_ekl_btn);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kln_lbl;
        private System.Windows.Forms.TextBox kln_txt;
        private System.Windows.Forms.Button baslat_btn;
        private System.Windows.Forms.TextBox sfr_txt;
        private System.Windows.Forms.Label sfr_lbl;
        private System.Windows.Forms.Label syc_lbl;
        private System.Windows.Forms.Button bgn_btn;
        private System.Windows.Forms.Button yrm_btn;
        public System.Windows.Forms.Button ana_btn;
        public System.Windows.Forms.Button msj_btn;
        private System.Windows.Forms.TextBox msj_txt;
        private System.Windows.Forms.CheckedListBox msj_chkbox;
        public System.Windows.Forms.Button yrm_ekl_btn;
        private System.Windows.Forms.TextBox insta_txt;
        private System.Windows.Forms.Label insta_lbl;
        private System.Windows.Forms.Button tkp_btn;
        private System.Windows.Forms.ComboBox gnd_cmbbox;
        public System.Windows.Forms.Button yrm_tmz_btn;
        public System.Windows.Forms.Button yrm_ckr_btn;
        private System.Windows.Forms.TextBox yrm_syc_txt;
        private System.Windows.Forms.Label yrm_syc_lbl;
        private System.Windows.Forms.CheckBox yrm_syc_chk;
        public System.Windows.Forms.Button kyt_btn;
        private System.Windows.Forms.CheckBox bgn_ckb;
        private System.Windows.Forms.CheckBox yrm_ckb;
        private System.Windows.Forms.CheckBox tkp_ckb;
        public System.Windows.Forms.Button button1;
    }
}

