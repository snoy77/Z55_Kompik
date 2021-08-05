using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Z55_V3_DLL
{
    public class MainModule
    {
        //Системные модули
        public TimerModule timerModule;

        public MainModule()
        {
            this.timerModule = new TimerModule();
        }

        public void StartAllModule(bool notification)
        {
            timerModule.StartWork();
            if (notification)
            {
                Speaker.speakText("Все модули активированы");
            }
        }
    }
    public class Note
    {
        public DateTime dateTime;
        public string message;

        public Note(DateTime dateTime, string message)
        {
            this.dateTime = dateTime;
            this.message = message;
        }

        public bool checkTime()
        {
            return DateTime.Now.ToString() == this.dateTime.ToString();
        }
        public void sendMessage()
        {
            Speaker.speakText(this.message);
        }
    }
    public class TimerModule
    {
        public List<Note> notes = new List<Note>();
        //Поток для рабочего метода модуля
        static Thread a = new Thread(new ParameterizedThreadStart(DoWork));

        public  void StartWork()
        {
            a.Start(notes);
        }
        public void StopWork()
        {
            a.Abort();
        }

        //Метод описывающий логику иттераций модуля
        private static void DoWork(object notesARG)
        {
            List<Note> notes = (List<Note>)notesARG;
            while (true)
            {
                Thread.Sleep(1000);

                for(int i = 0; i < notes.Count; i++)
                {
                    if (notes[i].checkTime())
                    {
                        notes[i].sendMessage();
                    }
                }
            }
        }
    }
}
