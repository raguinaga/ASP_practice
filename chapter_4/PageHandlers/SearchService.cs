using System.Collections.Generic;
using System.Linq;

namespace PageHandlers
{
    public class SearchService
    {
        private static readonly List<Product> Items = new()
        {
            new Product {Name = "iPad"},
            new Product {Name = "iPod"},
            new Product {Name = "iMac"},
            new Product {Name = "Mac Pro"},
            new Product {Name = "Mac Mini"},
        };

        public static List<Product> SearchProducts(string term)
        {
            // filter by provided category
            return Items.Where(x => x.Name.Contains(term)).ToList();
        }
    }
}