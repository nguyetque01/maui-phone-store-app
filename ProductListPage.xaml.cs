using System.Collections.ObjectModel;

namespace MAUIAssignment;

public partial class ProductListPage : ContentPage
{
    public ObservableCollection<Product> Products { get; set; }

    public ProductListPage()
    {
        InitializeComponent();
        Products = new ObservableCollection<Product>(ProductService.GetProducts());
        BindingContext = this;
    }

    private async void OnProductTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Product selectedProduct)
        {
            await Navigation.PushAsync(new ProductDetailPage { BindingContext = selectedProduct });
        }
    }
}