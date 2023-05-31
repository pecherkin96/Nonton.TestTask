using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonton.TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Это тест отработки

            Product product1 = new Product();
            product1.id = "sdk-1";
            product1.name = "chair";

            Product product2 = new Product();
            product2.id = "shj-2";
            product2.name = "sofa";

            Product product3 = new Product();
            product3.id = "klmj-20";
            product3.name = "table";

            ProductsImpl productimpl = new ProductsImpl();

            productimpl.AddProduct(product1);
            productimpl.AddProduct(product2);
            productimpl.AddProduct(product1);
            productimpl.AddProduct(product3);
            productimpl.DeleteProduct(product1);
            productimpl.DeleteProduct(product1);
            productimpl.AddProduct(product1);
            Console.WriteLine(productimpl.GetName("sdk-1"));
            Console.WriteLine(String.Join(", ", productimpl.FindByName(productimpl.GetName("shj-2"))));

        }
    }
}
