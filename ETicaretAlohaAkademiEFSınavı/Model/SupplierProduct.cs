using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAlohaAkademiEFSınavı.Model
{
    public class SupplierProduct // Product ve Suplier arasında çoka çok ilişki kuruldu. Aslında bir ürünün tek tedarikçisi olur ama tedarikçinin birden fazla ürünü olabilir. yani Product hem category'e hem de Suplier e bağlanması gerekiyor. Ama hata aldığım için ilişkiyi böyle kurmnak durumunda kaldım.
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int SuplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
