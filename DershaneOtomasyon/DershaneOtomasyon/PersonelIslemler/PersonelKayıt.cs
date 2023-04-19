using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DershaneOtomasyon.PersonelIslemler
{
    public partial class PersonelKayit : Form
    {
        public PersonelKayit()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=PC\UGUR;Initial Catalog=kullanici;Integrated Security=True");
        SqlCommand command = new SqlCommand();


        private void KayıtButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string Sql = "select * from dershane where" +
                    " PrsAdi=@PrsAdi, PrsSoyad=@PrsSoyad, PrsTc=@PrsTc," +
                    " PrsDogum=@PrsDogum, PrsAdres=@PrsAdres, PrsTel=@PrsTel, " +
                    "PrsMeslek=@PrsMeslek, PrsUnvan=@PrsUnvan, PrsMaas=@PrsMaas, " +
                    "PrsSozlesmeBas=@PrsSozlesmeBas, PrsSozlesmeBit=@PrsSozlesmeBit ";

                SqlParameter PrsAdi = new SqlParameter("PrsAdi", PersonelAdTextBox.Text.Trim());
                SqlParameter PrsSoyad = new SqlParameter("PrsSoyad", PersonelSoyadTextBox.Text.Trim());
                SqlParameter PrsTc = new SqlParameter("PrsTc", PersonelTcTextBox.Text.Trim());
                SqlParameter PrsDogum = new SqlParameter("PrsDogum", PersonelDogumTextBox.Text.Trim());
                SqlParameter PrsAdres = new SqlParameter("PrsAdres", PersonelAdresTextBox.Text.Trim());
                SqlParameter PrsTel = new SqlParameter("PrsTel", PersonelTelNumTextBox.Text.Trim());
                SqlParameter PrsMeslek = new SqlParameter("PrsMeslek", PersonelPozisyonTextBox.Text.Trim());
                SqlParameter PrsUnvan = new SqlParameter("PrsUnvan", PersonelUnvanTextBox.Text.Trim());
                SqlParameter PrsMaas = new SqlParameter("PrsMaas", PersonelMaasTextBox.Text.Trim());
                SqlParameter PrsSozlesmeBas = new SqlParameter("PrsSozlesmeBas", PersonelSözlesmeTarihiTextBox.Text.Trim());

                command.Parameters.Add(PrsAdi);
                command.Parameters.Add(PrsSoyad);
                command.Parameters.Add(PrsTc);
                command.Parameters.Add(PrsDogum);
                command.Parameters.Add(PrsAdres);
                command.Parameters.Add(PrsTel);
                command.Parameters.Add(PrsMeslek);
                command.Parameters.Add(PrsUnvan);
                command.Parameters.Add(PrsMaas);
                command.Parameters.Add(PrsSozlesmeBas);

                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    MainForm DershaneMain = new MainForm();
                    DershaneMain.Show();
                }
                this.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("HATA");
            }
        }
    }
}
