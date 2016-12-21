using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bastan
{
   
    

    public partial class Form1 : Form
    {
        public class karsilastir
        {
            public string kelime;
            public int sayi;
        }
        public class genel_entropi
        {
            public String sayi;
            public int adet = 0;
            public double orani;
        }


        List<karsilastir> liste = new List<karsilastir>();
        List<genel_entropi> genel_e = new List<genel_entropi>();

        int say=1;
        float a;
        float b;
        double[] Y = new double[2000];
        double[] ID = new double[2000];
        public Form1()
        {
            InitializeComponent();
          
        }
        /*Dosya seçimi için filtreleme*/


        private void Btn_DosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop), // dosya seçici pencere masaüstünden başlıyor
                Filter = "Excel Dosyası | *.xlsx |Excel Dosyası |*.xls |Csv Dosyası| *.csv",
                FilterIndex = 3
            };

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = openfile.FileName;
                string DosyaAdi = openfile.SafeFileName;

                Txb_Dosyayolu.Text = DosyaYolu; // Ana sayfadaki txt_dosyayolu metin kutusuna dosya yolunu yaz
            }
        }

        /* değerin String mi sayısal değer olduğunu bulma*/
        public static bool IsNumeric(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }

        /*Seçilen Dosyayı Okuma*/
       
        
        /*Silinebilir*/
        private String[,] oku(string TextBox)
        {
            var dosyaOkuyucu = new StreamReader(File.OpenRead(TextBox));

            var satirSayisi = SatirSayisiBul(TextBox);
            var sutunSayisi = SutunSayisiBul(TextBox);

         //   double[,] sondizi = new double[satirSayisi - 1, sutunSayisi - 1];

            string[,] veriler = new string[(satirSayisi - 1), (sutunSayisi )];

            // Dosyanın sadece ilk satırının okunup, özellik adlarının ataması (dosyanın ilk satırını atla)
            var ilksatir = dosyaOkuyucu.ReadLine();
            var ozellikler = ilksatir.Split(',');

            /* NA lar değişecek ve dosyadaki sayı değerleri ile aynı olmayacak*/
            for (int i = 0; i < (satirSayisi - 1); i++) // satırları oku
            {

                var satir = dosyaOkuyucu.ReadLine(); // StreamReader nesnesi
                for (int j = 0; j < (sutunSayisi); j++) // sütunları oku
                {
                    var degerler = satir.Split(','); // satırdaki verileri virgüle göre ayır

                    /*iç for*/

                    veriler[i, j] = degerler[j];

                }
                /*dış for*/
            }
            return veriler;
            /*fonk bitis*/

        }

        /*silinebilir*/
        private String[,] siloku(string TextBox)
        {
            var dosyaOkuyucu = new StreamReader(File.OpenRead(TextBox));

            var satirSayisi = SatirSayisiBul(TextBox);
            var sutunSayisi = SutunSayisiBul(TextBox);

            //   double[,] sondizi = new double[satirSayisi - 1, sutunSayisi - 1];

            string[,] veriler = new string[(satirSayisi - 1), (sutunSayisi)];

            // Dosyanın sadece ilk satırının okunup, özellik adlarının ataması (dosyanın ilk satırını atla)
            var ilksatir = dosyaOkuyucu.ReadLine();
            var ozellikler = ilksatir.Split(',');


            /* NA lar değişecek ve dosyadaki sayı değerleri ile aynı olmayacak*/
            for (int i = 0; i < (satirSayisi - 1); i++) // satırları oku
            {
                
                var satir = dosyaOkuyucu.ReadLine();
                var de = satir.Replace('.', ',');
                // StreamReader nesnesi
                /*dış for*/
            }
            return veriler;
            /*fonk bitis*/

        }

        /*Stringleri int çevirme*/


        /*Silinebilir*/
        private string[,] veri_duzelt(String[,] veriler, string text)
        {
            int sayi_ata = 1;
            var satirSayisi = SatirSayisiBul(text);
            var sutunSayisi = SutunSayisiBul(text);
            for (int i = 0; i < (satirSayisi - 1); i++) //satır
            {
                for (int j = 1; j < (sutunSayisi); j++)
                {
                    karsilastir ata = new karsilastir();
                    int kontrol = 0;
                    if (IsNumeric(veriler[i, j]) == false && veriler[i, j] != "NA") //değer sayısal değilse
                    {
                        if (say != 1)
                        {
                            foreach (var dolas in liste)
                            {
                                if (String.Equals(dolas.kelime, veriler[i, j]) == true) /*okunan string ile class taki değerler karşılaşrıma eşit ise sayı otomatik olarak atanıyor*/
                                {
                                    sayi_ata = dolas.sayi;
                                    kontrol++;
                                    break;
                                }

                            }
                            if (kontrol == 0)/*classtaki stringler ile eşleşen yoksa yeni sayı atanıyor.*/
                            {
                                ata.kelime = veriler[i, j];


                                ata.sayi = say;
                                sayi_ata = say;
                                liste.Add(ata);
                                say++;
                            }
                        }

                        else
                        {

                            ata.kelime = veriler[i, j];

                            ata.sayi = say;
                            sayi_ata = say;
                            liste.Add(ata);
                            say++;
                        }
                        veriler[i, j] = sayi_ata.ToString();
                    }
                    else
                    {
                        veriler[i, j] = veriler[i, j];      // ayırılan değerleri matrise al
                    }



                }
            }
            int count = 0;
            int deger = 0;
            for (int i = 0; i < (satirSayisi - 1); i++)
            {
                for (int j = 1; j < (sutunSayisi - 2); j++)
                {
                    if (veriler[i, j] == "NA")//NA ları bulup ortalaması alınması için NA_ortalama fonk. yollandı.
                    {
                        if (count == 0)
                        {
                            count++;
                            deger = NA_ortalama(veriler, j, text);
                            veriler[i, j] = deger.ToString();
                        }
                        else
                        {
                            veriler[i, j] = deger.ToString();
                        }
                    }
                }
                count = 0;
            }

            return veriler;
        }


        /*NA ortalama */
        private int NA_ortalama(string[,] dizi, int sutun,string text)
        {
            int ortalama = 0;
            int toplam = 0;
            int adet = 0;
            int satirSayisi = SatirSayisiBul(text);


            for (int i = 0; i < satirSayisi - 1; i++)
            {
                for (int j = sutun; j < sutun + 1; j++)
                {
                    if (dizi[i, j] != "NA")
                    {
                        toplam += Convert.ToInt32(dizi[i, j]);
                        adet++;
                    }
                }

            }
            ortalama = toplam / adet;

            return ortalama;
        }
        
        /*Txt yazma*/
 
        private void yaz(String[,] veriler, string text)
        {
            string dosya_yolu = @"D:\Veri_Duzeltme.txt";

            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            int satirSayisi = SatirSayisiBul(text);
            int sutunSayisi = SutunSayisiBul(text);

            for (int i = 0; i < satirSayisi - 1; i++)
            {

                for (int j = 0; j < sutunSayisi ; j++)
                {
                    sw.Write(veriler[i, j] + ",");

                }
                sw.Write("\n");
            }

            sw.Flush();

            sw.Close();
            fs.Close();
        }

        #region Satır ve Sütun Sayılarını Bulan Fonksiyonların Tanımlamaları

        public int SutunSayisiBul(string text)
        {
            var lines = File.ReadAllLines(text);
            var sutunsayisi = lines[0].Split(',').Length;

            return sutunsayisi;
        }
        public int SatirSayisiBul(string text)
        {
            var lines = File.ReadAllLines(text);
            var satirsayisi = lines.Count();

            return satirsayisi;
        }
        #endregion

        private void Btn_Veriduzelt_Click(object sender, EventArgs e)
        {
            var iki = veri_duzelt(oku(Txb_Dosyayolu.Text), Txb_Dosyayolu.Text);
            yaz(iki,Txb_Dosyayolu.Text);
            lineer(iki);
            MessageBox.Show("Veri düzeltme başarıyla sonuçlandı.");

        }

        private void lineer(string[,] veriler)
        {
            int satir = SatirSayisiBul(Txb_Dosyayolu.Text) -1;
            int sutun = SutunSayisiBul(Txb_Dosyayolu.Text) ;

            int[] Xsatir = new int[satir];
            int Ytoplam = 0;
            int z = 0;
            for (int i = 0; i < satir; i++)
            {
                for (int j =1; j < sutun; j++)
                {
                    if (j == sutun - 1)
                    {
                        Ytoplam += Convert.ToInt32(veriler[i, j]);
                    }
                    else
                    {
                        z += Convert.ToInt32(veriler[i, j]);
                    }
                }
                Xsatir[i] = z;
                z = 0;

            }
            int xy = 0;
            int x2 = 0;


            int xtop = 0;

            for (int i = 0; i < satir; i++)
            {
                xy += Convert.ToInt32(Xsatir[i]) * Convert.ToInt32(veriler[i, sutun - 1]);
                x2 += Convert.ToInt32(Xsatir[i] * Xsatir[i]);
                xtop += Xsatir[i];
            }

            float yort = (float)(Ytoplam / satir);
            float oort = (float)(xtop / satir);

            b = (float)(xy - (satir * (oort) * yort)) / (x2 - (satir * (oort * oort)));
            a = (float)(yort - (b * oort));
            double[] denemey = new double[satir];

          

            for (int i = 0; i < satir; i++)
            {
                denemey[i] = (double)(a + (b * Xsatir[i]));

            }


        }

        private void Btn_DosyaSec2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop), // dosya seçici pencere masaüstünden başlıyor
                Filter = "Excel Dosyası | *.xlsx |Excel Dosyası |*.xls |Csv Dosyası| *.csv",
                FilterIndex = 3
            };

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = openfile.FileName;
                string DosyaAdi = openfile.SafeFileName;

                Txb_Dosyayolu2.Text = DosyaYolu; // Ana sayfadaki txt_dosyayolu metin kutusuna dosya yolunu yaz
            }
        }

        private void Btn_Lineer_Click(object sender, EventArgs e)
        {
            var dosya = veri_duzelt(oku(Txb_Dosyayolu2.Text),Txb_Dosyayolu2.Text);

            fiyatBelirleme(dosya,Txb_Dosyayolu2.Text);
            MessageBox.Show("Test düzeltme başarıyla sonuçlandı.");

            // yaz(dosya,Txb_Dosyayolu2.Text);
        }

        private void fiyatBelirleme(string [,] veriler,string text)
        {
            
            int satir = SatirSayisiBul(text)-1;
            int sutun = SutunSayisiBul(text)-1;
            int[] XTop = new int[satir];
           
            
            for(int i=0;i<satir;i++)
            {
                for(int j=1;j<sutun-1;j++)
                {
                    XTop[i] += Convert.ToInt32( veriler[i, j]);


                }
                Y[i] = (double)(a + (b * XTop[i]));
            }
            string dosya_yolu = @"D:\Lineer_Regresyon_Sonuc.txt";

            FileStream k = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter ya = new StreamWriter(k);
            for (int i = 0; i < satir; i++)
            {
                // ya.Write(" a: "+a+" b: "+b+" y :"+denemey[i]+"xsatr : "+Xsatir[i]+ "\n ");
                ID[i] = Convert.ToDouble(veriler[i, 0]);
                ya.Write( ID[i] + " -- " + Y[i] + Environment.NewLine);
               
            }
            ya.Flush();

            ya.Close();
            k.Close();


        }

        private void Mean_Square_Error(string [,] veriler,string text)
        {
            int satir = SatirSayisiBul(text)-1;
           
            double hata = 0;
            double toplam = 0;
            double a = 0;
            float toplam2 = 0;
            for(int i = 0;i< satir;i++)
            {
                a = Convert.ToDouble(veriler[i, 1]) - Convert.ToDouble(Y[i]);
                hata += a * a;

            }
            toplam = hata / satir;
            toplam2 =(float) (Math.Sqrt(toplam));
            MessageBox.Show("Hata Payı = " + toplam2.ToString());
            label5.Text = toplam2.ToString();
           

        }

        private void Btn_DosyaSec3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop), // dosya seçici pencere masaüstünden başlıyor
                Filter = "Excel Dosyası | *.xlsx |Excel Dosyası |*.xls |Csv Dosyası| *.csv",
                FilterIndex = 3
            };

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = openfile.FileName;
                string DosyaAdi = openfile.SafeFileName;

                Txt_MSE.Text = DosyaYolu; // Ana sayfadaki txt_dosyayolu metin kutusuna dosya yolunu yaz
            }
        }

        private void Btn_Hata_Click(object sender, EventArgs e)
        {
            var iki = siloku(Txt_MSE.Text);
            Mean_Square_Error(iki,Txt_MSE.Text);
        }

        private void j48_genel_entropy(String[,] veriler,string text)
        {
            int satir_sayisi = SatirSayisiBul(text);
            int sutun_sayisi = SutunSayisiBul(text);
            int sayac = 0;
            int kontrol = 0;
            for (int i = 0; i < satir_sayisi - 1; i++)
            {
                genel_entropi atama = new genel_entropi();

                if (sayac == 0)
                {
                    atama.sayi = veriler[i, sutun_sayisi - 1];
                    atama.adet++;
                    genel_e.Add(atama);
                    sayac++;
                }
                else
                {
                    foreach (var dolas in genel_e)
                    {
                        if (String.Equals(veriler[i, sutun_sayisi - 1], dolas.sayi) == true)
                        {
                            dolas.adet++;
                            kontrol++;
                            break;
                        }
                    }
                    if (kontrol == 0)
                    {
                        atama.sayi = veriler[i, sutun_sayisi - 1];
                        atama.adet++;
                        genel_e.Add(atama);

                    }
                    kontrol = 0;
                }
                foreach (var dolas in genel_e)
                {
                    dolas.orani = Convert.ToDouble(dolas.adet) / Convert.ToDouble(satir_sayisi - 1);//dosyayı ilk okurken üstteki kategoriyi aldığı için -1 .

                }

                double entropi = 0.0;
                foreach (var dolas in genel_e)
                {
                    entropi += Convert.ToDouble(dolas.orani) * Convert.ToDouble(Math.Log(dolas.orani, 2));
                }


                entropi *= (-1);
                /*silinecek*/
                string dosya_yolu = @"D:\Entropi.txt";

                FileStream d = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);

                StreamWriter f = new StreamWriter(d);
                foreach (var dolas in genel_e)
                {
                    f.Write(dolas.sayi + "," + dolas.adet + "," + dolas.orani + "\n");
                }
                f.Write("\n" + entropi);

                f.Flush();

                f.Close();
                d.Close();

            }
        }

        private void Btn_J48_Click(object sender, EventArgs e)
        {
            var dosya = oku(Txb_Dosyayolu2.Text);
            j48_genel_entropy(dosya, Txb_Dosyayolu2.Text);
        }
    }
}
