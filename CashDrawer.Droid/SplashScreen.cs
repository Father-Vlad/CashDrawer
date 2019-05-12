using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace CashDrawer.Droid
{
    [Activity(
        MainLauncher = true,
        Theme = "@style/Theme.Splash",
        NoHistory = true,
        Icon = "@mipmap/ic_launcher",
        RoundIcon = "@mipmap/ic_launcher_round",
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.SplashScreenLayout)
        {
        }
    }
}