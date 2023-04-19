using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DershaneOtomasyon
{
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        // Öğrencilerin sınıf , indirim ve taksit sayılarına göre ödeyeceği miktarı hesaplayan fonksiyon
        {
            if (OdemeIndırımTextBox.Text == "")
            {
                int indirim = 3;
                if (OdemeSınıfComboBox.Text == "5.Sınıf" || OdemeSınıfComboBox.Text == "6.Sınıf" || OdemeSınıfComboBox.Text == "7.Sınıf" || OdemeSınıfComboBox.Text == "8.Sınıf")
                {
                    int tutar = 39000;
                    if (OdemeTaksiktComboBox.Text == "Peşin")
                    {
                        int odenecektutar = tutar - ((tutar * 10 / 100) + (tutar * indirim / 100));
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "3 Taksit")
                    {
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 3;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "6 Taksit")
                    {
                        tutar = tutar + (tutar * 10 / 100);
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 6;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "9 Taksit")
                    {
                        tutar = tutar + (tutar * 18 / 100);
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 9;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                }
                else if (OdemeSınıfComboBox.Text == "9.Sınıf" || OdemeSınıfComboBox.Text == "10.Sınıf" || OdemeSınıfComboBox.Text == "11.Sınıf" || OdemeSınıfComboBox.Text == "12.Sınıf")
                {
                    int tutar = 48000;
                    if (OdemeTaksiktComboBox.Text == "Peşin")
                    {
                        int odenecektutar = tutar - ((tutar * 10 / 100) + (tutar * indirim / 100));
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "3 Taksit")
                    {
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 3;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "6 Taksit")
                    {
                        tutar = tutar + (tutar * 10 / 100);
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 6;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "9 Taksit")
                    {
                        tutar = tutar + (tutar * 18 / 100);
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 9;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();

                    }
                }
                else
                {
                    int tutar = 53000;
                    if (OdemeTaksiktComboBox.Text == "Peşin")
                    {
                        int odenecektutar = tutar - ((tutar * 10 / 100) + (tutar * indirim / 100));
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "3 Taksit")
                    {
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 3;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "6 Taksit")
                    {
                        tutar = tutar + (tutar * 10 / 100);
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 6;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "9 Taksit")
                    {
                        tutar = tutar + (tutar * 18 / 100);
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 9;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();

                    }
                }
            }
            else
            {
                int indirim = Convert.ToInt32(OdemeIndırımTextBox.Text);
                if (OdemeSınıfComboBox.Text == "5.Sınıf" || OdemeSınıfComboBox.Text == "6.Sınıf" || OdemeSınıfComboBox.Text == "7.Sınıf" || OdemeSınıfComboBox.Text == "8.Sınıf")
                {
                    int tutar = 39000;
                    if (OdemeTaksiktComboBox.Text == "Peşin")
                    {
                        int odenecektutar = tutar - ((tutar * 10 / 100) + (tutar * indirim / 100));
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "3 Taksit")
                    {
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 3;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "6 Taksit")
                    {
                        tutar = tutar + (tutar * 10 / 100);
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 6;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "9 Taksit")
                    {
                        tutar = tutar + (tutar * 18 / 100);
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 9;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                }
                else if (OdemeSınıfComboBox.Text == "9.Sınıf" || OdemeSınıfComboBox.Text == "10.Sınıf" || OdemeSınıfComboBox.Text == "11.Sınıf" || OdemeSınıfComboBox.Text == "12.Sınıf")
                {
                    int tutar = 48000;
                    if (OdemeTaksiktComboBox.Text == "Peşin")
                    {
                        int odenecektutar = tutar - ((tutar * 10 / 100) + (tutar * indirim / 100));
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "3 Taksit")
                    {
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 3;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "6 Taksit")
                    {
                        tutar = tutar + (tutar * 10 / 100);
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 6;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "9 Taksit")
                    {
                        tutar = tutar + (tutar * 18 / 100);
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 9;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();

                    }
                }
                else
                {
                    int tutar = 53000;
                    if (OdemeTaksiktComboBox.Text == "Peşin")
                    {
                        int odenecektutar = tutar - ((tutar * 10 / 100) + (tutar * indirim / 100));
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "3 Taksit")
                    {
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 3;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "6 Taksit")
                    {
                        tutar = tutar + (tutar * 10 / 100);
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 6;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();
                    }
                    else if (OdemeTaksiktComboBox.Text == "9 Taksit")
                    {
                        tutar = tutar + (tutar * 18 / 100);
                        int odenecektutar = tutar - (tutar * indirim / 100);
                        int aylıkharc = odenecektutar / 9;
                        OdenecekTutarLabel.Text = odenecektutar.ToString();
                        AylıkOdenecekLabel.Text = aylıkharc.ToString();

                    }
                }

            }
        }
        SqlConnection bag = new SqlConnection("@\"Data Source=PC\\UGUR;Initial Catalog=kullanici;Integrated Security=True\""); //veritabanı bağlantımız
        private void button2_Click(object sender, EventArgs e)
        {
            if (OgrAdTextBox.Text == "")
            {
                MessageBox.Show("Lütfen Öğrenci Adını Giriniz.");
            }
            else if (OgrSoyadTextBox.Text == "")
            {
                MessageBox.Show("Lütfen Öğrencinin Soyadını Giriniz.");
            }
            else if (OgrTcKimlikTextBox.Text == "")
            {
                MessageBox.Show("Lütfen Öğrencinin Kimlik Numarasını Giriniz.");
            }
            else if (OgrDogumTarihiTextBox.Text == "")
            {
                MessageBox.Show("Lütfen Öğrencinin Doğum Tarihini Giriniz.");
            }
            else if (OgrAdresTextBox.Text == "")
            {
                MessageBox.Show("Lütfen Öğrencinin Adresini Giriniz.");
            }
            else if (OgrTelefonNumTextBox.Text == "")
            {
                MessageBox.Show("Lütfen Öğrencinin Telefon Numarasını Giriniz.");
            }
            else if (OkulTextBox.Text == "")
            {
                MessageBox.Show("Lütfen Öğrencinin Okulunu Giriniz.");
            }
            try
            {
                string sorgu = "INSERT INTO tblOgr(OgrAd , OgrSoyad ,OgrTc , OgrAdrs , OgrDogum , OgrTel , OgrOkul , OgrSinif , OgrNo) VALUES(@ogrAd , @ogrSAd , @ogrTC , @ogrAdrs , @ogrDogum , @ogrTel , @ogrOkul , @ogrSinif , @ogrNo)";
                SqlCommand komut = new SqlCommand(sorgu, bag);
                komut.Parameters.AddWithValue("@ogrAd", OgrAdTextBox.Text);
                komut.Parameters.AddWithValue("@ogrSAd", OgrSoyadTextBox.Text);
                komut.Parameters.AddWithValue("@ogrTC", OgrTcKimlikTextBox.Text);

                komut.Parameters.AddWithValue("@ogrDogum", OgrDogumTarihiTextBox.Text);
                komut.Parameters.AddWithValue("@ogrAdrs", OgrAdresTextBox.Text);
                komut.Parameters.AddWithValue("@ogrTel", OgrTelefonNumTextBox.Text);

                komut.Parameters.AddWithValue("@ogrOkul", OkulTextBox.Text);
                komut.Parameters.AddWithValue("@ogrSinif", OgrSınıfComboBox.Text);
                if (bag.State.ToString() == "Closed")
                {
                    bag.Open();
                }
                else
                {
                    bag.Close();
                    bag.Open();
                }
                komut.ExecuteNonQuery();
                bag.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } //Verileri veritabanına kaydetme
        }


    }
}
