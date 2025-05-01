namespace DalTest;

using DO;
using DalApi;

public static class Initialization
{ 
    private static IDal s_dal;

    private static void createProduct()
    {
        s_dal.Product.Create(new Product(001, "משקפיים מסרגת פלסטיק ורודה", Categories.Children_glasses, 250, 50));
        s_dal.Product.Create(new Product(002, "משקפיים מסרגת מתכת שחורה", Categories.Adult_glasses, 350, 40));
        s_dal.Product.Create(new Product(003, "משקפי שמש מנומר", Categories.Sun_glasses, 200, 60));
    }

    private static void createCustomer()
    {
        s_dal.Customer.Create(new Customer(325536804, "ישראל לוי", "התאנה 5", "0543652224"));
        s_dal.Customer.Create(new Customer(214485236, "שוקי בר-אור", "חזון איש 20", "0547124585"));
        s_dal.Customer.Create(new Customer(338965402, "תמר גולדברג", "רימון 50", "0527185236"));
    }

    private static void createSale()
    {
        s_dal.Sale.Create(new Sale(100, 001, 2, 450, true, DateTime.Now, DateTime.Parse("01/12/2028")));
        s_dal.Sale.Create(new Sale(101, 002, 1, 300, true, DateTime.Now, DateTime.Parse("01/12/2028")));
        s_dal.Sale.Create(new Sale(102, 003, 5, 800, false, DateTime.Now, DateTime.Parse("01/12/2028")));
    }

    public static void Initialize()//IDal s_dal
    {
        s_dal = Factory.Get;
        //Initialization.s_dal = s_dal;
        createProduct();
        createCustomer();
        createSale();
    }
}
