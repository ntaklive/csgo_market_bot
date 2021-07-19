using System.IO;
using System.Linq;

namespace FloatTool.Tools
{
    public static class PathTools
    {
        public static string ToValidFilename(string text)
        {
            return Path.GetInvalidFileNameChars().Aggregate(text, (current, c) => current.Replace(c, '_'));
        }
    }
}
