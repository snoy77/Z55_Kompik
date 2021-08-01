using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Z55_V3_WPF
{
    public class Speaker
    {
        SpeechSynthesizer speechSynthesizer { get; set; }

        public Speaker()
        {
            speechSynthesizer = new SpeechSynthesizer();
        }
        public void speakText(string text)
        {
            speechSynthesizer.SpeakAsync(text);
        }
    }
}
