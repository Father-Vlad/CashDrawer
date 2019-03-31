using Android.App;
using Android.Graphics;
using Android.Widget;

namespace CashDrawer.Droid.Helper
{
    public static class Typefaces
    {
        private static Android.Content.Res.AssetManager assets = Application.Context.Assets;

        public static void SetBold(TextView view, string fontName)
        {
            if (view != null)
            {
                view.SetTypeface(Typeface.CreateFromAsset(assets, fontName), TypefaceStyle.Bold);
            }
        }

        public static void SetBoldItalic(TextView view, string fontName)
        {
            if (view != null)
            {
                view.SetTypeface(Typeface.CreateFromAsset(assets, fontName), TypefaceStyle.BoldItalic);
            }
        }

        public static void SetItalic(TextView view, string fontName)
        {
            if (view != null)
            {
                view.SetTypeface(Typeface.CreateFromAsset(assets, fontName), TypefaceStyle.Italic);
            }
        }

        public static void SetNormal(TextView view, string fontName)
        {
            if (view != null)
            {
                view.SetTypeface(Typeface.CreateFromAsset(assets, fontName), TypefaceStyle.Normal);
            }
        }

        public static void SetBold(EditText view, string fontName)
        {
            if (view != null)
            {
                view.SetTypeface(Typeface.CreateFromAsset(assets, fontName), TypefaceStyle.Bold);
            }
        }

        public static void SetBoldItalic(EditText view, string fontName)
        {
            if (view != null)
            {
                view.SetTypeface(Typeface.CreateFromAsset(assets, fontName), TypefaceStyle.BoldItalic);
            }
        }

        public static void SetItalic(EditText view, string fontName)
        {
            if (view != null)
            {
                view.SetTypeface(Typeface.CreateFromAsset(assets, fontName), TypefaceStyle.Italic);
            }
        }

        public static void SetNormal(EditText view, string fontName)
        {
            if (view != null)
            {
                view.SetTypeface(Typeface.CreateFromAsset(assets, fontName), TypefaceStyle.Normal);
            }
        }

        public static void SetBold(Button view, string fontName)
        {
            if (view != null)
            {
                view.SetTypeface(Typeface.CreateFromAsset(assets, fontName), TypefaceStyle.Bold);
            }
        }

        public static void SetBoldItalic(Button view, string fontName)
        {
            if (view != null)
            {
                view.SetTypeface(Typeface.CreateFromAsset(assets, fontName), TypefaceStyle.BoldItalic);
            }
        }

        public static void SetItalic(Button view, string fontName)
        {
            if (view != null)
            {
                view.SetTypeface(Typeface.CreateFromAsset(assets, fontName), TypefaceStyle.Italic);
            }
        }

        public static void SetNormal(Button view, string fontName)
        {
            if (view != null)
            {
                view.SetTypeface(Typeface.CreateFromAsset(assets, fontName), TypefaceStyle.Normal);
            }
        }
    }
}