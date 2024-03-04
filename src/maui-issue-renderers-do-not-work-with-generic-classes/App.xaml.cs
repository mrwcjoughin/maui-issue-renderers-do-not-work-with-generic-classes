using Microsoft.Maui.Controls;

namespace maui_issue_renderers_do_not_work_with_generic_classes;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		MainPage = new AppFlyoutPage();
	}
}
