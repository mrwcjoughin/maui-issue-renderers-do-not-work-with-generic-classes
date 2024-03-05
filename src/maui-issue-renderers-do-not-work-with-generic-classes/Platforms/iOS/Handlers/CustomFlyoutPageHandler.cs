// using System;
// using Microsoft.Maui.Controls.Compatibility.Platform.iOS;
// using Microsoft.Maui.Controls.Handlers.Compatibility;
// using Microsoft.Maui.Handlers;
// using Microsoft.Maui.Platform;
// using UIKit;
//
// namespace maui_issue_renderers_do_not_work_with_generic_classes.Platforms.iOS.Handlers;
//
// public class CustomFlyoutPageHandler : FlyoutViewHandler
// {
//   protected override UIView CreatePlatformView()
//   {
//     System.Console.WriteLine("In " + nameof(CreatePlatformView) + " of " + nameof(CustomFlyoutPageHandler));
//     return new UIView();
//   }
// }
