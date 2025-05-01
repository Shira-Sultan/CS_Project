namespace BO;

/// <summary>
///     תאור מוצר בהזמנה
/// </summary>
/// <param name="Id">קוד מוצר</param>
/// <param name="ProductName">שם מוצר</param>
/// <param name="BasePrice">מחיר בסיס למוצר</param>
/// <param name="Quantity">כמות בהזמנה</param>
/// <param name="Sales">רשימת מבצעים למוצר זה</param>
/// <param name="TotalPrice">מחיר סופי למוצר</param>

public class ProductInOrder
{
    public int Id { get; init; }
    public string? ProductName { get; set; }
    public double BasePrice { get; set; }
    public int Quantity { get; set; }
    public List<SaleInProduct> Sales { get; set; }
    public double TotalPrice { get; set; }
}

