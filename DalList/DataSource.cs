
namespace Dal;

using DO;

internal static class DataSource
{
    internal static List<Product?> Products = new List<Product?>();
    internal static List<Customer?> Customers = new List<Customer?>();
    internal static List<Sale?> Sales = new List<Sale?>();

    internal static class Config
    {
        //מספר מזהה רץ עבור קוד-מוצר
        internal const int ProductMinCode = 100;
        //מספר מזהה רץ עבור קוד-מבצע
        internal const int SaleMinCode = 100;

        private static int ProductIndex = ProductMinCode;
        private static int SaleIndex = SaleMinCode;

        public static int ProductCode
        {
            get
            {
                return ProductIndex++;
            }
        }
        public static int SaleCode
        {
            get
            {
                return SaleIndex++;
            }
        }

    }

}
