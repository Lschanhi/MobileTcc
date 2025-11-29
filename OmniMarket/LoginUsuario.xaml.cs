namespace OmniMarket;

public partial class LoginUsuario : ContentPage
{
	public LoginUsuario()
	{
		InitializeComponent();
	}

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//home");
    }
}