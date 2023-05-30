using System;
using TestApp.Services;

namespace TestApp.Commands
{
    class ChangeThemeCommand :BaseCommand
    {
        public override void Execute(object? parameter)
        {
            AppearanceEditor.ChangeTheme(GenerateUri(parameter as string));

        }
        private Uri GenerateUri(string theme)
        {
            return new Uri($"Themes/{theme}.xaml", UriKind.Relative);
        }
    }
}
