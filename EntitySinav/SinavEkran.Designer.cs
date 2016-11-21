namespace EntitySinav
{
    partial class SinavEkran
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
            this.lbl_Soru = new System.Windows.Forms.Label();
            this.lbl_Konu = new System.Windows.Forms.Label();
            this.txt_cevap = new System.Windows.Forms.TextBox();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.lbl_kactayiz = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Soru
            // 
            this.lbl_Soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soru.Location = new System.Drawing.Point(36, 76);
            this.lbl_Soru.Name = "lbl_Soru";
            this.lbl_Soru.Size = new System.Drawing.Size(592, 125);
            this.lbl_Soru.TabIndex = 0;
            this.lbl_Soru.Text = "lbl_Soru";
            // 
            // lbl_Konu
            // 
            this.lbl_Konu.AutoSize = true;
            this.lbl_Konu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Konu.Location = new System.Drawing.Point(31, 9);
            this.lbl_Konu.Name = "lbl_Konu";
            this.lbl_Konu.Size = new System.Drawing.Size(108, 29);
            this.lbl_Konu.TabIndex = 1;
            this.lbl_Konu.Text = "lbl_Konu";
            // 
            // txt_cevap
            // 
            this.txt_cevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_cevap.Location = new System.Drawing.Point(41, 249);
            this.txt_cevap.Name = "txt_cevap";
            this.txt_cevap.Size = new System.Drawing.Size(587, 35);
            this.txt_cevap.TabIndex = 2;
            // 
            // btn_ileri
            // 
            this.btn_ileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ileri.Location = new System.Drawing.Point(506, 348);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(125, 60);
            this.btn_ileri.TabIndex = 3;
            this.btn_ileri.Text = "İleri >>";
            this.btn_ileri.UseVisualStyleBackColor = true;
            this.btn_ileri.Click += new System.EventHandler(this.btn_ileri_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(41, 348);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(125, 60);
            this.btn_geri.TabIndex = 3;
            this.btn_geri.Text = "<< Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // lbl_kactayiz
            // 
            this.lbl_kactayiz.AutoSize = true;
            this.lbl_kactayiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kactayiz.Location = new System.Drawing.Point(501, 19);
            this.lbl_kactayiz.Name = "lbl_kactayiz";
            this.lbl_kactayiz.Size = new System.Drawing.Size(136, 29);
            this.lbl_kactayiz.TabIndex = 4;
            this.lbl_kactayiz.Text = "lbl_kactayiz";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(437, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "bitir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SinavEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_kactayiz);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.txt_cevap);
            this.Controls.Add(this.lbl_Konu);
            this.Controls.Add(this.lbl_Soru);
            this.Name = "SinavEkran";
            this.Text = "SinavEkran";
            this.Load += new System.EventHandler(this.SinavEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Soru;
        private System.Windows.Forms.Label lbl_Konu;
        private System.Windows.Forms.TextBox txt_cevap;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label lbl_kactayiz;
        private System.Windows.Forms.Button button1;
    }
}