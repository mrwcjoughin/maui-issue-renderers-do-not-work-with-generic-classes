using Android.Content;

namespace maui_issue_renderers_do_not_work_with_generic_classes.Platforms.Android.Renderers;

public class CustomContentPageRenderer : Microsoft.Maui.Controls.Compatibility.Platform.Android.PageRenderer
{
  public CustomContentPageRenderer(Context context) : base(context)
  {
  }
}
