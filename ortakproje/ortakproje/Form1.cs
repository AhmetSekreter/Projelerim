namespace ortakproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="Kullanýcý1"&&textBox2.Text=="123")
            { 
                Form2 form2 = new Form2();
                form2.Show();
               
               
            }
            else
            {
                MessageBox.Show("Kullanýcý bilgileri yanlýþtýr.");
            }
        }
    }
}
