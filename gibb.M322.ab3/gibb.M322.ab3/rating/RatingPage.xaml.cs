using Microsoft.UI.Xaml.Media;
using System.Diagnostics;

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
        bool answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
        Debug.WriteLine("Answer: " + answer);
    }

}