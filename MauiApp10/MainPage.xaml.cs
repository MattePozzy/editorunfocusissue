namespace MauiApp10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void VolosEditor_Unfocused(object sender, FocusEventArgs e)
        {
            if (BindingContext is MyViewModel bv)
            {
                await bv.AlertText();
            }
        }
    }
}
