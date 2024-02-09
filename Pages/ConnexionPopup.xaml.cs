namespace TeleportMe.Pages;

using CommunityToolkit.Maui.Views;
using TeleportMe.Controllers;

public partial class ConnexionPopup : Popup
{
	public ConnexionPopup()
	{
		InitializeComponent();
	}
    private void testConnection(Object sender, EventArgs e)
    {
        //Connexion aaa = new Connexion();
        BtnConnexion.Text = Connexion.testConnexion(1).ToString();
    }

    private void fermePopup(Object sender, EventArgs e)
    {
        Close();
    }
}