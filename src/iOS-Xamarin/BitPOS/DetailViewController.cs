using System;
using System.Drawing;
using System.Collections.Generic;

using Foundation;
using UIKit;

namespace BitPOS
{
	public partial class DetailViewController : UIViewController
	{
		private Decimal amount = 0;
		UIPopoverController masterPopoverController;
		object detailItem;
		private Providers.IExchangeProvider exchangeProvider;

		public DetailViewController (IntPtr handle) : base (handle)
		{
			exchangeProvider = new Providers.Mock ();
		}

		private void Refresh()
		{
			labAmount.Text = String.Format("${0:00}", amount);
		}

		partial void btn1_down (UIButton sender)
		{
			amount *= 10;
			amount += 1;
			Refresh();
		}

		partial void btn2_down (UIButton sender)
		{
			amount *= 10;
			amount += 2;
			Refresh();
		}

		partial void btn4_down (UIButton sender)
		{
			amount *= 10;
			amount += 4;
			Refresh();
		}
			
		public void SetDetailItem (object newDetailItem)
		{
			if (detailItem != newDetailItem) {
				detailItem = newDetailItem;
				
				// Update the view
				ConfigureView ();
			}
			
			if (masterPopoverController != null)
				masterPopoverController.Dismiss (true);
		}

		void ConfigureView ()
		{
			// Update the user interface for the detail item
			//if (IsViewLoaded && detailItem != null)
				//detailDescriptionLabel.Text = detailItem.ToString ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			labExchange.Text = String.Format("${0:0.000}", exchangeProvider.GetRate (1, "AUD"));

			// Any additional setup after loading the view, typically from a nib.
			ConfigureView ();
		}

		[Export ("splitViewController:willHideViewController:withBarButtonItem:forPopoverController:")]
		public void WillHideViewController (UISplitViewController splitController, UIViewController viewController, UIBarButtonItem barButtonItem, UIPopoverController popoverController)
		{
			barButtonItem.Title = NSBundle.MainBundle.LocalizedString ("Master", "Master");
			NavigationItem.SetLeftBarButtonItem (barButtonItem, true);
			masterPopoverController = popoverController;
		}

		[Export ("splitViewController:willShowViewController:invalidatingBarButtonItem:")]
		public void WillShowViewController (UISplitViewController svc, UIViewController vc, UIBarButtonItem button)
		{
			// Called when the view is shown again in the split view, invalidating the button and popover controller.
			NavigationItem.SetLeftBarButtonItem (null, true);
			masterPopoverController = null;
		}
	}
}