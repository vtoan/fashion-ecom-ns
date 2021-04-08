using System;
using System.Globalization;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace CustomerSite.TagHelpers
{
    public class CurrencyTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var textContent = await output.GetChildContentAsync();
            int val = Int32.Parse(textContent.GetContent());
            var currency = val.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            output.Content.SetContent(currency);
        }
    }
}