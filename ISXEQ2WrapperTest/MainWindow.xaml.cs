using System;
using System.Collections.Generic;
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

        private void Log(string entry)
        {
            entry = String.Format("[{0}:{1} - {2}]", DateTime.Now.Date, DateTime.Now.TimeOfDay, entry);
            logBuilder.AppendLine(entry);
            UpdateLogTextBox();
            using (var sw = File.AppendText("ISXEQ2WrapperTest.log"))
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
            TextBoxISXEQ2TLOResult.Text = "Untested";
            TextBoxISXEQ2TLOResult.Foreground = Brushes.Magenta;
        }
    }

    
}
