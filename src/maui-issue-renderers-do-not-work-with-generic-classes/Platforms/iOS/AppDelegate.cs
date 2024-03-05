using Foundation;
using maui_issue_renderers_do_not_work_with_generic_classes.Platforms.iOS.Handlers;
// using maui_issue_renderers_do_not_work_with_generic_classes.Platforms.iOS.Renderers;
using Microsoft.Maui;
// using Microsoft.Maui.Controls.Compatibility.Hosting;
using Microsoft.Maui.Hosting;

namespace maui_issue_renderers_do_not_work_with_generic_classes;
[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp()
	
	{
		var mauiAppBuilder = MauiProgram.CreateMauiAppBuilder();
		mauiAppBuilder.ConfigureMauiHandlers(handlers =>
		{
			// handlers.AddHandler(typeof(FlyoutPage), typeof(CustomFlyoutPageRenderer));
			// handlers.AddHandler(typeof(CustomFlyoutPage), typeof(CustomFlyoutPageHandler));
			// handlers.AddCompatibilityRenderer(typeof(CustomContentPage), typeof(CustomContentPageRenderer));
			handlers.AddHandler(typeof(CustomContentPage), typeof(CustomContentPageHandler));
		});

		return mauiAppBuilder.Build();
	}
}
