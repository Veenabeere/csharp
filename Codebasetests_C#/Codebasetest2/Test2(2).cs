using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    //Create a Class called Products with
    //Productid, Product Name, Price. Accept 10 Products, sort them based on the price, and display the sorted Products
    class Product
    {
       public int ProductId;
      public  string ProductName;
      public  decimal Price;
    }
    class Test2_2_
    {

        static void Main(string[] args)
        {
            Product[] products = new Product[10];
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}:");
                Console.Write("Product ID: ");
                
                int productId = int.Parse(Console.ReadLine());
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                products[i] = new Product
                {
                    ProductId = productId,
                    ProductName = productName,
                    Price = price
                };
            }
            SortProductsByPrice(products);
            Console.WriteLine("\nSorted Products by Price:");

            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}");
                Console.WriteLine($"Product Name: {product.ProductName}");
                Console.WriteLine($"Price: {product.Price:C2}");
                Console.WriteLine();
            }
        }

        static void SortProductsByPrice(Product[] products)
        {
            for (int i = 0; i < products.Length - 1; i++)
            {
                for (int j = i + 1; j < products.Length; j++)
                {
                    if (products[j].Price < products[i].Price)
                    {
                        Product temp = products[i];
                        products[i] = products[j];
                        products[j] = temp;
                    }
                    Console.ReadLine();
                }
            }
        }
    }

}
    
