using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //订单
    [Serializable]
    public class Order
    {
        public string OrdNum { get; set; }
        public string BuyerName { get; set; }
        public List<OrderDetail> orderDetails;
        public double OrdMon;

        public Order(string OrdNum, string BuyerName, List<OrderDetail> orderDetails)
        {
            this.OrdNum = OrdNum;
            this.BuyerName = BuyerName;
            this.orderDetails = orderDetails;
            double sum = 0;
            foreach (var o in orderDetails)
            {
                sum += o.goodsPrice;
            }
            this.OrdMon = sum;
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
            Console.WriteLine("基本信息：" + OrdNum + " " + BuyerName + " " + OrdMon);
            Console.WriteLine("具体信息：");
            foreach (var od in orderDetails)
            {
                Console.WriteLine(od.goodsName + " " + od.goodsPrice + " " + od.sourcePlace);
            }
        }
    }
}
