﻿using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using CoreGraphics;
using Foundation;
using UIKit;
using System.Security.Cryptography.X509Certificates;

using System.Net;
using System.Net.Security;

using Newtonsoft.Json;

namespace BitPOS
{
	public partial class DetailViewController : UIViewController
	{
		private Decimal amount = 0;
		UIPopoverController masterPopoverController;
		object detailItem;
		private Providers.IExchangeProvider exchangeProvider;

		private const Int64 SATOSHI = 100000000;

		public DetailViewController (IntPtr handle) : base (handle)
		{
			exchangeProvider = new Providers.Mock ();
		}

		private void Refresh()
		{
			labAmount.Text = String.Format("${0:0.00}", amount);
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

		partial void btn3_down (UIButton sender)
		{
			amount *= 10;
			amount += 3;
			Refresh();
		}

		partial void btn4_down (UIButton sender)
		{
			amount *= 10;
			amount += 4;
			Refresh();
		}

		partial void btn5_down (UIButton sender)
		{
			amount *= 10;
			amount += 5;
			Refresh();
		}

		partial void btn6_down (UIButton sender)
		{
			amount *= 10;
			amount += 6;
			Refresh();
		}

		partial void btn7_down (UIButton sender)
		{
			amount *= 10;
			amount += 7;
			Refresh();
		}

		partial void btn8_down (UIButton sender)
		{
			amount *= 10;
			amount += 8;
			Refresh();
		}

		partial void btn9_down (UIButton sender)
		{
			amount *= 10;
			amount += 9;
			Refresh();
		}

		partial void btn0_down (UIButton sender)
		{
			ShowPopover(btn0);
			amount *= 10;
			Refresh();
		}

		partial void btnPay_down (UIButton sender)
		{
			Boolean isTestNet = true;

			//const String KEY = "api_key_from_admin_portal";
			//const String PASSWORD = "password_used_when_api_key_was_created";

			String authorization = String.Format("{0}:{1}", Settings.Key, Settings.Password);
			String base64credentials = Convert.ToBase64String(new ASCIIEncoding().GetBytes(authorization));

			//Note fields mandatory otherwise 500 error
			Int32 amountInCents = Convert.ToInt32(amount * 100);
			Models.BitPOS.OrderRequest request = new Models.BitPOS.OrderRequest() { amount = amountInCents, currency = "AUD", reference = "BitcoinBrisbane", description = "Test Ticket", failureURL="https://www.bitcoinbrisbane.com.au/fail/1", successURL="https://www.bitcoinbrisbane.com.au/greatsuccess/1" };
			String json = JsonConvert.SerializeObject(request);

			WebClient webClient = new WebClient() { Credentials = new NetworkCredential(Settings.Key, Settings.Password) };
			webClient.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", base64credentials);
			webClient.Headers[HttpRequestHeader.ContentType] = "application/json";

			if (isTestNet == true)
			{
				//Use this for test because of SSL issues
				//System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
			}

			String response = webClient.UploadString("https://rest.bitpos.me/services/webpay/order/create", json);

			Models.BitPOS.OrderResponse orderResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.BitPOS.OrderResponse>(response);

//			LoadingOverlay loadingOverlay = new LoadingOverlay();
//
//			// Determine the correct size to start the overlay (depending on device orientation)
//			var bounds = UIScreen.MainScreen.Bounds; // portrait bounds
//			if (UIApplication.SharedApplication.StatusBarOrientation == UIInterfaceOrientation.LandscapeLeft || UIApplication.SharedApplication.StatusBarOrientation == UIInterfaceOrientation.LandscapeRight) {
//				bounds.Size = new CGSize(bounds.Size.Height, bounds.Size.Width);
//			}
//			// show the loading overlay on the UI thread using the correct orientation sizing
//			loadingOverlay = new LoadingOverlay (bounds);
//			this.View.Add ( loadingOverlay.loadPop );

			UIAlertView alert = new UIAlertView ("Send BTC", String.Format("Send {0:0.0000} to {1}", Decimal.Divide(orderResponse.satoshis, SATOSHI), orderResponse.bitcoinAddress) , null, "Ok", null);
			alert.Show ();

			//ShowPopover(btn0, orderResponse.bitcoinAddress, String.Format("bitcoin:{0}", orderResponse.bitcoinAddress));
		}

//		[Action ("showPopover:")]
//		public void ShowPopover (NSObject sender, String message, String paymentUrl) {
//			// Set the sender to a UIButton.
//			UIButton tappedButton = (UIButton)sender;
//
//			//DetailViewPopover.
//
//			// Present the popover from the button that was tapped in the detail view.
//			DetailViewPopover.PresentFromRect (tappedButton.Frame, View, UIPopoverArrowDirection.Any, true);
//
//			//todo
//			// Set the last button tapped to the current button that was tapped.
//			//LastTappedButton = sender;
//		}

		[Action ("showPopover:")]
		public void ShowPopover (NSObject sender) {
			// Set the sender to a UIButton.
			UIButton tappedButton = (UIButton)sender;

			// Present the popover from the button that was tapped in the detail view.
			DetailViewPopover.PresentFromRect (tappedButton.Frame, View, UIPopoverArrowDirection.Any, true);

			//todo
			// Set the last button tapped to the current button that was tapped.
			//LastTappedButton = sender;
		}

//		private async void ShowDetails()
//		{
//			var modalPage = new DetailsPage ();
//			//await Navigation.PushModalAsync (modalPage);
//			//Debug.WriteLine ("The modal page is now on screen");
//			//var poppedPage = await Navigation.PopModalAsync ();
//		}
			
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
			try
			{
				base.ViewDidLoad ();

				labExchange.Text = String.Format("Exchange rate ${0:0.000}", exchangeProvider.GetRate (1, "AUD"));

				// Any additional setup after loading the view, typically from a nib.
				ConfigureView ();


				var content = new PopoverContentViewController ();
				DetailViewPopover = new UIPopoverController (content);
				DetailViewPopover.PopoverContentSize = new CGSize (320, 320);
				DetailViewPopover.DidDismiss += delegate { LastTappedButton = null; };
			}
			catch (Exception ex) {
			}
		}

		[Export ("splitViewController:willHideViewController:withBarButtonItem:forPopoverController:")]
		public void WillHideViewController (UISplitViewController splitController, UIViewController viewController, UIBarButtonItem barButtonItem, UIPopoverController popoverController)
		{
			barButtonItem.Title = NSBundle.MainBundle.LocalizedString ("Orders", "Orders");
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