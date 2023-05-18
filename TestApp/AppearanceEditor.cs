using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestApp
{
    class AppearanceEditor
    {
        public static void ChangeLanguage(Uri uri)
        {
            ResourceDictionary dictionary = new ResourceDictionary() { Source = uri };
            var oldDictionary = App.Current.Resources.MergedDictionaries.FirstOrDefault(d => d.Source.OriginalString.Contains("Languages/"));
            if (oldDictionary != null) App.Current.Resources.MergedDictionaries.Remove(oldDictionary);
            App.Current.Resources.MergedDictionaries.Add(dictionary);
        }
        public static void ChangeTheme(Uri uri)
        {
            ResourceDictionary dictionary = new ResourceDictionary() { Source = uri };
            var oldDictionary = App.Current.Resources.MergedDictionaries.FirstOrDefault(d => d.Source.OriginalString.Contains("Themes/"));
            if (oldDictionary != null) App.Current.Resources.MergedDictionaries.Remove(oldDictionary);
            App.Current.Resources.MergedDictionaries.Add(dictionary);
        }
    }
}
