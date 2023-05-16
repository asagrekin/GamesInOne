using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games_In_One_App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainScreen mainScreen = new MainScreen();
            string pngFilePath = "Resources/Logo.png";
            string iconFilePath = "Resources/Logo.ico";
            ConvertPngToIcon(pngFilePath, iconFilePath);
            mainScreen.Icon = new Icon(iconFilePath);
            Application.Run(mainScreen);
        }

        static void ConvertPngToIcon(string pngFilePath, string iconFilePath)
        {
            using (Bitmap pngBitmap = new Bitmap(pngFilePath))
            {
                Icon icon = Icon.FromHandle(pngBitmap.GetHicon());
                using (var stream = System.IO.File.Create(iconFilePath))
                {
                    icon.Save(stream);
                }
            }
        }
    }
}
