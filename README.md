[![NuGet Version](https://img.shields.io/nuget/v/Drastic.IQKeyboardManager.svg)](https://www.nuget.org/packages/Drastic.IQKeyboardManager/) ![License](https://img.shields.io/badge/License-MIT-blue.svg)

# Drastic.IQKeyboardManager

<img width="382" alt="スクリーンショット 2023-02-22 17 06 55" src="https://user-images.githubusercontent.com/898335/220560733-eaf1cefb-d911-4ad9-89b2-9454101ff1f4.png">

This is a binding of IQKeyboardManager (https://github.com/hackiftekhar/IQKeyboardManager/) for .NET for iOS. It can be used within your iOS and MAUI iOS apps to allow for automatically allow navigating between UITextField/UITextViews.

## HOWTO

Setup the initial manager:

```csharp
using Drastic.IQKeyboardManager;
...
        IQKeyboardManager.SharedManager().Enable = true;
        IQKeyboardManager.SharedManager().ShouldResignOnTouchOutside = true;
        IQKeyboardManager.SharedManager().ToolbarManageBehaviour = IQAutoToolbarManageBehaviour.Position;
        IQKeyboardManager.SharedManager().EnableAutoToolbar = true;
        IQKeyboardManager.SharedManager().ShouldShowToolbarPlaceholder = true;
```