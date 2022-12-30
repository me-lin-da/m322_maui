namespace gibb.M322.ab3;

public partial class FAQPage : ContentPage
{
	public FAQPage()
	{
		InitializeComponent();
	}
    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entry.Text;
    }
    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
    private void OnInfoClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new InfoPage(), true);
        Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));

    }
    private void OnSettingsButtonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new NewPage1(), true);
        Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));

    }
    private void OnBackClick(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new MainPage(), true);
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

    }
    async void OnAlertYesNoClicked(object sender, EventArgs e)
    {
        bool accept = await DisplayAlert("Thank you for your review", "Your review will be checked and posted within the next 24h", "Ok", "Cancel");
        if (accept == true)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new RatingPage(), true);
            Routing.RegisterRoute(nameof(RatingPage), typeof(RatingPage));
        }

    }
}