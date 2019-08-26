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
            Student s1 = new Student(){
                StudentID = 1,
                FirstName = Kelsey,
                LastName = Bonnicksen
            };

            Student s2 = new Student(){
                StudentID = 2,
                FirstName = Jim,
                LastName = Halpert
            };

            Student s3 = new Student(){
                StudentID = 3,
                FirstName = Drew,
                LastName = Carrey
            };

            // Sorting by lastname due to IComparable
            Student[] allStu = new Student[]{s3, s2, s1};

            //Sort using linq in descending order
            Student[] stus = allStu.OrderByDescending(s => s.LastName).ToArray();

            Array.Sort(allStu);
        }

        private void BtnLogData_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            log.WriteData(input);
        }
    }

    public class Student : IComparable<Student>
    {
        public int  StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CompareTo(Student other)
        {
            Student currStu = this;

            // This instance comes after null because nulls fo first

            return currStu.StudentID.CompareTo(other.StudentID);
            if(other == null)
                return 1;

            if(currStu.StudentID < other.StudentID)
                return -1;
            if(currStu.StudentID == other.StudentID)
                return 0;
            if(currStu.StudentID > other.StudentID)
                return 1;
        }
    }
}
