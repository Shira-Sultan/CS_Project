namespace BO;

/// <summary>
///     תאור מבצע של מוצר
/// </summary>
/// <param name="Id">מזהה מבצע</param>
/// <param name="QuantityForSale">כמות למבצע</param>
/// <param name="Price">מחיר</param>
/// <param name="IfClub">האם המבצע מיועד לכל הלקוחות</param>
public class SaleInProduct
{
    public int Id { get; init; }
    public int QuantityForSale { get; set; }
    public double Price { get; set; }
    public bool IfClub { get; set; }
}
