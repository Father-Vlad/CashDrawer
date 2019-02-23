using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace CashDrawer.Core.ViewModels
{
    public abstract class BaseViewModel<T> : MvxViewModel<T>
    {
        #region Variables
        protected IMvxNavigationService _navigationService;
        #endregion Variables

        #region Constructors
        public BaseViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        #endregion Constructors

        #region Lifecycle
        public override void Prepare(T parameter)
        {
        }
        #endregion Lifecycle

        #region Properties

        #endregion Properties

        #region Methods

        #endregion Methods
    }
}
