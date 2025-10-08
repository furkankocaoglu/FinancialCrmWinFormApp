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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            List<Categories> categories =db.Categories.ToList();
                

            dataGridView1.DataSource = categories;  
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            string categoryName= txtCategoryName.Text;

            Categories categories= new Categories();

            categories.CategoryName = categoryName; 

            db.Categories.Add(categories);
            db.SaveChanges();

            MessageBox.Show("Kategori eklendi");

            txtCategoryName.Clear();

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtCategoryId.Text);

            Categories categories=db.Categories.Find(id);

            db.Categories.Remove(categories);
            db.SaveChanges();

            MessageBox.Show("Kategori silindi");
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {          

            int id= int.Parse(txtCategoryId.Text);  

            Categories categories =db.Categories.Find(id);

            categories.CategoryName=txtCategoryName.Text;

            db.SaveChanges();

            MessageBox.Show("Kategori düzenlendi");
        }
    }
}
