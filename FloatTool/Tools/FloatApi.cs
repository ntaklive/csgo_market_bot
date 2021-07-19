using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using FloatTool.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FloatTool.Tools
{
    public sealed class FloatApi
    {
        private readonly ILogger<FloatApi> _logger;
        private readonly HttpClient _httpClient;
        public static string ApiUrl { get; } = @"https://api.csgofloat.com/";

        public FloatApi(ILogger<FloatApi> logger = null)
        {
            _logger = logger;

            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
            _httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
            _httpClient.DefaultRequestHeaders.Add("Keep-alive", "3600");
        }

        public async Task<ListingInfo> ParseInfo(string link)
        {
            try
            {
                var response = await _httpClient.GetStringAsync(ApiUrl + $@"?url={link}");
                _logger?.LogDebug("[{0}] Response from '{1}' received successfully: {2}", "CSGOFloat", link, response);
                var itemInfoResponse = JsonConvert.DeserializeObject<ItemInfoResponse>(response);

                if (itemInfoResponse == null)
                    throw new ArgumentNullException(nameof(itemInfoResponse));
                
                return itemInfoResponse.ItemInfo;
            }
            catch (Exception e)
            {
                _logger?.LogError("[{0}] Exception received: {1}", "CSGOFloat", e.Message);
                throw;
            }
        }

        // Weapon Rarity Colors
        private static readonly Color CommonColor = Color.FromArgb(255, 255, 255);
        private static readonly Color UncommonColor = Color.FromArgb(100, 152, 255);
        private static readonly Color RareColor = Color.FromArgb(75, 104, 204);
        private static readonly Color MythicalColor = Color.FromArgb(135, 70, 250);
        private static readonly Color LegendaryColor = Color.FromArgb(213, 44, 231);
        private static readonly Color AncientColor = Color.FromArgb(237, 75, 73);
        private static readonly Color ExceedinglyColor = Color.FromArgb(227,192,12);
        private static readonly Color ImmortalColor = Color.FromArgb(137, 107, 9);

        public static Color GetColor(int rarity)
        {
            return rarity switch
            {
                1 => CommonColor,
                2 => UncommonColor,
                3 => RareColor,
                4 => MythicalColor,
                5 => LegendaryColor,
                6 => AncientColor,
                7 => ExceedinglyColor,
                8 => ImmortalColor,
                _ => throw new ArgumentOutOfRangeException(nameof(rarity))
            };
        }
    }
}