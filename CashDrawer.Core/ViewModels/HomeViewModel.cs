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
        private string _titleText = "Cash Drawer";
        private readonly string _valuta_USD = "USD";
        private readonly string _valuta_EUR = "EUR";
        private readonly string _valuta_UAH = "UAH";
        private readonly string _valuta_GBP = "GBP";
        private readonly string _valuta_RUB = "RUB";
        #endregion Variables

        #region Fields
        private MvxObservableCollection<Wallet> _wallets;
        private bool _isRefreshLayoutRefreshing;
        private string _totalCash;
        private string _cashValuta;
        #endregion Fields

        #region Constructors
        public HomeViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
            TitleText = _titleText;
            ToolbarButtonCommand = new MvxAsyncCommand(async () => await _navigationService.Close(this));
            Wallets = new MvxObservableCollection<Wallet>();
            IsRefreshLayoutRefreshing = false;
            LookDescriptionCommand = new MvxAsyncCommand<Wallet>(async (wallet) => await _navigationService.Navigate<WalletDescriptionViewModel, Wallet>(wallet));
            UpdateDataCommand = new MvxAsyncCommand(UpdateData);
            CashValuta = _valuta_UAH;
            TotalCash = "99999.88";
        }
        #endregion Constructors

        #region Lifecycle
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

        public string TotalCash
        {
            get
            {
                return _totalCash;
            }

            set
            {
                _totalCash = value;
                RaisePropertyChanged(() => TotalCash);
            }
        }

        public string CashValuta
        {
            get
            {
                return _cashValuta;
            }

            set
            {
                _cashValuta = value;
                RaisePropertyChanged(() => CashValuta);
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
