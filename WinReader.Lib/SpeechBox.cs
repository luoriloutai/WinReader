using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace WinReader.Lib
{
    class SpeechBox
    {
        private SpeechSynthesizer synthersizer=new SpeechSynthesizer();

        /// <summary>
        /// 获取所有语音
        /// </summary>
        /// <returns></returns>
        public string[] GetAllVoices()
        {
            var voices = synthersizer.GetInstalledVoices().Select(i=>i.VoiceInfo.Name).ToArray();
            
            return voices;
        }
    }
}
