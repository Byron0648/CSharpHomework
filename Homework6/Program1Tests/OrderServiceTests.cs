using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Program1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        [TestMethod()]
        public void AddOrderTest()
        {
            Order od = new Order();
            OrderService os = new OrderService();
            os.AddOrder(od);
            Assert.IsTrue(os.orders.Count == 1);
        }

        [TestMethod()]
        public void DelOrderTest()
        {
            Order od1 = new Order();
            Order od2 = new Order();
            List<Order> ods = new List<Order>();
            ods.Add(od1);
            ods.Add(od2);
            OrderService os = new OrderService(ods);
            os.DelOrder(od1);
            Assert.IsTrue(os.orders.Count == 1);

        }

        [TestMethod()]
        public void ChangeOrderTest()
        {
            List<OrderDetail> orderDetails1 = new List<OrderDetail>();
            OrderDetail od1_1 = new OrderDetail("笔", 1, "北京");
            orderDetails1.Add(od1_1);
            OrderDetail od1_2 = new OrderDetail("纸", 0.5, "上海");
            orderDetails1.Add(od1_2);
            Order order1 = new Order("123456", "张三", orderDetails1);
            List<Order> ods = new List<Order>();
            ods.Add(order1);
            OrderService os = new OrderService(ods);
            os.ChangeOrder("张三", "Byron");
            Assert.IsTrue(order1.BuyerName == "Byron");

        }

        [TestMethod()]
        public void SearchByOrdNumTest()
        {
            //订单1
            List<OrderDetail> orderDetails1 = new List<OrderDetail>();
            OrderDetail od1_1 = new OrderDetail("笔", 1, "北京");
            orderDetails1.Add(od1_1);
            OrderDetail od1_2 = new OrderDetail("纸", 0.5, "上海");
            orderDetails1.Add(od1_2);
            Order order1 = new Order("123456", "张三", orderDetails1);
            //订单2
            List<OrderDetail> orderDetails2 = new List<OrderDetail>();
            OrderDetail od2_1 = new OrderDetail("书包", 100, "北京");
            orderDetails2.Add(od2_1);
            OrderDetail od2_2 = new OrderDetail("笔记本", 10000, "上海");
            orderDetails2.Add(od2_2);
            Order order2 = new Order("234567", "张四", orderDetails2);

            List<Order> ods = new List<Order>();
            ods.Add(order1);
            ods.Add(order2);
            OrderService os = new OrderService(ods);
            Assert.IsTrue(os.SearchByOrdNum("123456") == order1);
        }

        [TestMethod()]
        public void SearchByBuyerNameTest()
        {
            //订单1
            List<OrderDetail> orderDetails1 = new List<OrderDetail>();
            OrderDetail od1_1 = new OrderDetail("笔", 1, "北京");
            orderDetails1.Add(od1_1);
            OrderDetail od1_2 = new OrderDetail("纸", 0.5, "上海");
            orderDetails1.Add(od1_2);
            Order order1 = new Order("123456", "张三", orderDetails1);
            //订单2
            List<OrderDetail> orderDetails2 = new List<OrderDetail>();
            OrderDetail od2_1 = new OrderDetail("书包", 100, "北京");
            orderDetails2.Add(od2_1);
            OrderDetail od2_2 = new OrderDetail("笔记本", 10000, "上海");
            orderDetails2.Add(od2_2);
            Order order2 = new Order("234567", "张四", orderDetails2);

            List<Order> ods = new List<Order>();
            ods.Add(order1);
            ods.Add(order2);
            OrderService os = new OrderService(ods);
            Assert.IsTrue(os.SearchByBuyerName("张三") == order1);
        }

        [TestMethod()]
        public void SearchByGoodsNameTest()
        {
            //订单1
            List<OrderDetail> orderDetails1 = new List<OrderDetail>();
            OrderDetail od1_1 = new OrderDetail("笔", 1, "北京");
            orderDetails1.Add(od1_1);
            OrderDetail od1_2 = new OrderDetail("纸", 0.5, "上海");
            orderDetails1.Add(od1_2);
            Order order1 = new Order("123456", "张三", orderDetails1);
            //订单2
            List<OrderDetail> orderDetails2 = new List<OrderDetail>();
            OrderDetail od2_1 = new OrderDetail("书包", 100, "北京");
            orderDetails2.Add(od2_1);
            OrderDetail od2_2 = new OrderDetail("笔记本", 10000, "上海");
            orderDetails2.Add(od2_2);
            Order order2 = new Order("234567", "张四", orderDetails2);

            List<Order> ods = new List<Order>();
            ods.Add(order1);
            ods.Add(order2);
            OrderService os = new OrderService(ods);
            Assert.IsTrue(os.SearchByGoodsName("笔") == order1);
        }

        [TestMethod()]
        public void SearchByOrdMonMoreThan10000Test()
        {
            List<OrderDetail> orderDetails2 = new List<OrderDetail>();
            OrderDetail od2_1 = new OrderDetail("书包", 100, "北京");
            orderDetails2.Add(od2_1);
            OrderDetail od2_2 = new OrderDetail("笔记本", 10000, "上海");
            orderDetails2.Add(od2_2);
            Order order2 = new Order("234567", "张四", orderDetails2);

            List<Order> ods = new List<Order>();
            ods.Add(order2);
            OrderService os = new OrderService(ods);
            Assert.IsTrue(os.SearchByOrdMonMoreThan10000() == order2);
        }


        [TestMethod()]
        public void XmlSerializeExportTest()
        {
            List<OrderDetail> orderDetails1 = new List<OrderDetail>();
            OrderDetail od1_1 = new OrderDetail("笔", 1, "北京");
            orderDetails1.Add(od1_1);
            OrderDetail od1_2 = new OrderDetail("纸", 0.5, "上海");
            orderDetails1.Add(od1_2);
            Order order1 = new Order("123456", "张三", orderDetails1);
            List<Order> ods = new List<Order>();
            ods.Add(order1);
            OrderService os = new OrderService(ods);
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            string xmlFileName = "s.xml";
            FileInfo file = OrderService.XmlSerializeExport(xmlser, xmlFileName, ods);
            Assert.IsTrue(file.Exists);
            file.Delete();
        }

        [TestMethod()]
        public void XmlDeserilizeImportTest()
        {
            List<OrderDetail> orderDetails1 = new List<OrderDetail>();
            OrderDetail od1_1 = new OrderDetail("笔", 1, "北京");
            orderDetails1.Add(od1_1);
            Order order1 = new Order("123456", "张三", orderDetails1);
            List<Order> ods = new List<Order>();
            ods.Add(order1);
            OrderService os = new OrderService(ods);
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            string xmlFileName = "s.xml";
            OrderService.XmlSerializeExport(xmlser, xmlFileName, ods);
            OrderService nos = OrderService.XmlDeserilizeImport(xmlser, xmlFileName, ods);
            Assert.IsTrue(os.orders[0].OrdNum == "123456");
        }

        
    }
}