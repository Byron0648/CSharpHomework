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
   public class Program
    { 
        static void Main(string[] args)
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

            //订单3
            List<OrderDetail> orderDetails3 = new List<OrderDetail>();
            OrderDetail od3_1 = new OrderDetail("书包", 100, "北京");
            orderDetails3.Add(od3_1);
            OrderDetail od3_2 = new OrderDetail("笔记本", 10000, "上海");
            orderDetails3.Add(od3_2);
            Order order3 = new Order("345678", "张五", orderDetails3);

            List<Order> orders = new List<Order>();
            orders.Add(order1);
            orders.Add(order2);
            orders.Add(order3);

            //订单服务
            OrderService orderService = new OrderService(orders);
            orderService.ShowAllOrders();

            //XML序列化
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            string xmlFileName = "s.xml";
            OrderService.XmlSerializeExport(xmlser, xmlFileName, orders);
            Console.WriteLine("XML序列化\n");
            //显示XML文本
            string xml = File.ReadAllText(xmlFileName);
            Console.WriteLine(xml);

            Console.WriteLine("XML反序列化\n");
            OrderService os = OrderService.XmlDeserilizeImport(xmlser, xmlFileName, orders);
            os.ShowAllOrders();

            //对订单的操作
            int n = 1;

            while (n > 0)
            {
                Console.WriteLine("请输入整数表示操作 1.添加订单 2.删除订单（订单号） 3.修改订单 4.查询订单（订单号） 5.查询订单（购买人） 6.查询订单（订单内的商品）7.查找金额大于10000的订单 0退出");
                n = int.Parse(Console.ReadLine());
                Order find = new Order();
                switch (n)
                {
                    //1.添加订单
                    case 1:
                        {
                            string s1, s2;
                            Console.WriteLine("请输入一个新的订单");
                            Order newOrder;

                            Console.WriteLine("请输入订单号");
                            s1 = Console.ReadLine();
                            Console.WriteLine("请输入购买人");
                            s2 = Console.ReadLine();
                            Console.WriteLine("请输入购买商品的数量");
                            int goodCount = 0;
                            goodCount = int.Parse(Console.ReadLine());
                            List<OrderDetail> ods = new List<OrderDetail>();
                            string s3, s4;
                            double d1;
                            for (int i = 0; i < goodCount; i++)
                            {
                                Console.WriteLine("请输入商品名");
                                s3 = Console.ReadLine();
                                Console.WriteLine("请输入价格");
                                d1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("请输入产地");
                                s4 = Console.ReadLine();
                                OrderDetail AOd = new OrderDetail(s3, d1, s4);
                                ods.Add(AOd);
                            }
                            newOrder = new Order(s1, s2, ods);


                            Console.WriteLine("添加第这个订单后");
                            orderService.AddOrder(newOrder);
                            Console.WriteLine();
                            orderService.ShowAllOrders();
                            Console.WriteLine();
                            break;
                        }

                    //2.删除订单（订单号）    
                    case 2:
                        {
                            string s = "";

                            Console.WriteLine("请输入想删除的订单号的订单");
                            s = Console.ReadLine();

                            try
                            {
                                orderService.DelOrder(orderService.SearchByOrdNum(s));
                                orderService.ShowAllOrders();
                                Console.WriteLine("删除一个订单之后");
                                Console.WriteLine();
                            }
                            catch (CanNotFindOrder e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            break;

                        }

                    //3.修改订单(订单名) 
                    case 3:
                        {
                            try
                            {
                                Console.WriteLine("把订单名张三改成李四");
                                orderService.ChangeOrder("张三", "李四");
                                orderService.ShowAllOrders();
                            }
                            catch (CanNotFindOrder e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.WriteLine();
                            break;
                        }
                        

                    //4.查询订单（订单号）
                    case 4:
                        {
                            Console.WriteLine("请输入想查询的订单号的订单");
                            string sNum = "";
                            sNum = Console.ReadLine();
                            try
                            {
                                find = orderService.SearchByOrdNum(sNum);
                                find.ShowOrder();
                            }
                            catch (CanNotFindOrder e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.WriteLine();
                            break;
                        }

                    //5.查询订单（购买人）
                    case 5:
                        {
                            Console.WriteLine("请输入想查询的订单号的购买人");
                            string sName = "";
                            sName = Console.ReadLine();
                            try
                            {
                                find = orderService.SearchByBuyerName(sName);
                                find.ShowOrder();
                            }
                            catch (CanNotFindOrder e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.WriteLine();
                            break;
                        }

                    //6.查询订单（商品名）
                    case 6:
                        {
                            Console.WriteLine("请输入想查询的订单号的商品名");
                            string gName = "";
                            gName = Console.ReadLine();
                            try
                            {
                                find = orderService.SearchByGoodsName(gName);
                                find.ShowOrder();
                            }
                            catch (CanNotFindOrder e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.WriteLine();
                            break;

                        }

                    case 7:
                        {
                            try
                            {
                                Console.WriteLine("金额超过10000的订单有");
                                find = orderService.SearchByOrdMonMoreThan10000();
                                find.ShowOrder();
                            }
                            catch (CanNotFindOrder e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.WriteLine();
                            break;
                        }
                    default:
                        n = -1;
                        break;
                }

            }
            Console.ReadKey();
        }

    }
}


