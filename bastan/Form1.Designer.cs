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
            this.Txb_Dosyayolu2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_J48 = new System.Windows.Forms.Button();
            this.Btn_Lineer = new System.Windows.Forms.Button();
            this.Btn_DosyaSec2 = new System.Windows.Forms.Button();
            this.Txt_MSE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_DosyaSec3 = new System.Windows.Forms.Button();
            this.Btn_Hata = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğretilecek dosyayı(train.csv) Seçin";
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
            this.Btn_Veriduzelt.Location = new System.Drawing.Point(184, 142);
            this.Btn_Veriduzelt.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Veriduzelt.Name = "Btn_Veriduzelt";
            this.Btn_Veriduzelt.Size = new System.Drawing.Size(106, 53);
            this.Btn_Veriduzelt.TabIndex = 6;
            this.Btn_Veriduzelt.Text = "Katsayı değişkenlerini hesapla";
            this.Btn_Veriduzelt.UseVisualStyleBackColor = true;
            this.Btn_Veriduzelt.Click += new System.EventHandler(this.Btn_Veriduzelt_Click);
            // 
            // Txb_Dosyayolu2
            // 
            this.Txb_Dosyayolu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txb_Dosyayolu2.Location = new System.Drawing.Point(59, 269);
            this.Txb_Dosyayolu2.Multiline = true;
            this.Txb_Dosyayolu2.Name = "Txb_Dosyayolu2";
            this.Txb_Dosyayolu2.Size = new System.Drawing.Size(216, 40);
            this.Txb_Dosyayolu2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(59, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fiyat Hesaplanacak dosyayı seçiniz";
            // 
            // Btn_J48
            // 
            this.Btn_J48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_J48.Location = new System.Drawing.Point(184, 393);
            this.Btn_J48.Name = "Btn_J48";
            this.Btn_J48.Size = new System.Drawing.Size(86, 53);
            this.Btn_J48.TabIndex = 9;
            this.Btn_J48.Text = "Basit Regresyon-J48";
            this.Btn_J48.UseVisualStyleBackColor = true;
            this.Btn_J48.Click += new System.EventHandler(this.Btn_J48_Click);
            // 
            // Btn_Lineer
            // 
            this.Btn_Lineer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Lineer.Location = new System.Drawing.Point(62, 393);
            this.Btn_Lineer.Name = "Btn_Lineer";
            this.Btn_Lineer.Size = new System.Drawing.Size(75, 53);
            this.Btn_Lineer.TabIndex = 10;
            this.Btn_Lineer.Text = "Lineer Regresyon";
            this.Btn_Lineer.UseVisualStyleBackColor = true;
            this.Btn_Lineer.Click += new System.EventHandler(this.Btn_Lineer_Click);
            // 
            // Btn_DosyaSec2
            // 
            this.Btn_DosyaSec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_DosyaSec2.Location = new System.Drawing.Point(59, 332);
            this.Btn_DosyaSec2.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_DosyaSec2.Name = "Btn_DosyaSec2";
            this.Btn_DosyaSec2.Size = new System.Drawing.Size(86, 28);
            this.Btn_DosyaSec2.TabIndex = 11;
            this.Btn_DosyaSec2.Text = "Dosya Seç";
            this.Btn_DosyaSec2.UseVisualStyleBackColor = true;
            this.Btn_DosyaSec2.Click += new System.EventHandler(this.Btn_DosyaSec2_Click);
            // 
            // Txt_MSE
            // 
            this.Txt_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_MSE.Location = new System.Drawing.Point(59, 528);
            this.Txt_MSE.Multiline = true;
            this.Txt_MSE.Name = "Txt_MSE";
            this.Txt_MSE.Size = new System.Drawing.Size(216, 46);
            this.Txt_MSE.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(62, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "MSE için dosyayı seçiniz";
            // 
            // Btn_DosyaSec3
            // 
            this.Btn_DosyaSec3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_DosyaSec3.Location = new System.Drawing.Point(62, 597);
            this.Btn_DosyaSec3.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_DosyaSec3.Name = "Btn_DosyaSec3";
            this.Btn_DosyaSec3.Size = new System.Drawing.Size(86, 28);
            this.Btn_DosyaSec3.TabIndex = 14;
            this.Btn_DosyaSec3.Text = "Dosya Seç";
            this.Btn_DosyaSec3.UseVisualStyleBackColor = true;
            this.Btn_DosyaSec3.Click += new System.EventHandler(this.Btn_DosyaSec3_Click);
            // 
            // Btn_Hata
            // 
            this.Btn_Hata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Hata.Location = new System.Drawing.Point(195, 601);
            this.Btn_Hata.Name = "Btn_Hata";
            this.Btn_Hata.Size = new System.Drawing.Size(75, 38);
            this.Btn_Hata.TabIndex = 15;
            this.Btn_Hata.Text = "Hata Hesapla";
            this.Btn_Hata.UseVisualStyleBackColor = true;
            this.Btn_Hata.Click += new System.EventHandler(this.Btn_Hata_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hata Değeri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 615);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 651);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Hata);
            this.Controls.Add(this.Btn_DosyaSec3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_MSE);
            this.Controls.Add(this.Btn_DosyaSec2);
            this.Controls.Add(this.Btn_Lineer);
            this.Controls.Add(this.Btn_J48);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_Dosyayolu2);
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
        private System.Windows.Forms.TextBox Txb_Dosyayolu2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_J48;
        private System.Windows.Forms.Button Btn_Lineer;
        private System.Windows.Forms.Button Btn_DosyaSec2;
        private System.Windows.Forms.TextBox Txt_MSE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_DosyaSec3;
        private System.Windows.Forms.Button Btn_Hata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

