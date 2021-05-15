using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;

namespace Routing_Examples.Pages
{
    public class Search : PageModel
    {
        private readonly ProductService productService;
        private readonly LinkGenerator link;

        public Search(ProductService service, LinkGenerator link)
        {
            productService = service;
            this.link = link;
        }
        
        [BindProperty, Required]
        public string SearchTerm { get; set; }
        public List<Product> Results { get; private set; }

        public void OnGet()
        {
            // Demonstrates link generation
            var url1 = Url.Page("ProductDetails/Index", new {name = "big-widget"});
            var url2 = link.GetPathByPage("/ProductDetails/Index", values: new {name = "big-widget"});
            var url3 = link.GetPathByPage(HttpContext, "/ProductDetails/Index", values: new {name = "big-widget"});
            var url4 = this.link.GetUriByPage(
                page: "/ProductDetails/Index",
                handler: null,
                values: new {name = "big-widget"},
                scheme: "https",
                host: new HostString("example.com"));
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Results = productService.Search(SearchTerm, StringComparison.Ordinal);
            }
        }

        public void OnPostIgnoreCase()
        {
            if (ModelState.IsValid)
            {
                Results = productService.Search(SearchTerm, StringComparison.OrdinalIgnoreCase);
            }
            {
                
            }
        }
    }
}