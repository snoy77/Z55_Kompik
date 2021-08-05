using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Z55_V3_WPF
{
    public class MainModule
    {
        //Системные модули
        public TimerModule timerModule;

        public MainModule()
        {
            this.timerModule = new TimerModule();
        }

        public void StartAllModule()
        {
            timerModule.StartWork();
        }
    }
    public class TimerModule
    {
        //Поток для рабочего метода модуля
        static Thread a = new Thread(new ThreadStart(DoWork));

        
        public  void StartWork()
        {
            a.Start();
        }
        public void StopWork()
        {
            a.Abort();
        }

        //Метод описывающий логику иттераций модуля
        private static void DoWork()
        {
            while (true)
            {
                Thread.Sleep(2000);
            }
        }
    }
}
