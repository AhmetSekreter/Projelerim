using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortakproje
{
    public partial class Form2 : Form
    {
        int toplam = 0;
        List<int> fiyatlar = new List<int>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Basic T-shirt");
            comboBox1.Items.Add("Sweatshirt");
            comboBox1.Items.Add("Kazak");
            comboBox1.Items.Add("Kot Pantolon");
            comboBox1.Items.Add("Kumaş Pantolon");
            comboBox1.Items.Add("Eşofman Altı");

            numericUpDown1.Value = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.Text == "Basic T-shirt")
            {
                comboBox2.Items.Add("S");
                comboBox2.Items.Add("M");
                comboBox2.Items.Add("L");
                label1.Text = "300";
            }
            else if (comboBox1.Text == "Sweatshirt")
            {
                comboBox2.Items.Add("S");
                comboBox2.Items.Add("M");
                comboBox2.Items.Add("L");
                label1.Text = "500";
            }
            else if (comboBox1.Text == "Kazak")
            {
                comboBox2.Items.Add("S");
                comboBox2.Items.Add("M");
                comboBox2.Items.Add("L");
                label1.Text = "400";
            }
            else if (comboBox1.Text == "Eşofman Altı")
            {
                comboBox2.Items.Add("S");
                comboBox2.Items.Add("M");
                comboBox2.Items.Add("L");
                label1.Text = "350";
            }
            else if (comboBox1.Text == "Kot Pantolon")
            {
                comboBox2.Items.Add("30");
                comboBox2.Items.Add("32");
                comboBox2.Items.Add("34");
                label1.Text = "550";
            }
            else if (comboBox1.Text == "Kumaş Pantolon")
            {
                comboBox2.Items.Add("30");
                comboBox2.Items.Add("32");
                comboBox2.Items.Add("34");
                label1.Text = "450";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" && comboBox2.Text == "")
            {
                MessageBox.Show("Ürün ve beden seçiniz");
                return;
            }
            string urun = comboBox1.Text;
            string beden = comboBox2.Text;
            int fiyat = Convert.ToInt32(label1.Text);
            int adet = Convert.ToInt32(numericUpDown1.Value);
            fiyatlar.Add(fiyat);
            int aratoplam = fiyat * adet;
            listBox1.Items.Add(urun + "  Beden: " + beden + "  Adet:" + adet + " " + aratoplam + " TL");
            toplam += aratoplam;
            label2.Text = toplam + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Sepet Boş Bırakılamaz");
                return;
            }
            
            Form3 form3 = new Form3();
            form3.toplamtutar = toplam;
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            if(listBox1.SelectedIndex >=fiyatlar.Count) return;
            toplam -= fiyatlar[listBox1.SelectedIndex];
            fiyatlar.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            label2.Text = toplam + " TL";
        }
    }
}
