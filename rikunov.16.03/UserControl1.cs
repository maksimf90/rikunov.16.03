using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rikunov._16._03
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1(string name, string product_type, string image, string worker, string number_factory, string price, string write_up)
        {

            InitializeComponent();

            labelName.Text = name;
            labelProductType.Text = product_type;
            labelWorker.Text = worker;
            labelNumberFactory.Text = number_factory;
            labelPrice.Text = price;
            labelWorker.Text = worker;
            labelWriteUp.Text = write_up;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void labelWorker_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
