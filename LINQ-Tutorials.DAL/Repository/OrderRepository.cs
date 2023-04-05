using LINQ_Tutorials.Core.Entity;

namespace LINQ_Tutorials.DAL.Repository
{
    public partial class OrderRepository
    {
        #region GetAll Method
        public static List<Order> GetAll()
        {
            return new List<Order>
      {
        new Order
        {
          OrderID = 71774,
          OrderQty = 1,
          ProductID = 680,
          UnitPrice = 1431.50M,
          LineTotal = 1431.50M
        },
        new Order
        {
          OrderID = 71774,
          OrderQty = 10,
          ProductID = 712,
          UnitPrice = 8.99M,
          LineTotal = 80.99M
        },
        new Order
        {
          OrderID = 71776,
          OrderQty = 3,
          ProductID = 680,
          UnitPrice = 1431.50M,
          LineTotal = 4294.5M
        },
        new Order
        {
          OrderID = 71780,
          OrderQty = 4,
          ProductID = 707,
          UnitPrice = 34.99M,
          LineTotal = 244.93M
        },
        new Order
        {
          OrderID = 71780,
          OrderQty = 2,
          ProductID = 708,
          UnitPrice = 35.99M,
          LineTotal = 71.98M
        },
        new Order
        {
          OrderID = 71780,
          OrderQty = 6,
          ProductID = 709,
          UnitPrice = 9.50M,
          LineTotal = 57.00M
        },
        new Order
        {
          OrderID = 71781,
          OrderQty = 2,
          ProductID = 709,
          UnitPrice = 9.50M,
          LineTotal = 19.00M
        },
        new Order
        {
          OrderID = 71781,
          OrderQty = 1,
          ProductID = 710,
          UnitPrice = 9.50M,
          LineTotal = 9.50M
        },
        new Order
        {
          OrderID = 71781,
          OrderQty = 1,
          ProductID = 711,
          UnitPrice = 36.99M,
          LineTotal = 36.99M
        },
        new Order
        {
          OrderID = 71782,
          OrderQty = 3,
          ProductID = 711,
          UnitPrice = 36.99M,
          LineTotal = 110.97M
        },
        new Order
        {
          OrderID = 71782,
          OrderQty = 4,
          ProductID = 712,
          UnitPrice = 8.99M,
          LineTotal = 35.96M
        },
        new Order
        {
          OrderID = 71783,
          OrderQty = 20,
          ProductID = 713,
          UnitPrice = 49.99M,
          LineTotal = 999.80M,
        },
        new Order
        {
          OrderID = 71784,
          OrderQty = 4,
          ProductID = 714,
          UnitPrice = 1391.99M,
          LineTotal = 5567.96M
        },
        new Order
        {
          OrderID = 71784,
          OrderQty = 10,
          ProductID = 715,
          UnitPrice = 49.99M,
          LineTotal = 490.99M,
        },
        new Order
        {
          OrderID = 71784,
          OrderQty = 6,
          ProductID = 716,
          UnitPrice = 49.99M,
          LineTotal = 299.94M
        },
        new Order
        {
          OrderID = 71784,
          OrderQty = 1,
          ProductID = 717,
          UnitPrice = 113.00M,
          LineTotal = 113.00M
        },
        new Order
        {
          OrderID = 71785,
          OrderQty = 2,
          ProductID = 718,
          UnitPrice = 1431.50M,
          LineTotal = 2863.00M
        },
        new Order
        {
          OrderID = 71785,
          OrderQty = 3,
          ProductID = 719,
          UnitPrice = 1531.50M,
          LineTotal = 4594.50M
        },
        new Order
        {
          OrderID = 71786,
          OrderQty = 1,
          ProductID = 720,
          UnitPrice = 1631.50M,
          LineTotal = 1631.50M
        },
        new Order
        {
          OrderID = 71786,
          OrderQty = 2,
          ProductID = 721,
          UnitPrice = 1831.50M,
          LineTotal = 3663.00M
        },
        new Order
        {
          OrderID = 71786,
          OrderQty = 2,
          ProductID = 722,
          UnitPrice = 337.22M,
          LineTotal = 674.44M
        },
        new Order
        {
          OrderID = 71787,
          OrderQty = 3,
          ProductID = 723,
          UnitPrice = 347.22M,
          LineTotal = 1041.66M,
        },
        new Order
        {
          OrderID = 71788,
          OrderQty = 3,
          ProductID = 724,
          UnitPrice = 357.22M,
          LineTotal = 1071.66M
        },
        new Order
        {
          OrderID = 71788,
          OrderQty = 2,
          ProductID = 725,
          UnitPrice = 337.22M,
          LineTotal = 674.44M,
        },
        new Order
        {
          OrderID = 71788,
          OrderQty = 8,
          ProductID = 726,
          UnitPrice = 347.22M,
          LineTotal = 2777.76M
        },
        new Order
        {
          OrderID = 99988,
          OrderQty = 1,
          ProductID = 9999,
          UnitPrice = 461.69M,
          LineTotal = 461.69M
        }
      };
        }
        #endregion
    }
}
