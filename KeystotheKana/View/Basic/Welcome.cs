﻿using System;

using Xamarin.Forms;

namespace KeystotheKana
{
	public class Guide : ContentPage
	{
		public Guide ()
		{
			this.Title = "Guide to This Course";

			var browser = new BaseUrlWebView (); // temporarily use this so we can custom-render in iOS

			var htmlSource = new HtmlWebViewSource ();
			htmlSource.BaseUrl = DependencyService.Get<IBaseUrl> ().Get ();
			if (Device.OS != TargetPlatform.iOS) {
				browser.Source = htmlSource.BaseUrl+"Guide.html";
			}
			else
			{	      
				browser.Source = htmlSource.BaseUrl+"/Guide.html";
			}
			Content = browser;
		}
	}
}

