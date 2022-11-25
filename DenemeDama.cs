using System.Data;
using System.Data.OleDb;
using System.OleDb; 
using System.Text;
using System.Linq;

namespace DamaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string eski = "  ";
        public static PictureBox seciliolan = null;
        public static PictureBox Sender { get; set; }

        private void Form1_Load(object Sender, EventArgs e)
        {

        }
       

        private PictureBox konumdondur(string mevcut_konum)
        {
            
            PictureBox simetri = null;
            if (mevcut_konum == "A1") simetri = "A1";
            else if (mevcut_konum == "A2") simetri = "A2";
            else if (mevcut_konum == "A3") simetri = "A3";
            else if (mevcut_konum == "A4") simetri = "A4";
            else if (mevcut_konum == "A5") simetri = "A5";
            else if (mevcut_konum == "A6") simetri = "A6";
            else if (mevcut_konum == "A7") simetri = "A7";
            else if (mevcut_konum == "A8") simetri = "A8";
            else if (mevcut_konum == "B1") simetri = "B1";
            else if (mevcut_konum == "B2") simetri = "B2";
            else if (mevcut_konum   == "B3") simetri = "B3";
            else if (mevcut_konum == "B4") simetri = "B4";
            else if (mevcut_konum == "B5") simetri = "B5";
            else if (mevcut_konum == "B6") simetri = "B6";
            else if (mevcut_konum == "B7") simetri = "B7";
            else if (mevcut_konum == "B8") simetri = "B8";
            else if (mevcut_konum == "C1") simetri = "C1";
            else if (mevcut_konum == "C2") simetri = "C2";
            else if (mevcut_konum == "C3") simetri = "C3";
            else if (mevcut_konum == "C4") simetri = "C4";
            else if (mevcut_konum == "C5") simetri = "C5";
            else if (mevcut_konum == "C6") simetri = "C6";
            else if (mevcut_konum == "C7") simetri = "C7";
            else if (mevcut_konum == "C8") simetri = "C8";
            else if (mevcut_konum == "D1") simetri = "D1";
            else if (mevcut_konum == "D2") simetri = "D2";
            else if (mevcut_konum == "D3") simetri = "D3";
            else if (mevcut_konum == "D4") simetri = "D4";
            else if (mevcut_konum == "D5") simetri = "D5";
            else if (mevcut_konum == "D6") simetri = "D6";
            else if (mevcut_konum == "D7") simetri = "D7";
            else if (mevcut_konum == "D8") simetri = "D8";
            else if (mevcut_konum == "E1") simetri = "E1";
            else if (mevcut_konum == "E2") simetri = "E2";
            else if (mevcut_konum == "E3") simetri = "E3";
            else if (mevcut_konum == "E4") simetri = "E4";
            else if (mevcut_konum == "E5") simetri = "E5";
            else if (mevcut_konum == "E6") simetri = "E6";
            else if (mevcut_konum == "E7") simetri = "E7";
            else if (mevcut_konum == "E8") simetri = "E8";
            else if (mevcut_konum == "F1") simetri = "F1";
            else if (mevcut_konum == "F2") simetri = "F2";
            else if (mevcut_konum == "F3") simetri = "F3";
            else if (mevcut_konum == "F4") simetri = "F4";
            else if (mevcut_konum == "F5") simetri = "F5";
            else if (mevcut_konum == "F6") simetri = "F6";
            else if (mevcut_konum == "F7") simetri = "F7";
            else if (mevcut_konum == "F8") simetri = "F8";
            else if (mevcut_konum == "G1") simetri = "G1";
            else if (mevcut_konum == "G2") simetri = "G2";
            else if (mevcut_konum == "G3") simetri = "G3";
            else if (mevcut_konum == "G4") simetri = "G4";
            else if (mevcut_konum == "G5") simetri = "G5";
            else if (mevcut_konum == "G6") simetri = "G6";
            else if (mevcut_konum == "G7") simetri = "G7";
            else if (mevcut_konum == "G8") simetri = "G8";
            else if (mevcut_konum == "H1") simetri = "H1";
            else if (mevcut_konum == "H2") simetri = "H2";
            else if (mevcut_konum == "H3") simetri = "H3";
            else if (mevcut_konum == "H4") simetri = "H4";
            else if (mevcut_konum == "H5") simetri = "H5";
            else if (mevcut_konum == "H6") simetri = "H6";
            else if (mevcut_konum == "H7") simetri = "H7";
            else if (mevcut_konum == "H8") simetri = "H8";
            else return simetri;
        }
        private PictureBox simetrikonumdondurme(string mevcut_konum)
        {
            PictureBox simetri = null;
            if (mevcut_konum == "A1") simetri = "A8";
            else if (mevcut_konum == "A2") simetri = "A7";
            else if (mevcut_konum == "A3") simetri = "A6";
            else if (mevcut_konum == "A4") simetri = "A5";
            else if (mevcut_konum == "A5") simetri = "A4";
            else if (mevcut_konum == "A6") simetri = "A3";
            else if (mevcut_konum == "A7") simetri = "A2";
            else if (mevcut_konum == "A8") simetri = "A1";
            else if (mevcut_konum == "B1") simetri = "B8";
            else if (mevcut_konum == "B2") simetri = "B7";
            else if (mevcut_konum == "B3") simetri = "B6";
            else if (mevcut_konum == "B4") simetri = "B5";
            else if (mevcut_konum == "B5") simetri = "B4";
            else if (mevcut_konum == "B6") simetri = "B3";
            else if (mevcut_konum == "B7") simetri = "B2";
            else if (mevcut_konum == "B8") simetri = "B1";
            else if (mevcut_konum == "C1") simetri = "C8";
            else if (mevcut_konum == "C2") simetri = "C7";
            else if (mevcut_konum == "C3") simetri = "C6";
            else if (mevcut_konum == "C4") simetri = "C5";
            else if (mevcut_konum == "C5") simetri = "C4";
            else if (mevcut_konum == "C6") simetri = "C3";
            else if (mevcut_konum == "C7") simetri = "C2";
            else if (mevcut_konum == "C8") simetri = "C1";
            else if (mevcut_konum == "D1") simetri = "D8";
            else if (mevcut_konum == "D2") simetri = "D7";
            else if (mevcut_konum == "D3") simetri = "D6";
            else if (mevcut_konum == "D4") simetri = "D5";
            else if (mevcut_konum == "D5") simetri = "D4";
            else if (mevcut_konum == "D6") simetri = "D3";
            else if (mevcut_konum == "D7") simetri = "D2";
            else if (mevcut_konum == "D8") simetri = "D1";
            else if (mevcut_konum == "E1") simetri = "E8";
            else if (mevcut_konum == "E2") simetri = "E7";
            else if (mevcut_konum == "E3") simetri = "E6";
            else if (mevcut_konum == "E4") simetri = "E5";
            else if (mevcut_konum == "E5") simetri = "E4";
            else if (mevcut_konum == "E6") simetri = "E3";
            else if (mevcut_konum == "E7") simetri = "E2";
            else if (mevcut_konum == "E8") simetri = "E1";
            else if (mevcut_konum == "F1") simetri = "F8";
            else if (mevcut_konum == "F2") simetri = "F7";
            else if (mevcut_konum == "F3") simetri = "F6";
            else if (mevcut_konum == "F4") simetri = "F5";
            else if (mevcut_konum == "F5") simetri = "F4";
            else if (mevcut_konum == "F6") simetri = "F3";
            else if (mevcut_konum == "F7") simetri = "F2";
            else if (mevcut_konum == "F8") simetri = "F1";
            else if (mevcut_konum == "G1") simetri = "G8";
            else if (mevcut_konum == "G2") simetri = "G7";
            else if (mevcut_konum == "G3") simetri = "G6";
            else if (mevcut_konum == "G4") simetri = "G5";
            else if (mevcut_konum == "G5") simetri = "G4";
            else if (mevcut_konum == "G6") simetri = "G3";
            else if (mevcut_konum == "G7") simetri = "G2";
            else if (mevcut_konum == "G8") simetri = "G1";
            else if (mevcut_konum == "H1") simetri = "H8";
            else if (mevcut_konum == "H2") simetri = "H7";
            else if (mevcut_konum == "H3") simetri = "H6";
            else if (mevcut_konum == "H4") simetri = "H5";
            else if (mevcut_konum == "H5") simetri = "H4";
            else if (mevcut_konum == "H6") simetri = "H3";
            else if (mevcut_konum == "H7") simetri = "H2";
            else if (mevcut_konum == "H8") simetri = "H1";
             return simetri;


        }
        private DataTable listele(string sql)
        {

            OleDbConnection baglanti = new (@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\DamaVT.accdb; Persist Security Info = False;);
            baglanti.Open();
            OleDbDataAdapter komut =new (sql,baglanti);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            baglanti.Close();
            return dt;
                }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dt = listele("select * from DHamle where id>" + label3.Text);
            if (dt.Rows.Count > 0)
            {
                listBox1.Items.Add("kullanici:" + dt.Rows[0]["kullanici"].ToString() + "Eski Konumu:" + dt.Rows[0]["mevcut_konum"].ToString() + "Yeni Konum:"dt.Rows[0]["yeni konum:"].ToString() + "\n");
                label3.Text = dt.Rows[0]["id"].ToString();
                if (dt.Rows[0]["kullanici"].ToString() != textBox1.Text)
                    string eski_konum = dt.Rows[0]["mevcut_konum"].ToString();
                string yeni_konum = dt.Rows[0]["yeni_konum"].ToString();
                konumdondur(yeni_konum).Image = konumdondur(eski_konum).Image;
                konumdondur(eski_konum).Image = null;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public static void sqlbaglantisi(string sorgucumlesi)
        {


            OleDbConnection baglanti = new(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = "+Application.StartupPath+ "\\DamaVT.accdb; Persist Security Info = False;);
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand(sorgucumlesi, baglanti);
            sorgu.ExecuteNonQuery();
            baglanti.Close();
        }

        private void A1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A1";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(mevcut_konum,yeni_konum,kullanici,zaman) values('" + eski + "','" + A1 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void A2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A2";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(mevcut_konum,yeni_konum,kullanici,zaman) values('" + eski + "','" + A2 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void A3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A3";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(mevcut_konum,yeni_konum,kullanici,zaman) values('" + eski + "','" + A3 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void A4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A4";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(mevcut_konum,yeni_konum,kullanici,zaman) values('" + eski + "','" + A4 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void A5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A5";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(mevcut_konum,yeni_konum,kullanici,zaman) values('" + eski + "','" + A5 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void A6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A6";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + A6 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void A7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A7";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + A7 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void A8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A8";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "A8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + A8 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void B1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B1";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + B1 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void B2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B2";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + B2 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void B3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B3";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + B3 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void B4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B4";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + B4 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void B5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B5";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + B5 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void B6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B6";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + B6 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void B7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B7";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + B7 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void B8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B8";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "B8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + B8 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void C1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C1";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + C1 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void C2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C2";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + C2 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void C3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C3";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + C3 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void C4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C4";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + C4 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void C5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C5";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + C5 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void C6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C6";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + C6 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void C7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C7";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + C7 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void C8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C8";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "C8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + C8 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void D1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D1";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + D1 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void D2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D2";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + D2 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void D3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D3";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + D3 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void D4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D4";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + D4 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void D5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D5";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + D5 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void D6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D6";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + D6 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void D7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D7";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + D7 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void D8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D8";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "D8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + D8 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void E1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E1";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + E1 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void E2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E2";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + E2 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void E3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E3";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + E3 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void E4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E4";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + E4 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void E5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E5";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + E5 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void E6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E6";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + E6 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void E7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E7";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + E7 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void E8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E8";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "E8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + E8 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void F1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "F1";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "F1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + F1 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void F2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "F2";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "F2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + F2 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void F3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "F3";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "F3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + F3 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void F4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "F4";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "F4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + F4 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void F5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "F5";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "F5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + F5 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void F6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "F6";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "F6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + F6 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void F7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "F7";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "F7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + F7 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void F8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "F8";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "F8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + F8 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void G1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G1";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + G1 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void G2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G2";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + G2 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void G3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G3";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + G3 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void G4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G4";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + G4 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void G5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G5";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + G5 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void G6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G6";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + G6 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void G7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G7";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + G7 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void G8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G8";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "G8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + G8 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void H1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H1";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + H1 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void H2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H2";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + H2 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void H3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H3";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + H3 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void H4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H4";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + H4 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void H5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H5";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + H5 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void H6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H6";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + H6 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void H7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H7";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + H7 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }
        private void H8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H8";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)Sender;
                eski = "H8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("insert into DHamle(2,3,4,5) values('" + eski + "','" + H8 + "','" + TextBox1.Text + "','" + DateTime.Now.ToString("yyyy.mm.dd") + "')'");
                seciliolan.Image = null;
            }
        }

        private void A1_Click(object sender, EventArgs e)
        {

        }

       
    }
    }
}