using System;
using System.Collections.Generic;
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
using System.Diagnostics;

namespace 极刺客GUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void runScript(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("StudentMain");//进程名称不要加上.exe
                Process.Start(@".\lib\ntsd.exe", "-y -y -p " + processes[0].Id);
                stadu.Text = "成功杀死进程";
            }
            catch
            {
                stadu.Text = "捕获进程失败";
                MessageBox.Show("未能找到进程，似乎已经杀死该程序");
            }
        }
        

        
    }
}
