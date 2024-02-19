using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Shared.Models;
using Shared.Services;

namespace MauiApp_App.Mvvm.ViewModels;

public partial class AddPageViewModel : ObservableObject
{
    private readonly UserService _userService;

    public AddPageViewModel(UserService userService)
    {
        _userService = userService;
    }

    [ObservableProperty]
    User user = new User();

    [RelayCommand]
    public async Task GoBack()
    {
        await Shell.Current.GoToAsync($"..");
    }

    [RelayCommand]
    public async Task Save(User user)
    {
        //save
        _userService.AddUserToList(user);

        user = new User();
        await Shell.Current.GoToAsync($"..");
    }
}
