using MaterialSkin;
using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using FloatTool.Forms;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace FloatTool
{
    internal static class Program
    {
        internal static readonly string Label = "CS:GO Float Tool";
        internal static readonly LoggingLevelSwitch LoggingLevelSwitch = new() { MinimumLevel = LogEventLevel.Verbose };

        [STAThread]
        private static void Main()
        {
            // Configuration
            ConfigureSerilogLogger();
            ConfigureMaterialSkin();
            ConfigureCefSharpChromium();
            ConfigureConsole();

            // Run
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindowForm());
        }

        /// <summary>
        /// Serilog global logger configuration
        /// </summary>
        private static void ConfigureSerilogLogger()
        {
            Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.ControlledBy(LoggingLevelSwitch)
                    .WriteTo.Console()
                    .WriteTo
                    .File("log.txt",
                        rollingInterval: RollingInterval.Day,
                        rollOnFileSizeLimit: true)
                    .CreateLogger();
            Log.Information("[{0}]: Logger configured successfully", Program.Label);
        }

        /// <summary>
        /// MaterialSkin theme configuration
        /// </summary>
        private static void ConfigureMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey700, Primary.Grey900, Primary.Grey200, Accent.Red400, TextShade.WHITE);
        }

        /// <summary>
        /// CefSharp Chromium browser configuration
        /// </summary>
        private static void ConfigureCefSharpChromium()
        {
            var settings = new CefSettings { CachePath = GlobalFolders.CacheFolderPath, };
            settings.CefCommandLineArgs.Add("enable-gpu", "0");
            settings.CefCommandLineArgs.Add("enable-webgl", "0");
            settings.CefCommandLineArgs.Add("enable-begin-frame-scheduling", "0");
            settings.CefCommandLineArgs.Add("--off-screen-frame-rate", "60");
            //settings.CefCommandLineArgs.Add("–disable-web-security", "1");//Turn off the same-origin policy and allow cross-domain
            settings.CefCommandLineArgs.Add("–enable-system-flash", "1");//Use system flash
            settings.CefCommandLineArgs.Add("disable-gpu", "1");//Remove the gpu, otherwise chrome display problems
            Cef.Initialize(settings);
        }

        /// <summary>
        /// Console theme settings
        /// </summary>
        private static void ConfigureConsole()
        {
            Console.Title = "Console";
            Console.SetWindowSize(70, 30);
        }
    }
}
