using BlApi;

namespace BlImplementation;

internal class CustomerImplementation : ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Customer item)
    {
        try
        {
            DO.Customer c = BO.Tools.CustomerToDO(item);
            return _dal.Customer.Create(c);
        }
        catch(Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Customer.Delete(id);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public bool IsExist(int id)
    {
        try
        {
            DO.Customer c = _dal.Customer.Read(id);
            return c != null;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public BO.Customer? Read(int id)
    {
        try
        {
            BO.Customer c = BO.Tools.CustomerToBO(_dal.Customer.Read(id));
            return c;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    //public DO.Customer? Read(Func<BO.Customer, bool> filter)
    //{
    //    try
    //    {
    //        return _dal.Customer.Read(filter);
    //    }
    //    catch (Exception e)
    //    {
    //        throw new Exception(e.Message);
    //    }
    //}

    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        try
        {
            var allCustomers = _dal.Customer.ReadAll(c => true) // קח את כל הלקוחות
                                           .Select(c => BO.Tools.CustomerToBO(c)).ToList();

            if (filter != null)
            {
                return allCustomers.Where(c => filter(c)).ToList(); // סנן אם יש filter
            }

            return allCustomers; // החזר את כל הלקוחות אם filter הוא null
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public void Update(BO.Customer item)
    {
        try
        {
            DO.Customer c = BO.Tools.CustomerToDO(item);
            _dal.Customer.Update(c);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}

