using Android.Views;
using Microsoft.Maui.Handlers;

namespace maui_issue_renderers_do_not_work_with_generic_classes.Platforms.Android.Handlers;

public class CustomNavigationPageHandler : NavigationViewHandler
{
  protected override View CreatePlatformView()
  {
    System.Console.WriteLine("In " + nameof(CreatePlatformView) + " of " + nameof(CustomNavigationPageHandler));
    return base.CreatePlatformView();
  }
}
