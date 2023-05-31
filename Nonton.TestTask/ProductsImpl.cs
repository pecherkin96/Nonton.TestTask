using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonton.TestTask
{
    class ProductsImpl
    {
        List<Product> Products = new List<Product>();

        public bool AddProduct(Product product)
        {
            foreach(Product productCycle in Products)
            {
                if(productCycle.id == product.id)
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }
            Products.Add(product);
            return true;
        }

        public bool DeleteProduct(Product product)
        {
           if (Products.Contains(product) == true)
           {
                Products.Remove(product);
                return true;
           }
           else
           {
                return false;
           }
        }

        public string GetName(string id)
        {
            foreach (Product productCycle in Products)
            {
                if (productCycle.id == id)
                {
                    return productCycle.name;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }

        public List<string> FindByName(string name)
        {
            List<string> listsId = new List<string>();

            foreach(Product productCycle in Products)
            {
                if(productCycle.name == name)
                {
                    listsId.Add(productCycle.id);
                }
                else
                {
                    continue;
                }
            }
            return listsId;
        }
    }
}

