﻿using Foundation;

namespace maui_issue_renderers_do_not_work_with_generic_classes;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiAppBuilder().Build();
}
