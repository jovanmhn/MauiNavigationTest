namespace MauiNavigationTest.Pages;

public partial class ThirdPage : ContentPage
{
	public ThirdPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
        //await Shell.Current.GoToAsync(".."); //<- doesnt work either! :(
        await Shell.Current.GoToAsync("//FirstPage/SecondPage"); //<- this one does
	}
}