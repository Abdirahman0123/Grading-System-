using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace application_dev_coursework_1
{
    [Serializable]
    // This displays the result in the Console. Please change your output type to "Console"
    public partial class Group2 : Form
    {

        SortedSet<Student> group2 = new SortedSet<Student>(new SortingHelper());
        List<int> group2Marks = new List<int>();

        public Group2()
        {
            InitializeComponent();
        }

        // manuall add students 
        private void AddAStudent_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n");
            try
            {
                int id = int.Parse(IDTextBox.Text);
                string firstName = FirstNameTextBox.Text;
                string lastName = LastNameTextBox.Text;
                string email = EmailTextBox.Text;

                // if there are 4 students in a group, dont add students
                if (group2.Count == 4)
                {
                    MessageBox.Show("You can`t add another student", "Maximum capacity Reached", MessageBoxButtons.OK);
                }
                else
                {
                    group2.Add(new Student(id, firstName, lastName, email));
                }
                clearTextBoxes();

            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the fields with right data type", "Empty Field");
            }
        }

        public void clearTextBoxes()
        {
            IDTextBox.Clear();
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            EmailTextBox.Clear();
        }

        // students in group2
        private void DisplayGroup2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n");
            if (group2.Count == 0)
            {
                MessageBox.Show("Add students to the group  first", "No Students Added");
            }
            else
            {
                Console.WriteLine("Id" + " " + "FirstName" + " " + "LastName" + " " + "Email");
                foreach (Student student in group2)
                {
                    Console.WriteLine(student.Id + " " + student.FirstName + " " + student.LastName + " " + student.Email);
                }
            }
        }

        public List<int> calculateMarks(SortedSet<Student> group)
        {
            Console.WriteLine("\n");
            // stores marks for the students in groups        
            List<int> studentsMarks = new List<int>();
            double groupMark;

            Console.WriteLine("Enter group mark: ");
            String inputGroupMark = Console.ReadLine(); // reads user input for group

            // keep asking the user to enter a number
            while (!double.TryParse(inputGroupMark, out groupMark))
            {
                Console.WriteLine("Not a valid number, try again.");
                inputGroupMark = Console.ReadLine();
            }

            double maxMark = groupMark / 4;

            // loops through students in the group and asks wieghting for each student. 
            // it ensures user enters valid number and then calculates mark for each student
            foreach (Student student in group)
            {
                double weighting = 0;
                Console.WriteLine($"Enter weighting  for :{student.FirstName + " " + student.LastName} ");
                String inputWeighting = Console.ReadLine();
                while (!double.TryParse(inputWeighting, out weighting))
                {
                    Console.WriteLine("Enter valid weighting");
                    inputWeighting = Console.ReadLine();
                }

                if (weighting < 25)
                {                   
                    int mark = (int)((weighting / maxMark) * groupMark); // calculate their mark                  
                    studentsMarks.Add(mark); // add calculated mark to the studentsMarks
                }
                else
                {
                    Console.WriteLine("Enter weighting less than 25%");
                    inputWeighting = Console.ReadLine();
                }
            }

            // student in the group and thier marks are combined, so that their details and marks are displayed in parallel. 
            var studentsAndTheirMarks = group.Zip(studentsMarks, (student, mark) => student.Id + " " +
            student.FirstName + " " + student.LastName + " " + student.Email + " " + mark);
            Console.WriteLine("\n");
            Console.WriteLine("Id" + " " + "FirstName" + " " + "LastName" + " " + "Email" + " " + "Mark");
            foreach (var studentMakr in studentsAndTheirMarks)
            {
                Console.WriteLine(studentMakr);
            }
            return studentsMarks; // return students marks for the current group*/
        }

        private void SaveGroup2_Click(object sender, EventArgs e)
        {
            if (group2.Count == 0 || group2Marks.Count == 0)
            {
                MessageBox.Show("Add students to the group  first and calculate their marks", "No Students Added");
            }
            else
            {
                //saveGroups.save(group2, group2Marks);

                BinaryFormatter formatter = new BinaryFormatter();

                // FileMode.Create create the file and FileAccess.Write 
                Stream streamGroup2 = new FileStream("streamGroup2.txt", FileMode.Create, FileAccess.Write);
                Stream streamGroup2Marks = new FileStream("group2Marks.txt", FileMode.Create, FileAccess.Write);

                formatter.Serialize(streamGroup2, group2);
                formatter.Serialize(streamGroup2Marks, group2Marks);
                streamGroup2.Close();
                streamGroup2Marks.Close();
                MessageBox.Show("Done");

            }

        }

        private void DisplayMarkforGroup2_Click(object sender, EventArgs e)
        {
            if (group2.Count == 0)
            {
                MessageBox.Show("Add students to the group  first", "No Students Added");
            }
            else
            {
                group2Marks = calculateMarks(group2);
            }
        }

        // retrieve group2 and their marks from text file through deserialisation 
        private void RetrieveGroup2_Click(object sender, EventArgs e)
        {
            if (group2.Count == 0)
            {
                MessageBox.Show("Add students to the group  first and serialise", "No file");
            }
            else
            {
                // create object of binary formatter
                BinaryFormatter formatter = new BinaryFormatter();
                // retrieve group2 and their marks from text files
                FileStream streamGroup2 = new FileStream("streamGroup2.txt", FileMode.Open, FileAccess.Read);
                FileStream streamgroup2Marks = new FileStream("group2Marks.txt", FileMode.Open, FileAccess.Read);

                // deserialisation group2 and their marks 
                var group2Students = (SortedSet<Student>)formatter.Deserialize(streamGroup2);
                var group2Marks = (List<int>)formatter.Deserialize(streamgroup2Marks);

                // combine students in group2 and their marks using zip function and then print them
                var group1AndTheirMarks = group2Students.Zip(group2Marks, (student, mark) => student.Id + " " + student.FirstName + " " +
                student.LastName + " " + student.Email + " " + mark);
                Console.WriteLine("\n");
                Console.WriteLine("Id" + " " + "FirstName" + " " + "LastName" + " " + "Email" + " " + "Mark");
                foreach (var studentMark in group1AndTheirMarks)
                {
                    Console.WriteLine(studentMark);
                }
            }
        }
    }
}

/*
double weighting = 0;
Console.WriteLine($"Enter weighting for :{student.FirstName + " " + student.LastName} ");
String inputWeighting = Console.ReadLine();
while (!double.TryParse(inputWeighting, out weighting))
{
    Console.WriteLine("Enter valid weighting");
    inputWeighting = Console.ReadLine();
}
int mark = (int)((weighting / maxMark) * groupMark); // calculate their mark                  
studentsMarks.Add(mark); // add calculated mark to the studentsMarks
*/

/*

while (inputWeighting != null)
{
    string input = inputWeighting;
    weighting = Convert.ToInt32(input);
    if (weighting > 25)
    {
        Console.WriteLine("Weight must be less than 25%. Try again");
        inputWeighting = Console.ReadLine();
    }
    Console.WriteLine("Enter valid weighting");
    inputWeighting = Console.ReadLine();
}

*/

/*
 *  while (!double.TryParse(inputWeighting, out weighting) )
                {
                    Console.WriteLine("Enter valid weighting");
                    inputWeighting = Console.ReadLine();
                }

                if (weighting < 25 )
                {
                    Console.WriteLine("yes");
                    int mark = (int)((weighting / maxMark) * groupMark); // calculate their mark                  
                    studentsMarks.Add(mark); // add calculated mark to the studentsMarks
                }

                else
                {
                    Console.WriteLine("Enter weighting less than 25%");
                    inputWeighting = Console.ReadLine();
                }
*/