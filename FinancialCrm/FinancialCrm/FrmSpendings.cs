using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSpendings : Form
    {
        SqlConnection con; SqlCommand cmd;
        public FrmSpendings()
        {
            InitializeComponent();

        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Spendings> spendings = db.Spendings.ToList();
            dataGridView1.DataSource = spendings;
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            decimal? totalSpend = db.Spendings.Sum(x => x.SpendingAmount ?? 0.00m);
            txtTotalSpend.Text = totalSpend.ToString();

        }
    }



}
