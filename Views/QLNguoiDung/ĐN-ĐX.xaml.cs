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
    /// Interaction logic for ĐN_ĐX.xaml
    /// </summary>
    public partial class ĐN_ĐX : UserControl
    {
        private bool isLoggedIn = false;
        private string currentUser = "";
        public ĐN_ĐX()
        {
            InitializeComponent();
            UpdateUI();
        } 
        private void UpdateUI()
        {
            txtUsername.IsEnabled = !isLoggedIn;
            txtPassword.IsEnabled = !isLoggedIn;
            lblStatus.Text = isLoggedIn ? $"Đã đăng nhập: {currentUser}" : "";
        }
        private void ĐN(object sender, RoutedEventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblStatus.Text = "Vui lòng nhập đủ thông tin!";
                return;
            }

            // Giả lập check đăng nhập, user = admin, pass = 123456
            if (username == "admin" && password == "123456")
            {
                isLoggedIn = true;
                currentUser = username;
                lblStatus.Foreground = System.Windows.Media.Brushes.Green;
                lblStatus.Text = "Đăng nhập thành công!";
                UpdateUI();
            }
            else
            {
                lblStatus.Foreground = System.Windows.Media.Brushes.Red;
                lblStatus.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
            }
        }

        private void ĐX(object sender, RoutedEventArgs e)
        {
            if (!isLoggedIn)
            {
                lblStatus.Text = "Chưa đăng nhập!";
                return;
            }

            isLoggedIn = false;
            currentUser = "";
            lblStatus.Foreground = System.Windows.Media.Brushes.Black;
            lblStatus.Text = "Đã đăng xuất!";
            UpdateUI();
        }
    }
}
