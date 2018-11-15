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
        public string BuyerPhoneNum { get; set; }
        public List<OrderDetail> orderDetails { get; set; } = new List<OrderDetail>();
        public double OrdMon { get; set; }

        public Order(int num, string BuyerName,string BuyerPhoneNum, List<OrderDetail> orderDetails)
        {
            OrdNum =DateTime.Now.ToString("yyyyMMdd")+String.Format("{0:D3}",num);
            this.BuyerName = BuyerName;
            this.BuyerPhoneNum = BuyerPhoneNum;
            this.orderDetails = orderDetails;
            double sum = 0;
            foreach (var o in orderDetails)
            {
                sum += o.GoodsPrice*o.GoodsNum;
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
                Console.WriteLine(od.GoodsName + " " + od.GoodsPrice + " "+od.GoodsNum+" "+ od.SourcePlace);
            }
        }
    }
}
