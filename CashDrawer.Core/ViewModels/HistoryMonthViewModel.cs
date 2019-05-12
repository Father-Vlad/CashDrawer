using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;

namespace CashDrawer.Core.ViewModels
{
    public class HistoryMonthViewModel : BaseViewModel
    {
        public HistoryMonthViewModel(IMvxNavigationService navigationService, IMvxMessenger messenger) : base(navigationService, messenger)
        {
        }
    }
}
