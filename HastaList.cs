using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Otomasyon
{
    public partial class HastaList : Form
    {
        public HastaList()
        {
            InitializeComponent();
        }

        private void HastaList_Load(object sender, EventArgs e)
        {
            BilgiGetir();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BPP0FPL\\Batuhan;Initial Catalog=HastaneOtamasyon;Integrated Security=True;");
        DataTable tablo = new DataTable();
        private void BilgiGetir()
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select HastaID,Ad,Soyad,Cinsiyet,Tel,Adres,Dtarihi,Kan,Tc FROM HastaBilgileri Where Durumu='Kalıyor' ORDER BY HastaID DESC", baglanti);
            adapter.Fill(tablo);
            ekran.DataSource = tablo;
            baglanti.Close();
        }
    }
}
