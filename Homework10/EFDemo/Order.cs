using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF {
    public class Order {
        [Key]
        public String Id { get; set; }
        public String Customer { get; set; }
        public String PhoneNum { get; set; }
        public DateTime CreateTime { get; set; }
        public List<OrderItem> Items { get; set; }
        

        public Order() {
            Items = new List<OrderItem>();
        }

        public Order(string id, string customer,string phonenum, DateTime createTime, List<OrderItem> items) {
            Id = id;
            Customer = customer;
            PhoneNum = phonenum;
            CreateTime = createTime;
            Items = items;

        }
    }
}
