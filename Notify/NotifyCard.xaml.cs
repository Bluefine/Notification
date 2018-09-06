using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notifications.Notify
{
    /// <summary>
    /// Interaction logic for NotifyCard.xaml
    /// </summary>
    public partial class NotifyCard : UserControl
    {
        public NotifyCard()
        {
            InitializeComponent();
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            NotificationWindow.Instance.StackPanelNotifys.Children.Remove(this);
        }

        private async void FrameworkElement_OnLoaded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(5000);
            NotificationWindow.Instance.StackPanelNotifys.Children.Remove(this);
        }
    }
}
