using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesSample
{
    public partial class frmLogger : Form
    {
        private readonly ILogger log;

        public frmLogger(ILogger logger)
        {
            log = logger;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogData_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
           // ILogger log = new ConsoleLogger();
            log.WriteData(input);
        }
    }
}
