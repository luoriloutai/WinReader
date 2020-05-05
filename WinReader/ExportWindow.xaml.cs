using Microsoft.Win32;
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
using System.Windows.Shapes;
using WinReader.Lib;

namespace WinReader
{
    /// <summary>
    /// ExportWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ExportWindow : Window
    {
        private string text;
        private Reader reader;
        private string voice;
        public ExportWindow(string voice,string text,Reader reader)
        {
            InitializeComponent();
            this.text = text;
            this.voice = voice;
            this.reader = reader;
            this.reader.AfterExport += Reader_AfterSpeak;
        }

        private void Reader_AfterSpeak()
        {
            Action CloseWindow = () =>
            {
                Close();
            };
            Dispatcher.Invoke(CloseWindow);
        }

        private void Sure_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(path.Text))
            {
                MessageBox.Show("存储位置未选择！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("没有内容，无法导出！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            Task.Run(() =>
            {
                string savePath = "";
                Action VisitUi = () =>
                 {
                     exportTips.Visibility = Visibility.Visible;
                     savePath = path.Text;
                 };
                Dispatcher.Invoke(VisitUi);
                bool r = reader.ExportToWav(voice, text, savePath);
                
            });
            
        }

        private void SelectPath_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "音频文件(*.wav)|*.wav";
            var r = fd.ShowDialog(this);
            if (r.Value)
            {
                path.Text = fd.FileName;
            }
        }
    }
}
