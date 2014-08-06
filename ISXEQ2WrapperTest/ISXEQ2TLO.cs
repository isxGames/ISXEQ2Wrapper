using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using LavishVMAPI;

namespace ISXEQ2WrapperTest
{
    public partial class MainWindow : Window
    {
        private void TestISXEQ2TLO()
        {
            TextBoxISXEQ2TLOResult.Text = "Testing";
            TextBoxISXEQ2TLOResult.Foreground = Brushes.Yellow;
            var item = "[ISXEQ2TLO] ";
            var result = String.Empty;
            Log(item + "Starting test of ISXEQ2 Top Level Object.");
            Log(item + "Testing Version...");
            using (new FrameLock(true))
            {
                var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                result = isxeq2.Version;
                Log(item + result);
            }
        }
    }
}
