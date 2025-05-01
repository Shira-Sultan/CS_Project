using BlApi;


namespace BlImplementation
{
    internal class SaleImplementation : ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Sale item)
        {
            try
            {
                // בדיקה אם המוצר שעליו המבצע אכן קיים
                BO.Product p = BO.Tools.ProductToBO(_dal.Product.Read(item.IdProduct));
                if (p == null)
                {
                    throw new BO.Bl_objectNotFound("Error! You cannot add a sale to a non-existent product.");
                }
                DO.Sale s = BO.Tools.SaleToDO(item);
                return _dal.Sale.Create(s);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Sale.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public BO.Sale? Read(int id)
        {
            try
            {
                BO.Sale s = BO.Tools.SaleToBO(_dal.Sale.Read(id));
                return s;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //public BO.Sale? Read(Func<BO.Sale, bool> filter)
        //{
        //    throw new NotImplementedException();
        //}

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                var allSales = _dal.Sale.ReadAll(s => true)
                                    .Select(s => BO.Tools.SaleToBO(s)).ToList();
                if (filter != null)
                {
                    return allSales.Where(s => filter(s)).ToList();
                }
                return allSales;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Update(BO.Sale item)
        {
            try
            {
                DO.Sale s = BO.Tools.SaleToDO(item);
                _dal.Sale.Update(s);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
