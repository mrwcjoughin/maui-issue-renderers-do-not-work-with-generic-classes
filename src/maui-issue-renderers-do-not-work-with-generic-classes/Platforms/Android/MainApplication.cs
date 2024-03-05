using Android.App;
using Android.Runtime;
using maui_issue_renderers_do_not_work_with_generic_classes.Platforms.Android.Renderers;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility.Hosting;
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
			// handlers.AddHandler(typeof(FlyoutPage), typeof(CustomFlyoutPageRenderer));
			handlers.AddCompatibilityRenderer(typeof(CustomContentPage), typeof(CustomContentPageRenderer));
		});
			

		return mauiAppBuilder.Build();
	}
}
