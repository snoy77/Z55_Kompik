using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Z55_V3_DLL;

namespace Z55_V3_Forms
{
    public partial class Form1 : Form
    {
        MainModule mainModule;

        public Form1()
        {
            InitializeComponent();
            mainModule = new MainModule();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Speaker.speakText("Форма загружена");
            mainModule.StartAllModule(true);
        }

        private void button_CreateNote_Click(object sender, EventArgs e)
        {
            string message = textBox_timerModuleMessage.Text;

            int[] dates = textBox_timerModuleDatetime.Text.Split(' ').Select(x => int.Parse(x)).ToArray();
            DateTime dateTime = new DateTime(dates[0], dates[1], dates[2], dates[3], dates[4], dates[5]);
            
            mainModule.timerModule.notes.Add(new Note(dateTime, message));
            Speaker.speakText("Напоминание добавлено");
        }
    }
}
