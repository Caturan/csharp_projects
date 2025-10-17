using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDbFirstProduct
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Db2Project20Entities1 db = new Db2Project20Entities1();
        void ProductList()
        {
            dataGridView1.DataSource = db.TblProduct.ToList();
        }
        // BU KODU KULLANIN
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            // Veritabanından KATEGORİ listesini çekiyoruz.
            var categories = db.TblCategory.ToList();

            // ComboBox'ta hangi kolonun görüneceğini belirtiyoruz.
            cmdProductCategory.DisplayMember = "CategoryName";

            // Arka planda hangi kolonun değer olarak tutulacağını belirtiyoruz.
            cmdProductCategory.ValueMember = "CategoryId";

            // ComboBox'ın veri kaynağını ayarlıyoruz.
            cmdProductCategory.DataSource = categories;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblProduct tblProduct = new TblProduct();
            tblProduct.ProductPrice = decimal.Parse(txtProductPrice.Text);
            tblProduct.ProductStock = int.Parse(txtProductStock.Text);  
            tblProduct.ProductName = txtProductName.Text;   
            tblProduct.CategoryId  = int.Parse(cmdProductCategory.SelectedValue.ToString());
            db.TblProduct.Add(tblProduct);  
            db.SaveChanges();
            ProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = db.TblProduct.Find(int.Parse(txtProductId.Text));
            db.TblProduct.Remove(value);
            db.SaveChanges();
            ProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var value = db.TblProduct.Find(int.Parse(txtProductId.Text));
            value.ProductPrice=decimal.Parse(txtProductPrice.Text);
            value.ProductStock=int.Parse(txtProductStock.Text); 
            value.ProductName=txtProductName.Text;  
            value.CategoryId=int.Parse(cmdProductCategory.SelectedValue.ToString());
            db.SaveChanges();
            ProductList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnListWithCategory_Click(object sender, EventArgs e)
        {
            var values = db.TblProduct
                .Join(db.TblCategory,
                product => product.CategoryId,
                category => category.CategoryId,
                (product, category) => new
                {
                    ÜrünId = product.ProductId,
                    ÜrünAdı = product.ProductName, 
                    ÜrünFiyatı = product.ProductPrice,
                    ID = product.CategoryId,
                    KategoriAdı = category.CategoryName, 
                })
                .ToList();  
            dataGridView1.DataSource = values;  
        }
    }
}
