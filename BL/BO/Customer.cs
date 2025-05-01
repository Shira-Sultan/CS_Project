namespace BO;

/// <summary>
///     פרטי לקוח
/// </summary>
/// <param name="Id">תעודת זהות</param>
/// <param name="CustomerName">שם לקוח</param>
/// <param name="CustomerAddress">כתובת</param>
/// <param name="CustomerPhone">מספר טלפון</param>
public class Customer
{
    public int Id { get; init; }
    public string CustomerName { get; set; }
    public string? CustomerAddress { get; set; }
    public string CustomerPhone { get; set; }

    public Customer (int id, string customerName, string? customerAddress, string customerPhone)
    {
        Id = id;
        CustomerName = customerName;
        CustomerAddress = customerAddress;
        CustomerPhone = customerPhone;
    }
}
