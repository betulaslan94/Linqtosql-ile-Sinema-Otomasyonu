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
    public partial class filmekle : Form
    {
        SinemaDataContext db = new SinemaDataContext();
        public filmekle()
        {
            InitializeComponent();
            var x = from salon in db.salons select new { salon.salon_id };
            foreach(var item in x)
            {
                comboBox1.Items.Add(item.salon_id);
            }
        }
        public static string _resimsakla;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Resim dosyaları |*.jpg;*.jpeg;*.gif;*.bmp;" +
                "*.png;*ico|JPEG Files ( *.jpg;*.jpeg )|*.jpg;*.jpeg|GIF Files ( *.gif )|*.gif|BMP Files ( *.bmp )" +
                "|*.bmp|PNG Files ( *.png )|*.png|Icon Files ( *.ico )|*.ico";
            openDialog.Title = "Resim Ekle";
            openDialog.InitialDirectory = Application.StartupPath + @"\\DataPicture\";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                _resimsakla = openDialog.FileName.ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = _resimsakla;
            }
            openDialog.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "") { 
                film yenifilm = new film();
                yenifilm.fAdi = textBox1.Text;
                yenifilm.fTur = textBox2.Text;
                yenifilm.sure = textBox3.Text;
                yenifilm.resim = _resimsakla;
                yenifilm.salon_id =Convert.ToInt32(comboBox1.Text);
                db.films.InsertOnSubmit(yenifilm);
                db.SubmitChanges();
                MessageBox.Show("Film eklendi.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Text = "";
                pictureBox1.Image = null;
            }
            else
            {
                MessageBox.Show("Lütfen alanları eksiksiz doldurun!");
            }
        }
    }
}
