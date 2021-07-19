namespace FloatTool.Models.Parameters
{
    public struct BuyListingScriptParams
    {
        public long ListingId { get; set; }
        public int BuyNowDelay { get; set; }
        public int AgreeDelay { get; set; }
        public int PurchaseDelay { get; set; }
        public int CloseWindowDelay { get; set; }
    }
}