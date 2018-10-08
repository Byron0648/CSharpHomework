using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        //订单
        public class Order
        {
            public string OrdNum { get; set; }
            public string BuyerName { get; set; }
            public List<OrderDetail> orderDetails;

            public Order(string OrdNum,string BuyerName, List<OrderDetail> orderDetails)
            {
                this.OrdNum = OrdNum;
                this.BuyerName = BuyerName;
                this.orderDetails = orderDetails;
            }

            public Order()
            {
            }


            //一个订单中添加商品
            public void AddOrderDetail(OrderDetail orderDetail)
            {
                orderDetails.Add(orderDetail);
            }

            //一个订单中删除商品
            public void DelOrderDetail(OrderDetail orderDetail)
            {
                orderDetails.Remove(orderDetail);
            }
            
            //输出订单
            public void ShowOrder()
            {
                Console.WriteLine("基本信息："+OrdNum + " " + BuyerName );
                Console.WriteLine("具体信息：");
                foreach(var od in orderDetails)
                {
                    Console.WriteLine(od.goodsName + " " + od.goodsPrice + " " + od.sourcePlace);
                }
            }
        }

        //订单明细
        public class OrderDetail
        {
            public string goodsName ;
            public double goodsPrice;
            public string sourcePlace;

            public OrderDetail(string goodsName,double goodsPrice,string sourcePlace)
            {
                this.goodsName = goodsName;
                this.goodsPrice = goodsPrice;
                this.sourcePlace = sourcePlace;
            }
        }

        //订单服务
        public class OrderService
        {
            public List<Order> orders = new List<Order>();

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
            public void ChangeOrder(string fName,string pName)
            {
                Order o=SearchByBuyerName(fName);
                o.BuyerName = pName;
            }

            //订单号查询订单
            public Order SearchByOrdNum(string OrdNum)
            {
                foreach(var o in orders)
                {
                    if (o.OrdNum == OrdNum)
                    {
                        return o;
                    }
                    
                }
                throw new CanNotFindOrder($"不存在订单号为{OrdNum}的订单.");
            }

            //客户查询订单
            public Order SearchByBuyerName(string BuyerName)
            {
                foreach (var o in orders)
                {
                    if (o.BuyerName==BuyerName)
                    {
                        return o;
                    }
                }
                throw new CanNotFindOrder($"不存在买家为{BuyerName}的订单.");
            }

            //商品名称查询订单
            public Order SearchByGoodsName(string GoodsName)
            {
                foreach (var o in orders)
                {
                    foreach(var od in o.orderDetails)
                    {
                        if (od.goodsName == GoodsName)
                            return o;
                        
                    }
                }
                throw new CanNotFindOrder($"不存在商品名含{GoodsName}的订单.");
   
            }

            public void ShowAllOrders()
            {
                int nCount = 1;
                foreach(var o in orders)
                {
                    Console.WriteLine("订单"+nCount);
                    o.ShowOrder();
                    nCount++;
                }
            }
        }

        static void Main(string[] args)
        {
            //订单1
            List<OrderDetail> orderDetails1 = new List<OrderDetail>();
            OrderDetail od1_1 = new OrderDetail("笔", 1, "北京");
            orderDetails1.Add(od1_1);
            OrderDetail od1_2 = new OrderDetail("纸", 0.5, "上海");
            orderDetails1.Add(od1_2);
            Order order1=new Order("123456","张三", orderDetails1);
          
            //订单2
            List<OrderDetail> orderDetails2 = new List<OrderDetail>();
            OrderDetail od2_1 = new OrderDetail("书包", 100, "北京");
            orderDetails2.Add(od2_1);
            OrderDetail od2_2 = new OrderDetail("笔记本", 4000, "上海");
            orderDetails2.Add(od2_2);
            Order order2 = new Order("234567", "张四", orderDetails2);

            List<Order> orders = new List<Order>();
            orders.Add(order1);
            orders.Add(order2);

            //订单服务
            OrderService orderService = new OrderService(orders);
            orderService.ShowAllOrders();

            //订单3
            List<OrderDetail> orderDetails3 = new List<OrderDetail>();
            OrderDetail od3_1 = new OrderDetail("书包", 100, "北京");
            orderDetails3.Add(od3_1);
            OrderDetail od3_2 = new OrderDetail("笔记本", 4000, "上海");
            orderDetails3.Add(od3_2);
            Order order3 = new Order("345678", "张五", orderDetails3);
            

            //对订单的操作
            int n=1;
           
            while (n>0)
            {
                Console.WriteLine("请输入整数表示操作 1.添加订单 2.删除订单（订单号） 3.修改订单 4.查询订单（订单号） 5.查询订单（购买人） 6.查询订单（订单内的商品）0退出");
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
                            Console.WriteLine("把订单名张三改成李四");
                            orderService.ChangeOrder("张三", "李四");
                            orderService.ShowAllOrders();
                            Console.WriteLine();
                        }
                        break;

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


                }

            }
           
            Console.ReadKey();
        }
    }
}

class CanNotFindOrder : ApplicationException
{
    public CanNotFindOrder(String message) : base(message) { }
}