// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SimpleActionsheet
{
	[Register ("SimpleActionsheetViewController")]
	partial class SimpleActionsheetViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ComplexActionSheet { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SimpleActionSheet { get; set; }

		[Action ("ComplexActionSheet_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ComplexActionSheet_TouchUpInside (UIButton sender);

		[Action ("SimpleActionSheet_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void SimpleActionSheet_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (ComplexActionSheet != null) {
				ComplexActionSheet.Dispose ();
				ComplexActionSheet = null;
			}
			if (SimpleActionSheet != null) {
				SimpleActionSheet.Dispose ();
				SimpleActionSheet = null;
			}
		}
	}
}
