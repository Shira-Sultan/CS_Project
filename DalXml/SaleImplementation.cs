using DalApi;
using DO;
using System.Xml.Linq;
using System.Reflection;
using Tools;

namespace Dal;

internal class SaleImplementation : ISale
{
    private const string SALE = "Sale";
    private const string ID = "Id";
    private const string ID_PRODUCT = "IdProduct";
    private const string REQUIRED_QUANTITY = "RequiredQuantity";
    private const string TOTAL_PRICE = "TotalPrice";
    private const string IF_CLUB = "IfClub";
    private const string START_DATE = "StartDate";
    private const string FINISH_DATE = "FinishDate";

    const string PATH_SALE = "../xml/sales.xml";
    XElement salesXml = XElement.Load(PATH_SALE);

    public int Create(Sale item)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            // צור מבצע חדש
            XElement sale = new XElement(SALE,
                new XElement(ID, Config.SaleCode),
                new XElement(ID_PRODUCT, item.IdProduct),
                new XElement(REQUIRED_QUANTITY, item.RequiredQuantity),
                new XElement(TOTAL_PRICE, item.TotalPrice),
                new XElement(IF_CLUB, item.IfClub),
                new XElement(START_DATE, item.StartDate),
                new XElement(FINISH_DATE, item.FinishDate)
            );

            // הוסף את המבצע החדש לקובץ XML
            salesXml.Add(sale);
            salesXml.Save(PATH_SALE);

            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Sale {item.Id} created successfully");
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

            // בדוק אם המבצע קיים
            Sale existingSale = Read(id);

            // אם המבצע לא קיים, החזר שגיאה
            if (existingSale == null)
            {
                throw new Dal_idNotFound("The sale does not exist in the system.");
            }

            // מצא את האלמנט המתאים ב-XML
            var saleToDelete = salesXml.Descendants(SALE)
                                        .FirstOrDefault(s => int.Parse(s.Element(ID).Value) == id);

            // אם מצאנו את האלמנט, נמחק אותו
            if (saleToDelete != null)
            {
                saleToDelete.Remove();
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Sale {id} deleted successfully");
            }

            // שמור את השינויים בקובץ ה-XML
            salesXml.Save(PATH_SALE);
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }

    public Sale? Read(int id)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            // מחפש את המבצע בקובץ XML לפי מזהה
            var existingSale = salesXml.Descendants(SALE)
                                        .FirstOrDefault(s => int.Parse(s.Element(ID).Value) == id);

            // אם המבצע לא נמצא, זורק חריגה
            if (existingSale == null)
                throw new Dal_idNotFound("The sale does not exist in the system.");

            // יוצר אובייקט Sale וממלא את הפרטים מה-XML
            Sale sale = new Sale()
            {
                Id = int.Parse(existingSale.Element(ID)?.Value ?? "0"),
                IdProduct = int.Parse(existingSale.Element(ID_PRODUCT)?.Value ?? "0"),
                RequiredQuantity = int.Parse(existingSale.Element(REQUIRED_QUANTITY)?.Value ?? "0"),
                TotalPrice = int.Parse(existingSale.Element(TOTAL_PRICE)?.Value ?? "0"),
                IfClub = bool.Parse(existingSale.Element(IF_CLUB).Value),
                StartDate = DateTime.Parse(existingSale.Element(START_DATE).Value),
                FinishDate = DateTime.Parse(existingSale.Element(FINISH_DATE).Value)
            };

            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return sale;
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            // מחפש את כל המבצעים בקובץ XML ומסנן אותם לפי הפילטר
            Sale matchingSale = salesXml.Descendants(SALE)
                .Select(saleXml => new Sale()
                {
                    Id = int.Parse(saleXml.Element(ID)?.Value ?? "0"),
                    IdProduct = int.Parse(saleXml.Element(ID_PRODUCT)?.Value ?? "0"),
                    RequiredQuantity = int.Parse(saleXml.Element(REQUIRED_QUANTITY)?.Value ?? "0"),
                    TotalPrice = int.Parse(saleXml.Element(TOTAL_PRICE)?.Value ?? "0"),
                    IfClub = bool.Parse(saleXml.Element(IF_CLUB).Value),
                    StartDate = DateTime.Parse(saleXml.Element(START_DATE).Value),
                    FinishDate = DateTime.Parse(saleXml.Element(FINISH_DATE).Value)
                })
                .FirstOrDefault(sale => filter(sale)) ?? new Sale(); // מחפש את המבצע הראשון שמתאים לפילטר

            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return matchingSale; // מחזיר את המבצע שנמצא או null אם לא נמצא
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }

    public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            // יוצרים רשימה חדשה של מבצעים
            List<Sale> allSales = salesXml.Descendants(SALE)
                .Select(saleXml => new Sale()
                {
                    Id = int.Parse(saleXml.Element(ID)?.Value ?? "0"),
                    IdProduct = int.Parse(saleXml.Element(ID_PRODUCT)?.Value ?? "0"),
                    RequiredQuantity = int.Parse(saleXml.Element(REQUIRED_QUANTITY)?.Value ?? "0"),
                    TotalPrice = int.Parse(saleXml.Element(TOTAL_PRICE)?.Value ?? "0"),
                    IfClub = bool.Parse(saleXml.Element(IF_CLUB).Value),
                    StartDate = DateTime.Parse(saleXml.Element(START_DATE).Value),
                    FinishDate = DateTime.Parse(saleXml.Element(FINISH_DATE).Value)
                })
                .ToList(); // ממירים ל-List

            // אם יש פילטר, מסננים את הרשימה
            if (filter != null)
            {
                allSales = allSales.Where(filter).ToList();
            }

            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return allSales; // מחזירים את הרשימה
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception("An error occurred while reading Sales: " + ex.Message);
        }
    }

    public void Update(Sale item)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

            // מחפש את המבצע בקובץ XML לפי מזהה
            var existingSale = salesXml.Descendants(SALE)
                                        .FirstOrDefault(s => int.Parse(s.Element(ID).Value) == item.Id);

            // אם המבצע לא נמצא, זורק חריגה
            if (existingSale == null)
            {
                throw new Dal_idNotFound("The sale does not exist in the system.");
            }

            // מעדכן את הפרטים של המבצע
            existingSale.SetElementValue(ID_PRODUCT, item.IdProduct);
            existingSale.SetElementValue(REQUIRED_QUANTITY, item.RequiredQuantity);
            existingSale.SetElementValue(TOTAL_PRICE, item.TotalPrice);
            existingSale.SetElementValue(IF_CLUB, item.IfClub);
            existingSale.SetElementValue(START_DATE, item.StartDate);
            existingSale.SetElementValue(FINISH_DATE, item.FinishDate);

            // שמור את השינויים בקובץ ה-XML
            salesXml.Save(PATH_SALE);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Sale {item.Id} updated successfully");
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }
}
