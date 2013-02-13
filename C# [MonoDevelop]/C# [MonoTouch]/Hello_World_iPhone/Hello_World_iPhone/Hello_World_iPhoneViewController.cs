using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Hello_World_iPhone
{
	public partial class Hello_World_iPhoneViewController : UIViewController
	{
		protected int _numberOfTimesClicked = 0;

		public Hello_World_iPhoneViewController () : base ("Hello_World_iPhoneViewController", null)
		{
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
			
			// Perform any additional setup after loading the view, typically from a nib.
			this.btnClickMe.TouchUpInside += (sender, e) => {
				this._numberOfTimesClicked++;
				this.lblOutput.Text = "Clicked [" +
					this._numberOfTimesClicked.ToString() + "] times!";
			};
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		/// <summary>
		/// This is our common action handler. Two buttons call this via an action method.
		/// </summary>
		partial void actnButtonClick (MonoTouch.Foundation.NSObject sender)
		{
			this.lblOutput.Text = "Action button " +  ((UIButton)sender).CurrentTitle + " clicked.";
		}
	}
}

