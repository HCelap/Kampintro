using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId=5, UnitsInStock = 5, 
                ProductName = "Kalem", UnitPrice =35  };

            //PascalCase (ilk harf de büyük) camelCase(ilk harf küçük diğer ilk harfler büyük)
            //case sensitive

            ProductManager productManager = new ProductManager();
            productManager.Add(product);
                 
;    }
}
