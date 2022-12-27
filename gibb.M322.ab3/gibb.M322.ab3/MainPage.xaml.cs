namespace gibb.M322.ab3;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnSettingsButtonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new NewPage1(), true);
        Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));

    }

    private void ToBlackClover(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new RatingPage(), true);
        Routing.RegisterRoute(nameof(RatingPage), typeof(RatingPage));

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

}

