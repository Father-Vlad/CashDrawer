using Android.App;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using CashDrawer.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using System;
using System.Threading.Tasks;

namespace CashDrawer.Droid.Views
{
    [Activity(Label = "SplashScreenAnimatedView", Theme = "@style/AppThemeNoActionBar")]
    public class SplashScreenAnimatedView : MvxAppCompatActivity<SplashViewModel>
    {
        #region Variables
        private View _view;
        private TransitionDrawable _transition;
        private RelativeLayout _mainLayout;
        #endregion Variables

        #region Lifecycle
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SplashScreenAnimatedLayout);
            OverridePendingTransition(Android.Resource.Animation.FadeIn, Android.Resource.Animation.FadeOut);
            Initialize();
            StartAnimation();
        }
        #endregion Lifecycle

        #region Methods
        private void Initialize()
        {
            _view = FindViewById<View>(Resource.Id.view_splash_screen_animated_object);
            _transition = (TransitionDrawable)_view.Background;
            _transition.StartTransition(1000);
            _mainLayout = FindViewById<RelativeLayout>(Resource.Id.relative_layout_splash_screen_animated_main);
            _view.Animation = AnimationUtils.LoadAnimation(this, Resource.Animation.SplashScreenAnimation);
            _view.Animation.AnimationEnd += TerminateAnimation;
        }

        private void StartAnimation()
        {
            Task.Run(() => { _view.Animate(); });
        }

        private void TerminateAnimation(object sender, EventArgs e)
        {
            _mainLayout.SetBackgroundColor(Android.Graphics.Color.ParseColor("#0000FF"));
            /*
            this.ViewModel.TerminateAnimationCommand.Execute(null);
            */
        }
        #endregion Methods
    }
}