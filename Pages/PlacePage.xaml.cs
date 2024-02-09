using CommunityToolkit.Maui.Views;

namespace TeleportMe.Pages;

public partial class PlacePage : ContentPage
{
	public PlacePage()
	{
		InitializeComponent();
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        // base.OnNavigatedTo(args);
        ConnexionPopup popup = new ConnexionPopup();
        var result = this.ShowPopupAsync(popup);
    }
}