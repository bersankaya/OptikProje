using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Optik_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-AGQ4V6UP\WOLVOX8;Initial Catalog=HareketProje;Integrated Security=True");
       void kayit()
        {
            SqlDataAdapter da = new SqlDataAdapter("execute HareketProje", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hareketProjeDataSet1.HAREKETLER' table. You can move, or remove it, as needed.
            this.hAREKETLERTableAdapter.Fill(this.hareketProjeDataSet1.HAREKETLER);
            // TODO: This line of code loads data into the 'hareketProjeDataSet.HareketProje' table. You can move, or remove it, as needed.
            this.hareketProjeTableAdapter.Fill(this.hareketProjeDataSet.HareketProje);




            SqlCommand komut = new SqlCommand("select * from URUNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            SqlCommand komut1= new SqlCommand("Select * from MUSTERILER", baglanti);
            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            SqlCommand komut2 = new SqlCommand("select * from PERSONELLER", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);


            //Ürünleri çekme cmb
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("Select AD From URUNLER", baglanti);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                CmbUrunler.Items.Add(dr[0]);
            }
            baglanti.Close();

            //Müşteri Çekme cmb
            baglanti.Open();
            SqlCommand kmt1 = new SqlCommand("select ADSOYAD From MUSTERILER", baglanti);
            SqlDataReader dr1 = kmt1.ExecuteReader();
            while (dr1.Read())
            {
                CmbMusteri.Items.Add(dr1[0]);
            }
            baglanti.Close();

            //Personel Çekme cmb
            baglanti.Open();
            SqlCommand kmt2 = new SqlCommand("Select AD from PERSONELLER", baglanti);
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                CmbPersonel.Items.Add(dr2[0]);
            }
            baglanti.Close();


            //displaymember & valueMember
            CmbUrunler.DisplayMember = "AD";
            CmbUrunler.ValueMember = "ID";
            CmbUrunler.DataSource = dt;
            CmbMusteri.DisplayMember = "ADSOYAD";
            CmbMusteri.ValueMember = "ID";
            CmbMusteri.DataSource = dt1;
            CmbPersonel.DisplayMember = "AD";
            CmbPersonel.ValueMember = "ID";
            CmbPersonel.DataSource = dt2;
            CmbUrunler.Text = "";
            CmbMusteri.Text = "";
            CmbPersonel.Text = "";


        }
        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into HAREKETLER (URUN,MUSTERI,PERSONEL,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
            //COMBOBOXTAN SEÇİLEN DEĞERİ STRİNG OLARAK TXTİD YAZDIR CmbUrunler.SelectedValue.ToString()
            komut.Parameters.AddWithValue("@p1", byte.Parse(CmbUrunler.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@p2", byte.Parse(CmbMusteri.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@p3", byte.Parse(CmbPersonel.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@p4", TxtFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            int stok = Convert.ToInt32(LblStok.Text);
            stok--;
            LblStok.Text = stok.ToString();
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Update URUNLER set STOK=@T1 where AD=@T2",baglanti);
            komut1.Parameters.AddWithValue("@T1",int.Parse( LblStok.Text));
            komut1.Parameters.AddWithValue("@T2", CmbUrunler.Text);
            komut1.ExecuteNonQuery();   
            baglanti.Close();
            kayit();
            
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into URUNLER (AD,STOK,ALISFIYAT,SATISFIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtStok.Text);
            komut.Parameters.AddWithValue("@p3", TxtAlisFiyat.Text);
            komut.Parameters.AddWithValue("@p4", TxtSatisfiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            FRMURUN FR = new FRMURUN();
            FR.Show();
        }

        private void CmbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select STOK from URUNLER WHERE AD=@P1 ", baglanti);
            kmt.Parameters.AddWithValue("@P1", CmbUrunler.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                LblStok.Text = dr[0].ToString();

            }
            LblUrunAd.Text = CmbUrunler.Text;
            baglanti.Close();
        }
    }
}
