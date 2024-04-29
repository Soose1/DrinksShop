using Auto666.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace Auto666.Web.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
