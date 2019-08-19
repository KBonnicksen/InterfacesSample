using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesSample
{
    public interface ILogger
    {
        void WriteData(string data);
    }

    class WinFormsLogger : ILogger
    {
        void ILogger.WriteData(string data)
        {
            MessageBox.Show(data);
        }
    }

    class ConsoleLogger : ILogger
    {
        void ILogger.WriteData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
