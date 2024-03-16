using System.Data;
using System.Drawing;
using System.Linq;

namespace rikunov._16._03
{
    public partial class Form1 : Form
    {
        public DataTable product;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            DBconnection dbManager = new DBconnection("host=db.edu.cchgeu.ru; port=5432; username=postgres; password=postgres; database=isp-201o-rikunov");
            product = dbManager.GetProduct();

            foreach (DataRow row in product.Rows)
            {
                string name = row["name"].ToString();
                string product_type = row["product_type"].ToString();
                string image = row["image"].ToString();
                string worker = row["worker"].ToString();
                string number_factory = row["number_factory"].ToString();
                string price = row["price"].ToString();
                string write_up = row["write_up"].ToString();

                UserControl1 user = new UserControl1(name, product_type, worker, image, number_factory, price, write_up);


            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSorting = comboBox1.SelectedItem.ToString();

            if(selectedSorting == "По возрастанию")
            {
                product.DefaultView.Sort = "imya ASC";
            }
            else if(selectedSorting =="По убыванию")
            {
                product.DefaultView.Sort = "imya DESC";
            }

            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow rowView in product.DefaultView) 
            {
                DataRow row = rowView.Row;
                string image = row["image"].ToString();
                string name = row["name"].ToString();
                string product_type = row["product_type"].ToString();
                string worker = row["worker"].ToString();
                string number_factory = row["number_factory"].ToString();
                string price = row["price"].ToString();
                string write_up = row["write_up"].ToString();

            }

        }
    }
}