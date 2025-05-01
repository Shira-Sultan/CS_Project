using System.Reflection;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;

namespace Dal;

internal class ProductImplementation : IProduct
{
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));
    const string PATH_PRODUCT = "../xml/products.xml";

    public int Create(Product item)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            List<Product?> products = ReadAll() ?? new List<Product?>();

            products.Add(item with { Id = Config.ProductCode });

            using (FileStream XmlWrite = new FileStream(PATH_PRODUCT, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(XmlWrite, products);
            }

            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Product {item.Id} created successfully");
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

            List<Product?> products = ReadAll() ?? new List<Product?>();
            Product p = products.FirstOrDefault(x => x.Id == id);
            if (p == null)
            {
                throw new Dal_idNotFound("The product does not exist in the system.");
            }

            products.Remove(p);

            using (FileStream XmlWrite = new FileStream(PATH_PRODUCT, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(XmlWrite, products);
            }

            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Product {id} deleted successfully");
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }

    public Product? Read(int id)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            List<Product?> products = ReadAll() ?? new List<Product?>();
            Product p = products.FirstOrDefault(x => x.Id == id);

            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return p;
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }

    public Product? Read(Func<Product, bool> filter)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            List<Product?> products = ReadAll() ?? new List<Product?>();
            Product c = products.FirstOrDefault(filter) ?? new Product();

            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return c;
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            List<Product> products;
            using (FileStream fs = new FileStream(PATH_PRODUCT, FileMode.Open, FileAccess.Read))
            {
                products = (List<Product>)xmlSerializer.Deserialize(fs);
            }

            if (filter != null)
            {
                return products.Where(filter).ToList();
            }

            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return products;
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception("An error occurred while reading Products: " + ex.Message);
        }
    }

    public void Update(Product item)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            List<Product?> products = ReadAll() ?? new List<Product?>();
            Product p = products.FirstOrDefault(x => x.Id == item.Id);
            if (p == null)
            {
                throw new Dal_idNotFound("The Product does not exist in the system.");
            }
            products.Remove(p);
            products.Add(item);

            using (FileStream XmlWrite = new FileStream(PATH_PRODUCT, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(XmlWrite, products);
            }

            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Product {item.Id} updated successfully");
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }
}
