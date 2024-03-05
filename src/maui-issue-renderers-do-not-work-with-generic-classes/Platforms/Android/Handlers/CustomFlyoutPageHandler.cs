using Microsoft.Maui.Handlers;
using View = Android.Views.View;

namespace maui_issue_renderers_do_not_work_with_generic_classes.Platforms.Android.Handlers;

public class CustomFlyoutPageHandler : FlyoutViewHandler
{
  protected override View CreatePlatformView()
  {
    System.Console.WriteLine("In " + nameof(CreatePlatformView) + " of " + nameof(CustomFlyoutPageHandler));
    return base.CreatePlatformView();
  }
}
