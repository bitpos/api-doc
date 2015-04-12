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
		UILabel labAmount { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labExchange { get; set; }

		[Action ("btn1_down:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn1_down (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btn1 != null) {
				btn1.Dispose ();
				btn1 = null;
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
