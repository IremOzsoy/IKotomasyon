using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKotomasyon
{
    public partial class IzinIslemleri : Form
    {

        IKEntities db;
        tblPersonelIslemleri calisan;
        tblIzinIslemleri izin;
        List<tblIzinIslemleri> raporluList,ucretsizList,ucretliList;


        int secilenID;
        int toplamRaporlu, toplamUcretsiz, toplamUcretli;
        public IzinIslemleri()
        {
            db = new IKEntities();
            raporluList = new List<tblIzinIslemleri>();
            ucretsizList = new List<tblIzinIslemleri>();
            ucretliList = new List<tblIzinIslemleri>();
            InitializeComponent();
        }

        private void txtBaslangic_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lvPersonel.SelectedItems.Count > 0)
            {
                lvIzinHareketleri.Items.Clear();
                txtPersonelID.Text = lvPersonel.SelectedItems[0].SubItems[0].Text;
                txtAdi.Text = lvPersonel.SelectedItems[0].SubItems[1].Text;
                txtSoyadi.Text = lvPersonel.SelectedItems[0].SubItems[2].Text;

                secilenID = Convert.ToInt32(txtPersonelID.Text);
    
                calisan =
                    (from personel in db.tblPersonelIslemleris
                    where personel.personelID == secilenID
                    select personel).First();

                foreach (var calisanIzin in calisan.tblIzinIslemleris)
                {

                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = calisan.personelID.ToString();
                    lvi.SubItems.Add(calisan.personelAdi);
                    lvi.SubItems.Add(calisan.personelSoyadi);
                    lvi.SubItems.Add(calisanIzin.izinTipi.ToString());
                    lvi.SubItems.Add(calisanIzin.izinGunSayisi.ToString());
                    lvi.SubItems.Add(calisanIzin.izinBaslangicTarihi.ToString());
                    lvi.SubItems.Add(calisanIzin.izinBitisTarihi.ToString());
                    lvi.SubItems.Add(calisanIzin.izinGunSayisi.ToString());
                    lvIzinHareketleri.Items.Add(lvi);



                }

                //foreach (var calisanIzin in calisan.tblIzinIslemleris)
                //{
                //    if ((IzinTipleri)calisanIzin.izinTipi == IzinTipleri.Raporlu)
                //    {
                //        raporluList.Add(calisanIzin);

                //    }
                //    else if ((IzinTipleri)calisanIzin.izinTipi == IzinTipleri.Ucretsiz)
                //    {
                //        ucretsizList.Add(calisanIzin);
                //    }
                //    else if ((IzinTipleri)calisanIzin.izinTipi == IzinTipleri.Mazeret)
                //    {
                //        ucretliList.Add(calisanIzin);
                //    }
                  
                //}
               
            }
            //toplamRaporlu = raporluList.Count;
            //toplamUcretli = ucretliList.Count;
            //toplamUcretsiz = ucretsizList.Count;
            //txtToplamRaporlu.Text = toplamRaporlu.ToString();
            //txtToplamUcretli.Text = toplamUcretli.ToString();
            //txtToplamUcretsiz.Text = toplamUcretsiz.ToString();
            
        }

        private void IzinIslemleri_Load(object sender, EventArgs e)
        {
            // enum sayısı sabit olan değişkenler için kullandığımız bir yapı. İsteğe bağlı numaralandırılır. 
            //numaralandırma verilmezse 0'dan başlar otomatik. Örn. haftanın günleri, sezon,mevsimler.
            cbIzinTipi.DataSource = Enum.GetValues(typeof(IzinTipleri));


            // izin gün hesaplama
            DateTime baslamaTarihi = dtpIzinBaslangic.Value;
            DateTime bitisTarihi = dtpIzinBitis.Value;

            TimeSpan fark = bitisTarihi - baslamaTarihi;
            int izinGunSayisi = (int)fark.TotalDays;

            txtGunSayisi.Text = izinGunSayisi.ToString();


            foreach (tblPersonelIslemleri pList in db.tblPersonelIslemleris)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = pList.personelID.ToString();
                lvi.SubItems.Add(pList.personelAdi);
                lvi.SubItems.Add(pList.personelSoyadi);
                lvi.SubItems.Add(pList.personelTel);
                lvi.SubItems.Add(pList.personelAdres);
                lvPersonel.Items.Add(lvi);

            }
            
                
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            lvIzinHareketleri.Items.Clear();
            izin = new tblIzinIslemleri();

            izin.izinBaslangicTarihi = dtpIzinBaslangic.Value;
            izin.izinBitisTarihi = dtpIzinBitis.Value;
            izin.izinTipi = (int)(Enum.Parse(typeof(IzinTipleri), cbIzinTipi.Text));
            izin.izinGunSayisi = Convert.ToInt32(txtGunSayisi.Text);

            db.tblIzinIslemleris.Add(izin);
            calisan.tblIzinIslemleris.Add(izin);

            db.SaveChanges();

            foreach (var calisanIzin in calisan.tblIzinIslemleris)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = calisan.personelID.ToString();
                lvi.SubItems.Add(calisan.personelAdi);
                lvi.SubItems.Add(calisan.personelSoyadi);
                lvi.SubItems.Add(calisanIzin.izinTipi.ToString());
                lvi.SubItems.Add(calisanIzin.izinGunSayisi.ToString());
                lvi.SubItems.Add(calisanIzin.izinBaslangicTarihi.ToString());
                lvi.SubItems.Add(calisanIzin.izinBitisTarihi.ToString());
                lvi.SubItems.Add(calisanIzin.izinGunSayisi.ToString());
                lvIzinHareketleri.Items.Add(lvi);



            }

        }

        private void dtpIzinBitis_ValueChanged(object sender, EventArgs e)
        {
            // izin gün hesaplama
            DateTime baslamaTarihi = dtpIzinBaslangic.Value;
            DateTime bitisTarihi = dtpIzinBitis.Value;

            TimeSpan fark = bitisTarihi - baslamaTarihi;
            int izinGunSayisi = (int)fark.TotalDays;

            txtGunSayisi.Text = izinGunSayisi.ToString();
        }

        private void dtpIzinBaslangic_ValueChanged(object sender, EventArgs e)
        {
            // izin gün hesaplama
            DateTime baslamaTarihi = dtpIzinBaslangic.Value;
            DateTime bitisTarihi = dtpIzinBitis.Value;

            TimeSpan fark = bitisTarihi - baslamaTarihi;
            int izinGunSayisi = (int)fark.TotalDays;

            txtGunSayisi.Text = izinGunSayisi.ToString();
        }

        private void lvIzinHareketleri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
