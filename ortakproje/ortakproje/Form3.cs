using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace ortakproje
{

    public partial class Form3 : Form
    {

        public int toplamtutar;
        private SqlConnection baglanti = new SqlConnection(
     @"Server=DESKTOP-48OFADI\SQLEXPRESS;Database=ortakprojeDB;Trusted_Connection=True;TrustServerCertificate=True;");


        public Form3()
        {
            InitializeComponent();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = toplamtutar + " TL";
            textBox3.MaxLength = 16;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""||textBox3.Text.Length<16)
            {
                MessageBox.Show("Tüm Alanları Doldurunuz ve kart Numarası 16 dan küçük olamaz");
            }
            try
            {
                baglanti.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO OdemeBilgileri (IsimSoyisim, Adres, KartNumarasi) " +
                    "VALUES (@isim, @adres, @kart)", baglanti);

                cmd.Parameters.AddWithValue("@isim", textBox1.Text);
                cmd.Parameters.AddWithValue("@adres", textBox2.Text);
                cmd.Parameters.AddWithValue("@kart", textBox3.Text);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Ödeme Başarılı Toplam Tutar :" + toplamtutar + " " + MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
