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


            var categoryTotalSpendings = db.Spendings.GroupBy(x => x.CategoryId).Select(g => new
            {
                CategoryId = g.Key,
                TotalAmount = g.Sum(x => x.SpendingAmount)
            }).ToList();

            var topCategory = categoryTotalSpendings.OrderByDescending(c => c.TotalAmount).FirstOrDefault();

            string categoryName = db.Categories.Where(x => x.CategoryId == topCategory.CategoryId).Select(y => y.CategoryName).FirstOrDefault();

            txtTopCategoryName.Text = categoryName;

            txtCategorySpend.Text = $"Kategori ID: {topCategory.CategoryId}, Toplam Harcama: {topCategory.TotalAmount:C}";


            //En Az Harcama olan Kategori Adı


            var littleCategorySpend = categoryTotalSpendings.OrderBy(c => c.TotalAmount).FirstOrDefault();


            string littleCategorySpendResult = db.Categories.Where(x => x.CategoryId == littleCategorySpend.CategoryId).Select(y => y.CategoryName).FirstOrDefault();


            txtLittleCategorySpend.Text = littleCategorySpendResult;


            txtLittleSpendCategory.Text= $"Kategori Id: {littleCategorySpend.CategoryId}, Toplam Harcama: {littleCategorySpend.TotalAmount}";




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmSpendings frm= new FrmSpendings();
            this.Hide();
            this.Close();
            
            DialogResult result= MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }



}
