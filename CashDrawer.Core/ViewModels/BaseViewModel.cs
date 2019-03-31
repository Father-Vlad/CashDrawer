using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace CashDrawer.Core.ViewModels
{
    public abstract class BaseViewModel<T> : MvxViewModel<T>
    {
        #region Variables
        protected readonly IMvxNavigationService _navigationService;
        #endregion Variables

        #region Fields
        private string _titleText = string.Empty;
        #endregion Fields

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
        public IMvxAsyncCommand ToolbarButtonCommand { get; set; }
        #endregion Commands

        #region Methods

        #endregion Methods
    }
}
