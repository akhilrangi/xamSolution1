using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace And1
{
    [Activity(Label = "And1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button buttonPrev;
        Button buttonNext;
        TextView textTitle;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            buttonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            buttonNext = FindViewById<Button>(Resource.Id.buttonNext);

        }
    }
}

