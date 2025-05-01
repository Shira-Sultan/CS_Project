
using DalApi;
using DO;
using System.Reflection;
using Tools;

namespace DalTest;

internal class Program
{
    private static readonly IDal s_dal = DalApi.Factory.Get;

    static void Main(string[] args)
    {
        Console.WriteLine("Do you want to initialize the data? press y/n");
        string s = Console.ReadLine();
        if (s == "y" ) 
            Initialization.Initialize();

        try
        {
            int pressing1 = printMainMenu();
            while (pressing1 != 0)
            {
                switch (pressing1)
                {
                    case 1:
                        Console.WriteLine("Customers");
                        CustomerMenu();
                        break;
                    case 2:
                        Console.WriteLine("Products");
                        ProductMenu();
                        break;
                    case 3:
                        Console.WriteLine("Sales");
                        SaleMenu();
                        break;
                    case 4:
                        LogManager.removeOldFolders();
                        break;
                    default:
                        Console.WriteLine("Wrong! please choose again");
                        break;
                }
                pressing1 = printMainMenu();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
        }

    }

    public static int printMainMenu()
    {
        Console.WriteLine("For Customers press 1");
        Console.WriteLine("For Products press 2");
        Console.WriteLine("For Sales press 3");
        Console.WriteLine("To clean the log folder press 4");
        Console.WriteLine("To Exit press 0");

        int pressing;
        if (!int.TryParse(Console.ReadLine(), out pressing))
            pressing = -1;
        return pressing;
    }

    public static int printSubMenu(string item)
    {
        Console.WriteLine($"To Add {item}: perss 1");
        Console.WriteLine($"To Read {item}: perss 2");
        Console.WriteLine($"To Read All {item}: perss 3");
        Console.WriteLine($"To Update {item}: perss 4");
        Console.WriteLine($"To Delete {item}: perss 5");
        Console.WriteLine("Go back a step: perss 0");

        int pressing;
        if (!int.TryParse(Console.ReadLine(), out pressing))
            pressing = -1;
        return pressing;
    }

    //פונקציות גנריות
    private static void Read<T>(ICrud<T> ICrud)
    {
        try
        {
            int code;
            Console.WriteLine("Enter code");
            if (!int.TryParse(Console.ReadLine(), out code)) code = 0;
            Console.WriteLine(ICrud.Read(code));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
        }
    }
    private static void ReadAll<T>(List<T> List)
    {
        foreach (var item in List)
        {
            Console.WriteLine(item);
        }
    }
    private static void Delete<T>(ICrud<T> icrud)
    {
        try
        {
            Console.WriteLine("Enter Code");
            int code = int.Parse(Console.ReadLine());
            icrud.Delete(code);
            Console.WriteLine("The deletion was successful");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
        }
    }


    //תפריט עבור לקוח
    private static void CustomerMenu()
    {
        int pressing = printSubMenu("Customer");
        while (pressing != 0)
        {
            switch (pressing)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2:
                    Read(s_dal.Customer);
                    break;
                case 3:
                    ReadAll(s_dal.Customer.ReadAll());
                    break;
                case 4:
                    UpdateCustomer();
                    break;
                case 5:
                    Delete(s_dal.Customer);
                    break;
                default:
                    Console.WriteLine("Wrong! please choose again");
                    break;
            }
            pressing = printSubMenu("Customer");
        }
    }

    //פונקציה שמקבלת מהמשתמש פרטים על משתמש
    private static Customer CreateCustomer()
    {
        int id; //תעודת זהות
        string name;
        string address;
        string phone;

        Console.WriteLine("Enter user ID");
        if (!int.TryParse(Console.ReadLine(), out id));

        Console.WriteLine("Enter a username");
        name = Console.ReadLine();

        Console.WriteLine("Enter an address");
        address = Console.ReadLine();

        Console.WriteLine("Enter a phone number");
        phone = Console.ReadLine();

        Customer c = new Customer(id, name, address, phone);
        return c;
    }

    private static void AddCustomer()
    {
        Customer c = CreateCustomer();
        s_dal.Customer.Create(c);

        Console.WriteLine("Customer successfully added");
        Console.WriteLine(c);
    }

    private static void UpdateCustomer()
    {
        Customer c = CreateCustomer();
        s_dal.Customer.Update(c);

        Console.WriteLine("The client has been updated successfully");
        Console.WriteLine(c);
    }

    private static void DeleteCustomer()
    {
        int id;
        Console.WriteLine("Enter the ID of the user to delete");
        if (!int.TryParse(Console.ReadLine(), out id)) id = 0;
        s_dal.Customer.Delete(id);
        Console.WriteLine("User removed successfully");
    }


