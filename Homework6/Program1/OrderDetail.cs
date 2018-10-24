using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    //订单明细
    public class OrderDetail
    {
        public string goodsName;
        public double goodsPrice;
        public string sourcePlace;

        public OrderDetail()
        {

        }
        public OrderDetail(string goodsName, double goodsPrice, string sourcePlace)
        {
            this.goodsName = goodsName;
            this.goodsPrice = goodsPrice;
            this.sourcePlace = sourcePlace;
        }
    }
}
