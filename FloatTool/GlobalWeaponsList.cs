using System.Collections.Generic;
using System.IO;
using FloatTool.Models;
using Newtonsoft.Json;
using Serilog;

namespace FloatTool
{
    public static class GlobalWeaponsList
    {
        public static string WeaponsListConfigPath = Path.Combine(GlobalFolders.DataFolderPath, "weapons.json");
        public static List<Weapon> Weapons { get; set; } = new ();

        public static void Save()
        {
            // Creating files if not exists
            if (!File.Exists(WeaponsListConfigPath))
                using (File.Create(WeaponsListConfigPath))
                {
                }

            // Serialization
            var weaponsJson = JsonConvert.SerializeObject(Weapons);

            // Saving
            File.WriteAllText(WeaponsListConfigPath, weaponsJson);

            Log.Debug("[{0}]: Global Weapon List updated successfully", Program.Label);
        }

        public static bool IsCreated => File.Exists(WeaponsListConfigPath);
    }
}