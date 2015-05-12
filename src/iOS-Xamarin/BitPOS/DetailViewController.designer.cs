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
		UIButton btn0 { get; set; }

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
		UIButton btn7 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn8 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn9 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnDecimal { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnPay { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnTest { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labAmount { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labExchange { get; set; }

		[Action ("btn0_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn0_down (UIButton sender);

		[Action ("btn1_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn1_down (UIButton sender);

		[Action ("btn2_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn2_down (UIButton sender);

		[Action ("btn3_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn3_down (UIButton sender);

		[Action ("btn4_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn4_down (UIButton sender);

		[Action ("btn5_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn5_down (UIButton sender);

		[Action ("btn6_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn6_down (UIButton sender);

		[Action ("btn7_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn7_down (UIButton sender);

		[Action ("btn8_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn8_down (UIButton sender);

		[Action ("btn9_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn9_down (UIButton sender);

		[Action ("btnPay_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnPay_down (UIButton sender);

		[Outlet]
		public UIPopoverController DetailViewPopover { get; set; }

		[Outlet]
		public NSObject LastTappedButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn0 != null) {
				btn0.Dispose ();
				btn0 = null;
			}
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
			if (btn7 != null) {
				btn7.Dispose ();
				btn7 = null;
			}
			if (btn8 != null) {
				btn8.Dispose ();
				btn8 = null;
			}
			if (btn9 != null) {
				btn9.Dispose ();
				btn9 = null;
			}
			if (btnDecimal != null) {
				btnDecimal.Dispose ();
				btnDecimal = null;
			}
			if (btnPay != null) {
				btnPay.Dispose ();
				btnPay = null;
			}
			if (btnTest != null) {
				btnTest.Dispose ();
				btnTest = null;
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
