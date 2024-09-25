namespace PagesDemo;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PopAsync(IsLoaded);
    }
}