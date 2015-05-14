using System;
using System.Collections.Generic;
using CoreGraphics;
using System.Linq;
using Foundation;
using UIKit;

namespace BitPOS
{
	public partial class PopoverContentViewController : UIViewController
	{
		public String Message { get; set; }

		public PopoverContentViewController (IntPtr handle) : base (handle)
		{
		}

		//loads the PopoverContentViewController.xib file and connects it to this object
		public PopoverContentViewController () : base ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var label = new UILabel (new CGRect (0, 0, 320, 320));
			label.Text = this.Message;
			label.Font = UIFont.BoldSystemFontOfSize (32);
			label.TextAlignment = UITextAlignment.Center;
			label.TextColor = UIColor.Red;

			View.AddSubview (label);
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return true;
		}
	}
}