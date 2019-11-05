# Windows 10 Toast Demo
Demo of how to implement Windows 10 Toasts with WPF and C# (or vice versa!).

Starting point was the sample at  [https://www.whitebyte.info/programming/c/how-to-make-a-notification-from-a-c-desktop-application-in-windows-10](https://www.whitebyte.info/programming/c/how-to-make-a-notification-from-a-c-desktop-application-in-windows-10 ) 

The real magic lies in "Win10ToastService.cs", everything else is mainly MVVM driven.

Features of this implementation:
- MVVM design
- Toast Model is abstracted from Win 10 SDK Toast and can be used on any platform
- made use of IoC
- .NET Core and .NET Standard implementation
- Builder for toasts included