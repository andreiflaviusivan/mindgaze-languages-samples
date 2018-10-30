using System;

using Mindgaze.Languages.UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Mindgaze.Languages.UWP.Views
{
    public sealed partial class BlankPage : Page
    {
        private BlankViewModel ViewModel => DataContext as BlankViewModel;

        public BlankPage()
        {
            InitializeComponent();
        }
    }
}
