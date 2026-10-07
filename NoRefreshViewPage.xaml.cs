namespace MauiRefreshView
{
    public partial class NoRefreshViewPage : ContentPage
    {
        public NoRefreshViewPage() =>  InitializeComponent();

        private async void RefreshView_Refreshing(object sender, EventArgs e)
        {
            await DisplayAlertAsync("RefreshView", "Refreshing event fired", "Cancel");
            ((RefreshView)sender).IsRefreshing = false;
        }
    }
}
