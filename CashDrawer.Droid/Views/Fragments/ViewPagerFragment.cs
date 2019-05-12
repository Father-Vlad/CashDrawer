using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Views;
using CashDrawer.Core.ViewModels;
using CashDrawer.Droid.Adapters;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using System.Collections.Generic;

namespace CashDrawer.Droid.Views.Fragments
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame, false)]
    [Register("CashDrawer.Droid.Views.Fragments.ViewPagerView")]
    public class ViewPagerFragment : BaseFragment<ViewPagerViewModel>
    {
        #region Lifecycle
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);
            ViewPager _viewPager = view.FindViewById<ViewPager>(Resource.Id.view_pager_historyViewPager_main);
            TabLayout _tabLayout = view.FindViewById<TabLayout>(Resource.Id.tab_layout_historyViewPager_main);
            var fragments = new List<MvxFragmentStatePagerAdapter.FragmentInfo>
            {
                new MvxFragmentStatePagerAdapter.FragmentInfo
                {
                    FragmentType = typeof(HistoryDayFragment),
                    Title = "Today",
                    ViewModel = ViewModel.HistoryDayViewModel
                },

                new MvxFragmentStatePagerAdapter.FragmentInfo
                {
                    FragmentType = typeof(HistoryMonthFragment),
                    Title = "This Month",
                    ViewModel = ViewModel.HistoryMonthViewModel
                },

                new MvxFragmentStatePagerAdapter.FragmentInfo
                {
                    FragmentType = typeof(HistoryYearFragment),
                    Title = "This Year",
                    ViewModel = ViewModel.HistoryYearViewModel
                }
            };
            _viewPager.Adapter = new MvxFragmentStatePagerAdapter(Activity, ChildFragmentManager, fragments);
            _tabLayout.SetupWithViewPager(_viewPager);
            //_tabLayout.GetTabAt(0).SetIcon(Resource.Drawable.checkbox_checked_20);
            //_tabLayout.GetTabAt(1).SetIcon(Resource.Drawable.checkbox_unchecked_20);
            return view;
        }
        #endregion Lifecycle

        #region Overrides
        protected override int FragmentId => Resource.Layout.HistoryViewPagerLayout;
        #endregion Overrides
    }
}