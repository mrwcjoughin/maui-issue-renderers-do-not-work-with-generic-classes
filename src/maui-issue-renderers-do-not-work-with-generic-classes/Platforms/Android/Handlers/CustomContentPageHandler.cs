using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace maui_issue_renderers_do_not_work_with_generic_classes.Platforms.Android.Handlers;

public class CustomContentPageHandler : PageHandler
{
  protected override ContentViewGroup CreatePlatformView()
  {
    System.Console.WriteLine("In " + nameof(CreatePlatformView) + " of " + nameof(CustomContentPageHandler));
    return base.CreatePlatformView();
  }
}
