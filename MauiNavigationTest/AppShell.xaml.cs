using MauiNavigationTest.Pages;

namespace MauiNavigationTest;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(LoginPage),typeof(LoginPage));
        Routing.RegisterRoute(nameof(FirstPage), typeof(FirstPage));
        Routing.RegisterRoute(nameof(SecondPage), typeof(SecondPage));
        Routing.RegisterRoute(nameof(ThirdPage), typeof(ThirdPage));
    }
}
