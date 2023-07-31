using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAlohaAkademiEFSınavı.Model
{
    public class Product : BaseModel
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }

    }
}
