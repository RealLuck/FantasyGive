// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;

namespace FantasyGiveiOS
{
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIPageControl LoginCarousel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (LoginCarousel != null) {
				LoginCarousel.Dispose ();
				LoginCarousel = null;
			}
		}
	}
}
