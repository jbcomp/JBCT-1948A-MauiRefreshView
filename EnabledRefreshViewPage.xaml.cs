namespace MauiRefreshView
{
    public partial class EnabledRefreshViewPage : ContentPage
    {
        public EnabledRefreshViewPage() => InitializeComponent();

        private async void RefreshView_Refreshing(object sender, EventArgs e)
        {
            await DisplayAlertAsync("RefreshView", "Refreshing event fired", "OK");
            ((RefreshView)sender).IsRefreshing = false;
        }
    }
}
