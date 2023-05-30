using System;
using TestApp.Services;

namespace TestApp.Commands
{
    class ChangeLanguageCommand : BaseCommand
    {
   
        public override void Execute(object? parameter)
        {
            AppearanceEditor.ChangeLanguage(GenerateUri(parameter as string));

        }
        private Uri GenerateUri(string language)
        {
            return new Uri($"Languages/{language}.xaml", UriKind.Relative);
        }
        
    }
}
