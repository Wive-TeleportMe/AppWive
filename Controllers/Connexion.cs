//using TeleportMe.Pages;
using MySqlConnector;

namespace TeleportMe.Controllers;

public class Connexion : ContentPage
{

    public string login {get; set;}
    public string password {get; set;}


    //public Connexion(string _login, string _password)
    public static string testConnexion(int _idTest)
    {
        string tmpReturn="";

        using var connection = new MySqlConnection("Server=mysql-wive.alwaysdata.net;User ID=wive;Password=WiveTeleportMe13;Database=wive_teleportme");
        connection.Open();

        using var command = new MySqlCommand("SELECT username FROM users WHERE id = "+_idTest+";", connection);
        using var reader = command.ExecuteReader();
        while (reader.Read())
            tmpReturn = reader.GetString(0);

        connection.Close();

        return tmpReturn;

        //login = _login;
        //password = _password;

    }



    public string isConnected()
    {
        return "yes";
    }

}