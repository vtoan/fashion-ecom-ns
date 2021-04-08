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
            new ItemPreview{ Title ="Featured", RequestUrl ="/product"},
            new ItemPreview{ Title ="Shirts", RequestUrl ="/"},
            new ItemPreview{ Title ="Pants", RequestUrl ="/"},
        };
    }
}