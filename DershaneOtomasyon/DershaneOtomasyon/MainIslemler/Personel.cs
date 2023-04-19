using DershaneOtomasyon.PersonelIslemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DershaneOtomasyon
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void OgrKayitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ogrkayit = new OgrenciKayit();
            ogrkayit.Closed += (s, args) => this.Close();
            ogrkayit.Show();
        }

        private void PersonelKayıtButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var prskayit = new PersonelKayit();
            prskayit.Closed += (s, args) => this.Close();
            prskayit.Show();
        }

        private void HarcButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var harc = new Harc();
            harc.Closed += (s, args) => this.Close();
            harc.Show();
        }

        private void OgretmenNotButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ogretmennot = new OgretmenNot();
            ogretmennot.Closed += (s, args) => this.Close();
            ogretmennot.Show();
        }

        private void OdevTakipButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var odevtakip = new Odev();
            odevtakip.Closed += (s, args) => this.Close();
            odevtakip.Show();
        }

        private void VeliBilgiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var velibilgi = new VeliBilgi();
            velibilgi.Closed += (s, args) => this.Close();
            velibilgi.Show();
        }

        private void TakvimButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var takvim = new Takvim();
            takvim.Closed += (s, args) => this.Close();
            takvim.Show();
        }
    }
}
