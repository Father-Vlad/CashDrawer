using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;

namespace CashDrawer.Core.ViewModels
{
    public class HistoryDayViewModel : BaseViewModel
    {
        public HistoryDayViewModel(IMvxNavigationService navigationService, IMvxMessenger messenger) : base(navigationService, messenger)
        {
        }
    }
}
