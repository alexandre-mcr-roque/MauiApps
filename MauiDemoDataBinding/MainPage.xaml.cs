using MauiDemoDataBinding.Models;

namespace MauiDemoDataBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    var product = new Product
        //    {
        //        Name = "IPhone 15",
        //        Price = 850.00m,
        //        Stock = 5
        //    };

        //    //Binding productBinding = new Binding();
        //    //productBinding.Source = product;
        //    //productBinding.Path = nameof(Product.Name);

        //    //lblName.SetBinding(Label.TextProperty, productBinding);

        //    Binding nameBinding = new Binding
        //    {
        //        Source = product,
        //        Path = nameof(Product.Name),
        //        StringFormat = "Product: {0}"
        //    };
        //    lblName.SetBinding(Label.TextProperty, nameBinding);

        //    Binding priceBinding = new Binding
        //    {
        //        Source = product,
        //        Path = nameof(Product.Price),
        //        StringFormat = "Price: {0:C2}"
        //    };
        //    lblPrice.SetBinding(Label.TextProperty, priceBinding);

        //    Binding stockBinding = new Binding
        //    {
        //        Source = product,
        //        Path = nameof(Product.Stock),
        //        StringFormat = "Stock: {0}"
        //    };
        //    lblStock.SetBinding(Label.TextProperty, stockBinding);
        //}
    }

}
