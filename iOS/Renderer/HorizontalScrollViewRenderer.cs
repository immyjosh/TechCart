using System;
using TechCart;
using TechCart.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(HorizontalScrollView), typeof(HorizontalScrollViewRenderer))]
namespace TechCart.iOS
{
	public class HorizontalScrollViewRenderer : ScrollViewRenderer
	{
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			var element = e.NewElement as HorizontalScrollView;
			element?.Render();

			// Don't need these.
			ShowsHorizontalScrollIndicator = false;
		} 
	}
}
