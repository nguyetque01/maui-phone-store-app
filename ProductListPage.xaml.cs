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

    private void SortAscending_Clicked(object sender, EventArgs e)
    {
        SortProductsByPrice(true); // true for ascending
    }

    private void SortDescending_Clicked(object sender, EventArgs e)
    {
        SortProductsByPrice(false); // false for descending
    }

    private void SortProductsByPrice(bool ascending)
    {
        if (ascending)
            Products = new ObservableCollection<Product>(Products.OrderBy(p => p.Price));
        else
            Products = new ObservableCollection<Product>(Products.OrderByDescending(p => p.Price));

        OnPropertyChanged(nameof(Products));
    }
}