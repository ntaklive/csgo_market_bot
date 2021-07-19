using System.IO;
using FloatTool.Models.Parameters;

namespace FloatTool.Tools
{
    public static class ScriptsBuilder
    {
        private static readonly string FloatParserScriptRaw = File.ReadAllText(Path.Combine(GlobalFolders.DataFolderPath, "floatParser.js"));
        private static readonly string BuyListingScriptRaw = File.ReadAllText(Path.Combine(GlobalFolders.DataFolderPath, "buyListing.js"));
        private static readonly string JunkRemoverScriptRaw = File.ReadAllText(Path.Combine(GlobalFolders.DataFolderPath, "junkRemover.js"));
        private static readonly string NotificatorScriptRaw = File.ReadAllText(Path.Combine(GlobalFolders.DataFolderPath, "notificator.js"));

        public static string BuildParserScript(ParserScriptParams parameters)
        {
            return FloatParserScriptRaw
                .Replace("{@url}", parameters.Url)
                .Replace("{@count}", parameters.Count)
                .Replace("{@country}", parameters.Country)
                .Replace("{@language}", parameters.Language)
                .Replace("{@currency}", parameters.Currency)
                .Replace("{@filter}", parameters.Filter);
        }

        public static string BuildBuyListingScript(BuyListingScriptParams parameters)
        {
            return BuyListingScriptRaw
                .Replace("{@listingId}", parameters.ListingId.ToString())
                .Replace("{@delay1}", parameters.BuyNowDelay.ToString())
                .Replace("{@delay2}", parameters.AgreeDelay.ToString())
                .Replace("{@delay3}", parameters.PurchaseDelay.ToString())
                .Replace("{@delay4}", parameters.CloseWindowDelay.ToString());
        }

        public static string BuildJunkRemoverScript() => JunkRemoverScriptRaw;

        public static string BuildNotificatorScript(NotificatorScriptParams parameters)
        {
            return NotificatorScriptRaw
                .Replace("{@listingId}", parameters.ListingId.ToString());
        }
    }
}