    //תפריט עבור מוצר
    private static void ProductMenu()
    {
        int pressing = printSubMenu("Product");
        while (pressing != 0)
        {
            switch (pressing)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    Read(s_dal.Product);//איך מפעילים את הפונקציה בצורה שתוכל לקבל לאו דווקא - id?
                    break;
                case 3:
                    ReadAll(s_dal.Product.ReadAll()); //x => x.Price == 200
                    break;
                case 4:
                    UpdateProduct();
                    break;
                case 5:
                    Delete(s_dal.Product);
                    break;
                default:
                    Console.WriteLine("Wrong! please choose again");
                    break;
            }
            pressing = printSubMenu("Product");
        }
    }

    //פונקציה שמקבלת מהמשתמש פרטים על מוצר
    private static Product CreateProduct()
    {
        string name;
        Categories category; // שם הקטגוריה
        int categoryNum; // מספר הקטגוריה
        double price;
        int quantity;

        Console.WriteLine("Enter a name for the product");
        name = Console.ReadLine();

        Console.WriteLine("Enter a number for a category between 0 - 4");
        if (!int.TryParse(Console.ReadLine(), out categoryNum))
            category = 0;
        else
            category = (Categories)categoryNum;

        Console.WriteLine("Enter a price for the product");
        if (!double.TryParse(Console.ReadLine(), out price)) price = 30;

        Console.WriteLine("Enter a quantity for the product");
        if (!int.TryParse(Console.ReadLine(), out quantity)) quantity = 0;

        Product p = new Product(0, name, category, price, quantity);
        return p;
    }

    private static void AddProduct()
    {
        Product p = CreateProduct();
        int code = s_dal.Product.Create(p);
        p = p with { Id = code };

        Console.WriteLine("The product has been successfully added");
        Console.WriteLine(p);
    }

    private static void UpdateProduct()
    {
        int code;
        Console.WriteLine("Enter the product code to update");
        if (!int.TryParse(Console.ReadLine(), out code)) code = 0;
        Product p = CreateProduct();
        p = p with { Id = code };
        s_dal.Product.Update(p);

        Console.WriteLine("The product has been updated successfully");
        Console.WriteLine(p);
    }

    private static void DeleteProduct()
    {
        int code;
        Console.WriteLine("Enter a code to delete a product");
        if (!int.TryParse(Console.ReadLine(), out code)) code = 0;
        s_dal.Product.Delete(code);
        Console.WriteLine("The product has been removed successfully");
    }



    //תפריט עבור מבצע
    private static void SaleMenu()
    {
        int pressing = printSubMenu("Sale");
        while (pressing != 0)
        {
            switch (pressing)
            {
                case 1:
                    AddSale();
                    break;
                case 2:
                    Read(s_dal.Sale);
                    break;
                case 3:
                    ReadAll(s_dal.Sale.ReadAll());
                    break;
                case 4:
                    UpdateSale();
                    break;
                case 5:
                    Delete(s_dal.Sale);
                    break;
                default:
                    Console.WriteLine("Wrong! please choose again");
                    break;
            }
            pressing = printSubMenu("Sale");
        }
    }

    //פונקציה שמקבלת מהמשתמש פרטים על מבצע
    private static Sale CreateSale()
    {
        int prodId; //קוד מוצר שעליו המבצע 
        int requiredQ; // כמות נדרשת למבצע
        double totalPrice; // מחיר סופי לאחר המבצע
        bool ifClub; // האם המבצע לחברי מועדון
        DateTime startDate; // זמן תחילת המבצע
        DateTime finishDate; // זמן סיום המבצע

        Console.WriteLine("Enter a product code on sale");
        if (!int.TryParse(Console.ReadLine(), out prodId)) prodId = 0;

        Console.WriteLine("Enter the required amount for the operation");
        if (!int.TryParse(Console.ReadLine(), out requiredQ)) requiredQ = 0;

        Console.WriteLine("Enter final price after sale");
        if (!double.TryParse(Console.ReadLine(), out totalPrice)) totalPrice = 0;

        Console.WriteLine("Is the sale for club customers only?");
        if (bool.TryParse(Console.ReadLine(), out ifClub)) ifClub = true;

        Console.WriteLine("Enter the start time of the sale");
        if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out startDate)) ;

        Console.WriteLine("Enter the end time of the sale");
        if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out finishDate)) ;

        Sale s = new Sale(0, prodId, requiredQ, totalPrice, ifClub, startDate, finishDate);
        return s;
    }

    private static void AddSale()
    {
        Sale s = CreateSale();
        s_dal.Sale.Create(s);

        Console.WriteLine("The sale has been successfully added");
        Console.WriteLine(s);
    }

    private static void UpdateSale()
    {
        Sale s = CreateSale();
        s_dal.Sale.Update(s);

        Console.WriteLine("The sale has been updated successfully");
        Console.WriteLine(s);
    }

    private static void DeleteSale()
    {
        int prodId;
        Console.WriteLine("Enter a product code to delete a sale");
        if (!int.TryParse(Console.ReadLine(), out prodId)) prodId = 0;
        s_dal.Sale.Delete(prodId);
        Console.WriteLine("The sale has been removed successfully");
    }

}