﻿using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.Platform;
using Foundation;
using UIKit;
using MvvmCross.iOS.Views.Presenters;

namespace MvvmWeather2.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxApplicationDelegate
    {
        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Window = new UIWindow(UIScreen.MainScreen.Bounds);
			var presenter = new MvxIosViewPresenter(this, Window);
			var setup = new Setup(this, presenter);
			setup.Initialize();
			var startup = Mvx.Resolve<IMvxAppStart>();
			startup.Start();
			Window.MakeKeyAndVisible();
			return true;
        }
    }
}
