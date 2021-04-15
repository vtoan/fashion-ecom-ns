using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomerSite.TagHelpers
{
    [HtmlTargetElement(Attributes = "product-src")]
    public class HostImageTagHelper : TagHelper
    {
        private readonly string ResProduct = "product-images/";
        public string ProductSrc { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var srcImg = Startup.HostUri + ResProduct + ProductSrc;
            output.Attributes.SetAttribute("src", srcImg);
        }
    }
}