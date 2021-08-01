using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Speech.Synthesis;

namespace Z55_V3_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Speaker speacer;
        
        public MainWindow()
        {
            InitializeComponent();
            speacer = new Speaker();
            speacer.speakText("Раз, два, три... Голосовой модуль подключён.");
        }

        private void button_botTestSpeakStart_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox_botTestSpeakText.Text;
            speacer.speakText(text);
        }
    }
}
