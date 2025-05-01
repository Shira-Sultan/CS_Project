
/// <summary>
///     פרטי לקוח
/// </summary>
/// <param name="Id">תעודת זהות</param>
/// <param name="CustomerName">שם לקוח</param>
/// <param name="CustomerAddress">כתובת</param>
/// <param name="CustomerPhone">מספר טלפון</param>

namespace DO
{
    public record Customer(int Id,string? CustomerName,string? CustomerAddress,string? CustomerPhone)
    {
        public Customer(): this(0, null, null, null) { }
    }
}
