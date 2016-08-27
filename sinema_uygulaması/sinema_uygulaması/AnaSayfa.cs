using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_uygulaması
{
    public partial class AnaSayfa : Form
    {
        SinemaDataContext db = new SinemaDataContext();
        public AnaSayfa()
        {
            InitializeComponent();
            var sorgu1 = from film in db.films select new { film.fAdi };
            var sorgu2 = from sean in db.seans select new { sean.saat };
            foreach(var item in sorgu1)
            {
                comboBox1.Items.Add(item.fAdi);
            }
            foreach(var item in sorgu2)
            {
                listBox1.Items.Add(item.saat);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen filme göre salon no ve resmin gösterilmesi
            var sorgu1 = from film in db.films where film.fAdi == comboBox1.Text select new { film.resim, film.salon_id };
            foreach (var item in sorgu1)
            {
                label4.Text = item.salon_id.ToString();
                pictureBox1.ImageLocation = item.resim;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            filmekle f = new filmekle();
            f.ShowDialog();
        }
        public void guncelle()
        {
            salon1 s1 = new salon1();
            s1.koltuk_durum(listBox1.Text, comboBox1.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && listBox1.Text != "")
            {
                if (label4.Text == "1")
                {
                    salon1 s1 = new salon1();
                    s1.Owner = this;
                    s1.label13.Text = listBox1.Text;
                    s1.koltuk_durum(listBox1.Text, comboBox1.Text);
                    s1.ShowDialog();
                }
                else if (label4.Text == "2")
                {
                    salon2 s2 = new salon2();
                    s2.Owner = this;
                    s2.label15.Text = listBox1.Text;
                    s2.koltuk_durum(listBox1.Text, comboBox1.Text);
                    s2.ShowDialog();
                }
            }
            else { MessageBox.Show("Eksik seçim yapmayınız!"); }
        }
    }
}
