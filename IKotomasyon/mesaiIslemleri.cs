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
    public partial class mesaiIslemleri : Form
    {
        IKEntities db;
        int silinecekID;
        int guncellenecekID;

        List<tblPersonelIslemleri> personelList;
        tblPersonelIslemleri calisan;
        tblMesaiIslemleri silinecekMesai;
        tblMesaiIslemleri guncellenecekMesai;
        public mesaiIslemleri()
        {
            InitializeComponent();
            db = new IKEntities();
            personelList = new List<tblPersonelIslemleri>();
            foreach (tblPersonelIslemleri item in db.tblPersonelIslemleris)
            {
                personelList.Add(item);
            }
        }



        private void mesaiIslemleri_Load(object sender, EventArgs e)
        {
            dtpGirisSaati.Format = DateTimePickerFormat.Time;
            dtpGirisSaati.ShowUpDown = true;
            dtpCikisSaati.Format = DateTimePickerFormat.Time;
            dtpCikisSaati.ShowUpDown = true;


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

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            tblMesaiIslemleri yeniMesai = new tblMesaiIslemleri();

            yeniMesai.mesaiTarihi = dtpMesaiTarih.Value;

            yeniMesai.girisSaati = dtpGirisSaati.Value;
            yeniMesai.cikisSaati = dtpCikisSaati.Value;

            db.tblMesaiIslemleris.Add(yeniMesai);
            calisan.tblMesaiIslemleris.Add(yeniMesai);

            db.SaveChanges();
            lvMesai.Items.Clear();
            foreach (tblMesaiIslemleri mesai in calisan.tblMesaiIslemleris)
            {
                DateTime giris = (DateTime)mesai.girisSaati;
                DateTime cikis = (DateTime)mesai.cikisSaati;

                ListViewItem lvi = new ListViewItem();

                lvi.Text = mesai.mesaiID.ToString();
                lvi.SubItems.Add(mesai.ToString());//saati almamak için tostringi override ettik.
                lvi.SubItems.Add(calisan.personelAdi);
                lvi.SubItems.Add(calisan.personelSoyadi);
                lvi.SubItems.Add(giris.TimeOfDay.ToString());
                lvi.SubItems.Add(cikis.TimeOfDay.ToString());
                lvMesai.Items.Add(lvi);


            }

        }

        private void lvPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvMesai.Items.Clear();
            if (lvPersonel.SelectedItems.Count > 0)
            {
                int secilenID;


                txtPersonelID.Text = lvPersonel.SelectedItems[0].SubItems[0].Text;
                txtAdi.Text = lvPersonel.SelectedItems[0].SubItems[1].Text;
                txtSoyadi.Text = lvPersonel.SelectedItems[0].SubItems[2].Text;
                //tc kimlik numarası da gelmeli.
                // personel listesi alanına search getirilmeli


                secilenID = Convert.ToInt32(txtPersonelID.Text);

                var idSorgu =
                    from personel in db.tblPersonelIslemleris
                    where personel.personelID == secilenID
                    select personel;

                foreach (var personel in idSorgu)
                {
                    if (secilenID == personel.personelID)
                    {
                        calisan = personel;
                    }

                }
                if (lvPersonel.SelectedItems.Count >= 0)
                {
                    foreach (tblMesaiIslemleri mesai in calisan.tblMesaiIslemleris)
                    {
                        DateTime giris = (DateTime)mesai.girisSaati;
                        DateTime cikis = (DateTime)mesai.cikisSaati;

                        ListViewItem lvi = new ListViewItem();

                        lvi.Text = mesai.mesaiID.ToString();
                        lvi.SubItems.Add(mesai.ToString());//saati almamak için tostringi override ettik.
                        lvi.SubItems.Add(calisan.personelAdi);
                        lvi.SubItems.Add(calisan.personelSoyadi);
                        lvi.SubItems.Add(giris.TimeOfDay.ToString());
                        lvi.SubItems.Add(cikis.TimeOfDay.ToString());
                        lvMesai.Items.Add(lvi);


                    }
                }
                else
                {

                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvMesai.SelectedItems.Count > 0)
            {


                txtMesaiID.Text = lvMesai.SelectedItems[0].SubItems[0].Text;


                silinecekID = Convert.ToInt32(txtMesaiID.Text);

                var idSorgu =
                    from mesai in db.tblMesaiIslemleris
                    where mesai.mesaiID == silinecekID
                    select mesai;

                foreach (var mesai in idSorgu)
                {
                    silinecekMesai = mesai;
                }
                db.tblMesaiIslemleris.Remove(silinecekMesai);
                lvMesai.Items.Remove(lvMesai.SelectedItems[0]);
                db.SaveChanges();

            }

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {

            if (lvMesai.SelectedItems.Count > 0)
            {
                lvMesai.Items.Clear();

                guncellenecekMesai.mesaiTarihi = dtpMesaiTarih.Value;
                guncellenecekMesai.girisSaati = dtpGirisSaati.Value;
                guncellenecekMesai.cikisSaati = dtpCikisSaati.Value;

                db.SaveChanges();

                foreach (tblMesaiIslemleri mesai in calisan.tblMesaiIslemleris)
                {
                    DateTime giris = (DateTime)mesai.girisSaati;
                    DateTime cikis = (DateTime)mesai.cikisSaati;

                    ListViewItem lvi = new ListViewItem();

                    lvi.Text = mesai.mesaiID.ToString();
                    lvi.SubItems.Add(mesai.ToString());//saati almamak için tostringi override ettik.
                    lvi.SubItems.Add(calisan.personelAdi);
                    lvi.SubItems.Add(calisan.personelSoyadi);
                    lvi.SubItems.Add(giris.TimeOfDay.ToString());
                    lvi.SubItems.Add(cikis.TimeOfDay.ToString());
                    lvMesai.Items.Add(lvi);


                }

            }


        }

        private void lvMesai_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvMesai.SelectedItems.Count > 0)
            {
                txtMesaiID.Text = lvMesai.SelectedItems[0].SubItems[0].Text;
                guncellenecekID = Convert.ToInt32(txtMesaiID.Text);
                guncellenecekMesai = (from mesai in db.tblMesaiIslemleris
                                      where mesai.mesaiID == guncellenecekID
                                      select mesai).First();

                dtpMesaiTarih.Value = guncellenecekMesai.mesaiTarihi.Value;
                dtpGirisSaati.Value = guncellenecekMesai.girisSaati.Value;
                dtpCikisSaati.Value = guncellenecekMesai.cikisSaati.Value;
            }

        }
    }
}
