using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;

namespace WinReader.Lib
{
    public class Reader
    {
        public int Volume { get; set; } = 100;
        public int Rate { get; set; } = 1;

        public SynthesizerState State
        {
            get
            {
                return synthesizer.State;
            }
        }

        private static readonly SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public static Dictionary<string,string> GetAllVoices()
        {
            var dic = new Dictionary<string, string>();
            var voices = synthesizer.GetInstalledVoices();
            foreach(var v in voices)
            {
                var gender = v.VoiceInfo.Gender.ToString().ToLower()=="male"?"男":"女";
                dic.Add(v.VoiceInfo.Name, $"{v.VoiceInfo.Name}({gender})");
            }

          return  dic;
        }

        public static List<VoiceItem> GetAllVoiceItems()
        {
            var list = new List<VoiceItem>();
            var voices = synthesizer.GetInstalledVoices();
            foreach (var v in voices)
            {
                var gender = v.VoiceInfo.Gender.ToString().ToLower() == "male" ? "男" : "女";
                list.Add(new VoiceItem
                {
                    Key = v.VoiceInfo.Name,
                    Value = $"{v.VoiceInfo.Name}({gender})"
                });
            }
            return list;
        }

        public void Speak(string voice,string text,bool isSync = false)
        {
            synthesizer.Volume = Volume;
            synthesizer.Rate = Rate;
            synthesizer.SelectVoice(voice);
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                return;
            }
            if (isSync)
            {
                synthesizer.SpeakAsync(text);

                return;
            }
            
            synthesizer.Speak(text);
        }

        

        public void Pause()
        {
            if (synthesizer.State != SynthesizerState.Paused)
            {
                synthesizer.Pause();
                
            }
        }

        public void Resume()
        {
            if (synthesizer.State == SynthesizerState.Paused)
            {
                synthesizer.Resume();
            }
        }

        public void Stop()
        {
            synthesizer.SpeakAsyncCancelAll();
            
            // 暂停状态时停止朗读后的状态仍然是Paused，
            // 并没有Stoped状态，这会导致再次朗读时会
            // 先Resume再朗读，造成点击“朗读”后没反应，
            // 再点击一次后才重新开始朗读。
            if(synthesizer.State== SynthesizerState.Paused)
            {
                synthesizer.Resume();
            }
        }

        public void Dispose()
        {
            synthesizer.Dispose();
        }

        public bool ExportToWav(string voice,string text,string path)
        {
            Stop();
            synthesizer.Volume = Volume;
            synthesizer.Rate = Rate;
            synthesizer.SelectVoice(voice);
            try
            {
                synthesizer.SetOutputToWaveFile(path);
                synthesizer.Speak(text);
                synthesizer.SetOutputToDefaultAudioDevice();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

        
    }
}
