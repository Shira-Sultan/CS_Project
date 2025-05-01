using DalTest;
using BO;
using System.Collections.Generic;

namespace BlTest;

class Program
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

    static void Main(string[] args)
    {
        Console.WriteLine("Do you want to initialize the data? press y/n");
        string s = Console.ReadLine();
        if (s == "y")
            Initialization.Initialize();

        try
        {
            Console.WriteLine("Please insert your identity");
            int identity = int.Parse(Console.ReadLine());

            int stop = 1;

            // התחלת הזמנה חדשה
            do    
            {
                Order order = new Order();
                // 0 - מציין לקוח מזדמן שלו אין מועדון
                bool ifClub = identity != 0;
                order.IfClub = ifClub;

                // הוספת מוצר להזמנה
                do
                {
                    Console.WriteLine("insert product to order -");

                    Console.WriteLine("product id:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("product quantity:");
                    int q = int.Parse(Console.ReadLine());

                    Product p = s_bl.Product.Read(id);

                    List<BO.SaleInProduct> salesForPoduct = s_bl.Order.AddProductToOrder(order, id, q);

                    // אם יש מבצע/ים למוצר זה
                    if (salesForPoduct.Count > 0)
                            Console.WriteLine(salesForPoduct);

                    Console.WriteLine($"Total price: {order.TotalPriceForOrder}");

                    Console.WriteLine("To continue ordering, press 1");
                    stop = int.Parse(Console.ReadLine());

                } while (stop == 1);

                // פרוט ההזמנה
                Console.WriteLine(order);

                
                Console.WriteLine("To start a new order, press 1");
                stop = int.Parse(Console.ReadLine());

            } while (stop == 1);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.WriteLine("The order was successfully received!");

    }
}
