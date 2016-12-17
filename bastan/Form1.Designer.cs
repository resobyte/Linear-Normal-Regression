namespace bastan
{
    partial class Form1
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
            this.Txb_Dosyayolu = new System.Windows.Forms.TextBox();
            this.Btn_DosyaSec = new System.Windows.Forms.Button();
            this.Btn_Veriduzelt = new System.Windows.Forms.Button();
            this.Btn_satirsutunsayisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txb_satirsayisi = new System.Windows.Forms.TextBox();
            this.Txb_sutunsayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dosya Seçin";
            // 
            // Txb_Dosyayolu
            // 
            this.Txb_Dosyayolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txb_Dosyayolu.Location = new System.Drawing.Point(59, 67);
            this.Txb_Dosyayolu.Margin = new System.Windows.Forms.Padding(2);
            this.Txb_Dosyayolu.Multiline = true;
            this.Txb_Dosyayolu.Name = "Txb_Dosyayolu";
            this.Txb_Dosyayolu.Size = new System.Drawing.Size(216, 43);
            this.Txb_Dosyayolu.TabIndex = 4;
            // 
            // Btn_DosyaSec
            // 
            this.Btn_DosyaSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_DosyaSec.Location = new System.Drawing.Point(59, 142);
            this.Btn_DosyaSec.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_DosyaSec.Name = "Btn_DosyaSec";
            this.Btn_DosyaSec.Size = new System.Drawing.Size(86, 28);
            this.Btn_DosyaSec.TabIndex = 5;
            this.Btn_DosyaSec.Text = "Dosya Seç";
            this.Btn_DosyaSec.UseVisualStyleBackColor = true;
            this.Btn_DosyaSec.Click += new System.EventHandler(this.Btn_DosyaSec_Click);
            // 
            // Btn_Veriduzelt
            // 
            this.Btn_Veriduzelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Veriduzelt.Location = new System.Drawing.Point(59, 206);
            this.Btn_Veriduzelt.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Veriduzelt.Name = "Btn_Veriduzelt";
            this.Btn_Veriduzelt.Size = new System.Drawing.Size(106, 35);
            this.Btn_Veriduzelt.TabIndex = 6;
            this.Btn_Veriduzelt.Text = "Verileri Düzelt";
            this.Btn_Veriduzelt.UseVisualStyleBackColor = true;
            this.Btn_Veriduzelt.Click += new System.EventHandler(this.Btn_Veriduzelt_Click);
            // 
            // Btn_satirsutunsayisi
            // 
            this.Btn_satirsutunsayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_satirsutunsayisi.Location = new System.Drawing.Point(59, 269);
            this.Btn_satirsutunsayisi.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_satirsutunsayisi.Name = "Btn_satirsutunsayisi";
            this.Btn_satirsutunsayisi.Size = new System.Drawing.Size(104, 50);
            this.Btn_satirsutunsayisi.TabIndex = 7;
            this.Btn_satirsutunsayisi.Text = "Satır-Sutun Sayılarını Bul";
            this.Btn_satirsutunsayisi.UseVisualStyleBackColor = true;
            this.Btn_satirsutunsayisi.Click += new System.EventHandler(this.Btn_satirsutunsayisi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(221, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Satır Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(221, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sütün Sayısı";
            // 
            // Txb_satirsayisi
            // 
            this.Txb_satirsayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txb_satirsayisi.Location = new System.Drawing.Point(321, 269);
            this.Txb_satirsayisi.Margin = new System.Windows.Forms.Padding(2);
            this.Txb_satirsayisi.Name = "Txb_satirsayisi";
            this.Txb_satirsayisi.Size = new System.Drawing.Size(56, 21);
            this.Txb_satirsayisi.TabIndex = 10;
            // 
            // Txb_sutunsayisi
            // 
            this.Txb_sutunsayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txb_sutunsayisi.Location = new System.Drawing.Point(321, 304);
            this.Txb_sutunsayisi.Margin = new System.Windows.Forms.Padding(2);
            this.Txb_sutunsayisi.Name = "Txb_sutunsayisi";
            this.Txb_sutunsayisi.Size = new System.Drawing.Size(56, 21);
            this.Txb_sutunsayisi.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 396);
            this.Controls.Add(this.Txb_sutunsayisi);
            this.Controls.Add(this.Txb_satirsayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_satirsutunsayisi);
            this.Controls.Add(this.Btn_Veriduzelt);
            this.Controls.Add(this.Btn_DosyaSec);
            this.Controls.Add(this.Txb_Dosyayolu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_Dosyayolu;
        private System.Windows.Forms.Button Btn_DosyaSec;
        private System.Windows.Forms.Button Btn_Veriduzelt;
        private System.Windows.Forms.Button Btn_satirsutunsayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txb_satirsayisi;
        private System.Windows.Forms.TextBox Txb_sutunsayisi;
    }
}

