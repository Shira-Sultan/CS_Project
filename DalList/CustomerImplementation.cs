using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace Dal;

internal class CustomerImplementation : ICustomer
{

    public int Create(Customer item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var res = DataSource.Customers.FirstOrDefault(c => c.Id == item.Id);
        if (res != null)
        {      
            throw new Dal_idIsExist("הקוד קיים במערכת");
        }
        else
        {
            DataSource.Customers.Add(item);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"customer {item} added successfully");
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            return item.Id;
        }   
    }

    public Customer? Read(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var res = DataSource.Customers.FirstOrDefault(c => c.Id == id);
        if (res != null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            return res;
        }
        else
        {
            throw new Dal_idNotFound("הקוד לא קיים במערכת");
        }
    }

    public Customer Read(Func<Customer, bool>? filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var res = DataSource.Customers.FirstOrDefault(c => filter(c));
        if (res != null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            return res;
        }
        else
        {
            throw new Dal_objectNotFound("לקוח לא קיים");
        }
    }

    //public List<Customer> ReadAll()
    //{
    //    return DataSource.Customers;
    //}

    public List<Customer> ReadAll(Func<Customer, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        // מפעילים את הפילטר על הלקוחות ומחזירים רק את המתאימים
        var data = from customer in DataSource.Customers
                   where filter == null || filter(customer) // רק לקוחות שעבורם הפילטר מחזיר true
                   select customer;
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return data.ToList();
    }

    public void Update(Customer item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Delete(item.Id);
        DataSource.Customers.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"customer {item} updated successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }

    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Customer c = Read(id);
        DataSource.Customers.Remove(c);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"customer {c.CustomerName} deleted successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }

}


