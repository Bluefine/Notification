# Notification

Material design notify system for WPF applications

## Getting Started

- Build Notification project for the .dll
- Add Notification.dll reference in your application
- Copy MaterialDesignColor.dll and MaterialDesignThemes.Wpf.dll to your app folder

- Add namespace
```
using Notifications;
```

- Create main object
```
private readonly Main _notify = new Main();
```

- In your init method add
```
public MainWindow()
{
    InitializeComponent();
    _notify.PrepareWindow();
}
```

- Finally you can call the function
```
_notify.ShowNotify(Main.NotifyType.Error, "Title", "Description");
```
