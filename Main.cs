using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;
using Notifications.Notify;

namespace Notifications
{
    public class Main
    {
        private readonly NotificationWindow _window = new NotificationWindow();

        public void PrepareWindow()
        {
            _window.Show();
        }

        public void ShowNotify(NotifyType type, string title, string description)
        {
            var card = new NotifyCard
            {
                TextBlockTitle = {Text = title},
                TextBlockDesc = {Text = description}
            };
            switch (type)
            {
                case NotifyType.Error:
                {
                    card.PackIconNotifyIcon.Kind = PackIconKind.CloseCircle;
                    card.CardNotify.Background = new SolidColorBrush(Colors.Red);
                    break;
                }
                case NotifyType.Success:
                {
                    card.PackIconNotifyIcon.Kind = PackIconKind.CheckCircle;
                    card.CardNotify.Background = new SolidColorBrush(Colors.MediumSeaGreen);
                    break;
                }
                case NotifyType.Info:
                {
                    card.PackIconNotifyIcon.Kind = PackIconKind.Information;
                    card.CardNotify.Background = new SolidColorBrush(Colors.DodgerBlue);
                    break;
                }
                case NotifyType.Warning:
                {
                    card.PackIconNotifyIcon.Kind = PackIconKind.AlertCircle;
                    card.CardNotify.Background = new SolidColorBrush(Colors.Goldenrod);
                    break;
                }
            }
           
            NotificationWindow.Instance.StackPanelNotifys.Children.Add(card);
        }

        public void KillWindow()
        {
            _window.Close();
        }

        public enum NotifyType
        {
            Error,
            Success,
            Info,
            Warning,
        }
    }
}
