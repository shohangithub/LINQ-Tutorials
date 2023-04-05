using LINQ_Tutorials.Core.Entity;
using LINQ_Tutorials.Helper;

public class MultipleFieldSorting : ViewModelBase
{
    public void Run()
    {

        #region view-model instance section

        // Create instance of view model
        ViewModelBase vm = new();
        List<Product> products = GetProducts();
        List<Product> result = new();

        #endregion





        #region coding section with query expression

        result = (from product in products
                  orderby product.Color, product.Name descending
                  select product).ToList();

        #endregion


        #region coding section with method expression

        result = products.OrderBy(x => x.Color).ThenByDescending(x => x.Name).ToList();

        #endregion





        #region display section
        // Display Results
        vm.Display(result);
        #endregion

    }








}