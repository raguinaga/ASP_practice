using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EditProduct.Pages
{
    [IgnoreAntiforgeryToken]
    public class EditProduct : PageModel
    {
        private ProductModel Product { get; set; }
        public void OnGet()
        {
            
        }

        public void OnPost(ProductModel productModel)
        {
            Product = productModel;
        }

        public void OnPostEditTwoProducts(ProductModel p1, ProductModel p2)
        {
            Product = p1;
        }
    }
}