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

namespace QuanLyBanHang.Views.QLNguoiDung
{
    /// <summary>
    /// Interaction logic for QMK.xaml
    /// </summary>
    public partial class QMK : UserControl
    {
        public QMK()
        {
            InitializeComponent();
        }
        private void Gui(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // TODO: Gửi yêu cầu đặt lại mật khẩu (kết nối backend ở đây nếu có)
            MessageBox.Show($"Yêu cầu đặt lại mật khẩu đã được gửi đến: {email}", "Thành công", MessageBoxButton.OK, MessageBoxImage.Information);

            EmailTextBox.Clear();
        }
    }
}
 