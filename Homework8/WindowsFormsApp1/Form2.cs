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
        public OrderService orderService = OrderService.Import(@"..\..\s.xml");
        public string path = @"..\..\s.xml";
        private Form1 form1;
        public Form2(Form1 form)
        {
            form1 = form;
            InitializeComponent();
            orderBindingSource.DataSource = orderService.orders;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        private void  button1_Click(object sender, EventArgs e)
        {
           if(form1.CheckPhoneNum())
           {
                foreach (var o in orderService.orders)
                {
                    o.OrdMon = 0;
                    foreach(var od in o.orderDetails)
                    {
                        o.OrdMon += od.GoodsPrice * od.GoodsNum;
                    }
                }
                orderService.Export(@"..\..\s.xml");
                orderService = OrderService.Import(@"..\..\s.xml");
                form1.ReFresh();
                MessageBox.Show("修改成功");
                this.Close();
                
           }
        }
    }
}
