using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabaniUygulama
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        private void kayıtlarToolStripMenuItem_Click(object sender, EventArgs e)
        { //personel formunda kayıtlara tıklanınca anasayfa ekranına getiriyor
            FormPersonel frmPersonel = new FormPersonel();
            frmPersonel.Name = "frmPersonel"; //forma yeni isim verdik
            if(Application.OpenForms["frmPersonel"] == null) //form daha önceden açık değilse aç, değilse bişey yapma
            {
                frmPersonel.MdiParent = this;
                frmPersonel.Show();
            }
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Name == "NodePerKayit")
            {
                FormPersonel frmPersonel = new FormPersonel();
                frmPersonel.Name = "frmPersonel"; //forma yeni isim verdik
                if (Application.OpenForms["frmPersonel"] == null) //form daha önceden açık değilse aç, değilse bişey yapma
                {
                    frmPersonel.MdiParent = this;
                    frmPersonel.Show();
                }
            }
        }
    }
}
