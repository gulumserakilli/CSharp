using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YildizSavaslari
{
    public partial class Form1 : Form
    {
        int formYukseklik = 500, formGenislik = 400;
        int Oyuncu_X = 200, Oyuncu_Y = 400;
        int OyuncuHiz_Yatay = 1, OyuncuHiz_Dusey = 1;
        int puan;
        List<PictureBox> Mermiler = new List<PictureBox>();
        int MermiHiz = 10;
        List<PictureBox> Dusmanlar = new List<PictureBox>();
        int DusmanHiz = 2;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void timerOyuncu_Tick(object sender, EventArgs e)
        {
            Oyuncu_X += OyuncuHiz_Yatay;
            Oyuncu_Y += OyuncuHiz_Dusey;
            OyuncuGemisi.Location = new Point(Oyuncu_X, Oyuncu_Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = formYukseklik;
            this.Width = formGenislik;
            OyuncuGemisi.Parent = pictureBoxGalaxy;
            labelPuan.Parent = pictureBoxGalaxy;
           
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int hiz = 5;
            switch (e.KeyCode)
            {
                case Keys.Left: OyuncuHiz_Yatay -= hiz; break;
                case Keys.Right: OyuncuHiz_Yatay += hiz;break;
                case Keys.Up: OyuncuHiz_Dusey -= hiz; break;
                case Keys.Down: OyuncuHiz_Dusey += hiz; break;
                case Keys.Enter: puan = 0; 
                    timerOyuncu.Start(); 
                    timerMermiFirlat.Start();
                    timerDusmanOlustur.Start();
                    timerDusmanDusur.Start();
                    timerMermiKontrol.Start(); 
                    break;
                case Keys.Space: MermiOlustur(); break;
            }
        }

        private void timerMermiFirlat_Tick(object sender, EventArgs e)
        {
            MermileriFirlat();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: OyuncuHiz_Yatay = 0; break;
                case Keys.Right: OyuncuHiz_Yatay = 0; break;
                case Keys.Up: OyuncuHiz_Dusey = 0; break;
                case Keys.Down: OyuncuHiz_Dusey = 0; break;
            }
        }

       public void MermiOlustur()
        {
            PictureBox Mermi = new PictureBox
            {
                Size = new Size(15, 15),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.Laser_08,
                BackColor = Color.Transparent
            };
            int MermiLocX = OyuncuGemisi.Left + OyuncuGemisi.Width / 2 - 5;
            int MermiLocY = OyuncuGemisi.Top - 1;
            Mermi.Location = new Point(MermiLocX, MermiLocY);
            Controls.Add(Mermi);
            Mermi.Parent = pictureBoxGalaxy;
            Mermi.BringToFront();//galaksinin üstüne çıkar
            Mermiler.Add(Mermi);
        }

        private void timerDusmanDusur_Tick(object sender, EventArgs e)
        {
            DusmanDusur();
        }

        private void timerDusmanOlustur_Tick(object sender, EventArgs e)
        {
            DusmanOlustur();
        }

        private void timerMermiKontrol_Tick(object sender, EventArgs e)
        {
            for(int m=0;m< Mermiler.Count; m++)
            {
                for(int d =0; d < Dusmanlar.Count; d++)
                {
                    try
                    {
                        //mermi ile düşmen çarpışması
                        if (Mermiler[m].Bounds.IntersectsWith(Dusmanlar[d].Bounds))
                        {
                            puan += 1;
                            labelPuan.Text = "Puan = " + puan.ToString();

                            pictureBoxGalaxy.Controls.Remove(Mermiler[m]);
                            Mermiler.Remove(Mermiler[m]);

                            pictureBoxGalaxy.Controls.Remove(Dusmanlar[d]);
                            Dusmanlar.Remove(Dusmanlar[d]);

                            //ram temizleme
                            GC.Collect();//çöp toplayıcısı
                            GC.WaitForPendingFinalizers();//çöpü yok et
                        }
                    } //picture box list elemanı sildiği için aynı indiste kontrol edildiği zaman ilk aşamada null old için return ile görmezden geliyoruz
                    catch (ArgumentOutOfRangeException)
                    {
                        return;
                    }
                   
                }
            }
        }

        public void MermileriFirlat()
        {
            for(int i = 0; i < Mermiler.Count; i++)
            {
                Mermiler[i].Top -= MermiHiz;
            }
        }

        private void pictureBoxGalaxy_Click(object sender, EventArgs e)
        {

        }

        public void DusmanOlustur()
        {
            int yer = rnd.Next(0, formGenislik - 50);//düşman gemilerinin pikselli 50
            PictureBox Dusman = new PictureBox
            {
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.Gemi_03,
                BackColor = Color.Transparent,
                Location = new Point(yer, 0),
                Visible = true
            };
            Controls.Add(Dusman);//düşmanları forma ekledik
            Dusman.Parent = pictureBoxGalaxy;//galaksi içine aldık
            Dusman.BringToFront();//öne getirdik
            Dusmanlar.Add(Dusman);
        }
        public void DusmanDusur()
        {//üst koordinatını hızımız kadar arttırıyoruz
            for(int i = 0; i < Dusmanlar.Count; i++)
            {
                Dusmanlar[i].Top += DusmanHiz;
                //Düşman gemizi formun dışına çıkarsa
                //oyuncunun gemisine çarparsa
                if(Dusmanlar[i].Top>=formYukseklik-10 ||
                    Dusmanlar[i].Bounds.IntersectsWith(OyuncuGemisi.Bounds))
                {
                    //oyun bitti
                    OyunBitir();
                }
            }
        }
        public void OyunBitir()
        {
            timerOyuncu.Stop();
            timerMermiFirlat.Stop();
            timerMermiKontrol.Stop();
            timerDusmanDusur.Stop();
            timerDusmanOlustur.Stop();

            MessageBox.Show("Oyun Bitti. Puanın =" + puan);
        }
    }
}
