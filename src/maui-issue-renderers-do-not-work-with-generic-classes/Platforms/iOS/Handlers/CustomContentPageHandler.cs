using Microsoft.Maui.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using ContentView = Microsoft.Maui.Platform.ContentView;

namespace maui_issue_renderers_do_not_work_with_generic_classes.Platforms.iOS.Handlers;

public class CustomContentPageHandler : PageHandler
{
  protected override ContentView CreatePlatformView()
  {
    System.Console.WriteLine("In " + nameof(CreatePlatformView) + " of " + nameof(CustomContentPageHandler));
    return base.CreatePlatformView();
  }
}
