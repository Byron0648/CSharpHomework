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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Order order = new Order();
        int m;
        public OrderService orderService = OrderService.Import(@"..\..\s.xml");
        public string path = @"..\..\s.xml";
        private Form1 form1;
        public Form3(Form1 form)
        {
            form1 = form;
            InitializeComponent();
            orderBindingSource1.DataSource = order;
            orderBindingSource.DataSource = orderService.orders;
            bool ifTodayHaveOrder = false;
            foreach (var o in orderService.orders)
            {
                if (o.OrdNum.Substring(0, 8) == DateTime.Now.ToString("yyyyMMdd"))
                {
                    ifTodayHaveOrder = true;
                    m =  int.Parse(o.OrdNum.Substring(8, 3) + 1);
                    OrdNum.Text = DateTime.Now.ToString("yyyyMMdd") + string.Format("{0:D3}", m);
                }
            }
            if (ifTodayHaveOrder == false)
                m = 1;
                OrdNum.Text = DateTime.Now.ToString("yyyyMMdd") + "001";


        }

        private void OrdNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PhoneNum = @"[1][0-9]{10}$";
            Regex r1 = new Regex(PhoneNum);
            Match m1 = r1.Match(PhoneCall.Text);
            if (Customer.Text.Length < 1 || PhoneCall.Text.Length < 1)
                MessageBox.Show("请输入必要的信息");
            else if (m1.Success == false)
            {
                MessageBox.Show("手机号格式错误");
            }
            else
            {
                Order order1 = new Order(m, Customer.Text, PhoneCall.Text, order.orderDetails);
                orderService.AddOrder(order1);
                orderService.Export(@"..\..\s.xml");
                orderService = OrderService.Import(@"..\..\s.xml");
                form1.ReFresh();
                MessageBox.Show("添加成功");
                this.Close();
            }
            
        }

        private void PhoneCall_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
