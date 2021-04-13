namespace CustomerSite.Helpful
{

    public enum EItemPreview
    {
        Shirts = 0,
        Pants = 1,
    }

    public class ItemPreview
    {
        public string Title { get; set; }
        public int TypeId { get; set; }
        public int Limited { get; set; }
    }

    public static class HelpperPreview
    {
        public static ItemPreview[] ItemPreviews =
        {
            new ItemPreview{ Title ="Shirts", TypeId =1,Limited =4},
            new ItemPreview{ Title ="Pants", TypeId =2 ,Limited =4},
        };
    }
}