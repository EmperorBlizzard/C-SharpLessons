using CimoApp.Mvvm.Models;
using CimoApp.Mvvm.Views;
using CimoApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimoApp.Mvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            UpdateContacts();
            ContactService.ContactsUpdated += UpdateContacts;
        }

        void UpdateContacts()
        {
            foreach (var contact in ContactService.GetContacts())
                Contacts.Add(contact);
        }

        [ObservableProperty]
        ObservableCollection<ContactModel> contacts = new ObservableCollection<ContactModel>();



        [RelayCommand]
        async Task GoToAdd()
        {
            await Shell.Current.GoToAsync(nameof(AddPage));
        }

        [RelayCommand]
        async Task GoToDetails(ContactModel contact)
        {

            var navigationParameters = new Dictionary<string, object>()
            {
                {"Contact", contact}
            };

            await Shell.Current.GoToAsync($"nameof(DetailsPage)", navigationParameters);
        }
    }
}
