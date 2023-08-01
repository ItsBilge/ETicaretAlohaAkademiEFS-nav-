using ETicaretAlohaAkademiEFSınavı.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAlohaAkademiEFSınavı
{
   public class ETicaretServis
        {
            private readonly EticaretContext _context;

            public ETicaretServis()
            {
                _context = new EticaretContext();
            }

            public void AddProduct() // Database'e product ekleme (product propertylerini kullanıcı girecek)
            {

                try
                {
                    Console.Write("Ürün adını giriniz: ");
                    var productName = Console.ReadLine();
                    Console.Write("Ürün açıklaması: ");
                    var description = Console.ReadLine();
                    Console.Write("Ürün fiyatı: ");
                    var price = decimal.Parse(Console.ReadLine());
                    Console.Write("Markası: ");
                    var brand = Console.ReadLine();

                    var categories = _context.Categories.ToList();

                    foreach (var category in categories)
                    {
                        Console.WriteLine($"Kategori ID'si {category.Id} - Kategori adı {category.CategoryName}");
                    }

                    Console.Write("Ürünü eklemek için yukarda belirtilen kategori ID sini yazınız: ");
                    var categoryId = int.Parse(Console.ReadLine());

                    Product product = new Product()
                    {
                        ProductName = productName,
                        Description = description,
                        Price = price,
                        Brand = brand,
                        CategoryId = categoryId
                    };

                    if (product != null)
                    {
                        _context.products.Add(product);
                        _context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }

            public void DeleteCostumer() // Kullanıcının girdiği ıd ye göre tablodan costumer silme
            {
                try
                {
                    var costumers = _context.Costumers.ToList();

                    foreach (var costumer in costumers)
                    {
                        Console.WriteLine($"Müşteri ID'si: {costumer.Id} - Müşteri Adı: {costumer.FirstName} {costumer.LastName}");
                    }

                    Console.Write("Silmek isteğiniz müşterinin ID'sini giriniz: ");
                    var costumerID = int.Parse(Console.ReadLine());
                    var deleteCostumer = _context.Costumers.Find(costumerID);

                    if (deleteCostumer != null && costumerID != 0)
                    {
                        _context.Costumers.Remove(deleteCostumer);
                        _context.SaveChanges();
                        Console.WriteLine($"{deleteCostumer.FirstName} {deleteCostumer.LastName} isimli müşteri silinmiştir.");
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            public void UpdateCostumer() // Costumer update işlemi
            {
                try
                {
                    var costumers = _context.Costumers.ToList();

                    foreach (var costumer in costumers)
                    {
                        Console.WriteLine($"Müşteri ID'si: {costumer.Id} - Müşteri Adı: {costumer.FirstName} {costumer.LastName} Email {costumer.Email} telenon numarası {costumer.PhoneNumber}");
                    }

                    Console.Write("Güncellemek isteğiniz müşterinin ID'sini giriniz: ");
                    var choseCostumer = int.Parse(Console.ReadLine());
                    if (choseCostumer != null && choseCostumer != 0)
                    {
                        var newCostumer = _context.Costumers.FirstOrDefault(cs => cs.Id == choseCostumer);
                        Console.Write("Yeni isim: ");
                        var newName = Console.ReadLine();
                        Console.Write("Soyisim: ");
                        var newLastname = Console.ReadLine();
                        Console.Write("Telefon no: ");
                        var newPhone = Console.ReadLine();

                        Costumer NewCostumer = new Costumer()
                        {
                            FirstName = newName,
                            LastName = newLastname,
                            PhoneNumber = newPhone
                        };

                        _context.Costumers.Update(newCostumer);
                        _context.SaveChanges();
                    }


                }
                catch (Exception ex)
                {

                    throw;
                }
            }

            public void GetCostumer() // Veri tabanından müşterileri getirme
            {
                var costumers = _context.Costumers.ToList();

                foreach (var costumer in costumers)
                {
                Console.WriteLine($"Müşteri ID: {costumer.Id} \nMüşteri adı: {costumer.FirstName} {costumer.LastName} \nE-mail adres: {costumer.Email} \nTelefon no: {costumer.PhoneNumber} \nGönderi adresi: {costumer.ShippingAdress} \nFatura adresi: {costumer.BilingAdress}");
                }

            }

            public void GetProduct() // Veri tabanındaki ürünleri getirme
            {
                var products = _context.products.ToList();

                foreach (var product in products)
                {
                    Console.WriteLine($"Ürün ID : {product.Id} Ürün adı: {product.ProductName} \nÜrün açıklaması: {product.Description} \nÜrün fiyatı: {product.Price} \nÜrün markası {product.Brand}");
                }
            }
           
        }
    
}
