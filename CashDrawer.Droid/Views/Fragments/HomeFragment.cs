using System;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using CashDrawer.Core.ViewModels;
using CashDrawer.Droid.Adapters;
using CashDrawer.Droid.Constants;
using CashDrawer.Droid.Helper;
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
        private TextView _tvTotalCash;
        private TextView _tvCashValuta;
        private ImageView _ivCashCircleTop;
        private ImageView _ivCashCircleBottom;
        private Animation _translateXtoRightAnimation;
        private Animation _translateXtoLeftAnimation;
        #endregion Variables

        #region Lifecycle
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);
            _recyclerView = view.FindViewById<MvxRecyclerView>(Resource.Id.recycler_view_main);
            _tvTotalCash = view.FindViewById<TextView>(Resource.Id.text_view_homeLayout_totalcash);
            _tvCashValuta = view.FindViewById<TextView>(Resource.Id.text_view_homeLayout_totalcash_valuta);
            _ivCashCircleTop = view.FindViewById<ImageView>(Resource.Id.image_view_homaLayout_circle_top);
            _ivCashCircleBottom = view.FindViewById<ImageView>(Resource.Id.image_view_homaLayout_circle_bottom);
            _translateXtoRightAnimation = AnimationUtils.LoadAnimation(view.Context, Resource.Animation.HomeLayout_TotalCash_Animation_Right_circle);
            _translateXtoLeftAnimation = AnimationUtils.LoadAnimation(view.Context, Resource.Animation.HomeLayout_TotalCash_Animation_Left_circle);

            SetupAnimations();
            SetupFonts();
            SetupAdapters();
            return view;
        }
        #endregion Lifecycle

        #region Methods
        private void SetupAnimations()
        {
            _ivCashCircleTop.StartAnimation(_translateXtoRightAnimation);
            _ivCashCircleBottom.StartAnimation(_translateXtoLeftAnimation);

        }

        private void SetupFonts()
        {
            Typefaces.SetNormal(_tvTotalCash, Fonts.QUICKSAND_BOLD);
            Typefaces.SetNormal(_tvCashValuta, Fonts.QUICKSAND_LIGHT);
        }

        private void SetupAdapters()
        {
            _layoutManager = new LinearLayoutManager(Context);
            _recyclerAdapter = new HomeRecyclerAdapter((IMvxAndroidBindingContext)BindingContext);
            _recyclerView.SetLayoutManager(_layoutManager);
            _recyclerView.Adapter = _recyclerAdapter;
        }
        #endregion Methods

        #region Overrides
        protected override int FragmentId => Resource.Layout.HomeLayout;
        #endregion Overrides
    }
}