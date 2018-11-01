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
    public partial class Form1 : Form
    {
        public OrderService orderService = OrderService.Import("s.xml");
        public string path = "s.xml";
        public string KeyWord { get; set; }
        public Form1()
        {
            InitializeComponent();
           
            orderBindingSource.DataSource = orderService.orders;

            FindCondition.DataBindings.Add("Text", this, "KeyWord");
           
        }

        public void ReFresh()
        {
            orderService = OrderService.Import(path);

            BindingSource bs = new BindingSource();
            bs.DataSource = orderService.orders;
            orderBindingSource.DataSource = bs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FindCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (waysToFind.SelectedItem == null)
                    return;
                if (waysToFind.SelectedItem.ToString() == "订单号")
                    orderBindingSource.DataSource = orderService.SearchByOrdNum(KeyWord);
                if(waysToFind.SelectedItem.ToString()== "买者")
                    orderBindingSource.DataSource = orderService.SearchByBuyerName(KeyWord);
                if (waysToFind.SelectedItem.ToString() == "货物")
                    orderBindingSource.DataSource = orderService.SearchByGoodsName(KeyWord);
               

            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }


        

        private void Del_Click(object sender, EventArgs e)
        {
            foreach (var o in orderService.orders)
            {
                if (o.OrdNum == textBox1.Text)
                {
                    orderService.DelOrder(o);
                    break;
                }
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = orderService.orders;
            orderBindingSource.DataSource = bs;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = orderService.orders;
        }
    }
}
