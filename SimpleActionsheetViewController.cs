using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace SimpleActionsheet
{
	public partial class SimpleActionsheetViewController : UIViewController
	{

		UIActionSheet normal;
		UIActionSheet option;

		public SimpleActionsheetViewController (IntPtr handle) : base (handle)
		{


		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			

			string[] tableitems = new string[] {"Move","Fruits","Duplicate" };
			base.ViewDidLoad ();
			normal = new UIActionSheet ("Simple ActionShete",null, "Cancel", "Delete",null);
			option= new UIActionSheet("ActionSheet With options",null,"Delete it","Copy",tableitems);

			// Perform any additional setup after loading the view, typically from a nib.



		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}




	

		partial void SimpleActionSheet_TouchUpInside (UIButton sender)
		{
			normal.ShowInView(View);
		}
		partial void ComplexActionSheet_TouchUpInside (UIButton sender)
		{
			option.ShowInView(View);
		}
		#endregion
	}
}

