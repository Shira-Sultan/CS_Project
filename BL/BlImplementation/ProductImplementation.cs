using BlApi;

namespace BlImplementation
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Product item)
        {
            try
            {
                DO.Product p = BO.Tools.ProductToDO(item);
                return _dal.Product.Create(p);
            }
            catch (DO.Dal_objectNotFound e)
            {
                throw new BO.Bl_objectNotFound("", e);
            } 
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<BO.SaleInProduct> GetAllSales(int id, bool IfClub)
        {
            return _dal.Sale.ReadAll().Where(s => s.StartDate < DateTime.Now &&
                                             s.FinishDate > DateTime.Now &&
                                             (!(s.IfClub ?? true) || IfClub)).Select(s => BO.Tools.ConvertSaleToSaleInProduct(s)).ToList();
        }

        public BO.Product? Read(int id)
        {
            try
            {
                BO.Product p = BO.Tools.ProductToBO(_dal.Product.Read(id));
                return p;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try
            {
                // קריאה לכל המוצרים
                var allProducts = _dal.Product.ReadAll(p => true)
                                   .Select(p => BO.Tools.ProductToBO(p)).ToList();

                // חיפוש המוצר הראשון שעובר את המסנן
                var product = allProducts.FirstOrDefault(filter);
                return product;
            }
            catch (BO.Bl_objectNotFound)
            {
                throw new BO.Bl_objectNotFound("The product does not exist.");
            }
        }


        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                var allProducts = _dal.Product.ReadAll(p => true)
                                .Select(p => BO.Tools.ProductToBO(p)).ToList();

                if (filter != null)
                {
                    return allProducts.Where(p => filter(p)).ToList();
                }
                return allProducts;
            }
            catch (BO.Bl_objectNotFound)
            {
                throw new BO.Bl_objectNotFound("Error in function - ReadAll in - ProductImplementation");
            }
        }

        public void Update(BO.Product item)
        {
            try
            {
                DO.Product p = BO.Tools.ProductToDO(item);
                _dal.Product.Update(p);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
