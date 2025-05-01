namespace Dal;

using DO;
using DalApi;
using System.Reflection;
using Tools;

internal class SaleImplementation : ISale
{
    public int Create(Sale item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Sale s = item with { Id = DataSource.Config.SaleCode };
        DataSource.Sales.Add(s);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"sale for the product: {item.IdProduct} added successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return s.IdProduct;
    }

    public Sale? Read(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var res = DataSource.Sales.FirstOrDefault(s => s.IdProduct == id);
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

    public Sale Read(Func<Sale, bool>? filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        var res = DataSource.Sales.FirstOrDefault(s => filter(s));
        if (res != null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            return res;
        }
        else
        {
            throw new Dal_objectNotFound("מבצע לא קיים");
        }
    }

    //public List<Sale> ReadAll()
    //{
    //    return DataSource.Sales;
    //}

    public List<Sale> ReadAll(Func<Sale, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        // מפעילים את הפילטר על הלקוחות ומחזירים רק את המתאימים
        var data = from sale in DataSource.Sales
                   where filter == null || filter(sale) // רק לקוחות שעבורם הפילטר מחזיר true
                   select sale;
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return data.ToList();
    }

    public void Update(Sale item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Delete(item.IdProduct);
        DataSource.Sales.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"sale for the product: {item.IdProduct} updated successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }

    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Sale s = Read(id);
        DataSource.Sales.Remove(s);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"sale for the product: {s.IdProduct} deleted successfully");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }
}
