namespace DershaneOtomasyon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        


        private void PrsGirisButton_Click(object sender, EventArgs e)
        {
            PersonelGiris personelGiris = new PersonelGiris();
            personelGiris.ShowDialog();
            Hide();

        }

        private void OgrGirisButton_Click(object sender, EventArgs e)
        {

            OgrenciGiris ogrenciGiris = new OgrenciGiris();
            ogrenciGiris.ShowDialog();
            Hide();
        }
    }
}