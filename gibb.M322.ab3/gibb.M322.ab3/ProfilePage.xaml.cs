using System.Diagnostics;

namespace gibb.M322.ab3;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
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

    private void OnInfoClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new InfoPage(), true);
        Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));

    }

}