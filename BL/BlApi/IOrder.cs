﻿using BO;

namespace BlApi;

public interface IOrder
{
    List<SaleInProduct> AddProductToOrder(Order order, int id, int quantityProductsToOrder);

    void CalcTotalPriceForProduct(ProductInOrder productInOrder);

    void CalcTotalPrice(Order order);

    void DoOrder(Order order);

    void SearchSaleForProduct(ProductInOrder product, bool isExist);
}

