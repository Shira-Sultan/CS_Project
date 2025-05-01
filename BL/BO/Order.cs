namespace BO;

/// <summary>
///     פרטי הזמנה
/// </summary>
/// <param name="IfClub">האם זו הזמנה של לקוח "מועדף" (בעל מועדון) או לקוח מזדמן </param>
/// <param name="ListProductInOrder">רשימת המוצרים בהזמנה </param>
/// <param name="TotalPriceForOrder">המחיר הסופי לתשלום</param>
public class Order
{
    public bool IfClub { get; set; }
    public List<ProductInOrder> ListProductInOrder { get; set; }
    public double TotalPriceForOrder { get; set; }
}

