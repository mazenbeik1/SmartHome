namespace SmartHome;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void StartBtn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new AppliancesView());
	}
}

