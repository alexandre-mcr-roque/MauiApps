using MauiControls.Models;

namespace MauiControls.Pages;

public partial class MauiCollectionControls : ContentPage
{
	public MauiCollectionControls()
	{
		InitializeComponent();
		BindingContext = new PhotoViewModel();
	}

    //  private async void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    //  {
    //      var before = e.PreviousItem as Photo;
    //      var next = e.CurrentItem as Photo;
    //      if (before != null && next != null)
    //{
    //	await DisplayAlert("CarouselView",
    //		$"Before = {before.Name}\n\nNext = {next.Name}", "Ok");
    //}
    //  }

    private void seatbeltAlert_OnChanged(object sender, ToggledEventArgs e)
    {
        DisplayAlert("Seat Belt Alert",
            "You selected/deselected this accessory", "Ok");
    }
}