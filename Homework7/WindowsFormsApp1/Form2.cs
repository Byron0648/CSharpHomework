using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program1;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public OrderService orderService = OrderService.Import("s.xml");
        public string path = "s.xml";
        private Form1 form1;
        public Form2(Form1 form)
        {
            form1 = form;
            InitializeComponent();
            orderBindingSource.DataSource = orderService.orders;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderService.Export(path);
            BindingSource bs = new BindingSource();
            bs.DataSource = orderService.orders;
            orderBindingSource.DataSource = bs;
            form1.ReFresh();
            this.Close();
        }
    }
}
