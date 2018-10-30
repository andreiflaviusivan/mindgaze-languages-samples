using Prism.Windows.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindgaze.Languages.UWP.ViewModels
{
    public class ViewModelBaseWithLang : ViewModelBase
    {
        public ViewModelBaseWithLang(MultiLanguageWorkshop lang)
        {
            this.Lang = lang;
        }

        public MultiLanguageWorkshop Lang { get; }
    }
}
