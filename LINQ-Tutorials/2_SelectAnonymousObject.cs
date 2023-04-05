using LINQ_Tutorials.Core.Composite;
using LINQ_Tutorials.Core.Entity;
using LINQ_Tutorials.Helper;

public class SelectAnonymousObject : ViewModelBase
{
    public void Run()
    {

        #region view-model instance section

        // Create instance of view model
        ViewModelBase vm = new();
        List<Product> products = GetProducts();
  
        #endregion





        #region coding section with query expression

        var result = (from product in products
                  where product.Size == "44"
                  select new { product.ProductID, product.Name }).ToList();


        foreach (var sale in result)
        {
            Console.Write(sale);
        }

        #endregion


        #region coding section with method expression

        var result1 = products.Where(x=>x.Size == "44").Select(product => new { product.ProductID, product.Name }).ToList();

        foreach (var sale in result1)
        {
            Console.Write(sale);
        }

        #endregion

    }








}