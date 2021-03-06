using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BindingLibrarySample
{
	public partial class BindingLibrarySampleViewController : UIViewController
	{
		BindingLibrarySDK.MBProgressHUD hud;

		public BindingLibrarySampleViewController () : base ("BindingLibrarySampleViewController", null)
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

		partial void showWindow (MonoTouch.Foundation.NSObject sender)
		{
		    hud = BindingLibrarySDK.MBProgressHUD.ShowHUDAddedTo(this.View, true);
			hud.Show(true);
			hud.LabelText = "加载中...";
			hud.Hide(true, 1); // hide hud after 1s 
		}
	}
}

