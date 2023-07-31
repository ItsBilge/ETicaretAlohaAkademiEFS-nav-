using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAlohaAkademiEFSınavı.Model
{
    public class Order : BaseModel
    {
        public DateTime OrderDate { get; set; }
        public int CostumerId { get; set; }
        public Costumer Costumer { get; set; }
        public decimal TotalAmount { get; set; }
        public string SppingAdress { get; set; }
        public bool PaymentStatus { get; set; }
        public string FulfillmentStatus { get; set; }
    }
}
