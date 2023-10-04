using CraftsOnline.website.models;
using CraftsOnline.website.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CraftsOnline.website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet()
        {
            /*Event fired when someone gets the page */
            Products = ProductService.GetProducts();
        }
    }
}