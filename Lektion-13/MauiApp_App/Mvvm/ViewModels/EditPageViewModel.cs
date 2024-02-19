using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Shared.Models;
using Shared.Services;

namespace MauiApp_App.Mvvm.ViewModels;

public partial class EditPageViewModel : ObservableObject
{
    private readonly UserService _userService;

    public EditPageViewModel(UserService userService)
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
        _userService.UpdateUserInList(user);

        user = new User();
        await Shell.Current.GoToAsync($"..");
    }
}
