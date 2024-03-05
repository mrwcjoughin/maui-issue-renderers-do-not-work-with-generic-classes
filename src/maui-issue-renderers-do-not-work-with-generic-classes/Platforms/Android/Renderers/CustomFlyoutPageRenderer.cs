using System;
using Android.Content;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace maui_issue_renderers_do_not_work_with_generic_classes.Platforms.Android.Renderers;

[Obsolete("Obsolete")]
public class CustomFlyoutPageRenderer : FlyoutPageRenderer
{
  public CustomFlyoutPageRenderer(Context context) : base(context)
  {
  }
}
