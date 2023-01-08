using DrinksShop.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace DrinksShop.Web.Pages
{
    public class DisplayProductsBase:ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
