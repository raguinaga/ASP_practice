﻿using System.Collections.Generic;
using RazorPageLayout.Pages;

namespace RazorPageLayout
{
    public class ProductService
    {
        public readonly Dictionary<int, ProductDetails> Products = new()
        {
            {1, new ProductDetails("Apple iPod", 200, 50)},
            {2, new ProductDetails("Surface Book", 2200, 10)},
            {3, new ProductDetails("XPS 15", 1600, 3)}
        };

        public ProductDetails GetProduct(int productId)
        {
            return Products.TryGetValue(productId, out var product) ? product : null;
        }

        public void UpdateProduct(int id, string newName, decimal newSellPrice)
        {
            var product = GetProduct(id);
            if (product is null)
            {
                return;
            }

            product.SellPrice = newSellPrice;
            product.Name = newName;
        }
    }
}