using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyleri

            decimal ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault() ?? 0.0m;
            decimal vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault() ?? 0.0m;
            decimal isBankasi = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault() ?? 0.0m;

            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + "₺";
            lblVakifBankBalance.Text = vakifBankBalance.ToString() + "₺";
            lblIsBankasiBalance.Text = isBankasi.ToString() + "₺";

            //Banka Hareketleri

            BankProcesses bankProccess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProccess1.Text = bankProccess1?.Description + " " + bankProccess1.Amount + " ₺ " + bankProccess1?.ProcessDate?.ToString("dd-MM-yyyy");

            BankProcesses bankProccess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault(); //( sondan aşağıya doğru 2.yi al ama 1.yi geç )
            lblBankProccess2.Text = bankProccess2?.Description + " " + bankProccess2.Amount + " ₺ " + bankProccess2?.ProcessDate?.ToString("dd-MM-yyyy");

            BankProcesses bankProccess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProccess3.Text = bankProccess3?.Description + " " + bankProccess3.Amount + " ₺ " + bankProccess3?.ProcessDate?.ToString("dd-MM-yyyy");

            BankProcesses bankProccess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProccess4.Text = bankProccess4?.Description + " " + bankProccess4.Amount + " ₺ " + bankProccess4?.ProcessDate?.ToString("dd-MM-yyyy");

            BankProcesses bankProccess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProccess5.Text = bankProccess5?.Description + " " + bankProccess5.Amount + " ₺ " + bankProccess5?.ProcessDate?.ToString("dd-MM-yyyy");

        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm= new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void frmDashboardButton_Click(object sender, EventArgs e)
        {
            FrmDashboard frm= new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory frm= new FrmCategory(); 
            frm.Show();
            this.Hide();
        }
    }
}
