using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCore.ViewComponents
{
    [HtmlTargetElement("paragraph")]
    public class Category : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}