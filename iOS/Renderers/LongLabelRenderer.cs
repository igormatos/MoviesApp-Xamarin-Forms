using System;
using MovieApp;
using MovieApp.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LongLabel), typeof(LongLabelRenderer))]
namespace MovieApp.iOS
{
	public class LongLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				UILabel label = Control;
				label.Lines = 5;
			}
		}
	}
}