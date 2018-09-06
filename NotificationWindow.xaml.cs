using System.Windows;

namespace Notifications
{
    public partial class NotificationWindow
    {
        public static NotificationWindow Instance;

        public NotificationWindow()
        {
            InitializeComponent();
            Instance = this;
            var desktopWorkingArea = SystemParameters.WorkArea;
            Left = desktopWorkingArea.Right - Width;
            Top = desktopWorkingArea.Bottom - Height;
        }
    }
}