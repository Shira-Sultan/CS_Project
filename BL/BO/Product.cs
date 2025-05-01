namespace BO;

/// <summary>
///     פרטי מוצר
/// </summary>
/// <param name="Id">קוד מוצר</param>
/// <param name="ProductName">שם מוצר</param>
/// <param name="Category">קטגוריה</param>
/// <param name="Price">מחיר מוצר</param>
/// <param name="Quantity">כמות במלאי</param>
/// <param name="ListSaleInProduct">רשימת מבצעים למוצר</param> 

public class Product
{
    public int Id { get; init; }
    public string? ProductName { get; set; }
    public Categories? Category { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public List<SaleInProduct> ListSaleInProduct { get; set; }

    public Product() { }
    public Product(int id, string? productName, Categories? category, double price, int quantity)
    {
        Id = id;
        ProductName = productName;
        Category = category;
        Price = price;
        Quantity = quantity;
        ListSaleInProduct = new List<SaleInProduct>();
    }
}
