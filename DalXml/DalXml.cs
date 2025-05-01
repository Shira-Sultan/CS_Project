
using DalApi;
using System.Diagnostics;

namespace Dal;

internal sealed class DalXml : IDal
{
    public IProduct Product => new ProductImplementation();

    public ICustomer Customer => new CustomerImplementation();

    public ISale Sale => new SaleImplementation();
    private DalXml() { }

    static readonly DalXml instance = new DalXml();
    public static DalXml Instance => instance;
}
