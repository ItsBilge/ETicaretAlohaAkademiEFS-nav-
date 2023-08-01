
using ETicaretAlohaAkademiEFSınavı.Model;

namespace ETicaretAlohaAkademiEFSınavı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var service = new EticaretContext();
            var eticaret = new ETicaretServis();
            //eticaret.AddProduct();
            //eticaret.DeleteCostumer();
            //eticaret.UpdateCostumer();
            //eticaret.GetCostumer();
            //eticaret.GetProduct();

            /////LINQ Sorduları

            ////Fiyatı 2000 den büyük ürünler
            var products = service.products.ToList();

            var result = products.Where(p => p.Price > 2000);
            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Ürün adı: {product.ProductName} fiyatı: {product.Price}");
            //}
            //Fiyatı küçükten büyüğe sıralama

            var result2 = products.OrderBy(p => p.Price).ToList();
            //foreach (var product in result2)
            //{
            //    Console.WriteLine($"ürün adı: {product.ProductName} fiyatı: {product.Price}");
            //}

            //2000 tl fiyatı olan ürün var mı? True or False dönecek

            var result3 = products.Any(p => p.Price == 2000);
            //Console.WriteLine(result3);

            //Fiyatı 3000-30000 arasındaki ürünler

            var result4 = products.Where(p => p.Price >= 3000 && p.Price <= 30000);

            //foreach (var product in result4)
            //{
            //    Console.WriteLine($"Ürün adı: {product.ProductName} fiyatı: {product.Price}");
            //}

            //Ürünleri isimlerine göre sıralama
            var productList = products.OrderBy(p => p.ProductName).ToList();

            //foreach ( var product in productList )
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            var product2 = products.Take(5).ToList();

            Console.WriteLine("-----Product tablosundaki ilk 5 product----");
            foreach ( var item in product2)
            {
                Console.WriteLine(item.ProductName);

            }
        }
    }
}