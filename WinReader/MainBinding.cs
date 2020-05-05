using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WinReader.Lib;

namespace WinReader
{
    class MainBinding:DependencyObject
    {
        public List<VoiceItem> Voices
        {
            get { return (List<VoiceItem>)GetValue(VoicesProperty); }
            set { SetValue(VoicesProperty, value); }
        }

        public static readonly DependencyProperty VoicesProperty =
            DependencyProperty.Register("Voices", typeof(List<VoiceItem>), typeof(MainBinding), new PropertyMetadata(Reader.GetAllVoiceItems()));



        public int Rate
        {
            get { return (int)GetValue(RateProperty); }
            set { SetValue(RateProperty, value); }
        }

        public static readonly DependencyProperty RateProperty =
            DependencyProperty.Register("Rate", typeof(int), typeof(MainBinding), new PropertyMetadata(1));



        public int Volume
        {
            get { return (int)GetValue(VolumeProperty); }
            set { SetValue(VolumeProperty, value); }
        }

        public static readonly DependencyProperty VolumeProperty =
            DependencyProperty.Register("Volume", typeof(int), typeof(MainBinding), new PropertyMetadata(100));



       


    }
}
