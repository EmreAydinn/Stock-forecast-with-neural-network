using System;
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
    public partial class FormInput1 : Form
    {
        public FormInput1()
        {
            InitializeComponent();
        }
        public static int gizli_katman_sayısı;
        public static double ögrenme_katsayısı;
        public static double momentum_katsayısı;
        public static int eğitim_yüzdesi;
        public static double sonlanma_için_hata_oranı;
        public static int sonlanma_için_iterasyon_sayısı;
        public static bool epoch = true;
        private void buttonileri_Click(object sender, EventArgs e)
        {
           
            if (textBoxgizli_katman.Text== "")
            {
                MessageBox.Show("Gizli Katman Sayısı Girilmedi !");
            }
            else
            {
                gizli_katman_sayısı = Convert.ToInt32(textBoxgizli_katman.Text);
                momentum_katsayısı = double.Parse(textBoxmomentum_katsayısı.Text);
                ögrenme_katsayısı = double.Parse(textBoxögrenme_katsayısı.Text);

                eğitim_yüzdesi = int.Parse(textBoxeğitim_yüzdesi.Text);
                sonlanma_için_hata_oranı = Convert.ToDouble(numericUpDownhata_oranı.Value);
                sonlanma_için_iterasyon_sayısı = int.Parse(textBoxsonlanma_iterasyonu.Text);
                FormInput2 frminpt2 = new FormInput2();

                frminpt2.gizli_katman_sayısı = gizli_katman_sayısı;
                frminpt2.Show();
                this.Hide();
            }
        
        }

        private void buttoniptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButtonepoch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonepoch.Checked)
            {
                epoch = true;
                textBoxsonlanma_iterasyonu.Enabled = true;
                numericUpDownhata_oranı.Enabled = false;
            }
            else
            {
                epoch = false;
                textBoxsonlanma_iterasyonu.Enabled = false;
                numericUpDownhata_oranı.Enabled = true;
            }
        }

        private void textBoxgizli_katman_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
