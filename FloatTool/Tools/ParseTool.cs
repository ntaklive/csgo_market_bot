using System;

namespace FloatTool.Tools
{
    public static class ParseTool
    {
        public static string ParseLink(string text)
        {
            try
            {
                var link = text;
                return link;
            }
            catch (Exception exception)
            {
                throw new ArgumentOutOfRangeException("Link is empty or invalid", exception);
            }
        }

        public static double ParseFloat(string text)
        {
            try
            {
                var floatValue = double.Parse(text.Replace('.', ','));
                return floatValue;
            }
            catch (Exception exception)
            {
                throw new ArgumentOutOfRangeException("Float is empty or invalid", exception);
            }
        }

        public static double ParsePrice(string text)
        {
            try
            {
                var priceValue = double.Parse(text.Replace('.', ','));
                return priceValue;
            }
            catch (Exception exception)
            {
                throw new ArgumentOutOfRangeException("Price is empty or invalid", exception);
            }
        }
    }
}