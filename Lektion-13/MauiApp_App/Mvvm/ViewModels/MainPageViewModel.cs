using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp_App.Mvvm.Views;
using Shared.Models;
using Shared.Services;
using System.Collections.ObjectModel;

namespace MauiApp_App.Mvvm.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    private readonly UserService _userService;

    public MainPageViewModel(UserService userService)
    {
        _userService = userService;
        UpdateUserList();
    }

    [ObservableProperty]
    ObservableCollection<User> users = new ObservableCollection<User> ();

    [RelayCommand]
    public async Task GoToDetails(string id)
    {
        await Shell.Current.GoToAsync($"{nameof(DetailsPage)}?userId={id}");
    }

    [RelayCommand]
    public async Task GoToAdd()
    {
        await Shell.Current.GoToAsync($"{nameof(AddPage)}");
    }

    private void UpdateUserList()
    {
        var _users = _userService.GetUsersFromList();
        Users.Clear();
        foreach ( var user in _users )
        {
            Users.Add( user );
        }
    }
}
