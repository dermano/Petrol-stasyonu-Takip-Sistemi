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
using System.Globalization;

namespace Test_Petrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0NNHPCV\SQLEXPRESS;Initial Catalog=TestBenzin;Integrated Security=True");
        void listele()
        {
            //Kurşunsuz 95 Satış Fiyatı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLBENZIN where petroltur='Kurşunsuz 95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKursunsuz.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                LblKursunsuzLitre.Text = dr[4].ToString();
            }
            baglanti.Close();

            //Diesel Satış Fiyatı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From TBLBENZIN where petroltur='V/Max Diesel'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblDiesel.Text = dr2[3].ToString();
                progressBar2.Value = int.Parse(dr2[4].ToString());
                LblDiesselLitre.Text = dr2[4].ToString();
            }
            baglanti.Close();

            // Gazyağı Satış Fiyatı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * From TBLBENZIN where petroltur='Gazyağı'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblGazyagi.Text = dr3[3].ToString();
                progressBar3.Value = int.Parse(dr3[4].ToString());
                LblGazLitre.Text = dr3[4].ToString();
            }
            baglanti.Close();

            //PO/gaz Otogaz Satış Fiyatı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * From TBLBENZIN where petroltur='PO/gaz Otogaz'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblOtogaz.Text = dr4[3].ToString();
                progressBar4.Value = int.Parse(dr4[4].ToString());
                LblOtogazLitre.Text = dr4[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from tblkasa", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                Lblkasa.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(LblKursunsuz.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;
            TxtKursunsuzFiyat.Text = tutar.ToString();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double diesel, litre, tutar;
            diesel = Convert.ToDouble(LblDiesel.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = diesel * litre;
            TxtDieselFİyat.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double gazyagi, litre, tutar;
            gazyagi = Convert.ToDouble(LblGazyagi.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = gazyagi * litre;
            TxtGazyagıFiyat.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double otogaz, litre, tutar;
            otogaz = Convert.ToDouble(LblOtogaz.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = otogaz * litre;
            TxtOtogazFiyat.Text = tutar.ToString();
        }

        private void BtnDepoDoldur_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (plaka,benzınturu,lıtre,fıyat) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kurşunsuz 95");
                komut.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtKursunsuzFiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update tblkasa set mıktar =mıktar+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtKursunsuzFiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update tblbenzın set stok = stok-@p1 where petroltur='Kurşunsuz 95'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown1.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();

            }
            if (numericUpDown2.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (plaka,benzınturu,lıtre,fıyat) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "V/Max Diesel");
                komut.Parameters.AddWithValue("@p3", numericUpDown2.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtDieselFİyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update tblkasa set mıktar = mıktar + @tutar", baglanti);
                komut2.Parameters.AddWithValue("@tutar", decimal.Parse(TxtDieselFİyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update tblbenzın set stok = stok - @lt where petroltur='V/Max Diesel'", baglanti);
                komut3.Parameters.AddWithValue("@lt", numericUpDown2.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            if (numericUpDown3.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (plaka,benzınturu,lıtre,fıyat) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Gazyağı");
                komut.Parameters.AddWithValue("@p3", numericUpDown3.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtGazyagıFiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update tblkasa set mıktar = mıktar + @tutar", baglanti);
                komut2.Parameters.AddWithValue("@tutar", decimal.Parse(TxtGazyagıFiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update tblbenzın set stok = stok - @lt where petroltur='Gazyağı'", baglanti);
                komut3.Parameters.AddWithValue("@lt", numericUpDown3.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            if (numericUpDown4.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (plaka,benzınturu,lıtre,fıyat) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "PO/gaz Otogaz");
                komut.Parameters.AddWithValue("@p3", numericUpDown4.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtOtogazFiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update tblkasa set mıktar = mıktar + @tutar", baglanti);
                komut2.Parameters.AddWithValue("@tutar", decimal.Parse(TxtOtogazFiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update tblbenzın set stok = stok - @lt where petroltur='PO/gaz Otogaz'", baglanti);
                komut3.Parameters.AddWithValue("@lt", numericUpDown4.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            MessageBox.Show("Satış yapıldı");
            listele();


        }

        // BtnSatinAl_Click içine:
        private void BtnSatinAl_Click(object sender, EventArgs e)
        {
            // 1) Seçim kontrolü
            if (cmbAlisTur.SelectedIndex == -1)
            {
                MessageBox.Show("Benzin türünü seçin.");
                return;
            }

            // 2) Litre kontrolü
            if (!decimal.TryParse(TxtAlınacakMiktar.Text.Replace(",", "."),
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out decimal litre) || litre <= 0)
            {
                MessageBox.Show("Geçerli litre girin!");
                return;
            }

            decimal alisFiyat = 0m;

            // 3) DB'den ALISFIYAT çek
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(
                    "SELECT ALISFIYAT FROM TBLBENZIN WHERE PETROLTUR = @p",
                    baglanti
                );
                komut.Parameters.AddWithValue("@p", cmbAlisTur.Text);

                object o = komut.ExecuteScalar();
                baglanti.Close();

                if (o == null)
                {
                    MessageBox.Show("Seçilen ürünün ALIŞ fiyatı bulunamadı! Veritabanı yazısı farklı olabilir.");
                    return;
                }

                alisFiyat = Convert.ToDecimal(o);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL HATASI: " + ex.Message);
                baglanti.Close();
                return;
            }

            // 4) Tutar hesapla
            decimal tutar = litre * alisFiyat;
            TxtAlisTutar.Text = tutar.ToString("0.00");

            try
            {
                // 5) Kasa düş
                baglanti.Open();
                SqlCommand komutKas = new SqlCommand(
                    "UPDATE TBLKASA SET MIKTAR = MIKTAR - @tutar",
                    baglanti
                );
                komutKas.Parameters.AddWithValue("@tutar", tutar);
                komutKas.ExecuteNonQuery();
                baglanti.Close();

                // 6) Stok artır
                baglanti.Open();
                SqlCommand komutStok = new SqlCommand(
                    "UPDATE TBLBENZIN SET STOK = STOK + @l WHERE PETROLTUR = @p",
                    baglanti
                );
                komutStok.Parameters.AddWithValue("@l", litre);
                komutStok.Parameters.AddWithValue("@p", cmbAlisTur.Text);
                komutStok.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Depo yakıt alımı tamamlandı.");
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
                baglanti.Close();
            }
        }

        private void HesaplaTutar()
        {
            if (string.IsNullOrWhiteSpace(cmbAlisTur.Text)) return;
            if (string.IsNullOrWhiteSpace(TxtAlınacakMiktar.Text)) return;

            // Miktar sayı mı kontrol et
            if (!double.TryParse(TxtAlınacakMiktar.Text, out double litre))
            {
                TxtAlisTutar.Text = "";
                return;
            }

            // Veritabanından ALISFIYAT çek
            baglanti.Open();
            SqlCommand komut = new SqlCommand(
                "SELECT ALISFIYAT FROM TBLBENZIN WHERE PETROLTUR=@p",
                baglanti
            );
            komut.Parameters.AddWithValue("@p", cmbAlisTur.Text);
            object o = komut.ExecuteScalar();
            baglanti.Close();

            if (o == null || o == DBNull.Value)
            {
                TxtAlisTutar.Text = "";
                return;
            }

            decimal alisFiyat = Convert.ToDecimal(o);

            // Hesapla
            decimal tutar = alisFiyat * (decimal)litre;
            TxtAlisTutar.Text = tutar.ToString("0.00");
        }

        private void TxtAlınacakMiktar_TextChanged(object sender, EventArgs e)
        {
            if (cmbAlisTur.SelectedIndex == -1) return;
            if (TxtAlınacakMiktar.Text == "") { TxtAlisTutar.Text = ""; return; }

            double litre, alisfiyat, tutar;

            litre = double.Parse(TxtAlınacakMiktar.Text);

            // Seçili ürünün alış fiyatını çek
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ALISFIYAT from TBLBENZIN where petroltur=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbAlisTur.Text);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            alisfiyat = Convert.ToDouble(dr[0]);
            baglanti.Close();

            tutar = litre * alisfiyat;
            TxtAlisTutar.Text = tutar.ToString("0.00");
            HesaplaTutar();
        }


        private void TxtAlisTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbAlisTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            HesaplaTutar();
        }
    }
}
