using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD_DD_F_K_HisseBaşınaKar
{
    public partial class FormInput2 : Form
    {
        public FormInput2()
        {
            InitializeComponent();
        }
        public double[] gercek_degerler;
        public static int hepsiaynıNöronSayısı = 0;
        public int gizli_katman_sayısı;
        private TextBox[] txtSoru;
        Dugum dügüm;
        int deger = 0;

        private void backgroundWorkereğitim_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void backgroundWorkereğitim_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Eğtim Tamamlandı");
            switch (deger)
            {
                case 0: gercek_degerler = (double[])dügüm.akbankhissefiyatı_gercek.Clone(); break;
                case 1: gercek_degerler = (double[])dügüm.işbankasıhissefiyatı_gercek.Clone(); break;
                case 2: gercek_degerler = (double[])dügüm.koçhissefiyatı_gercek.Clone(); break;
            }
            int test_verisi_sayısı = dügüm.dolar.Length - dügüm.eğitim_sayısı;
            listBox1.Items.Clear();
            // gerçek hisse değerleri listboxa atıldı.
            for (int i = dügüm.eğitim_sayısı; i < dügüm.dolar.Length; i++)
            {
                listBox1.Items.Add(gercek_degerler[i].ToString());
            }

        }
        private void backgroundWorkereğitim_DoWork(object sender, DoWorkEventArgs e)
        {
            int percantage = 0;
            int sayaç = 0;
            if (dügüm.epoch)
            {
                do
                {
                    dügüm.net__hata_yeniağırlıklar_hesapla_ak_bankası();
                    sayaç++;
                    percantage = sayaç * 100 / dügüm.sonlanma_için_iterasyon_sayısı;
                    backgroundWorkereğitim.ReportProgress(percantage);

                } while (dügüm.sonlanma_için_iterasyon_sayısı >= sayaç);
            }
            else
            {
                do
                {
                    dügüm.net__hata_yeniağırlıklar_hesapla_ak_bankası();
                    sayaç++;
                    
                   // percantage = sayaç * 100 / dügüm.sonlanma_için_iterasyon_sayısı;
                   // backgroundWorkereğitim.ReportProgress(percantage);

                } while (dügüm.ToplamHata >= dügüm.sonlanma_için_hata_oranı);
               // labelepochsayısı.Text = sayaç.ToString();
            }

            
        }
        private void FormInput2_Load(object sender, EventArgs e)
        {
            comboBoxşirketler.SelectedIndex = 0;
            backgroundWorkereğitim.WorkerReportsProgress = true;
            txtSoru = new TextBox[gizli_katman_sayısı];

            for (int i = 0; i < gizli_katman_sayısı; i++)
            {
                txtSoru[i] = new TextBox();

                txtSoru[i].ScrollBars = ScrollBars.Vertical;
                txtSoru[i].Location = new Point(40, (20 * (i + 1))+40);
                txtSoru[i].Size = new Size(40, 20);

                panel1.Controls.Add(txtSoru[i]);
            }
            radiobuttonkontrol();
        }

        private void radioButtonhepsiaynı_CheckedChanged(object sender, EventArgs e)
        {
            radiobuttonkontrol();
        }

        public void radiobuttonkontrol()
        {
            textBoxhepsiaynı.Enabled = true;
            if (radioButtonhepsiaynı.Checked == true)
            {
                for (int i = 0; i < txtSoru.Length; i++)
                {
                    txtSoru[i].Enabled = false;
                }
            }
            else if (radioButtontektek.Checked == true)
            {
                textBoxhepsiaynı.Enabled = false;
                textBoxhepsiaynı.Text = "";
                for (int i = 0; i < txtSoru.Length; i++)
                {
                    txtSoru[i].Enabled = true;
                }
            }
        }

        private void textBoxhepsiaynı_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtSoru.Length; i++)
            {
                txtSoru[i].Text = textBoxhepsiaynı.Text; ;
            }
        }
        public static int[] nöronDizileri;
        
        private void buttoneğit_Click(object sender, EventArgs e)
        {
            buttontest.Enabled = true;
            bool sıfırmı = true;
            hepsiaynıNöronSayısı = 0;
            // kontroller sonra yapılacak.
            nöronDizileri = new int[gizli_katman_sayısı];

            if (radioButtonhepsiaynı.Checked == true)
            {
              
                if (textBoxhepsiaynı.Text == "0" || textBoxhepsiaynı.Text== "")
                {
                    MessageBox.Show("Nöron Sayısı Girilmedi !");
                }
                else
                {
                    hepsiaynıNöronSayısı = int.Parse(textBoxhepsiaynı.Text);
                    dügüm = new Dugum();
                    gercek_degerler = new double[dügüm.dolar.Length];
                    dügüm.degerAta(deger);
                    backgroundWorkereğitim.RunWorkerAsync();
                }
            }

            else if (radioButtontektek.Checked == true)
            {
                for (int i = 0; i < gizli_katman_sayısı; i++)
                {
                    if (txtSoru[i].Text =="")
                    {
                        MessageBox.Show("Nöron Sayısı Eksik Girildi !");
                        sıfırmı = false;
                    }
                    else
                    {
                        nöronDizileri[i] = int.Parse(txtSoru[i].Text);
                        if (nöronDizileri[i] == 0)
                            sıfırmı = false;
                    }
                   
                }
                if (sıfırmı)
                {
                    dügüm = new Dugum();
                    gercek_degerler = new double[dügüm.dolar.Length];
                    dügüm.degerAta(deger);
                    backgroundWorkereğitim.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Nöron Sayısı Eksik Girildi !");
                }
            }
        }
        double max, min;
        private void buttontest_Click(object sender, EventArgs e)
        {
            ArrayList testSonuc = new ArrayList();
            ArrayList gerçekSonuç = new ArrayList();
            listBox2.Items.Clear();
            
            switch (deger)
            {
                case 0: max = dügüm.akhissemax;  min = dügüm.akhissemin; break;
                case 1: max = dügüm.işhissemax; min = dügüm.işhissemin; break;
                case 2: max = dügüm.koçhissemax; min = dügüm.koçhissemin; break;
            }
            testSonuc.AddRange(dügüm.test_işlemi_ak_bankası());
            gerçekSonuç.AddRange(dügüm.deNormalizasyon(testSonuc, max, min));

            for (int i = 0; i < testSonuc.Count; i++)
            {
                listBox2.Items.Add(gerçekSonuç[i].ToString());
            }
        }

        private void buttongeri_Click(object sender, EventArgs e)
        {
            FormInput1 form1 = new FormInput1();
            form1.Show();
            this.Hide();
        }

        private void buttoniptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void textBoxhepsiaynı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FormInput2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxşirketler_SelectedIndexChanged(object sender, EventArgs e)
        {
            deger = comboBoxşirketler.SelectedIndex;
        }
    }
}
