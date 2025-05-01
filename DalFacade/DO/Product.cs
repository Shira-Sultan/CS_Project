
/// <summary>
///     פרטי מוצר
/// </summary>
/// <param name="Id">קוד מוצר</param>
/// <param name="ProductName">שם מוצר</param>
/// <param name="Category">קטגוריה</param>
/// <param name="Price">מחיר מוצר</param>
/// <param name="Quantity">כמות</param>

namespace DO
{
    public record Product(int Id, string? ProductName, Categories? Category, double? Price, int? Quantity)
    {
        public Product() : this(0, null, null, 0, 0) { }
    }
}
