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
	[Register ("CharitiesViewController")]
	partial class CharitiesViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView Charities { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Charities != null) {
				Charities.Dispose ();
				Charities = null;
			}
		}
	}
}
