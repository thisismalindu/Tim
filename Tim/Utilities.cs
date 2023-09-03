using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;

namespace Tim
{
    internal class Utilities
    {
        public static string getIcon(string exePath, string defaultIcon)
        {

            Icon result;
            string tempIconPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\tempIcon.ico";

            try
            {
                //Extract Icon from the EXE
                result = Icon.ExtractAssociatedIcon(exePath);

                //Saves the icon to disk and returns its path
                using (var stream = new System.IO.FileStream(tempIconPath, System.IO.FileMode.CreateNew))
                {
                    result.Save(stream);
                    return tempIconPath;

                }
            }

            //Or Return Default Icon
            catch (System.Exception)
            {
                return defaultIcon;
            }

        }

        public static void CreateShortcut(string shortcutName, string shortcutPath, string shortcutDescription, string targetFileLocation, string shortCutIconLocation)
        {
            string defaultIcon = System.IO.Path.Combine(Application.StartupPath, "defaultIcon.ico");
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = shortcutDescription;                      // The description of the shortcut
            shortcut.IconLocation = getIcon(shortCutIconLocation, defaultIcon);           // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;                        // The path of the file that will launch when the shortcut is run
            shortcut.Save();                                                 // Save the shortcut
        }

    }




}
