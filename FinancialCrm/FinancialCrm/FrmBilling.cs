using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            List<Bills> bills = db.Bills.ToList();
            dataGridView1.DataSource = bills;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            List<Bills> bills = db.Bills.ToList();
            dataGridView1.DataSource = bills;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;


            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;

            db.Bills.Add(bills);
            db.SaveChanges();

            MessageBox.Show("Ödeme başarılı bir şekilde sisteme eklendi", "Ödeme ve Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            Bills bills = db.Bills.Find(id);

            db.Bills.Remove(bills);
            db.SaveChanges();

            MessageBox.Show("Başarılı şekilde silindi", "Ödeme ve Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;
            int id = int.Parse(txtBillId.Text);

            Bills bills = db.Bills.Find(id);

            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.SaveChanges();

            MessageBox.Show("Başarılı şekilde güncellendi", "Ödeme ve Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm= new FrmBanks();
            frm.Show();
            this.Hide();
        }
    }
}
