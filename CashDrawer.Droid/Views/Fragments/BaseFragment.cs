﻿using Android.Content.Res;
using Android.OS;
using Android.Views;
using Android.Widget;
using CashDrawer.Droid.Constants;
using CashDrawer.Droid.Helper;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.ViewModels;

namespace CashDrawer.Droid.Views.Fragments
{
    public abstract class BaseFragment : MvxFragment
    {
        #region Variables
        protected TextView _tvTitle;
        #endregion Variables

        #region Lifecycle
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = this.BindingInflate(FragmentId, null);
            _tvTitle = view.FindViewById<TextView>(Resource.Id.text_view_toolbar_title);
            Typefaces.SetBold(_tvTitle, Fonts.QUICKSAND_REGULAR);
            return view;
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
        }
        #endregion Lifecycle

        #region Properties
        public MvxAppCompatActivity ParentActivity
        {
            get
            {
                return (MvxAppCompatActivity)Activity;
            }
        }

        protected abstract int FragmentId { get; }
        #endregion Properties

        #region Overrides
        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
        }
        #endregion Overrides
    }

    public abstract class BaseFragment<TViewModel> : BaseFragment where TViewModel : class, IMvxViewModel
    {
        #region Lifecycle
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Activity.OverridePendingTransition(Android.Resource.Animation.FadeIn, Android.Resource.Animation.FadeOut);
            

        }
        #endregion Lifecycle

        #region Properties
        public new TViewModel ViewModel
        {
            get
            {
                return (TViewModel)base.ViewModel;
            }
            set
            {
                base.ViewModel = value;
            }
        }
        #endregion Properties
    }
}