using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CashDrawer.Core.Models;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace CashDrawer.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel<object>
    {
        #region Variables
        private MvxObservableCollection<Wallet> _wallets;
        private bool _isRefreshLayoutRefreshing;
        #endregion Variables

        #region Constructors
        public HomeViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }
        #endregion Constructors

        #region Lifecycle
        public override async Task Initialize()
        {
            await Task.Run(() =>
            {
                base.Initialize();
                Wallets = new MvxObservableCollection<Wallet>();
                IsRefreshLayoutRefreshing = false;
                LookDescriptionCommand = new MvxAsyncCommand<Wallet>(async (wallet) => await _navigationService.Navigate<WalletDescriptionViewModel, Wallet>(wallet));
                UpdateDataCommand = new MvxAsyncCommand(UpdateData);
            });
        }

        public override async void ViewAppearing()
        {
            base.ViewAppearing();
            await UpdateData();
        }

        #endregion Lifecycle

        #region Properties
        public MvxObservableCollection<Wallet> Wallets
        {
            get
            {
                return _wallets;
            }

            set
            {
                _wallets = value;
                RaisePropertyChanged(() => Wallets);
            }
        }

        public bool IsRefreshLayoutRefreshing
        {
            get
            {
                return _isRefreshLayoutRefreshing;
            }

            set
            {
                _isRefreshLayoutRefreshing = value;
                RaisePropertyChanged(() => IsRefreshLayoutRefreshing);
            }
        }
        #endregion Properties

        #region Commands
        public IMvxAsyncCommand<Wallet> LookDescriptionCommand { get; set; }
        public IMvxAsyncCommand UpdateDataCommand { get; set; }
        #endregion Commands

        #region Methods
        private async Task UpdateData()
        {
            await Task.Run(() =>
            {
                IsRefreshLayoutRefreshing = true;
                IsRefreshLayoutRefreshing = false;
            });
        }
        #endregion Methods
    }
}
