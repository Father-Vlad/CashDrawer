using Android.App;
using Android.Widget;
using CashDrawer.Core.Interfaces;

namespace CashDrawer.Droid.Services
{
    public class AlertService : IAlertService
    {
        public void ShowToastLong(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }

        public void ShowToastShort(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
    }
}