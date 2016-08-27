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
    public partial class salon2 : Form
    {
        SinemaDataContext db = new SinemaDataContext();
        public salon2()
        {
            InitializeComponent();
        }
        public void koltuk_durum(string x, string y)
        {
            var sorgu1 = from bilet in db.bilets join sean in db.seans on bilet.seans_id equals sean.seans_id join film in db.films on bilet.film_id equals film.film_id where sean.saat == x && film.fAdi == y select new { bilet.koltuk_no };
            foreach (var item in sorgu1)
            {
                comboBox1.Items.Add(item.koltuk_no);
                if (item.koltuk_no == "F1")
                {
                    f1.BackColor = Color.Red;
                }
                else if (item.koltuk_no == "F2") { f2.BackColor = Color.Red; }
                else if (item.koltuk_no == "F3") { f3.BackColor = Color.Red; }
                else if (item.koltuk_no == "F4") { f4.BackColor = Color.Red; }
                else if (item.koltuk_no == "F5") { f5.BackColor = Color.Red; }
                else if (item.koltuk_no == "F6") { f6.BackColor = Color.Red; }
                else if (item.koltuk_no == "F7") { f7.BackColor = Color.Red; }
                else if (item.koltuk_no == "F8") { f8.BackColor = Color.Red; }
                else if (item.koltuk_no == "F9") { f9.BackColor = Color.Red; }
                else if (item.koltuk_no == "F10") { f10.BackColor = Color.Red; }
                else if (item.koltuk_no == "E1") { e1.BackColor = Color.Red; }
                else if (item.koltuk_no == "E3") { e3.BackColor = Color.Red; }
                else if (item.koltuk_no == "E4") { e4.BackColor = Color.Red; }
                else if (item.koltuk_no == "E2") { e2.BackColor = Color.Red; }
                else if (item.koltuk_no == "E5") { e5.BackColor = Color.Red; }
                else if (item.koltuk_no == "E6") { e6.BackColor = Color.Red; }
                else if (item.koltuk_no == "E7") { e7.BackColor = Color.Red; }
                else if (item.koltuk_no == "E8") { e8.BackColor = Color.Red; }
                else if (item.koltuk_no == "E9") { e9.BackColor = Color.Red; }
                else if (item.koltuk_no == "E10") { e10.BackColor = Color.Red; }
                else if (item.koltuk_no == "D1") { d1.BackColor = Color.Red; }
                else if (item.koltuk_no == "D2") { d2.BackColor = Color.Red; }
                else if (item.koltuk_no == "D3") { d3.BackColor = Color.Red; }
                else if (item.koltuk_no == "D4") { d4.BackColor = Color.Red; }
                else if (item.koltuk_no == "D5") { d5.BackColor = Color.Red; }
                else if (item.koltuk_no == "D6") { d6.BackColor = Color.Red; }
                else if (item.koltuk_no == "D7") { d7.BackColor = Color.Red; }
                else if (item.koltuk_no == "D8") { d8.BackColor = Color.Red; }
                else if (item.koltuk_no == "D9") { d9.BackColor = Color.Red; }
                else if (item.koltuk_no == "D10") { d10.BackColor = Color.Red; }
                else if (item.koltuk_no == "C1") { c1.BackColor = Color.Red; }
                else if (item.koltuk_no == "C2") { c2.BackColor = Color.Red; }
                else if (item.koltuk_no == "C3") { c3.BackColor = Color.Red; }
                else if (item.koltuk_no == "C4") { c4.BackColor = Color.Red; }
                else if (item.koltuk_no == "C5") { c5.BackColor = Color.Red; }
                else if (item.koltuk_no == "C6") { c6.BackColor = Color.Red; }
                else if (item.koltuk_no == "C7") { c7.BackColor = Color.Red; }
                else if (item.koltuk_no == "C8") { c8.BackColor = Color.Red; }
                else if (item.koltuk_no == "C9") { c9.BackColor = Color.Red; }
                else if (item.koltuk_no == "C10") { c10.BackColor = Color.Red; }
                else if (item.koltuk_no == "B1") { b1.BackColor = Color.Red; }
                else if (item.koltuk_no == "B2") { b2.BackColor = Color.Red; }
                else if (item.koltuk_no == "B3") { b3.BackColor = Color.Red; }
                else if (item.koltuk_no == "B4") { b4.BackColor = Color.Red; }
                else if (item.koltuk_no == "B5") { b5.BackColor = Color.Red; }
                else if (item.koltuk_no == "B6") { b6.BackColor = Color.Red; }
                else if (item.koltuk_no == "B7") { b7.BackColor = Color.Red; }
                else if (item.koltuk_no == "B8") { b8.BackColor = Color.Red; }
                else if (item.koltuk_no == "B9") { b9.BackColor = Color.Red; }
                else if (item.koltuk_no == "B10") { b10.BackColor = Color.Red; }
                else if (item.koltuk_no == "A1") { a1.BackColor = Color.Red; }
                else if (item.koltuk_no == "A2") { a2.BackColor = Color.Red; }
                else if (item.koltuk_no == "A3") { a3.BackColor = Color.Red; }
                else if (item.koltuk_no == "A4") { a4.BackColor = Color.Red; }
                else if (item.koltuk_no == "A5") { a5.BackColor = Color.Red; }
                else if (item.koltuk_no == "A6") { a6.BackColor = Color.Red; }
                else if (item.koltuk_no == "A7") { a7.BackColor = Color.Red; }
                else if (item.koltuk_no == "A8") { a8.BackColor = Color.Red; }
                else if (item.koltuk_no == "A9") { a9.BackColor = Color.Red; }
                else if (item.koltuk_no == "A10") { a10.BackColor = Color.Red; }
            }
        }

        private void a10_Click(object sender, EventArgs e)
        {
            a10.BackColor = Color.Red;
            a10.Enabled = false;
            listBox1.Items.Add("A10");
        }

        private void a9_Click(object sender, EventArgs e)
        {
            a9.BackColor = Color.Red;
            a9.Enabled = false;
            listBox1.Items.Add("A9");
        }

        private void a8_Click(object sender, EventArgs e)
        {
            a8.BackColor = Color.Red;
            a8.Enabled = false;
            listBox1.Items.Add("A8");
        }

        private void a7_Click(object sender, EventArgs e)
        {
            a7.BackColor = Color.Red;
            a7.Enabled = false;
            listBox1.Items.Add("A7");
        }

        private void a6_Click(object sender, EventArgs e)
        {
            a6.BackColor = Color.Red;
            a6.Enabled = false;
            listBox1.Items.Add("A6");
        }

        private void a5_Click(object sender, EventArgs e)
        {
            a5.BackColor = Color.Red;
            a5.Enabled = false;
            listBox1.Items.Add("A5");

        }

        private void a4_Click(object sender, EventArgs e)
        {
            a4.BackColor = Color.Red;
            a4.Enabled = false;
            listBox1.Items.Add("A4");
        }

        private void a3_Click(object sender, EventArgs e)
        {
            a3.BackColor = Color.Red;
            a3.Enabled = false;
            listBox1.Items.Add("A3");
        }

        private void a2_Click(object sender, EventArgs e)
        {
            a2.BackColor = Color.Red;
            a2.Enabled = false;
            listBox1.Items.Add("A2");
        }

        private void a1_Click(object sender, EventArgs e)
        {
            a1.BackColor = Color.Red;
            a1.Enabled = false;
            listBox1.Items.Add("A1");
        }

        private void f1_Click(object sender, EventArgs e)
        {
            f1.BackColor = Color.Red;
            f1.Enabled = false;
            listBox1.Items.Add("F1");
        }

        private void b10_Click(object sender, EventArgs e)
        {
            b10.BackColor = Color.Red;
            b10.Enabled = false;
            listBox1.Items.Add("B10");
        }

        private void f2_Click(object sender, EventArgs e)
        {
            f2.BackColor = Color.Red;
            f2.Enabled = false;
            listBox1.Items.Add("F2");
        }

        private void b9_Click(object sender, EventArgs e)
        {
            b9.BackColor = Color.Red;
            b9.Enabled = false;
            listBox1.Items.Add("B9");
        }

        private void f3_Click(object sender, EventArgs e)
        {
            f3.BackColor = Color.Red;
            f3.Enabled = false;
            listBox1.Items.Add("F3");
        }

        private void b8_Click(object sender, EventArgs e)
        {
            b8.BackColor = Color.Red;
            b8.Enabled = false;
            listBox1.Items.Add("B8");
        }

        private void f4_Click(object sender, EventArgs e)
        {
            f4.BackColor = Color.Red;
            f4.Enabled = false;
            listBox1.Items.Add("F4");
        }

        private void b7_Click(object sender, EventArgs e)
        {
            b7.BackColor = Color.Red;
            b7.Enabled = false;
            listBox1.Items.Add("B7");
        }

        private void f5_Click(object sender, EventArgs e)
        {
            f5.BackColor = Color.Red;
            f5.Enabled = false;
            listBox1.Items.Add("F5");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            b6.BackColor = Color.Red;
            b6.Enabled = false;
            listBox1.Items.Add("B6");
        }

        private void f6_Click(object sender, EventArgs e)
        {
            f6.BackColor = Color.Red;
            f6.Enabled = false;
            listBox1.Items.Add("F6");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            b5.BackColor = Color.Red;
            b5.Enabled = false;
            listBox1.Items.Add("B5");
        }

        private void f7_Click(object sender, EventArgs e)
        {
            f7.BackColor = Color.Red;
            f7.Enabled = false;
            listBox1.Items.Add("F7");
        }

        private void b4_Click(object sender, EventArgs e)
        {
            b4.BackColor = Color.Red;
            b4.Enabled = false;
            listBox1.Items.Add("B4");
        }

        private void f8_Click(object sender, EventArgs e)
        {
            f8.BackColor = Color.Red;
            f8.Enabled = false;
            listBox1.Items.Add("F8");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.BackColor = Color.Red;
            b3.Enabled = false;
            listBox1.Items.Add("B3");
        }

        private void f9_Click(object sender, EventArgs e)
        {
            f9.BackColor = Color.Red;
            f9.Enabled = false;
            listBox1.Items.Add("F9");
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.BackColor = Color.Red;
            b2.Enabled = false;
            listBox1.Items.Add("B2");
        }

        private void f10_Click(object sender, EventArgs e)
        {
            f10.BackColor = Color.Red;
            f10.Enabled = false;
            listBox1.Items.Add("F10");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            b1.BackColor = Color.Red;
            b1.Enabled = false;
            listBox1.Items.Add("B1");
        }

        private void e1_Click(object sender, EventArgs e)
        {
            e1.BackColor = Color.Red;
            e1.Enabled = false;
            listBox1.Items.Add("E1");
        }

        private void c10_Click(object sender, EventArgs e)
        {
            c10.BackColor = Color.Red;
            c10.Enabled = false;
            listBox1.Items.Add("C10");
        }

        private void e2_Click(object sender, EventArgs e)
        {
            e2.BackColor = Color.Red;
            e2.Enabled = false;
            listBox1.Items.Add("E2");
        }

        private void c9_Click(object sender, EventArgs e)
        {
            c9.BackColor = Color.Red;
            c9.Enabled = false;
            listBox1.Items.Add("C9");
        }

        private void e3_Click(object sender, EventArgs e)
        {
            e3.BackColor = Color.Red;
            e3.Enabled = false;
            listBox1.Items.Add("E3");
        }

        private void c8_Click(object sender, EventArgs e)
        {
            c8.BackColor = Color.Red;
            c8.Enabled = false;
            listBox1.Items.Add("C8");
        }

        private void e4_Click(object sender, EventArgs e)
        {
            e4.BackColor = Color.Red;
            e4.Enabled = false;
            listBox1.Items.Add("E4");
        }

        private void c7_Click(object sender, EventArgs e)
        {
            c7.BackColor = Color.Red;
            c7.Enabled = false;
            listBox1.Items.Add("C7");
        }

        private void e5_Click(object sender, EventArgs e)
        {
            e5.BackColor = Color.Red;
            e5.Enabled = false;
            listBox1.Items.Add("E5");
        }

        private void c6_Click(object sender, EventArgs e)
        {
            c6.BackColor = Color.Red;
            c6.Enabled = false;
            listBox1.Items.Add("C6");
        }

        private void e6_Click(object sender, EventArgs e)
        {
            e6.BackColor = Color.Red;
            e6.Enabled = false;
            listBox1.Items.Add("E6");
        }

        private void c5_Click(object sender, EventArgs e)
        {
            c5.BackColor = Color.Red;
            c5.Enabled = false;
            listBox1.Items.Add("C5");
        }

        private void e7_Click(object sender, EventArgs e)
        {
            e7.BackColor = Color.Red;
            e7.Enabled = false;
            listBox1.Items.Add("E7");
        }

        private void c4_Click(object sender, EventArgs e)
        {
            c4.BackColor = Color.Red;
            c4.Enabled = false;
            listBox1.Items.Add("C4");
        }

        private void e8_Click(object sender, EventArgs e)
        {
            e8.BackColor = Color.Red;
            e8.Enabled = false;
            listBox1.Items.Add("E8");
        }

        private void c3_Click(object sender, EventArgs e)
        {
            c3.BackColor = Color.Red;
            c3.Enabled = false;
            listBox1.Items.Add("C3");
        }

        private void e9_Click(object sender, EventArgs e)
        {
            e9.BackColor = Color.Red;
            e9.Enabled = false;
            listBox1.Items.Add("E9");
        }

        private void c2_Click(object sender, EventArgs e)
        {
            c2.BackColor = Color.Red;
            c2.Enabled = false;
            listBox1.Items.Add("C2");
        }

        private void e10_Click(object sender, EventArgs e)
        {
            e10.BackColor = Color.Red;
            e10.Enabled = false;
            listBox1.Items.Add("E10");
        }

        private void c1_Click(object sender, EventArgs e)
        {
            c1.BackColor = Color.Red;
            c1.Enabled = false;
            listBox1.Items.Add("C1");
        }

        private void d1_Click(object sender, EventArgs e)
        {
            d1.BackColor = Color.Red;
            d1.Enabled = false;
            listBox1.Items.Add("D1");
        }

        private void d10_Click(object sender, EventArgs e)
        {
            d10.BackColor = Color.Red;
            d10.Enabled = false;
            listBox1.Items.Add("D10");
        }

        private void d2_Click(object sender, EventArgs e)
        {
            d2.BackColor = Color.Red;
            d2.Enabled = false;
            listBox1.Items.Add("D2");
        }

        private void d9_Click(object sender, EventArgs e)
        {
            d9.BackColor = Color.Red;
            d9.Enabled = false;
            listBox1.Items.Add("D9");
        }

        private void d3_Click(object sender, EventArgs e)
        {
            d3.BackColor = Color.Red;
            d3.Enabled = false;
            listBox1.Items.Add("D3");
        }

        private void d8_Click(object sender, EventArgs e)
        {
            d8.BackColor = Color.Red;
            d8.Enabled = false;
            listBox1.Items.Add("D8");
        }

        private void d4_Click(object sender, EventArgs e)
        {
            d4.BackColor = Color.Red;
            d4.Enabled = false;
            listBox1.Items.Add("D4");
        }

        private void d7_Click(object sender, EventArgs e)
        {
            d7.BackColor = Color.Red;
            d7.Enabled = false;
            listBox1.Items.Add("D7");
        }

        private void d5_Click(object sender, EventArgs e)
        {
            d5.BackColor = Color.Red;
            d5.Enabled = false;
            listBox1.Items.Add("D5");
        }

        private void d6_Click(object sender, EventArgs e)
        {
            d6.BackColor = Color.Red;
            d6.Enabled = false;
            listBox1.Items.Add("D6");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (((AnaSayfa)this.Owner).comboBox1.Text != null && ((AnaSayfa)this.Owner).listBox1.Text != null && listBox1.Items.Count != 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    bilet yenibilet = new bilet();
                    var p = from film in db.films where film.fAdi == ((AnaSayfa)this.Owner).comboBox1.Text select new { film.film_id };
                    foreach (var item in p)
                    {
                        yenibilet.film_id = item.film_id;
                    }
                    var x = from sean in db.seans where sean.saat == ((AnaSayfa)this.Owner).listBox1.Text select new { sean.seans_id };
                    foreach (var item in x)
                    {
                        yenibilet.seans_id = item.seans_id;
                    }
                    yenibilet.tarih = DateTime.Today.Date;
                    yenibilet.koltuk_no = listBox1.Items[i].ToString();
                    if (checkBox1.Checked == true)
                    {
                        yenibilet.ucret = 15;
                    }
                    else if (checkBox2.Checked == true)
                    {
                        yenibilet.ucret = 12;
                    }
                    db.bilets.InsertOnSubmit(yenibilet);
                    db.SubmitChanges();
                }
                MessageBox.Show("Satış işlemi gerçekleşmiştir.");
                listBox1.Items.Clear();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            else
            {
                MessageBox.Show("Lütfen alanları eksiksiz doldurunuz!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label12.Text = dt.ToShortDateString();
            label13.Text = dt.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var silinecek_kayit = db.bilets.Where(w => w.koltuk_no == comboBox1.Text).FirstOrDefault();
            db.bilets.DeleteOnSubmit(silinecek_kayit);
            db.SubmitChanges();
            MessageBox.Show("Kayıt silindi.");
        }
    }
}
