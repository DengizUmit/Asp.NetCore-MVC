using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCore.TagHelpers
{
    public class Paragraph : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetHtmlContent("<p> Ümit Dengiz </p>");

            base.Process(context, output);
        }
    }
}