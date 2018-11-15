using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Program1
{
    //订单服务
    public class OrderService
    {
        public List<Order> orders = new List<Order>();
        public OrderService()
        {

        }
        public OrderService(List<Order> orders)
        {
            this.orders = orders;
        }

        //添加订单
        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        //删除订单
        public void DelOrder(Order order)
        {

            orders.Remove(order);

        }

        //修改订单 修改订单的买者
        public void ChangeOrder(string fName, string pName)
        {
            Order o = SearchByBuyerName(fName);
            o.BuyerName = pName;
        }

        //订单号查询订单
        public Order SearchByOrdNum(string OrdNum)
        {
            var m = from n in orders where n.OrdNum == OrdNum select n;
            foreach (var n in m)
            {
                return (Order)n;
            }
            throw new CanNotFindOrder($"不存在订单号为{OrdNum}的订单.");
        }

        //客户查询订单
        public Order SearchByBuyerName(string BuyerName)
        {
            var m = from n in orders where n.BuyerName == BuyerName select n;
            foreach (var n in m)
            {
                return (Order)n;
            }
            throw new CanNotFindOrder($"不存在买家为{BuyerName}的订单.");
        }

        //商品名称查询订单
        public Order SearchByGoodsName(string GoodsName)
        {
            var o = orders.Where(a => a.orderDetails.Exists(b => b.GoodsName == GoodsName)).Select(a => a);
            foreach (var n in o)
            {
                return (Order)n;
            }


            throw new CanNotFindOrder($"不存在商品名含{GoodsName}的订单.");

        }

        public Order SearchByOrdMonMoreThan10000()
        {
            var m = from n in orders where n.OrdMon > 10000 select n;
            foreach (var n in m)
            {
                return (Order)n;
            }
            throw new CanNotFindOrder($"不存在订单金额大于10000的订单.");
        }

        public void ShowAllOrders()
        {
            int nCount = 1;
            foreach (var o in orders)
            {
                Console.WriteLine("订单" + nCount);
                o.ShowOrder();
                nCount++;
            }
        }

        //XML序列化
        public void Export(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderService));
            string xmlFileName = path;
            FileStream fs = new FileStream(xmlFileName, FileMode.Create);//输出到文件
            xmlSerializer.Serialize(fs, this);
            fs.Close();
        //    StringWriter sw = new StringWriter();//输出到控制台
        //    xmlSerializer.Serialize(sw, this);
        //    sw.Close();
        //    Console.Write(sw.ToString());
        }
       
        //XML反序列化
        public static OrderService Import(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderService));
            OrderService orderService = (OrderService)xmlSerializer.Deserialize(file);
            file.Close();
            Console.WriteLine("Import: ");
            orderService.ShowAllOrders();
            return orderService;
        }
    }
}
