using System;
using System.Collections.Generic;
using System.Linq;

namespace Routing_Examples
{
    public class ProductService
    {
        private static readonly IDictionary<string, Product> allProducts = new Dictionary<string, Product>()
        {
            {"big-widget", new Product("Big Widget", 123)},
            {"super-fancy-widget", new Product("Super Fancy Widget", 456)}
        };

        public Product GetProduct(string name)
        {
            return allProducts.TryGetValue(name, out var product) ? product : null;
        }

        public List<Product> Search(string term, StringComparison comparisonType)
        {
            return allProducts
                  .Where(x => x.Value.Name.Contains(term, comparisonType))
                  .Select(x => x.Value)
                  .ToList();
        }
    }
}