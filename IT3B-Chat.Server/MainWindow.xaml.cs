using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace IT3B_Chat.Server
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> messageLog;
        private ObservableCollection<string> connectionLog;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            messageLog = new ObservableCollection<string>();
            connectionLog = new ObservableCollection<string>();

            // Simulace příchozích zpráv a událostí připojení/odpojení klientů
            SimulateIncomingMessages();
            SimulateConnectionEvents();
        }

        public ObservableCollection<string> MessageLog
        {
            get { return messageLog; }
        }

        public ObservableCollection<string> ConnectionLog
        {
            get { return connectionLog; }
        }

        private void SimulateIncomingMessages()
        {
            // Simulace příchozích zpráv
            for (int i = 1; i <= 10; i++)
            {
                messageLog.Add($"Zpráva od klienta {i}: Obsah zprávy {i}.");
            }
        }

        private void SimulateConnectionEvents()
        {
            // Simulace událostí připojení/odpojení klientů
            for (int i = 1; i <= 5; i++)
            {
                connectionLog.Add($"Klient {i} se připojil.");
            }
            for (int i = 1; i <= 3; i++)
            {
                connectionLog.Add($"Klient {i} se odpojil.");
            }
        }
    }
}