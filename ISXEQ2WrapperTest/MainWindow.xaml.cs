using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using LavishScriptAPI;
using LavishVMAPI;


namespace ISXEQ2WrapperTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StringBuilder logBuilder;

        private const string LogFile = "ISXEQ2WrapperTest.log";

        private const string Testing = "TESTING";

        private const string Untested = "UNTESTED";

        private const string Passed = "PASSED";

        private const string Failed = "FAILED";

        private void Log(string entry)
        {
            if (!File.Exists(LogFile))
            {
                using(var sw = File.CreateText(LogFile))
                { }
            }
            entry = String.Format("[{0} | {1}] - {2}", DateTime.Now.ToShortDateString(), DateTime.Now.TimeOfDay, entry);
            logBuilder.AppendLine(entry);
            UpdateLogTextBox();
            using (var sw = File.AppendText(LogFile))
            {
                sw.WriteLine(entry);
            }
        }

        private void UpdateLogTextBox()
        {
            TextBoxLog.Text = logBuilder.ToString();
            TextBoxLog.CaretIndex = logBuilder.ToString().Length;
            TextBoxLog.ScrollToEnd();
        }

        public MainWindow()
        {
            InitializeComponent();
            logBuilder = new StringBuilder();
            TextBoxLog.Text = logBuilder.ToString();
            TextBoxISXEQ2TLOResult.Text = "UNTESTED";
            TextBoxISXEQ2TLOResult.Foreground = Brushes.Magenta;
        }

        private void ButtonTestISXEQ2TLO_Click(object sender, RoutedEventArgs e)
        {
            TestTLO("ISXEQ2");
        }
    }

    
}
