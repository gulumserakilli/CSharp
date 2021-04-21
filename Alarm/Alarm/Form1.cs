using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form1 : Form
    {
        int saat = 0, dakika = 0, saniye = 0;

        private void timerZAMAN_Tick(object sender, EventArgs e)
        {
            if (saniye == 0 & dakika == 0)
            {
                if (saat > 0)
                {
                    saat--;
                    dakika = 59;
                    saniye = 59;
                }
            }
            if (saniye == 0)
            {
                if (dakika > 0)
                {
                    dakika--;
                    saniye = 59;
                }
            }
            labelZAMAN.Text = string.Format("{0:00}:{1:00}:{2:00}", saat, dakika, saniye);
            if (saat == 0 & dakika == 0 & saniye == 0)
            {
                timerZAMAN.Stop();
                SystemSounds.Beep.Play();
                MessageBox.Show("ALARMA BİTTİ");
            }
            saniye--;
        }

        private void buttonDURDUR_Click(object sender, EventArgs e)
        {
            timerZAMAN.Stop();
            saat = 0; dakika = 0; saniye = 0;
            labelZAMAN.Text = string.Format("{0:00}:{1:00}:{2:00}", saat, dakika, saniye);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBASLA_Click(object sender, EventArgs e)
        {
            saat = (int)numericUpDownSAAT.Value;
            dakika = (int)numericUpDownDAKIKA.Value;
            saniye = (int)numericUpDownSANIYE.Value;
            timerZAMAN.Start();
        }
    }
}