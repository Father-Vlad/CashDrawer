using CashDrawer.Core.Helper;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using System.Threading.Tasks;

namespace CashDrawer.Core.ViewModels
{
    public class SplashViewModel : BaseViewModel<object>
    {
        #region Constructors
        public SplashViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }
        #endregion Constructors

        #region Lifecycle
        public override async Task Initialize()
        {
            await Task.Run(() =>
            {
                base.Initialize();
                TerminateAnimationCommand = new MvxAsyncCommand(TerminateAnimationAsync);
            });
        }

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
            await Task.Run(() =>
            {
                TimePresentation.IsFirstPresentation = false;
                _navigationService.Close(this);
                _navigationService.Navigate<MainViewModel>();
            });
        }
        #endregion Methods
    }
}
