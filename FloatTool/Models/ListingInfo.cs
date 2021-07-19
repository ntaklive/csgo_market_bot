using System.Collections.Generic;
using Newtonsoft.Json;

namespace FloatTool.Models
{
    public class ListingInfo
    {
        [JsonProperty("origin")]
        public int Origin;

        [JsonProperty("quality")]
        public int Quality;

        [JsonProperty("rarity")]
        public int Rarity;

        [JsonProperty("a")]
        public string A;

        [JsonProperty("d")]
        public string D;

        [JsonProperty("paintseed")]
        public int PaintSeed;

        [JsonProperty("defindex")]
        public int DefIndex;

        [JsonProperty("paintindex")]
        public int PaintIndex;

        [JsonProperty("stickers")]
        public List<object> Stickers;

        [JsonProperty("floatid")]
        public string FloatId;

        [JsonProperty("floatvalue")]
        public double FloatValue;

        [JsonProperty("m")]
        public string M;

        [JsonProperty("s")]
        public string S;

        [JsonProperty("imageurl")]
        public string ImageUrl;

        [JsonProperty("min")]
        public double Min;

        [JsonProperty("max")]
        public double Max;

        [JsonProperty("weapon_type")]
        public string WeaponType;

        [JsonProperty("item_name")]
        public string ItemName;

        [JsonProperty("rarity_name")]
        public string RarityName;

        [JsonProperty("quality_name")]
        public string QualityName;

        [JsonProperty("origin_name")]
        public string OriginName;

        [JsonProperty("wear_name")]
        public string WearName;

        [JsonProperty("full_item_name")]
        public string FullItemName;
    }

    public class ItemInfoResponse
    {
        [JsonProperty("iteminfo")]
        public ListingInfo ItemInfo;
    }
}