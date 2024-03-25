namespace MAUIAssignment;

public partial class ProductDetailPage : ContentPage
{
	public ProductDetailPage()
	{
		InitializeComponent();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // Chuyển về trang trước đó (trang ProductList)
    }
}