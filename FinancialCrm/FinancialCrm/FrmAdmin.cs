using FinancialCrm.Models;
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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text.Trim();
            string sifre = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz");
                return;
            }

            Users user = db.Users.FirstOrDefault(x => x.UserName == kullaniciAdi && x.Password==sifre);

            if (user == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                return;
            }
            
            MessageBox.Show("Giriş başarılı");

            FrmBanks banks = new FrmBanks();
            banks.Show();
            this.Hide();


        }
    }
}
