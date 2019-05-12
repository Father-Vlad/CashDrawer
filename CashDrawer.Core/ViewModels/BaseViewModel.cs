using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;

namespace CashDrawer.Core.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        #region Variables
        protected readonly IMvxNavigationService _navigationService;
        protected readonly IMvxMessenger _messenger;
        #endregion Variables

        #region Fields
        private string _titleText = string.Empty;
        #endregion Fields

        #region Constructors
        public BaseViewModel(IMvxNavigationService navigationService, IMvxMessenger messenger)
        {
            _navigationService = navigationService;
            _messenger = messenger;
        }
        #endregion Constructors

        #region Lifecycle
        #endregion Lifecycle

        #region Properties
        public string TitleText
        {
            get
            {
                return _titleText;
            }

            set
            {
                _titleText = value;
                RaisePropertyChanged(() => TitleText);
            }
        }
        #endregion Properties

        #region Commands
        public IMvxAsyncCommand LeftToolbarButtonCommand { get; set; }
        public IMvxAsyncCommand RightToolbarButtonCommand { get; set; }
        #endregion Commands

        #region Methods

        #endregion Methods
    }
}
