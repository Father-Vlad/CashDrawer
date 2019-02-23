using Android.Views;
using CashDrawer.Core.Models;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Platforms.Android.Binding.BindingContext;

namespace CashDrawer.Droid.Views.Holders
{
    public class HomeRecyclerHolder : MvxRecyclerViewHolder
    {
        #region Variables
        #endregion Variables

        #region Constructors
        public HomeRecyclerHolder(View itemView, IMvxAndroidBindingContext context) : base(itemView, context)
        {
            SetupBinding();
        }
        #endregion Constructors

        #region Methods
        private void SetupBinding()
        {
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<HomeRecyclerHolder, Wallet>();
            });
        }
        #endregion Methods
    }
}