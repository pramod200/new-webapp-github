using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sqltrainingapp.Models;
using sqltrainingapp.Services;

namespace sqltrainingapp.Pages
{
    public class IndexModel : PageModel
    {

        public List<Product> Products;

        public void OnGet()
        {
            ProductService productService = new ProductService();
            Products = productService.GetProducts();
        }
    }
}