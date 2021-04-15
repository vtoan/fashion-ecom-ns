using System;
using System.Globalization;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace CustomerSite.TagHelpers
{
    [HtmlTargetElement("cost-value")]
    public class CostTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var textContent = await output.GetChildContentAsync();
            double val = Double.Parse(textContent.GetContent());
            string result = "";
            if (val % 1 == 0) result = val.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            else result = val * 100 + " %";
            output.Content.SetContent(result);
        }
    }
}