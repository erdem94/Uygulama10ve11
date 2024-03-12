using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama10ve11
{
    public partial class Form1 : Form
    {
        ArrayList sehirler=new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtSehirAdi.Text);         
            txtSehirAdi.Clear();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();
            foreach (string i in sehirler)
            {
                lbListe.Items.Add(i);
            }
        }
    }
}
