using System;
using MovieApp; 
using MyProject.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LongLabel), typeof(LongLabelRenderer))]
namespace MyProject.Android
{
	public class LongLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);

			if (e.NewElement != null)
			{
				// Subscribe to the events
			}
			else if (e.OldElement != null)
			{
				// Unsubscribe
			}

			if (Control != null) {
				Control.SetMaxLines(5);
			}

		}
	}
}