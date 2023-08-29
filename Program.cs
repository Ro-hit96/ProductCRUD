using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            ProductCRUDD crud = new ProductCRUDD();

            do
            {

                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Product List");
                Console.WriteLine("2. Get Product By Id");
                Console.WriteLine("3. Add Product");
                Console.WriteLine("4. Update Product");
                Console.WriteLine("5. Delete Product");
                Console.WriteLine("Select your option");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        List<Product> list = crud.GetProduct();//Here i return List<Prodcut>bea and create obj of productCrud =crud
                        Console.WriteLine(" id\t Name\t Price \t Company");
                        foreach (Product pro in list)
                        {
                            Console.WriteLine($"{pro.id}\t {pro.pname}\t {pro.price}\t {pro.Company}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Product Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Product p = crud.GetProductById(id);
                        Console.WriteLine("Id \t Name \t   Price \t   Company");
                        Console.WriteLine($"{p.id} \t{p.pname} \t{p.price} \t{p.Company}");

                        break;

                    case 3:
                        Product p2 = new Product();
                        Console.WriteLine("Enter Product Id");
                        p2.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name");
                        p2.pname = Console.ReadLine();
                        Console.WriteLine("Enter Prodcut Price");
                        p2.price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Company Name");
                        p2.Company = Console.ReadLine();
                        crud.AddProducts(p2);
                        Console.WriteLine("Product Saved Succesfully");
                        break;

                    case 4:
                        Product p3 = new Product();
                        Console.WriteLine("Enter Product Id");
                        p3.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name");
                        p3.pname = Console.ReadLine();
                        Console.WriteLine("Enter Product Price");
                        p3.price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Company Name");
                        p3.Company = Console.ReadLine();
                        crud.UpdateProducts(p3);
                        break;

                    case 5:
                        Console.WriteLine("ENter Product Id");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteProducts(id2);
                        Console.WriteLine($"{id2} product deleted..");
                        break;

                }
                Console.WriteLine("Press 1 for Continue");
                no = Convert.ToInt32(Console.ReadLine());
            } while(no==1);

        }
        
    }
}
