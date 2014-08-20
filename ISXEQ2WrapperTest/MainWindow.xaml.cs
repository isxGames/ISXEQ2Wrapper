﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
using EQ2.ISXEQ2;


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

        public void Log(string entry)
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
            Trace.Listeners.Add(new TextWriterTraceListener(File.AppendText("Trace.log")));
            Trace.Listeners.Add(new MyTraceListener(this));
            Trace.AutoFlush = true;
            Trace.IndentLevel = 0;
            InitializeComponent();
            logBuilder = new StringBuilder();
            TextBoxLog.Text = logBuilder.ToString();
            TextBoxToggle("ISXEQ2", "UNTESTED", Brushes.Magenta);
            TextBoxToggle("EQ2", "UNTESTED", Brushes.Magenta);
        }

        private void ButtonTestISXEQ2TLO_Click(object sender, RoutedEventArgs e)
        {
            TestTLO("ISXEQ2");
        }

        private void ButtonTestEQ2_Click(object sender, RoutedEventArgs e)
        {
            using (new FrameLock(true))
            {
                foreach (Ability ability in new EQ2.ISXEQ2.Extension().Me().GetAbilities())
                {
                    Log(String.Format("ID: {0}", ability.ID));
                }
            }
            Thread.Sleep(1000);
            using (new FrameLock(true))
            {
                foreach (Ability ability in new EQ2.ISXEQ2.Extension().Me().GetAbilities())
                {
                    Log(String.Format("Name: {0}", ability.Name));
                }
            }
        }
    }

    
}
