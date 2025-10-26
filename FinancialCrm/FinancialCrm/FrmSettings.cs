using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                // Türkçe dilini seçti
                Label.Text = "Ayarlar";  // Örnek: Başlık metnini Türkçe'ye çevir
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                // İngilizce dilini seçti
                lblTitle.Text = "Settings";  // Örnek: Başlık metnini İngilizce'ye çevir
            }
        }
    }
}
