namespace FloatTool.Models.Settings.Worker
{
    public struct WorkerSettings
    {
        public int MinDelay { get; set; }
        public int MaxDelay { get; set; }
        public bool AutoBuy { get; set; }

        public ParserScriptSettings ParserScriptSettings { get; set; }
        public BuyScriptSettings BuyScriptSettings { get; set; }
        public JunkRemoverSettings JunkRemoverSettings { get; set; }
        public ProxySettings ProxySettings { get; set; }
    }
}