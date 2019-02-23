using Android.App;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using CashDrawer.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using System;

namespace CashDrawer.Droid.Views
{
    [Activity(Theme = "@style/AppThemeNoActionBar", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, NoHistory = true)]
    public class SplashScreenAnimatedView : MvxAppCompatActivity<SplashViewModel>
    {
        #region Variables
        private View _viewAnimated;
        private ImageView _imageIcon;
        private TransitionDrawable _transition;
        private RelativeLayout _mainLayout;
        private RelativeLayout _linesContainerLayout;
        #endregion Variables

        #region Lifecycle
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SplashScreenAnimatedLayout);
            OverridePendingTransition(Android.Resource.Animation.FadeIn, Android.Resource.Animation.FadeOut);
            Initialize();
        }
        #endregion Lifecycle

        #region Methods
        private void Initialize()
        {
            _viewAnimated = FindViewById<View>(Resource.Id.view_splash_screen_animated_object);
            _imageIcon = FindViewById<ImageView>(Resource.Id.image_view_icon_splash_screen_animated);
            _mainLayout = FindViewById<RelativeLayout>(Resource.Id.relative_layout_splash_screen_animated_main);
            _linesContainerLayout = FindViewById<RelativeLayout>(Resource.Id.relative_layout_lines_container);
            _transition = (TransitionDrawable)_viewAnimated.Background;
            _transition.StartTransition(2000);
            _viewAnimated.Animation = AnimationUtils.LoadAnimation(this, Resource.Animation.SplashScreenAnimation_view);
            _viewAnimated.Animation.AnimationEnd += TerminateAnimationBackgound;
            _imageIcon.Animation = AnimationUtils.LoadAnimation(this, Resource.Animation.SplashScreenAnimation_icon);
            _linesContainerLayout.Animation = AnimationUtils.LoadAnimation(this, Resource.Animation.SplashScreenAnimation_lines);
            _linesContainerLayout.Animation.AnimationEnd += TerminateAnimationIcon;
        }

        private void TerminateAnimationBackgound(object sender, EventArgs e)
        {
            _mainLayout.SetBackgroundColor(Android.Graphics.Color.ParseColor("#C4009A"));
        }

        private void TerminateAnimationIcon(object sender, EventArgs e)
        {
            this.ViewModel.TerminateAnimationCommand.Execute(null);
        }
        #endregion Methods
    }
}