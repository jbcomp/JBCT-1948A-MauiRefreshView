namespace MauiRefreshView
{
    public partial class DisabledRefreshViewPage : ContentPage
    {
        public DisabledRefreshViewPage() =>  InitializeComponent();

        private async void RefreshView_Refreshing(object sender, EventArgs e)
        {
            await DisplayAlertAsync("RefreshView", "Refreshing event fired", "Cancel");
            ((RefreshView)sender).IsRefreshing = false;
        }
    }
}
