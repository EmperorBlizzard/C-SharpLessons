using CimoApp.Mvvm.Models;
using CimoApp.Mvvm.ViewModels;

namespace CimoApp.Mvvm.Views;
[QueryProperty(nameof(ContactModel))]
public partial class DetailsPage : ContentPage
{
	


	public DetailsPage(DetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}