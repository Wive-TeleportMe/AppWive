namespace TeleportMe.Pages;

using TeleportMe.Controllers;
using static TeleportMe.Controllers.Connexion;

public partial class LivePage : ContentPage
{

	public LivePage()
	{
		InitializeComponent();
	}

    private void testConnection(Object sender, EventArgs e)
    {
        Connexion aaa = new Connexion();
        testConnectionBtn.Text = Connexion.testConnexion(1).ToString();
    }

    // PHOTO PRISE SUR LE MOMENT AVEC L'APPLI PHOTO
    private async void capturePhoto(Object sender, EventArgs e)
    {
        if (MediaPicker.Default.IsCaptureSupported)
        {
            FileResult myPhoto = await MediaPicker.Default.CapturePhotoAsync();
            if (myPhoto != null)
            {
                // Sauvegarde l'image capturée dans l'application
                string localFilePath = Path.Combine(FileSystem.CacheDirectory, myPhoto.FileName);

                using Stream sourceStream = await myPhoto.OpenReadAsync();
                using FileStream localFileStream = File.OpenWrite(localFilePath);
                await sourceStream.CopyToAsync(localFileStream);
            }
        }
        else
        {
            await Shell.Current.DisplayAlert("OOPS", "Your device isn't supported", "ok");
        }
    }

    // PHOTO PRISE DANS LES FICHIERS DU TEL
    private async void takeImage(Object sender, EventArgs e)
    {
        if (MediaPicker.Default.IsCaptureSupported)
        {
            FileResult myPhoto = await MediaPicker.Default.PickPhotoAsync();
            if (myPhoto != null)
            {
                // Sauvegarde l'image capturée dans l'application
                string localFilePath = Path.Combine(FileSystem.CacheDirectory, myPhoto.FileName);

                using Stream sourceStream = await myPhoto.OpenReadAsync();
                using FileStream localFileStream = File.OpenWrite(localFilePath);
                await sourceStream.CopyToAsync(localFileStream);
            }
        }
        else
        {
            await Shell.Current.DisplayAlert("OOPS", "Your device isn't supported", "ok");
        }
    }

    // VIDEO PRISE SUR LE MOMENT AVEC L'APPLI PHOTO
    private async void captureVideo(Object sender, EventArgs e)
    {
     
        if (MediaPicker.Default.IsCaptureSupported)
        {
            // POUR UNE IMAGE :
            FileResult myVideo = await MediaPicker.Default.CaptureVideoAsync();
            if (myVideo != null)
            {
                // Sauvegarde l'image capturée dans l'application
                string localFilePath = Path.Combine(FileSystem.CacheDirectory, myVideo.FileName);

                using Stream sourceStream = await myVideo.OpenReadAsync();
                using FileStream localFileStream = File.OpenWrite(localFilePath);
                await sourceStream.CopyToAsync(localFileStream);
            }
        }
        else
        {
            await Shell.Current.DisplayAlert("OOPS", "Your device isn't supported", "ok");
        }
    }

    // VIDEO PRISE DANS LES FICHIERS DU TEL
    private async void takeVideo(Object sender, EventArgs e)
    {

        // TAKE PHOTO OR CAPTURE PHOTO
        if (MediaPicker.Default.IsCaptureSupported)
        {
            // POUR UNE IMAGE :
            FileResult myVideo = await MediaPicker.Default.PickVideoAsync();
            if (myVideo != null)
            {
                // Sauvegarde l'image capturée dans l'application
                string localFilePath = Path.Combine(FileSystem.CacheDirectory, myVideo.FileName);

                using Stream sourceStream = await myVideo.OpenReadAsync();
                using FileStream localFileStream = File.OpenWrite(localFilePath);
                await sourceStream.CopyToAsync(localFileStream);
            }
        }
        else
        {
            await Shell.Current.DisplayAlert("OOPS", "Your device isn't supported", "ok");
        }
    }
}