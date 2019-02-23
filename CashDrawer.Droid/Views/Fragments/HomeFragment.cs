using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using CashDrawer.Core.ViewModels;
using CashDrawer.Droid.Adapters;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace CashDrawer.Droid.Views.Fragments
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame, false)]
    [Register("CashDrawer.Droid.Views.Fragments.HomeFragment")]
    public class HomeFragment : BaseFragment<HomeViewModel>
    {
        #region Variables
        private HomeRecyclerAdapter _recyclerAdapter;
        private RecyclerView.LayoutManager _layoutManager;
        private MvxRecyclerView _recyclerView;
        #endregion Variables

        #region Lifecycle
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);
            _recyclerView = view.FindViewById<MvxRecyclerView>(Resource.Id.recycler_view_main);
            _layoutManager = new LinearLayoutManager(Context);
            _recyclerView.SetLayoutManager(_layoutManager);
            var recyclerAdapter = new HomeRecyclerAdapter((IMvxAndroidBindingContext)BindingContext);
            _recyclerAdapter = recyclerAdapter;
            _recyclerView.Adapter = _recyclerAdapter;
            return view;
        }
        #endregion Lifecycle

        #region Overrides
        protected override int FragmentId => Resource.Layout.HomeLayout;
        #endregion Overrides
    }
}