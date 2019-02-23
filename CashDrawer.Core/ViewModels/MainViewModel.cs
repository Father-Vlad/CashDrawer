using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace CashDrawer.Core.ViewModels
{
    public class MainViewModel : BaseViewModel<object>
    {
        #region Constructors
        public MainViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
            ShowCurrentViewModelCommand = new MvxCommand(ShowCurrentViewModel);
            ShowLoginViewModelCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<LoginViewModel>());
            ShowHomeViewModelCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<HomeViewModel>());
        }
        #endregion Constructors

        #region Commands
        public IMvxCommand ShowCurrentViewModelCommand { get; set; }
        private IMvxAsyncCommand ShowLoginViewModelCommand { get; set; }
        private IMvxAsyncCommand ShowHomeViewModelCommand { get; set; }
        #endregion Commands

        #region Methods
        private void ShowCurrentViewModel()
        {
            /*
            if (CurrentUser.GetCurrentUserId() == string.Empty)
            {
                ShowLoginViewModelCommand.Execute();
                return;
            }
            */
            ShowHomeViewModelCommand.Execute();
        }
        #endregion Methods
    }
}