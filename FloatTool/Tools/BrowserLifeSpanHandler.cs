using CefSharp;

namespace FloatTool.Tools
{
    /// <summary>
    /// Popup window blocker
    /// </summary>
    public class BrowserLifeSpanHandler : ILifeSpanHandler
    {
        public bool OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName,
            WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo,
            IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            newBrowser = null;
            return true;
        }
        public void OnAfterCreated(IWebBrowser browserControl, IBrowser browser)
        {
            // ignore
        }
        public bool DoClose(IWebBrowser browserControl, IBrowser browser)
        {
            return false;
        }
        public void OnBeforeClose(IWebBrowser browserControl, IBrowser browser)
        {
            // ignore
        }
    }
}