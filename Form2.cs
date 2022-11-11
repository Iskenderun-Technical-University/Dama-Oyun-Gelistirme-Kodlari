/*
namespace NetHesapla
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double turkceDogru, turkceYanlis, turkceNet;
            double matDogru, matYanlis, matNet;
            double fizDogru, fizYanlis, fizNet;

            turkceDogru = Convert.ToDouble(txtTurkceDogru.Text);
            turkceYanlis = Convert.ToDouble(txtTurkceYanlis.Text);

            matDogru = Convert.ToDouble(txtMatDogru.Text);
            matYanlis = Convert.ToDouble(txtMatYanlis.Text);

            fizDogru = Convert.ToDouble(txtFizDogru.Text);
            fizYanlis = Convert.ToDouble(txtFizYanlis.Text);

            turkceNet = turkceDogru - (turkceYanlis / 4);
            matNet = matDogru - (matYanlis / 4);
            fizNet = fizDogru - (fizYanlis / 4);

            txtTurkceNet.Text = turkceNet.ToString();
            txtMatNet.Text = matNet.ToString();
            txtFizNet.Text = fizNet.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTurkceNet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatDogru_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatYanlis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatNet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFizDogru_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFizYanlis_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTurkceDogru_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("I LOVE YOU VEYSEL");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
*/