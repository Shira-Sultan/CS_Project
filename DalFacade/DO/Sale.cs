
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

namespace DO
{
    public record Sale(int Id, int IdProduct, int? RequiredQuantity, double? TotalPrice, bool? IfClub, DateTime? StartDate, DateTime? FinishDate)
    {
        public Sale(): this(0, 0, 0, 0, true, DateTime.Now, DateTime.Now) { }
        
    }
}
