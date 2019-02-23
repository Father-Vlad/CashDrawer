
using Android.App;
using Android.OS;
using CashDrawer.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace CashDrawer.Droid.Views
{
    [MvxActivityPresentation]
    [Activity]
    public class MainView : MvxAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainLayout);
            if (savedInstanceState == null)
            {
                this.ViewModel.ShowCurrentViewModelCommand?.Execute();
            }
        }
    }
}