﻿using System;
using System.ComponentModel;
using TechCart;
using TechCart.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(HorizontalScrollView), typeof(HorizontalScrollViewRenderer))]
namespace TechCart.Droid
{
	public class HorizontalScrollViewRenderer : ScrollViewRenderer
	{
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			var element = e.NewElement as HorizontalScrollView;
			element?.Render();

			if (e.OldElement != null || this.Element == null)
				return;

			if (e.OldElement != null)
				e.OldElement.PropertyChanged -= OnElementPropertyChanged;

			e.NewElement.PropertyChanged += OnElementPropertyChanged;
		}

		protected void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (ChildCount > 0)
			{
				GetChildAt(0).HorizontalScrollBarEnabled = false;
				GetChildAt(0).VerticalScrollBarEnabled = false;
			}
		}
	}
}
