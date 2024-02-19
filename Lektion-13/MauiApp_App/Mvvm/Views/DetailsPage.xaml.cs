using MauiApp_App.Mvvm.ViewModels;

namespace MauiApp_App.Mvvm.Views;

[QueryProperty(nameof(UserId), "userId")]

public partial class DetailsPage : ContentPage
{
	private string userId;

	public string UserId
	{
		get { return userId; }
		set 
		{ 
			userId = value;
			OnPropertyChanged();
		}
	}


	public DetailsPage(DetailsPageViewModel viewModel)
	{
		InitializeComponent();
		viewModel.UserId = userId;
        BindingContext = viewModel;
    }

}