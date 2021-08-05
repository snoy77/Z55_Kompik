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

            mainModule.timerModule.notes.Add(new Note(dateTimePicker1.Value, message));
            Speaker.speakText("Напоминание добавлено");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainModule.timerModule.StopWork();
        }
    }
}
