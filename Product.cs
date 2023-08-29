using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace ProductCRUD
{
    public class Product
    {
        public int id { get; set; }
        public string pname { get; set; }
        public int price { get; set; }
        public string Company { get; set; }
    }
    public class ProductCRUDD
    {
        private List<Product> productlist;
        public ProductCRUDD()
        {
            productlist = new List<Product>()
            {
                new Product {id=101,pname="Laptop",price=45000,Company="Dell"},
            new Product { id = 102, pname = "Mouse", price = 400, Company = "Lenovo" }
            };
            
        }
        public List<Product> GetProduct()//Display List Here i need List for prodcut and list available in product class that why we take<Product>
        {
            return productlist;
        }
        public Product GetProductById(int id)
        {
            Product product = new Product();
            foreach (Product p in productlist)
            {
                if (p.id == id)
                {
                    product = p;
                    break;
                }
            }
            return product;

        }
        public void AddProducts(Product p)
        {
            productlist.Add(p);
            
        }
        public void UpdateProducts(Product p)
        {
            foreach (Product item in productlist)
            {
                if(item.id==p.id)
                {
                    item.pname= p.pname;
                    item.price= p.price;
                    item.Company= p.Company;
                    break;
                }
            }
        }
        public void DeleteProducts(int Id2)
        {
            foreach(Product p in productlist)
            {
                if (p.id==Id2)
                {
                    productlist.Remove(p);
                    break;
                }
            }
        }

    }

    internal class Prodcut
    {
        internal object id;
    }
}
