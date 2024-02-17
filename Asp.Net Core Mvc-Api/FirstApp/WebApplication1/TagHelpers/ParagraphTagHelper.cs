using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FirstApp.TagHelpers
{
    [HtmlTargetElement("paragraphx")]
    public class ParagraphTagHelper : TagHelper
    {
        public string ShortDescription { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetHtmlContent($"<b>Custom Tag Helper works {ShortDescription}</b>");
        }
    }
}
