using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Naxam.Controls.Platform.Droid;

namespace TechCart.Droid
{
    [Activity(Label = "TechCart.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            BottomTabbedRenderer.BackgroundColor = new Android.Graphics.Color(206, 218, 237);
            BottomTabbedRenderer.FontSize = 15;
            BottomTabbedRenderer.IconSize = 20;
            BottomTabbedRenderer.BottomBarHeight = 50;

            LoadApplication(new App());
        }
    }
}
