namespace BostonBurger
{
    partial class MalzemeYonetimi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.nudMalzemeFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnekstraMalzemeEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMalzemeFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ekstra Malzeme Adı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(171, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyatı : ";
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(258, 119);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(253, 27);
            this.txtMalzemeAdi.TabIndex = 3;
            // 
            // nudMalzemeFiyat
            // 
            this.nudMalzemeFiyat.Location = new System.Drawing.Point(258, 177);
            this.nudMalzemeFiyat.Name = "nudMalzemeFiyat";
            this.nudMalzemeFiyat.Size = new System.Drawing.Size(253, 27);
            this.nudMalzemeFiyat.TabIndex = 4;
            // 
            // btnekstraMalzemeEkle
            // 
            this.btnekstraMalzemeEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnekstraMalzemeEkle.Location = new System.Drawing.Point(258, 220);
            this.btnekstraMalzemeEkle.Name = "btnekstraMalzemeEkle";
            this.btnekstraMalzemeEkle.Size = new System.Drawing.Size(253, 47);
            this.btnekstraMalzemeEkle.TabIndex = 5;
            this.btnekstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.btnekstraMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnekstraMalzemeEkle.Click += new System.EventHandler(this.btnekstraMalzemeEkle_Click);
            // 
            // MalzemeYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 317);
            this.Controls.Add(this.btnekstraMalzemeEkle);
            this.Controls.Add(this.nudMalzemeFiyat);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MalzemeYonetimi";
            this.Text = "MalzemeYonetimi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudMalzemeFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMalzemeAdi;
        private NumericUpDown nudMalzemeFiyat;
        private Button btnekstraMalzemeEkle;
    }
}