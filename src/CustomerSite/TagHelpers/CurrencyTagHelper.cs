using System;
using System.Globalization;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace CustomerSite.TagHelpers
{
    [HtmlTargetElement("currency")]
    public class CurrencyTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var textContent = await output.GetChildContentAsync();
            int val = (int)Convert.ToDouble(textContent.GetContent());
            var currency = val.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            output.Content.SetContent(currency);
        }
    }
}