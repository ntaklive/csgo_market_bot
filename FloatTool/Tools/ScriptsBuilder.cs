using FloatTool.Models.Parameters;

namespace FloatTool.Tools
{
    public static class ScriptsBuilder
    {
        private const string FloatParserScriptRaw = "!function(){let e=new URL(\"{@url}\"),s=new XMLHttpRequest,t=new URL(e+\"/render/\");t.searchParams.set(\"query\",\"\"),t.searchParams.set(\"start\",\"0\"),t.searchParams.set(\"count\",\"{@count}\"),t.searchParams.set(\"country\",\"{@country}\"),t.searchParams.set(\"language\",\"{@language}\"),t.searchParams.set(\"currency\",\"{@currency}\"),t.searchParams.set(\"filter\",\"{@filter}\"),s.open(\"GET\",t),s.send(),s.onload=function(){try{let r=new Object;if(r.idlist=[],r.links=[],r.prices=[],200!=s.status)alert(`Error ${s.status}: ${s.statusText}`);else{let t=JSON.parse(s.responseText);document.getElementById(\"searchResultsRows\").innerHTML=t.results_html;let a=t.listinginfo;for(var e in a){let s=a[e].asset.id,t=a[e].listingid;r.idlist.push(t),r.links.push(a[e].asset.market_actions[0].link.replace(\"%listingid%\",t).replace(\"%assetid%\",s)),r.prices.push((a[e].converted_price+a[e].converted_fee)/100)}}var t=JSON.stringify(r);CefSharp.PostMessage(t)}catch(e){CefSharp.PostMessage(\"Updating error\")}}}();";
        private const string BuyListingScriptRaw = "!async function(){const e=e=>new Promise(t=>setTimeout(t,e));try{var t=document.getElementsByClassName(\"item_market_action_button btn_green_white_innerfade btn_small\");for(let l=0;l<t.length;l++){const o=t[l];if(o.getAttribute(\"href\").includes(\"{@listingId}\")){await e(\"{@delay1}\"),o.click(),document.getElementsByClassName(\"newmodal_background\")[0].remove();var a=document.getElementById(\"market_buynow_dialog_accept_ssa\");a.getAttribute(\"checked\")||(await e(\"{@delay2}\"),a.click());var n=document.getElementById(\"market_buynow_dialog_purchase\");await e(\"{@delay3}\"),n.click();var c=document.getElementById(\"market_buynow_dialog_cancel\");await e(\"{@delay4}\"),c.click(),document.getElementById(\"market_buynow_dialog_cancel_close\").click()}}}catch(e){console.log(\"Updating error\")}}();";
        private const string JunkRemoverScriptRaw = "!function(){try{document.getElementById(\"global_header\").remove(),document.getElementById(\"BG_top\").remove(),document.getElementById(\"footer\").remove(),document.getElementById(\"footer_spacer\").remove(),document.getElementById(\"footer_responsive_optin_spacer\").remove(),document.getElementById(\"market_buyorder_info\").remove(),document.getElementById(\"searchResults_ctn\").style.padding=0,document.getElementById(\"searchResults_ctn\").style.marginBottom=0,document.getElementById(\"searchResults_ctn\").style.height=0,document.getElementById(\"searchResults_controls\").remove(),document.getElementById(\"listings\").className=\"\",document.getElementById(\"listings\").style=\"\",document.getElementById(\"searchResultsTable\").style.padding=0,document.getElementsByClassName(\"responsive_page_template_content\")[0].className=\"\",document.getElementsByClassName(\"responsive_page_content\")[0].className=\"\",document.getElementsByClassName(\"market_listing_nav_container\")[0].remove(),document.getElementsByClassName(\"market_paging_summary ellipsis\")[0].textContent=\"\",document.getElementsByClassName(\"responsive_page_menu_ctn mainmenu\")[0].remove(),document.getElementsByClassName(\"responsive_local_menu_tab\")[0].remove(),document.getElementsByClassName(\"responsive_page_menu_ctn localmenu\")[0].remove(),document.getElementsByClassName(\"responsive_header\")[0].remove(),document.getElementsByClassName(\"market_page_fullwidth market_listing_firstsection\")[0].remove(),document.getElementsByClassName(\"market_listing_filter\")[0].remove(),document.getElementsByClassName(\"resultsbluebg\")[0].remove(),document.getElementsByClassName(\"market_large_tab_well\")[0].remove(),document.getElementsByClassName(\"market_header_bg\")[0].remove(),document.getElementsByClassName(\"pagecontent no_header\")[0].className=\"\"}catch(e){console.log(e)}}();";
        private const string NotificatorScriptRaw = "document.getElementById(\"listing_{@listingId}\").style.border=\"thin dotted red\";";

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