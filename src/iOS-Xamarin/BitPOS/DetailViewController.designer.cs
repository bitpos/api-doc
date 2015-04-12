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

namespace BitPOS
{
	[Register ("DetailViewController")]
	partial class DetailViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn2 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn3 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn4 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn5 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn6 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labAmount { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labExchange { get; set; }

		[Action ("btn1_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn1_down (UIButton sender);

		[Action ("btn2_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn2_down (UIButton sender);

		[Action ("btn4_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn4_down (UIButton sender);

		[Action ("btn5_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn5_down (UIButton sender);

		[Action ("btn6_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn6_down (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btn1 != null) {
				btn1.Dispose ();
				btn1 = null;
			}
			if (btn2 != null) {
				btn2.Dispose ();
				btn2 = null;
			}
			if (btn3 != null) {
				btn3.Dispose ();
				btn3 = null;
			}
			if (btn4 != null) {
				btn4.Dispose ();
				btn4 = null;
			}
			if (btn5 != null) {
				btn5.Dispose ();
				btn5 = null;
			}
			if (btn6 != null) {
				btn6.Dispose ();
				btn6 = null;
			}
			if (labAmount != null) {
				labAmount.Dispose ();
				labAmount = null;
			}
			if (labExchange != null) {
				labExchange.Dispose ();
				labExchange = null;
			}
		}
	}
}
