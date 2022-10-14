namespace MauiBoxColor;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(HSLPage), typeof(HSLPage));
    }
}
