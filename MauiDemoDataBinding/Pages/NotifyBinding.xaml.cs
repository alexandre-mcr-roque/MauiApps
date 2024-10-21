using MauiDemoDataBinding.Models;

namespace MauiDemoDataBinding.Pages;

public partial class NotifyBinding : ContentPage
{
	private Product _product;
	public NotifyBinding()
	{
		InitializeComponent();
		_product = new Product
		{
			Name = "IPhone 15",
			Price = 850.00m,
			Stock = 5
		};

		BindingContext = _product;
	}

    private async void btnUpdate_Clicked(object sender, EventArgs e)
    {
		_product.Name = "Samsung Galaxy ZFold 6";
		_product.Price = 2000.00m;
		_product.Stock = 3;

		await DisplayAlert("Product Updated",
			$"{_product.Name} - {_product.Price} - {_product.Stock}", "Ok");
    }
}