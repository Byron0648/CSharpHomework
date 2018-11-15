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
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public OrderService orderService = OrderService.Import(@"..\..\s.xml");
        public string path = @"..\..\s.xml";
        public string KeyWord { get; set; }
        public Form1()
        {
            InitializeComponent();
           
            orderBindingSource.DataSource = orderService.orders;

            FindCondition.DataBindings.Add("Text", this, "KeyWord");
           
        }

        public void ReFresh()
        {
            orderService= OrderService.Import(@"..\..\s.xml");
            BindingSource bs = new BindingSource();
            bs.DataSource = orderService.orders;
            orderBindingSource.DataSource = bs;
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
                if (waysToFind.SelectedItem.ToString() == "所有订单")
                    orderBindingSource.DataSource = orderService.orders;

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

        private void Change_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Export_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\s.xml");
                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();
                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(@"..\..\s.xslt");
                FileStream outFileStream = File.OpenWrite(@"..\..\s.html");
                XmlTextWriter writer = new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                xt.Transform(nav, null, writer);
                outFileStream.Close();
                MessageBox.Show("成功转成HTML");
            }
            catch(XmlException ea)
            {
                Console.WriteLine("XmlException" + ea.ToString());
            }
            catch(XsltException ea)
            {
                Console.WriteLine("XslException" + ea.ToString());
            }
        }

        public bool CheckPhoneNum()
        {
            string PhoneNum = @"[1][0-9]{10}$";
            Regex r1 = new Regex(PhoneNum);
            foreach (var o in orderService.orders)
            {
                Match m1 = r1.Match(o.BuyerPhoneNum);
                if (m1.Success == false)
                {
                    MessageBox.Show("手机号格式错误");
                    return false;
                }
            }
            return true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(this);
            form.Show();
        }
    }
}
