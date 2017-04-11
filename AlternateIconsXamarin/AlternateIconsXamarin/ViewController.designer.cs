// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace AlternateIconsXamarin
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton darkThemeButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton defaultButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton lightThemeButton { get; set; }

        [Action ("DarkThemeButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DarkThemeButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("DefaultButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DefaultButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("LightThemeButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LightThemeButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (darkThemeButton != null) {
                darkThemeButton.Dispose ();
                darkThemeButton = null;
            }

            if (defaultButton != null) {
                defaultButton.Dispose ();
                defaultButton = null;
            }

            if (lightThemeButton != null) {
                lightThemeButton.Dispose ();
                lightThemeButton = null;
            }
        }
    }
}