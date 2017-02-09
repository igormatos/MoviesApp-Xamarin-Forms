using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace MovieApp.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			// Pra deixar o texto da status bar claro
			UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);

			return base.FinishedLaunching(app, options);
		}
	}
}
