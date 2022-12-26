namespace gibb.M322.ab3;

public partial class RatingPage : ContentPage
{
	public RatingPage()
	{
        InitializeComponent();

    }

    private void OnSettingsButtonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new MainPage(), true);
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

    }

   
}