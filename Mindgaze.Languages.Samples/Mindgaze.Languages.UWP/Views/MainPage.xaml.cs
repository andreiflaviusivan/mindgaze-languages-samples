using System;

using Mindgaze.Languages.UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Mindgaze.Languages.UWP.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ViewModel.ChangeLanguage((sender as Button).Content as string);
        }
    }
}
