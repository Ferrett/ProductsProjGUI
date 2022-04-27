using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           List<Product> product = JsonSerializer.Deserialize<List<Product>>(WorkWithWeb.GetTextFromCoreApi($"http://prikhod160422-001-site1.dtempurl.com/GetProductsByCategoryID?categoryID={textBoxGet1.Text}"));

            DisplayProducts(product);
        }

        private void get2btn_Click(object sender, EventArgs e)
        {
            List<Product> product = JsonSerializer.Deserialize<List<Product>>(WorkWithWeb.GetTextFromCoreApi($"http://prikhod160422-001-site1.dtempurl.com/GetProductsByName?name={textBoxGet2.Text}"));

            DisplayProducts(product);
        }
        private void get3btn_Click(object sender, EventArgs e)
        {
            List<Product> product = JsonSerializer.Deserialize<List<Product>>(WorkWithWeb.GetTextFromCoreApi($"http://prikhod160422-001-site1.dtempurl.com/GetAllProducts"));

            DisplayProducts(product);
        }

        private void get4btn_Click(object sender, EventArgs e)
        {
            List<Category> category = JsonSerializer.Deserialize<List<Category>>(WorkWithWeb.GetTextFromCoreApi($"http://prikhod160422-001-site1.dtempurl.com/GetAllCategories"));

            DisplayCategories(category);
        }

        private void post1btn_Click(object sender, EventArgs e)
        {
            textBoxReply.Text = WorkWithWeb.MakeRequest($"http://prikhod160422-001-site1.dtempurl.com/AddCategory", $"{textBoxPost1.Text}");
        }

        private void post2btn_Click(object sender, EventArgs e)
        {
            textBoxReply.Text = WorkWithWeb.MakeRequest($"http://prikhod160422-001-site1.dtempurl.com/AddProduct",int.Parse(textBoxPost2.Text),textBoxPost3.Text,int.Parse(textBoxPost4.Text));
        }

        private void deletebtn1_Click(object sender, EventArgs e)
        {
            textBoxresult2.Text = WorkWithWeb.GetTextFromCoreApi($"http://prikhod160422-001-site1.dtempurl.com/DeleteProductByID?id={deletetextBox1.Text}");
        }

        private void deletebtn2_Click(object sender, EventArgs e)
        {
            textBoxresult2.Text = WorkWithWeb.GetTextFromCoreApi($"http://prikhod160422-001-site1.dtempurl.com/DeleteProductByName?name={deletetextBox2.Text}");
        }
        public void DisplayCategories(List<Category> product)
        {
            listBox.Items.Clear();
            product.ForEach(x => {
                listBox.Items.Add($"ID: {x.ID}");
                listBox.Items.Add($"Name: {x.Name}");
                listBox.Items.Add("");
            });
        }

        public void DisplayProducts(List<Product> product)
        {
            listBox.Items.Clear();
            product.ForEach(x => {
                listBox.Items.Add($"ID: {x.ID}");
                listBox.Items.Add($"Name: {x.Name}");
                listBox.Items.Add($"Price: {x.Price}");
                listBox.Items.Add($"Category ID: {x.Category_ID}");
                listBox.Items.Add("");
            });
        }

       
    }
}
