using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISXEQ2WrapperTest
{
    public class MyTraceListener : TraceListener
    {
        public MyTraceListener(MainWindow window)
        {
            this._window = window;
            //if (!Trace.Listeners.Contains(this))
            //    Trace.Listeners.Add(this);
        }

        private MainWindow _window;

        public override void Write(string message)
        {
            _window.Log(message);
        }

        public override void WriteLine(string message)
        {
            _window.Log(message);
        }
    }
}
