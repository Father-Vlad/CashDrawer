using CashDrawer.Core.Helper;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using System.Threading.Tasks;

namespace CashDrawer.Core.ViewModels
{
    public class SplashViewModel : BaseViewModel
    {
        #region Constructors
        public SplashViewModel(IMvxNavigationService navigationService, IMvxMessenger messenger) : base(navigationService, messenger)
        {
            TerminateAnimationCommand = new MvxAsyncCommand(TerminateAnimationAsync);
        }
        #endregion Constructors

        #region Lifecycle

        public override async void ViewAppearing()
        {
            base.ViewAppearing();
            if (!TimePresentation.IsFirstPresentation)
            {
                await TerminateAnimationAsync();
            }
        }
        #endregion Lifecycle

        #region Commands
        public IMvxAsyncCommand TerminateAnimationCommand { get; set; }
        #endregion Commands

        #region Methods
        private async Task TerminateAnimationAsync()
        {
            TimePresentation.IsFirstPresentation = false;
            await _navigationService.Close(this);
            await _navigationService.Navigate<MainViewModel>();
        }
        #endregion Methods
    }
}
