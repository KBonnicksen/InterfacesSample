using System;
using System.Collections.Generic;
using System.IO;
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

    class FileLogger : ILogger
    {
        void ILogger.WriteData(string data)
        {
            string nl = Environment.NewLine;

            File.AppendAllText("log.txt", 
                DateTime.Now.ToString() + nl + data + nl + nl);
        }
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
