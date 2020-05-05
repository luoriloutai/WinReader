using System.Collections.Generic;

namespace WinReader.Lib
{
    public class Sentence
    {
        public Sentence()
        {
        }
        private List<char> symbols = new List<char>
        {
            ',','，','。',';','；','?','？','!','！','\n'
        };

        public List<SentenceInfo> GetSentenceInfos(string text)
        {
            List<SentenceInfo> infos = new List<SentenceInfo>();
            if (string.IsNullOrEmpty(text))
            {
                return infos;
            }
            int i = 0;
            int pre = 0;
            while (i < text.Length)
            {
                if (symbols.Contains(text[i]))
                {
                    if (pre > text.Length - 1)
                    {
                        pre = text.Length - 1;
                    }
                    infos.Add(new SentenceInfo
                    {
                        Length = i - pre,
                        StartIndex = pre
                    });
                    pre = i + 1;

                }
                i++;
            }
            // 处理最后一个字符不是标点符号的情况
            if (pre < text.Length - 1)
            {
                infos.Add(new SentenceInfo
                {
                    Length = text.Length - pre,
                    StartIndex = pre
                });
            }
            return infos;
        }
    }
}
