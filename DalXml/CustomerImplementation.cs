using System.Reflection;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
    const string PATH_CUSTOMER = "../xml/customers.xml";

    public int Create(Customer item)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            List<Customer?> customers = ReadAll() ?? new List<Customer?>();
            Customer c = customers.FirstOrDefault(x => x.Id == item.Id);
            if (c != null)
            {
                throw new Dal_idIsExist("The customer already exists in the system.");
            }

            customers.Add(item);

            // פתיחת קובץ לכתיבה
            using (FileStream XmlWrite = new FileStream(PATH_CUSTOMER, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(XmlWrite, customers);
            }
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Customer {item} added successfully");
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");

            return item.Id;
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            List<Customer> customers = ReadAll() ?? new List<Customer>();
            Customer c = customers.FirstOrDefault(x => x.Id == id);
            if (c == null)
            {
                throw new Dal_idNotFound("The customer does not exist in the system.");
            }

            customers.Remove(c);

            // פתיחת קובץ לכתיבה
            using (FileStream XmlWrite = new FileStream(PATH_CUSTOMER, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(XmlWrite, customers);
            }
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Customer {c} deleted successfully");
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }

    public Customer? Read(int id)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            List<Customer> customers = ReadAll() ?? new List<Customer>();
            Customer c = customers.FirstOrDefault(x => x.Id == id);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");

            return c;
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            List<Customer> customers = ReadAll() ?? new List<Customer>();
            Customer c = customers.FirstOrDefault(filter) ?? new Customer();
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return c;
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            List<Customer> customers;
            // פתיחת קובץ לקריאה
            using (FileStream fs = new FileStream(PATH_CUSTOMER, FileMode.Open, FileAccess.Read))
            {
                customers = (List<Customer>)xmlSerializer.Deserialize(fs);
            }
            if (filter != null)
            {
                return customers.Where(filter).ToList();
            }
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");

            return customers;
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception("An error occurred while reading customers: " + ex.Message);
        }
    }

    public void Update(Customer item)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            List<Customer> customers = ReadAll() ?? new List<Customer>();
            Customer c = customers.FirstOrDefault(x => x.Id == item.Id);
            if (c == null)
            {
                throw new Dal_idNotFound("The customer does not exist in the system.");
            }
            customers.Remove(c);
            customers.Add(item);

            // פתיחת קובץ לכתיבה
            using (FileStream XmlWrite = new FileStream(PATH_CUSTOMER, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(XmlWrite, customers);
            }
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Customer {item} updated successfully");
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }
}
