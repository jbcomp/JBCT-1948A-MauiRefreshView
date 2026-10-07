namespace MauiRefreshView
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();

        private async void Button1_Clicked(object sender, EventArgs e)
            => await Shell.Current.GoToAsync(nameof(EnabledRefreshViewPage));

        private async void Button2_Clicked(object sender, EventArgs e)
            => await Shell.Current.GoToAsync(nameof(DisabledRefreshViewPage));

        private async void Button3_Clicked(object sender, EventArgs e)
            => await Shell.Current.GoToAsync(nameof(NoRefreshViewPage));
    }
}
