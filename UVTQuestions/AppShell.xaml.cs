namespace UVTQuestions;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MainViewModel), typeof(MainPage));
	}
}

