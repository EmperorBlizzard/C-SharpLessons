using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp_App.Mvvm.Views;
using Shared.Models;
using Shared.Services;

namespace MauiApp_App.Mvvm.ViewModels;

public partial class DetailsPageViewModel : ObservableObject
{
    private readonly UserService _userService;

    public DetailsPageViewModel(UserService userService)
    {
        _userService = userService;
         User = _userService.GetUserFromList(x => x.Id == UserId);
    }

    [ObservableProperty]
    string userId = null!;

    [ObservableProperty]
    User user = new User();

    [RelayCommand]
    public async Task GoToEdit(string id)
    {
        await Shell.Current.GoToAsync($"{nameof(EditPage)}?id={id}");
    }

    [RelayCommand]
    public async Task GoBack()
    {
        await Shell.Current.GoToAsync($"..");
    }
}
