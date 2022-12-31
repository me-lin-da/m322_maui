using gibb.M322.ab3.rating;

namespace gibb.M322.ab3;

public partial class MainPage : ContentPage
{

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
    private void OnInfoClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new InfoPage(), true);
        Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));

    }
    private void ToNaruto(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new RatingPageNa(), true);
        Routing.RegisterRoute(nameof(RatingPageNa), typeof(RatingPageNa));

    }
    private void ToSaiki(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new RatingPageSa(), true);
        Routing.RegisterRoute(nameof(RatingPageSa), typeof(RatingPageSa));

    }
}

