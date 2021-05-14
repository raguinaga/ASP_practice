using System.Collections.Generic;
using System.Linq;

namespace PageHandlers
{
    public class SearchService
    {
        public static readonly List<Product> items = new()
        {
            new Product {Name = "iPad"},
            new Product {Name = "iPod"},
            new Product {Name = "iMac"},
            new Product {Name = "Mac Pro"},
            new Product {Name = "Mac Mini"},
        };

        public List<Product> SearchProducts(string term)
        {
            // filter by provided category
            return items.Where(x => x.Name.Contains(term)).ToList();
        }
    }
}