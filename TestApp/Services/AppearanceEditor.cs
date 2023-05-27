using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestApp.Services
{
    class AppearanceEditor
    {
        public static void ChangeLanguage(Uri uri)
        {
            ResourceDictionary dictionary = new ResourceDictionary() { Source = uri };
            var oldDictionary = Application.Current.Resources.MergedDictionaries.FirstOrDefault(d => d.Source.OriginalString.Contains("Languages/"));
            if (oldDictionary != null) Application.Current.Resources.MergedDictionaries.Remove(oldDictionary);
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
        }
        public static void ChangeTheme(Uri uri)
        {
            ResourceDictionary dictionary = new ResourceDictionary() { Source = uri };
            var oldDictionary = Application.Current.Resources.MergedDictionaries.FirstOrDefault(d => d.Source.OriginalString.Contains("Themes/"));
            if (oldDictionary != null) Application.Current.Resources.MergedDictionaries.Remove(oldDictionary);
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
        }
    }
}
