using System.IO;

namespace FloatTool
{
    public static class GlobalFolders
    {
        internal static readonly string DataFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "data");
        internal static readonly string CacheFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "cache");

        static GlobalFolders()
        {
            // Creating directories
            Directory.CreateDirectory(DataFolderPath);
            Directory.CreateDirectory(CacheFolderPath);
        }
    }
}