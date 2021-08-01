using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z55_V3_WPF
{
    //Главный модуль бота
    public class MainModule
    {
        //Натсройки главного модуля
        public bool botVoiceNeed = true;

        //Модули-инструменты
        public Speaker speaker;

        public MainModule(bool botVoiceNeed)
        {
            this.botVoiceNeed = botVoiceNeed;
        }
    }
}
