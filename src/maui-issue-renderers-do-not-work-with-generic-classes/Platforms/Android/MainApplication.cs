using System;
using Android.App;
using Android.Runtime;
using maui_issue_renderers_do_not_work_with_generic_classes.Platforms.Android.Handlers;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace maui_issue_renderers_do_not_work_with_generic_classes;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp()
	{
		var mauiAppBuilder = MauiProgram.CreateMauiAppBuilder();
		mauiAppBuilder.ConfigureMauiHandlers(handlers =>
		{
			// handlers.AddCompatibilityRenderer(typeof(CustomContentPage), typeof(CustomContentPageRenderer));
			// handlers.AddCompatibilityRenderer(typeof(CustomFlyoutPage), typeof(CustomFlyoutPageRenderer));
			handlers.AddHandler(typeof(CustomContentPage), typeof(CustomContentPageHandler));
			handlers.AddHandler(typeof(CustomNavigationPage), typeof(CustomNavigationPageHandler));
			handlers.AddHandler(typeof(CustomFlyoutPage), typeof(CustomFlyoutPageHandler));
		});
			

		return mauiAppBuilder.Build();
	}
}
