using Android.Support.V7.Widget;
using Android.Views;
using CashDrawer.Droid.Views.Holders;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Platforms.Android.Binding.BindingContext;

namespace CashDrawer.Droid.Adapters
{
    public class HomeRecyclerAdapter : MvxRecyclerAdapter
    {
        #region Constructors
        public HomeRecyclerAdapter(IMvxAndroidBindingContext bindingContext) : base(bindingContext)
        {
        }
        #endregion Constructors

        #region Overrides
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemBindingContext = new MvxAndroidBindingContext(parent.Context, this.BindingContext.LayoutInflaterHolder);
            var view = this.InflateViewForHolder(parent, viewType, itemBindingContext);
            return new HomeRecyclerHolder(view, itemBindingContext)
            {
                Click = ItemClick,
                LongClick = ItemLongClick
            };
        }
        #endregion Overrides

    }
}