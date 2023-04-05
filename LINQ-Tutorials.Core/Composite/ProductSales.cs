using LINQ_Tutorials.Core.Entity;

namespace LINQ_Tutorials.Core.Composite
{
    public partial class Sales
    {
        public Product Product { get; set; }
        public List<Order> Orders { get; set; }
    }
}
