using QuanLyBanHang.Views.QLNguoiDung;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyBanHang
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Sự kiện mở/đóng menu con cho từng nhóm chức năng  
        private void ToggleUserMenu_Click(object sender, RoutedEventArgs e)
        {
            UserSubMenu.Visibility = UserSubMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void ToggleProductMenu_Click(object sender, RoutedEventArgs e)
        {
            ProductSubMenu.Visibility = ProductSubMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void ToggleCartMenu_Click(object sender, RoutedEventArgs e)
        {
            CartSubMenu.Visibility = CartSubMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void ToggleOrderMenu_Click(object sender, RoutedEventArgs e)
        {
            OrderSubMenu.Visibility = OrderSubMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void ToggleInventoryMenu_Click(object sender, RoutedEventArgs e)
        {
            InventorySubMenu.Visibility = InventorySubMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void ToggleReportMenu_Click(object sender, RoutedEventArgs e)
        {
            ReportSubMenu.Visibility = ReportSubMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void ToggleSupportMenu_Click(object sender, RoutedEventArgs e)
        {
            SupportSubMenu.Visibility = SupportSubMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void TogglePromotionMenu_Click(object sender, RoutedEventArgs e)
        {
            PromotionSubMenu.Visibility = PromotionSubMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void ToggleSettingsMenu_Click(object sender, RoutedEventArgs e)
        {
            SettingsSubMenu.Visibility = SettingsSubMenu.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }

        private void ĐKTK(object sender, RoutedEventArgs e)
        {
            MainContentArea.Children.Clear(); // Clear existing children  
            MainContentArea.Children.Add(new ĐK_TK()); // Add the new UserControl  
        }

        private void QMK(object sender, RoutedEventArgs e)
        {
            MainContentArea.Children.Clear(); // Clear existing children  
            MainContentArea.Children.Add(new QMK()); // Add the new UserControl  

        }
        private void ĐNĐX(object sender, RoutedEventArgs e)
        {
            MainContentArea.Children.Clear(); // Clear existing children  
            MainContentArea.Children.Add(new ĐN_ĐX()); // Add the new UserControl  
        }
    }
}