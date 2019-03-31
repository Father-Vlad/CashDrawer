using Android.App;
using Android.OS;
using CashDrawer.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace CashDrawer.Droid.Views
{
    [MvxActivityPresentation]
    [Activity(Theme = "@style/Theme.Home", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, NoHistory = true)]
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