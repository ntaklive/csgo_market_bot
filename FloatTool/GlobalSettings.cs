using System.IO;
using FloatTool.Models.Settings.Worker;
using Newtonsoft.Json;
using Serilog;

namespace FloatTool
{
    public static class GlobalSettings
    {
        public static string WorkerSettingsConfigPath = Path.Combine(GlobalFolders.DataFolderPath, "settings.json");
        public static WorkerSettings WorkerSettings { get; set; }

        public static void Save()
        {
            // Creating files if not exists
            if (!File.Exists(WorkerSettingsConfigPath))
                using (File.Create(WorkerSettingsConfigPath))
                {
                }

            // Serialization
            var workerSettingsJson = JsonConvert.SerializeObject(WorkerSettings);

            // Saving
            File.WriteAllText(WorkerSettingsConfigPath, workerSettingsJson);

            Log.Debug("[{0}]: Global settings updated successfully", Program.Label);
        }

        public static bool IsCreated => File.Exists(WorkerSettingsConfigPath);
    }
}