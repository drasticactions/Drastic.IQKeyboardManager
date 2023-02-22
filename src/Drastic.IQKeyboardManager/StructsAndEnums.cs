using ObjCRuntime;

namespace Drastic.IQKeyboardManager
{
    [Native]
    public enum IQAutoToolbarManageBehaviour : long
    {
        Subviews,
        Tag,
        Position
    }

    [Native]
    public enum IQPreviousNextDisplayMode : long
    {
        Default,
        AlwaysHide,
        AlwaysShow
    }

    [Native]
    public enum IQEnableMode : long
    {
        Default,
        Enabled,
        Disabled
    }
}
