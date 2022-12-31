namespace gibb.M322.ab3.rating;

public partial class RatingPageNa : ContentPage
{
	public RatingPageNa()
	{
		InitializeComponent();
	}
	    private void OnSettingsButtonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new MainPage(), true);
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

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
    private void OnSettingsToProfile(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new NewPage1(), true);
        Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));

    }
    async void OnAlertYesNoClicked(object sender, EventArgs e)
    {
        bool accept = await DisplayAlert("Thank you for your review", "Your review will be checked and posted within the next 24h", "Ok","Cancel");
        if(accept == true)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new RatingPageNa(), true);
            Routing.RegisterRoute(nameof(RatingPageNa), typeof(RatingPageNa));
        }
        
    }
    void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
    {
        double value = args.NewValue;
        slider.Value = value;
        displayLabel.Text = String.Format("You rated this show a {0}", value);
    }
    private void OnInfoClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new InfoPage(), true);
        Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));

    }
}