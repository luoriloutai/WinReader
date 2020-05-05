using System;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using WinReader.Lib;

namespace WinReader
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Reader reader = new Reader();
        private MainBinding binding =new MainBinding();
        private DispatcherTimer timer = new DispatcherTimer();
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = binding;
            timer.Interval = TimeSpan.FromMilliseconds(50);
            //timer.Tick += Timer_Tick;
            //timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(reader.State == SynthesizerState.Ready)
            {
                read.IsEnabled = true;
                pause.IsEnabled = false;
                stop.IsEnabled = false;
                option.IsEnabled = true;
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            reader.Pause();
            reader.Dispose();
            Close();
        }


        private void Read_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            read.IsEnabled = false;
            
            if (txt.Text.Length == 0)
            {
                read.IsEnabled = true;
                MessageBox.Show("没有内容，无法朗读","提示",MessageBoxButton.OK,MessageBoxImage.Information);

                return;
            }
            reader.Rate = binding.Rate;
            reader.Volume = binding.Volume;
            pause.IsEnabled = true;
            stop.IsEnabled = true;
            option.IsEnabled = false;
            txt.Focus();
            if (reader.State == SynthesizerState.Paused)
            {
                reader.Resume();
                return;
            }
            Sentence s = new Sentence();
            var sentenceInfos = s.GetSentenceInfos(txt.Text);
            Task.Run(() =>
            {

                foreach (var info in sentenceInfos)
                {
                    Action changeSelect = () =>
                    {
                        txt.Select(info.StartIndex, info.Length);
                    };
                    Dispatcher.Invoke(changeSelect);
                    string subStr="";
                    string voice = "";
                    Action getArgs = () =>
                    {
                        subStr = txt.Text.Substring(info.StartIndex, info.Length);
                        voice = ((VoiceItem)voiceBox.SelectedItem).Key;
                    };
                    Dispatcher.Invoke(getArgs);

                    // 停止朗读后，这里还在执行，会报异常
                    // 捕捉后不执，跳出，忽略即可
                    try
                    {
                        reader.Speak(voice, subStr);
                    }
                    catch
                    {
                        break;
                    }
                }
                // 恢复状态
                void ResetState()
                {
                    read.IsEnabled = true;
                    pause.IsEnabled = false;
                    option.IsEnabled = true;
                    stop.IsEnabled = false;
                }
                Dispatcher.Invoke(ResetState);
            });

        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            if(reader.State== SynthesizerState.Speaking)
            {
                pause.IsEnabled = false;
                reader.Pause();
                
            }
            read.IsEnabled = true;
            option.IsEnabled = false;
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            reader.Rate = binding.Rate;
            reader.Volume = binding.Volume;
            var win = new ExportWindow(((VoiceItem)voiceBox.SelectedItem).Key, txt.Text, reader);
            win.Owner = this;
            win.ShowDialog();
            
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            reader.Stop();

            // 由于朗读是循环读取，停止后另一个线程还在执行
            // 因此这里设置了状态后，在另一个线程里还得重新
            // 设置，所以这里不需要
            //read.IsEnabled = true;
            //pause.IsEnabled = false;
            //option.IsEnabled = true;
            //stop.IsEnabled=false;
            
        }
    }
}
