using System.Reflection;
using System.Text;


namespace BO
{
    internal static class Tools
    {
        public static string ToStringProperty<T>(this T obj, string prefix = "")
        {
            StringBuilder sb = new StringBuilder();
            Type type = obj.GetType();

            foreach (PropertyInfo prop in type.GetProperties())
            {
                if (prop.PropertyType.IsPrimitive
                    || prop.PropertyType == typeof(string)
                    || prop.PropertyType == typeof(DateTime)
                    )
                {
                    sb.AppendLine($"{prefix}{prop.Name} = {prop.GetValue(obj)}");
                }
                else
                {
                    sb.Append($"{prefix}{prop.Name} = \n{prop.GetValue(obj).ToStringProperty(prefix + "\t")}");
                }
            }
            return sb.ToString();
        }

        public static BO.Product ProductToBO(DO.Product obj)
        {
            BO.Product p = new BO.Product(
                    obj.Id,
                    obj.ProductName,
                    (BO.Categories)(obj.Category ?? DO.Categories.Accessories),
                    obj.Price??0,
                    obj.Quantity??0
                );
            return p;
        }

        public static DO.Product ProductToDO(BO.Product obj)
        {
            DO.Product p = new DO.Product()
            {
                Id = obj.Id,
                ProductName = obj.ProductName,
                Category = (DO.Categories)obj.Category,
                Price = obj.Price,
                Quantity = obj.Quantity
            };
            return p;
        }

        public static BO.Customer CustomerToBO(DO.Customer obj)
        {
            BO.Customer c = new BO.Customer(
                    obj.Id,
                    obj.CustomerName?? "shira",
                    obj.CustomerAddress,
                    obj.CustomerPhone ?? "0583272396"
                );
            return c;
        }

        public static DO.Customer CustomerToDO(BO.Customer obj)
        {
            DO.Customer c = new DO.Customer()
            {
                Id = obj.Id,
                CustomerAddress = obj.CustomerAddress,
                CustomerName = obj.CustomerName,
                CustomerPhone = obj.CustomerPhone,
            };
            return c;
        }

        public static BO.Sale SaleToBO(DO.Sale obj)
        {
            BO.Sale s = new BO.Sale(
                    obj.Id,
                    obj.IdProduct,
                    obj.RequiredQuantity,
                    obj.TotalPrice,
                    obj.IfClub,
                    obj.StartDate,
                    obj.FinishDate
                );
            return s;
        }

        public static DO.Sale SaleToDO(BO.Sale obj)
        {
            DO.Sale s = new DO.Sale()
            {
                Id = obj.Id,
                IdProduct = obj.IdProduct,
                RequiredQuantity = obj.RequiredQuantity,
                TotalPrice = obj.TotalPrice,
                IfClub = obj.IfClub,
                StartDate = obj.StartDate,
                FinishDate = obj.FinishDate,
            };
            return s;
        }

        public static SaleInProduct ConvertSaleToSaleInProduct(DO.Sale sale)
        {
            SaleInProduct saleInProduct = new SaleInProduct();

            saleInProduct.QuantityForSale = sale.RequiredQuantity ?? 0;
            saleInProduct.Price = sale.TotalPrice ?? 0;
            saleInProduct.IfClub = sale.IfClub ?? true;

            return saleInProduct;
        }
    }
}
