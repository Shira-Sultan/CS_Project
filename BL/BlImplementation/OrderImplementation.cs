using BlApi;


namespace BlImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int id, int quantityProductsToOrder)
        {
            try
            {
                BO.Product product = BO.Tools.ProductToBO(_dal.Product.Read(id));
                BO.ProductInOrder productInOrder = new BO.ProductInOrder { Id = id };

                // אם יש מוצרים בהזמנה
                if (order.ListProductInOrder != null)
                {
                    productInOrder = order.ListProductInOrder.FirstOrDefault(p => p.Id == product.Id);
                    // אם המוצר לא קיים בהזמנה
                    if (productInOrder == null)
                        productInOrder = new BO.ProductInOrder { Id = id };
                }
                else
                {
                    order.ListProductInOrder = new List<BO.ProductInOrder>();
                }

                // אם המוצר קיים בהזמנה
                if (productInOrder.ProductName != null)
                {
                    // אם יש מספיק במלאי
                    if (product.Quantity >= quantityProductsToOrder + productInOrder.Quantity)
                    {
                        productInOrder.Quantity += quantityProductsToOrder;
                        product.Quantity -= quantityProductsToOrder;

                        Console.WriteLine($" {quantityProductsToOrder}products added to your order.");
                    }
                    // אם אין מספיק במלאי או אין בכלל
                    else
                    {
                        productInOrder.Quantity += product.Quantity - productInOrder.Quantity;
                        product.Quantity = 0;

                        Console.WriteLine($"{productInOrder.Quantity} products added to your order.");
                    }
                }
                // אם המוצר לא קיים בהזמנה
                else
                {
                    // אם יש מספיק במלאי
                    if (product.Quantity >= quantityProductsToOrder)
                    {
                        productInOrder.ProductName = product.ProductName;
                        productInOrder.BasePrice = product.Price;
                        productInOrder.Quantity = quantityProductsToOrder;
                        productInOrder.Sales = new List<BO.SaleInProduct>();
                        productInOrder.TotalPrice = 0;

                        product.Quantity -= quantityProductsToOrder;

                        order.ListProductInOrder.Add(productInOrder);
                        Console.WriteLine($" {quantityProductsToOrder}products added to your order.");
                    }
                    else
                    {
                        // אם אין מספיק במלאי
                        if (product.Quantity > 0)
                        {                           
                            productInOrder.ProductName = product.ProductName;
                            productInOrder.BasePrice = product.Price;
                            productInOrder.Quantity = product.Quantity;
                            productInOrder.Sales = new List<BO.SaleInProduct>();
                            productInOrder.TotalPrice = 0;

                            product.Quantity = 0;

                            order.ListProductInOrder.Add(productInOrder);
                            Console.WriteLine($"{productInOrder.Quantity} products added to your order.");
                        }
                        // אם אין כלום במלאי
                        else
                        {
                            throw new BO.Bl_OutOfStock("The product is out of stock.");
                        }
                    }
                }
                SearchSaleForProduct(productInOrder, order.IfClub);
                CalcTotalPriceForProduct(productInOrder);
                CalcTotalPrice(order);
                return productInOrder.Sales;  
            }
            catch
            {
                throw new Exception("Exception in: 'AddProductToOrder' function.");
            }
        }

        public void SearchSaleForProduct(BO.ProductInOrder product, bool isExist)
        {
            try
            {
                var sales = _dal.Sale.ReadAll()
                                    .Where(sale => sale.IdProduct == product.Id &&
                                                   sale.StartDate <= DateTime.Now &&
                                                   sale.FinishDate > DateTime.Now &&
                                                   sale.RequiredQuantity <= product.Quantity &&
                                                   (!(sale.IfClub ?? true) || isExist))
                                    .Select(s => BO.Tools.ConvertSaleToSaleInProduct(s))
                                    .ToList();

                // אם אין מבצעים, הקצה מערך ריק
                product.Sales = sales.Any() ? sales : new List<BO.SaleInProduct>();

                product.Sales = product.Sales.OrderBy(s => s.Price / s.QuantityForSale).ToList();
            }
            catch
            {
                throw new Exception("Exception in: 'SearchSaleForProduct' function.");
            }
        }

        public void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
        {
            // (מחיר בסיסי למוצר (ללא מבצע
            double basePrice = BO.Tools.ProductToBO(_dal.Product.Read(productInOrder.Id)).Price;

            // הגדרת מחיר כולל
            double totalPrice = 0;

            // אם אין מבצעים
            if (productInOrder.Sales == null || productInOrder.Sales.Count == 0)
            {
                totalPrice = basePrice * productInOrder.Quantity;
            }
            else
            {
                // מספר מוצרים בהזמנה
                int remainingQuantity = productInOrder.Quantity;

                foreach (BO.SaleInProduct sale in productInOrder.Sales)
                {
                    // אם הכמות הנוכחית קטנה מהדרישה למבצע, מדלגים על המבצע
                    if (remainingQuantity < sale.QuantityForSale)
                        continue;

                    // כמה פעמים ניתן להשתמש במבצע
                    int applicableCount = remainingQuantity / sale.QuantityForSale;
                    totalPrice += applicableCount * sale.Price;
                    remainingQuantity -= applicableCount * sale.QuantityForSale;

                    // אם הכמות הנותרת היא 0, מפסיקים לבדוק מבצעים נוספים
                    if (remainingQuantity == 0)
                        break;
                }

                // הוספת המוצרים שלא נכללו בשום מבצע
                totalPrice += remainingQuantity * basePrice;
            }

            // עדכון מחיר כולל במוצר
            productInOrder.TotalPrice = totalPrice;
        }

        public void CalcTotalPrice(BO.Order order)
        {
            order.TotalPriceForOrder = order.ListProductInOrder.Select(x => x.TotalPrice).Sum();
        }

        public void DoOrder(BO.Order order)
        {
            order.ListProductInOrder.ForEach(x =>
            {
                BO.Product p = BO.Tools.ProductToBO(_dal.Product.Read(x.Id));
                p.Quantity -= x.Quantity;
                _dal.Product.Update(BO.Tools.ProductToDO(p));
            });
        }

    }
}
