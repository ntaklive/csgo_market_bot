using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using FloatTool.Tools;

namespace FloatTool
{
    public static class GlobalImagesCache
    {
        private static readonly IDictionary<string, Image> CacheDictionary = new Dictionary<string, Image>();

        public static Image Get(string key)
        {
            if (CacheDictionary.ContainsKey(key))
            {
                return CacheDictionary[key];
            }

            var cachedFilePath = Path.Combine(GlobalFolders.CacheFolderPath, PathTools.ToValidFilename(key + ".png"));
            if (File.Exists(cachedFilePath))
            {
                return Image.FromFile(cachedFilePath);
            }

            throw new ArgumentException("Element is not found");
        }

        public static bool Contains(string key)
        {
            var cachedFilePath = Path.Combine(GlobalFolders.CacheFolderPath, PathTools.ToValidFilename(key + ".png"));
            return File.Exists(cachedFilePath) || CacheDictionary.ContainsKey(key);
        }

        public static void Add(string key, Image value)
        {
            if (CacheDictionary.ContainsKey(key))
                throw new ArgumentException("Element is already exists");

            // Getting path
            var cachedFilePath = Path.Combine(GlobalFolders.CacheFolderPath, PathTools.ToValidFilename(key + ".png"));

            // Creating file if not exists
            if (!File.Exists(cachedFilePath))
            {
                value.Save(cachedFilePath);
            }
            
            CacheDictionary.Add(key, value);
        }
    }
}