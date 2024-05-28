using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp10
{
    public partial class MyViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _text;


        public async Task AlertText()
        {
            await Application.Current.MainPage.DisplayAlert("title", Text, "ok");
        }
    }
}
