using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Z55_V3_WPF
{
    //Мдуль инструмент воспроизводит речь компьютером.
    public static class Speaker
    {
        public static SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

        public static void speakText(string text)
        {
            speechSynthesizer.SpeakAsync(text);
        }
    }

    //Переделал модули-инструменты в статичные классы, чтобы их можно было использовать во всех командных модулях 
    //без объявления копий объектов
}
