// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MvvmWeather2.iOS.Views
{
    [Register ("WeatherDetailsView")]
    partial class WeatherDetailsView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CityNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CloudnessLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DateLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel geoCoordsLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HumidityLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LatitudeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LongitudeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PressureLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel skyLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SunriseLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SunsetLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Temperature { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView WeatherIcon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel WindLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CityNameLabel != null) {
                CityNameLabel.Dispose ();
                CityNameLabel = null;
            }

            if (CloudnessLabel != null) {
                CloudnessLabel.Dispose ();
                CloudnessLabel = null;
            }

            if (DateLabel != null) {
                DateLabel.Dispose ();
                DateLabel = null;
            }

            if (geoCoordsLabel != null) {
                geoCoordsLabel.Dispose ();
                geoCoordsLabel = null;
            }

            if (HumidityLabel != null) {
                HumidityLabel.Dispose ();
                HumidityLabel = null;
            }

            if (LatitudeLabel != null) {
                LatitudeLabel.Dispose ();
                LatitudeLabel = null;
            }

            if (LongitudeLabel != null) {
                LongitudeLabel.Dispose ();
                LongitudeLabel = null;
            }

            if (PressureLabel != null) {
                PressureLabel.Dispose ();
                PressureLabel = null;
            }

            if (skyLabel != null) {
                skyLabel.Dispose ();
                skyLabel = null;
            }

            if (SunriseLabel != null) {
                SunriseLabel.Dispose ();
                SunriseLabel = null;
            }

            if (SunsetLabel != null) {
                SunsetLabel.Dispose ();
                SunsetLabel = null;
            }

            if (Temperature != null) {
                Temperature.Dispose ();
                Temperature = null;
            }

            if (WeatherIcon != null) {
                WeatherIcon.Dispose ();
                WeatherIcon = null;
            }

            if (WindLabel != null) {
                WindLabel.Dispose ();
                WindLabel = null;
            }
        }
    }
}