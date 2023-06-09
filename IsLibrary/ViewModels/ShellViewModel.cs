﻿using IsLibrary.Commands;
using IsLibrary.Services;

namespace IsLibrary.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        public ShellViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _navigationService.NavigateTo<HomeViewModel>();
            NavigateToBooksCommand = new RelayCommand(x => _navigationService.NavigateTo<BookListViewModel>());
            NavigateToAddBookCommand = new RelayCommand(x => _navigationService.NavigateTo<AddBookViewModel>());
        }

        public RelayCommand NavigateToBooksCommand { get; set; }
        public RelayCommand NavigateToAddBookCommand { get; set; }
        public RelayCommand NavigateToReadersCommand { get; set; }
        public RelayCommand NavigateToRelicsCommand { get; set; }
        public RelayCommand NavigateToExpiredBooksCommand { get; set; }
        public RelayCommand NavigateToSettingsCommand { get; set; }
        public RelayCommand NavigateToAboutCommand { get; set; }
        private INavigationService _navigationService;
        public INavigationService NavigationService
        {
            get => _navigationService;
            set
            {
                _navigationService = value;
                OnPropertyChanged(nameof(NavigationService));
            }
        }              
    }
}
