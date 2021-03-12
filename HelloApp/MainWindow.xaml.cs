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

namespace HelloApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // WindowStyle = WindowStyle.None; //Window의 타이틀, 버튼(Minimized, Maximized 등) 제거
            // WindowState = WindowState.Maximized; // 모니터의 해상도 크기로 변경
            // ResizeMode = ResizeMode.NoResize; // Window의 크기를 변경 불가
            // AllowsTransparency = true; // 투명도 설정여부
            // Topmost = true;   // 최상위 열기

        }

        private void HelloButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("반갑습니다");
        }
    }
}
