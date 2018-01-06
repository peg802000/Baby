// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace BabyApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtLeft { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtPauCon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtRight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtStop { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LbTimer { get; set; }

        [Action ("BtLeft_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtLeft_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtPauCon_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtPauCon_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtRight_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtRight_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtStop_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtStop_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BtLeft != null) {
                BtLeft.Dispose ();
                BtLeft = null;
            }

            if (BtPauCon != null) {
                BtPauCon.Dispose ();
                BtPauCon = null;
            }

            if (BtRight != null) {
                BtRight.Dispose ();
                BtRight = null;
            }

            if (BtStop != null) {
                BtStop.Dispose ();
                BtStop = null;
            }

            if (LbTimer != null) {
                LbTimer.Dispose ();
                LbTimer = null;
            }
        }
    }
}