namespace BO;

/// <summary>
///     פרטי מבצע
/// </summary>
/// <param name="Id">קוד מבצע</param>
/// <param name="IdProduct">(מספר מזהה של המוצר (שעליו יש את המבצע</param>
/// <param name="RequiredQuantity">כמות נדרשת לקבלת המבצע</param>
/// <param name="TotalPrice">מחיר כולל במבצע</param>
/// <param name="IfClub">האם המבצע מיועד לכלל הלקוחות או רק ללקוחות מועדון</param>
/// <param name="StartDate">תאריך תחילת המבצע</param>
/// <param name="FinishDate">תאריך סיום המבצע</param>
public class Sale
{
    public int Id { get; init; }
    public int IdProduct { get; set; }
    public int? RequiredQuantity { get; set; }
    public double? TotalPrice { get; set; }
    public bool? IfClub { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? FinishDate { get; set; }

    public Sale() { }
    public Sale (int id, int idProduct, int? requiredQuantity, double? totalPrice, bool? ifClub, DateTime? startDate, DateTime? finishDate)
    {
        Id = id;
        IdProduct = idProduct;
        RequiredQuantity = requiredQuantity;
        TotalPrice = totalPrice;
        IfClub = ifClub;
        StartDate = startDate;
        FinishDate = finishDate;
    }
}
