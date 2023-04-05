using LINQ_Tutorials.Core.Composite;
using LINQ_Tutorials.Core.Entity;
using LINQ_Tutorials.DAL.Repository;

namespace LINQ_Tutorials.Helper
{
    public class ViewModelBase
    {
        #region GetProducts Method
        protected List<Product> GetProducts()
        {
            // Load all Product Data
            return ProductRepository.GetAll();
        }
        #endregion

        #region GetSales Method
        protected List<Order> GetSales()
        {
            // Load all Sales Data
            return OrderRepository.GetAll();
        }
        #endregion

        #region Display Methods
        protected void DisplayStop()
        {
            Console.ReadKey();
        }

        public void Display(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.Write(product);
            }

            Console.WriteLine();
            Console.WriteLine($"Total Products: {products.Count}");
            DisplayStop();
        }

        public void Display(List<Order> sales)
        {
            foreach (Order sale in sales)
            {
                Console.Write(sale);
            }

            Console.WriteLine();
            Console.WriteLine($"Total Sales: {sales.Count}");
            DisplayStop();
        }

        public void Display(List<Product[]> collection)
        {
            int count = 1;
            foreach (Product[] products in collection)
            {
                Console.WriteLine($"Chunk: {count++}");
                Console.WriteLine(new string('-', 40));
                foreach (Product product in products)
                {
                    Console.Write(product);
                }
            }
            DisplayStop();
        }

        public void Display(List<IGrouping<string, Product>> collection)
        {
            // Loop through each size
            foreach (var group in collection)
            {
                // The value in the 'Key' property is 
                // whatever data you grouped upon
                Console.WriteLine($"Size: {group.Key}  Count: {group.Count()}");

                // Loop through the products in each size
                foreach (Product product in group)
                {
                    Console.Write($"  ProductID: {product.ProductID}");
                    Console.Write($"  Name: {product.Name}");
                    Console.WriteLine($"  Color: {product.Color}");
                }
            }
            DisplayStop();
        }

        public void Display(List<ProductOrder> products)
        {
            foreach (ProductOrder product in products)
            {
                Console.Write(product);
            }

            Console.WriteLine();
            Console.WriteLine($"Total Products: {products.Count}");
            DisplayStop();
        }

        public void Display(List<ProductStats> products)
        {
            foreach (ProductStats product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();
            Console.WriteLine($"Total Product Sizes: {products.Count}");
            DisplayStop();
        }

        public void Display(List<Sales> products)
        {
            foreach (Sales product in products)
            {
                Console.Write(product.Product);

                if (product.Orders.Any())
                {
                    Console.WriteLine("** Orders for this Product **");
                    // Loop through the products in each sale
                    foreach (Order sale in product.Orders)
                    {
                        Console.Write(sale);
                    }
                }
                else
                {
                    Console.WriteLine("   ** No Sales for this Product **");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Total Products/Sales: {products.Count}");
            DisplayStop();
        }

        public void Display(List<string> items)
        {
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine($"Total Items: {items.Count}");
            DisplayStop();
        }

        public void Display(List<int> items)
        {
            foreach (int item in items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine($"Total Items: {items.Count}");
            DisplayStop();
        }

        public void Display(Product product)
        {
            Console.WriteLine(product);
            DisplayStop();
        }

        public void Display(Exception ex)
        {
            Console.WriteLine(ex.ToString());
            DisplayStop();
        }

        public void Display(string value)
        {
            Console.WriteLine($"Value is '{value}'");
            DisplayStop();
        }

        public void Display(int value)
        {
            Console.WriteLine($"Value is '{value}'");
            DisplayStop();
        }

        public void Display(decimal value)
        {
            Console.WriteLine($"Value is '{value:c}'");
            DisplayStop();
        }

        public void Display(bool value)
        {
            Console.WriteLine($"Value is '{value}'");
            DisplayStop();
        }
        #endregion
    }
}
