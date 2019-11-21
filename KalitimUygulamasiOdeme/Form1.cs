using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalitimUygulamasiOdeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            Nakit nakit = new Nakit();
            nakit.Tutar = 442;
            nakit.KapidaMi = false;
            nakit.VergiTutari = nakit.Tutar * 0.18;

            KrediKarti krediKarti = new KrediKarti();
            krediKarti.Tutar = 442;
            krediKarti.KartNo = 1234;
            krediKarti.CVC2 = "Rastgele";
            krediKarti.SonaErmeTarihi=Convert.ToDateTime("11.11.2019");
            krediKarti.VergiTutari = krediKarti.Tutar * (0.18 + 0.08);


            Cek cek = new Cek();
            cek.Tutar = 442;
            cek.Kesideci = "Halil";
            cek.OdemeYeri = "İzmir-Menemen";
            cek.VergiTutari = cek.Tutar * (0.18 + 0.18);
            
            MessageBox.Show("!!! ODEME TIPI NAKITTIR !!!"+
                            "\nTutar : " + nakit.Tutar+
                            "\nNakit Ödeme Kapida Mi :" + nakit.KapidaMi +
                            "\nVergi Tutari : " + nakit.VergiTutari);
            MessageBox.Show("!!! ODEME TIPI KREDIKARTIDIR !!!"+
                            "\nTutar : " + krediKarti.Tutar +
                            "\nKart No :" + krediKarti.KartNo +
                            "\nCVC2 : " + krediKarti.CVC2 +
                            "\nKartin Sona Erme Tarihi : " + krediKarti.SonaErmeTarihi.ToLongDateString() +
                             "\nVergi Tutari : "+krediKarti.VergiTutari);
            MessageBox.Show("!!! ODEME TIPI CEKTIR !!! "+
                            "\nTutar : " + cek.Tutar +
                            "\nKesideci : " + cek.Kesideci +
                            "\nOdeme Yeri : " + cek.OdemeYeri +
                             "\nVergi Tutari : " + cek.VergiTutari );
            
        }
    }
}
