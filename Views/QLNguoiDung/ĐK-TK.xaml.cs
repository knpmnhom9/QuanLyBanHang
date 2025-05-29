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
    /// Interaction logic for ĐK_TK.xaml
    /// </summary>
    public partial class ĐK_TK : UserControl
    {
        public ĐK_TK()
        {
            InitializeComponent();
        }
        private void ĐK(object sender, RoutedEventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Password;
            var confirmPassword = txtConfirmPassword.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblStatus.Text = "Vui lòng nhập đủ thông tin!";
                return;
            }

            if (password != confirmPassword)
            {
                lblStatus.Text = "Mật khẩu không khớp!";
                return;
            }

            // Giả sử đăng ký thành công (ở đây chưa có backend)
            lblStatus.Foreground = System.Windows.Media.Brushes.Green;
            lblStatus.Text = "Đăng ký thành công!";
        }
    }
}
