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
        public string GoodsName { get; set; }
        public double GoodsPrice { get; set; }
        public string SourcePlace { get; set; }

       
        public OrderDetail(string goodsName, double goodsPrice, string sourcePlace)
        {
            this.GoodsName = goodsName;
            this.GoodsPrice = goodsPrice;
            this.SourcePlace = sourcePlace;
        }

        public OrderDetail()
        {

        }
    }
}
