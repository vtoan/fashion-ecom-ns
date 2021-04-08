namespace CustomerSite.Helpful
{

    public enum EItemPreview
    {
        Featured = 0,
        Shirts = 1,
        Pants = 2,
    }

    public class ItemPreview
    {
        public string Title { get; set; }
        public string RequestUrl { get; set; }
    }

    public static class HelpperPreview
    {
        public static ItemPreview[] ItemPreviews =
        {
            new ItemPreview{ Title ="Featured", RequestUrl ="product?cateId=1&&limited=4"},
            new ItemPreview{ Title ="Shirts", RequestUrl ="product?cateId=1&&limited=4"},
            new ItemPreview{ Title ="Pants", RequestUrl ="product?cateId=2&&limited=4"},
        };
    }
}