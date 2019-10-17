﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CustomKeyboardDemo.Droid
{
    [Activity(Label = "CustomKeyboardDemo", Icon = "@drawable/icon", Theme = "@style/MainTheme", WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.AdjustResize,  MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            this.Window.SetSoftInputMode(SoftInput.AdjustPan | SoftInput.AdjustResize);
        }
    }
}

