namespace FloatTool.Models
{
    public class ListingData
    {
        public long ListingId { get; set; }
        public double FloatValue { get; set; }
        public double? Price { get; set; }

        public override string ToString()
        {
            return $"ListingId='{ListingId}' FloatValue='{FloatValue}' Price='{Price}'";
        }
    }
}