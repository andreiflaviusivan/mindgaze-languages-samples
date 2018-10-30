using System;

using Prism.Windows.Mvvm;

namespace Mindgaze.Languages.UWP.ViewModels
{
    public class MainViewModel : ViewModelBaseWithLang
    {
        public MainViewModel(MultiLanguageWorkshop multiLanguageWorkshop) : base(multiLanguageWorkshop)
        {
        }

        public void ChangeLanguage(String language)
        {
            Lang.CurrentLanguage = language;
        }
    }
}
