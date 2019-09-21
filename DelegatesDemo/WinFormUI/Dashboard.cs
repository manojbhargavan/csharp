using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        ShoppingCartModel cart = new ShoppingCartModel();

        public Dashboard()
        {
            InitializeComponent();
            PopulateCartWithDemoData();
        }

        private void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }

        private void messageBoxDemoButton_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, PrintOutDiscountAlert);
            MessageBox.Show($"The total is {total:C2}");
        }
        private void textBoxDemoButton_Click(object sender, EventArgs e)
        {
            subTotalTextBox.Clear();
            totalTextBox.Clear();
            decimal total = cart.GenerateTotal(subTotal => subTotalTextBox.Text = subTotal.ToString(),
                (products, subTotal) => { decimal result = subTotal - products.Count; totalTextBox.Text = result.ToString(); return result; },
                m => MessageBox.Show(m));
                
        }

        private void PrintOutDiscountAlert(string discountMessage)
        {
            MessageBox.Show(discountMessage);
        }

        private void SubTotalAlert(decimal subTotal)
        {
            MessageBox.Show($"The sub total is {subTotal:C2}");
        }

        private decimal CalculateLeveledDiscount(List<ProductModel> products, decimal subTotal)
        {
            return subTotal - products.Count;
        }
    }
}
