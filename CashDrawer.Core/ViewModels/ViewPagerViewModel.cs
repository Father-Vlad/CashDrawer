using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;

namespace CashDrawer.Core.ViewModels
{
    public class ViewPagerViewModel : BaseViewModel
    {
        #region Variables
        #endregion Variables

        #region Fields
        #endregion Fields

        #region Constructors
        public ViewPagerViewModel(IMvxNavigationService navigationService, IMvxMessenger messenger) : base(navigationService, messenger)
        {
            TitleText = "History";
            HistoryDayViewModel = Mvx.IoCProvider.IoCConstruct<HistoryDayViewModel>();
            HistoryMonthViewModel = Mvx.IoCProvider.IoCConstruct<HistoryMonthViewModel>();
            HistoryYearViewModel = Mvx.IoCProvider.IoCConstruct<HistoryYearViewModel>();
        }
        #endregion Constructors

        #region Lifecycle
        #endregion Lifecycle

        #region Properties
        public HistoryDayViewModel HistoryDayViewModel { get; private set; }
        public HistoryMonthViewModel HistoryMonthViewModel { get; private set; }
        public HistoryYearViewModel HistoryYearViewModel { get; private set; }
        #endregion Properties

        #region Commands
        #endregion Commands

        #region Methods
        #endregion Methods

        #region Overrides
        #endregion Overrides
    }
}