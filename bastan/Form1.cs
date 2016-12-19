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
    public class karsilastir 
    {
        public string kelime;
        public int sayi;
    }
    

    public partial class Form1 : Form
    {
        List<karsilastir> liste = new List<karsilastir>();
       
        int say=1;
        public Form1()
        {
            InitializeComponent();
           //int say = 1;
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
       
        private String[,] oku()
        {
            var dosyaOkuyucu = new StreamReader(File.OpenRead(Txb_Dosyayolu.Text));
                   
            var satirSayisi = SatirSayisiBul();
            var sutunSayisi = SutunSayisiBul();
            double[,] sondizi = new double[satirSayisi - 1, sutunSayisi - 1];

            string[,] veriler = new string[(satirSayisi - 1), (sutunSayisi - 1)];

            // Dosyanın sadece ilk satırının okunup, özellik adlarının ataması (dosyanın ilk satırını atla)
            var ilksatir = dosyaOkuyucu.ReadLine();
            var ozellikler = ilksatir.Split(',');
            /* NA lar değişecek ve dosyadaki sayı değerleri ile aynı olmayacak*/
            for (int i = 0; i < (satirSayisi - 1); i++) // satırları oku
            {
                var satir = dosyaOkuyucu.ReadLine(); // StreamReader nesnesi
                for (int j = 1; j < (sutunSayisi ); j++) // sütunları oku
                {
                    var degerler = satir.Split(','); // satırdaki verileri virgüle göre ayır
                  
                    /*iç for*/
                    
                    veriler[i, j-1] = degerler[j];
                    
                }
                /*dış for*/
            }
            return veriler;
            /*fonk bitis*/

        }
      /*Stringleri int çevirme*/

        private string[,] veri_duzelt(String[,] veriler)
        {
            int sayi_ata = 1;
            var satirSayisi = SatirSayisiBul();
            var sutunSayisi = SutunSayisiBul();
            for(int i=0;i<(satirSayisi-1);i++) //satır
            {
                for(int j=0;j<(sutunSayisi-1);j++)
                {
                    karsilastir ata = new karsilastir();
                    int kontrol = 0;
                    if (IsNumeric(veriler[i,j]) == false && veriler[i,j] != "NA") //değer sayısal değilse
                    {
                        if (say != 1)
                        {
                            foreach (var dolas in liste)
                            {
                                if (String.Equals(dolas.kelime, veriler[i,j]) == true) /*okunan string ile class taki değerler karşılaşrıma eşit ise sayı otomatik olarak atanıyor*/
                                {
                                    sayi_ata = dolas.sayi;
                                    kontrol++;
                                    break;
                                }

                            }
                            if (kontrol == 0)/*classtaki stringler ile eşleşen yoksa yeni sayı atanıyor.*/
                            {
                                ata.kelime = veriler[i,j];
                            
                            
                                ata.sayi = say;
                                sayi_ata = say;
                                liste.Add(ata);
                                say++;
                            }
                        }
                     
                          else
                        {
                        
                            ata.kelime = veriler[i,j];
                            
                            ata.sayi = say;
                            sayi_ata = say;
                            liste.Add(ata);
                            say++;
                        }
                        veriler[i, j] = sayi_ata.ToString();
                    }
                    else
                    {
                        veriler[i, j] = veriler[i,j];      // ayırılan değerleri matrise al
                    }

                    

                }
            }

            for (int i = 0; i < (satirSayisi - 1);i++ )
            {
                for(int j=0;j<(sutunSayisi-2);j++)
                {
                    if(veriler[i,j]=="NA")//NA ları bulup ortalaması alınması için NA_ortalama fonk. yollandı.
                    {
                        veriler[i, j] = NA_ortalama(veriler, j).ToString();
                    }
                }
            }

                return veriler;
        }
        
        
        /*NA ortalama */
        private int NA_ortalama(string[,] dizi, int sutun)
        {
            int ortalama = 0;
            int toplam = 0;
            int adet = 0;
            int satirSayisi = SatirSayisiBul();


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
        private void yaz(String[,] veriler)
        {
            string dosya_yolu = @"D:\metinbelgesi.txt";

            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            int satirSayisi = SatirSayisiBul();
            int sutunSayisi = SutunSayisiBul();

            for (int i = 0; i < satirSayisi - 1; i++)
            {

                for (int j = 0; j < sutunSayisi - 1; j++)
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
        public int SutunSayisiBul()
        {
            var lines = File.ReadAllLines(Txb_Dosyayolu.Text);
            var sutunsayisi = lines[0].Split(',').Length;

            return sutunsayisi;
        }
        public int SatirSayisiBul()
        {
            var lines = File.ReadAllLines(Txb_Dosyayolu.Text);
            var satirsayisi = lines.Count();

            return satirsayisi;
        }
        #endregion

        private void Btn_satirsutunsayisi_Click(object sender, EventArgs e)
        {
            Txb_satirsayisi.Text = SatirSayisiBul().ToString();
            Txb_sutunsayisi.Text = SutunSayisiBul().ToString(); 
        }

        private void Btn_Veriduzelt_Click(object sender, EventArgs e)
        {
            
            var iki = veri_duzelt(oku());
           // yaz(iki);
            lineer(iki);

           
        }

    private void lineer(string [,] veriler)
        {
            int satir = SatirSayisiBul() - 1;
            int sutun = SutunSayisiBul() - 1;
            float a=0;
            float b=0;
            int [] Xsatir = new int[satir];
            int Ytoplam = 0;
            MessageBox.Show(satir.ToString());
            MessageBox.Show(sutun.ToString());
            int z=0;
            for(int i=0;i<satir;i++)
            {
                for (int j=0;j<sutun;j++)
                {
                    if(j==sutun-1)
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
            int xy=0;
            int x2=0;


            int xtop = 0;

        for(int i=0;i<satir;i++)
        {
            xy += Convert.ToInt32(Xsatir[i]) * Convert.ToInt32(veriler[i, sutun - 1]);
            x2 += Convert.ToInt32(Xsatir[i]*Xsatir[i]) ;
            xtop+=Xsatir[i];
        }

        float yort = (float)(Ytoplam / satir);
        float oort = (float)(xtop / satir);

        b = (float)(xy - (satir * (oort) * yort)) / (x2 - (satir*(oort * oort)));
        a = (float)(yort - (b * oort));

        double denemey = (double) (a + (b * Xsatir[0]));
        /*silinecek*/
        string dosya_yolu = @"D:\ab.txt";
        


        FileStream k = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);

        StreamWriter ya = new StreamWriter(k);
       
            ya.Write(" a: "+a+" b: "+b+" y :"+denemey+"xsatr : "+Xsatir[0]);
        

        ya.Flush();

        ya.Close();
        k.Close();
    }

    
    }
}
