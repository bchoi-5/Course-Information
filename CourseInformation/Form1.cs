using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseInformation
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> roomNumbers = new Dictionary<string, string>()
        {
            {"CS101", "3004" },
            {"CS102", "4501" },
            {"CS103", "6755" },
            {"NT110", "1244" },
            {"CM241", "1411" }
        };

        private Dictionary<string, string> instructors = new Dictionary<string, string>()
        {
            {"CS101", "Haynes" },
            {"CS102", "Alvarado" },
            {"CS103", "Rich" },
            {"NT110", "Burke" },
            {"CM241", "Lee" }
        };

        private Dictionary<string, string> meetingTimes = new Dictionary<string, string>()
        {
            {"CS101", "8:00 AM" },
            {"CS102", "9:00 AM" },
            {"CS103", "10:00 AM" },
            {"NT110", "11:00 AM" },
            {"CM241", "1:00 AM" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string courseNumber = "";
                string roomNumber = "";
                string instructor = "";
                string meetingTime = "";

                courseNumber = txtCourseNumberInput.Text;

                roomNumber = roomNumbers[courseNumber];
                instructor = instructors[courseNumber];
                meetingTime = meetingTimes[courseNumber];

                lblRoomNumber.Text = roomNumber;
                lblInstructor.Text = instructor;
                lblMeetingTime.Text = meetingTime;
            }
            catch
            {
                // make non case sensitive generic dictionary for strings?
                MessageBox.Show("Enter a valid course number. Case-senstive.");
            }
        }
    }
}
