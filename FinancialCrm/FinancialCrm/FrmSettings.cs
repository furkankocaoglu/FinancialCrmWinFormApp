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
        public static class AppSettings
        {
            public static Color CurrentColorScheme { get; set; } = Color.White; 
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Mavi");
            comboBox1.Items.Add("Yeşil");
            comboBox1.Items.Add("Kırmızı");
            comboBox1.Items.Add("Varsayılan");

            
            if (AppSettings.CurrentColorScheme == Color.LightBlue)
                comboBox1.SelectedIndex = 0;
            else if (AppSettings.CurrentColorScheme == Color.LightGreen)
                comboBox1.SelectedIndex = 1;
            else if (AppSettings.CurrentColorScheme == Color.LightCoral)
                comboBox1.SelectedIndex = 2;
            else
                comboBox1.SelectedIndex = 3;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    AppSettings.CurrentColorScheme = Color.LightBlue; 
                    break;
                case 1:
                    AppSettings.CurrentColorScheme = Color.LightGreen; 
                    break;
                case 2:
                    AppSettings.CurrentColorScheme = Color.LightCoral; 
                    break;
                default:
                    AppSettings.CurrentColorScheme = Color.White; 
                    break;
            }

            
            ApplyColorSchemeToOtherForms();
        }
        private void ApplyColorSchemeToOtherForms()
        {
            
            foreach (Form form in Application.OpenForms)
            {
                
                form.BackColor = AppSettings.CurrentColorScheme;
            }
        }

        private void frmDashboardButton_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmCategoryButton_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();

        }

        private void frmBankButton_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void frmFaturaButton_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();

        }

        private void frmBillForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();

        }

        private void frmBankProccessButton_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show(); 
            this.Hide();
        }
    }
}
