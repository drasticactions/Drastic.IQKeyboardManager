using Drastic.IQKeyboardManager;

namespace MauiSample;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

        IQKeyboardManager.SharedManager().Enable = true;
        IQKeyboardManager.SharedManager().ShouldResignOnTouchOutside = true;
        IQKeyboardManager.SharedManager().ToolbarManageBehaviour = IQAutoToolbarManageBehaviour.Position;
        IQKeyboardManager.SharedManager().EnableAutoToolbar = true;
        IQKeyboardManager.SharedManager().ShouldShowToolbarPlaceholder = true;
    }
}
