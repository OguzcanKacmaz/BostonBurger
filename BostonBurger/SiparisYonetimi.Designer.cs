namespace BostonBurger
{
    partial class SiparisYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisYonetimi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lbxMenu = new System.Windows.Forms.ListBox();
            this.btnSiparisOnayla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.pnlMalzeme = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbMenu
            // 
            this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(16, 377);
            this.cmbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(452, 36);
            this.cmbMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menü Seçin : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boyut Seçiniz : ";
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Checked = true;
            this.rbKucuk.Location = new System.Drawing.Point(16, 474);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(86, 32);
            this.rbKucuk.TabIndex = 4;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(207, 474);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(72, 32);
            this.rbOrta.TabIndex = 4;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(382, 474);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(86, 32);
            this.rbBuyuk.TabIndex = 4;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Malzeme Seçiniz : ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 805);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "ADET : ";
            // 
            // nudAdet
            // 
            this.nudAdet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudAdet.Location = new System.Drawing.Point(102, 803);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(4);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(148, 34);
            this.nudAdet.TabIndex = 7;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(16, 845);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sipariş Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxMenu
            // 
            this.lbxMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxMenu.FormattingEnabled = true;
            this.lbxMenu.HorizontalExtent = 500;
            this.lbxMenu.HorizontalScrollbar = true;
            this.lbxMenu.ItemHeight = 28;
            this.lbxMenu.Location = new System.Drawing.Point(515, 17);
            this.lbxMenu.Name = "lbxMenu";
            this.lbxMenu.Size = new System.Drawing.Size(707, 760);
            this.lbxMenu.TabIndex = 9;
            this.lbxMenu.SelectedIndexChanged += new System.EventHandler(this.lbxMenu_SelectedIndexChanged);
            // 
            // btnSiparisOnayla
            // 
            this.btnSiparisOnayla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisOnayla.Location = new System.Drawing.Point(928, 835);
            this.btnSiparisOnayla.Name = "btnSiparisOnayla";
            this.btnSiparisOnayla.Size = new System.Drawing.Size(208, 53);
            this.btnSiparisOnayla.TabIndex = 10;
            this.btnSiparisOnayla.Text = "Siparişi Onayla";
            this.btnSiparisOnayla.UseVisualStyleBackColor = true;
            this.btnSiparisOnayla.Click += new System.EventHandler(this.btnSiparisOnayla_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(586, 845);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Toplam Tutar : ";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToplamTutar.Location = new System.Drawing.Point(760, 845);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(71, 32);
            this.lblToplamTutar.TabIndex = 12;
            this.lblToplamTutar.Text = "₺0.00";
            // 
            // pnlMalzeme
            // 
            this.pnlMalzeme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMalzeme.AutoScroll = true;
            this.pnlMalzeme.Location = new System.Drawing.Point(12, 558);
            this.pnlMalzeme.Name = "pnlMalzeme";
            this.pnlMalzeme.Size = new System.Drawing.Size(456, 218);
            this.pnlMalzeme.TabIndex = 13;
            // 
            // SiparisYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 910);
            this.Controls.Add(this.pnlMalzeme);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSiparisOnayla);
            this.Controls.Add(this.lbxMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbBuyuk);
            this.Controls.Add(this.rbOrta);
            this.Controls.Add(this.rbKucuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SiparisYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparis Yonetimi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SiparisYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cmbMenu;
        private Label label1;
        private Label label2;
        private RadioButton rbKucuk;
        private RadioButton rbOrta;
        private RadioButton rbBuyuk;
        private Label label3;
        private Label label4;
        private NumericUpDown nudAdet;
        private Button button1;
        private ListBox lbxMenu;
        private Button btnSiparisOnayla;
        private Label label5;
        private Label lblToplamTutar;
        private Panel pnlMalzeme;
    }
}