using System;
using System.Collections;
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

        class Roster : IEnumerable<Student>
        {
            public List<Student> Students { get; set; }

            public IEnumerator<Student> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
        /// <summary>
        /// This is a documentation comment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            using(var u = new UnmanagedExample())
            {
                Roster stuRoster = new Roster();
                //List<Student> getStus = stuRoster.Students();
                foreach(Student s in stuRoster)
                {

                }
            }

            Student s1 = new Student(){
                StudentID = 1,
                FirstName = "Kelsey",
                LastName = "Bonnicksen"
            };

            Student s2 = new Student(){
                StudentID = 2,
                FirstName = "Jim",
                LastName = "Halpert"
            };

            Student s3 = new Student(){
                StudentID = 3,
                FirstName ="Drew",
                LastName = "Carrey"
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
            return currStu.StudentID.CompareTo(other.StudentID);
        }
    }

    class UnmanagedExample : IDisposable
    {
        public void Dispose()
        {
            // Clean up unmanaged resources
            // such as DB connections
        }
    }
}
