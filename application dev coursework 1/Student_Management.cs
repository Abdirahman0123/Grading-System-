using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Concurrent;
using System.Collections;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Linq.Expressions;
using System.Dynamic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics.Metrics;
//using System.Collections.Generic;
//using System.Collections;

// remove student from class list as you assign them to a group so that one student cannot be in the same group
// also
namespace application_dev_coursework_1
{
    [System.Serializable]
    public partial class ManagingGroupCoursework : Form

    {
        List<Student> students = new List<Student>();
        SortedSet<Student> group1 = new SortedSet<Student>(new SortingHelper()); // SortedSet ignores duplicates and  sorts the students based on custom comparator      
        SortedSet<Student> group3 = new SortedSet<Student>(new SortingHelper());
        SortedSet<Student> group4 = new SortedSet<Student>(new SortingHelper());
        List<int> group1Marks = new List<int>();
        List<int> group3Marks = new List<int>();
        List<int> group4Marks = new List<int>();
        Group2 gp2 = new Group2();


        public ManagingGroupCoursework()
        {
            InitializeComponent();

        }

        // closes application windows
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // opens Group2 form
        private void GroupTwo_Click_1(object sender, EventArgs e)
        {
            Group2 gp2 = new Group2();
            gp2.Show();
        }

        //  import a text file by 
        private void Import_Click(object sender, EventArgs e)
        {
            // stores student details split into columns
            string[] columns = new string[20];
            string idColumn = columns[0]; // id column
            string firstNameColumn = columns[1]; // first name column
            string lastNameColumn = columns[2]; // last name column
            string emailColumn = columns[3]; // email column
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // opening the dialogue window and stored the select file
                var importedFile = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(importedFile); // storing the file as stream

                // read each line and split it to columns 
                // then combine  columns to create student object, and store it in students list
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    // splits line into different columns, id, firstname, lastname email
                    columns = line.Split(' ');
                    foreach (string column in columns)
                    {
                        idColumn = columns[0];
                        firstNameColumn = columns[1];
                        lastNameColumn = columns[2];
                        emailColumn = columns[3];
                    }
                    students.Add(new Student(int.Parse(idColumn), firstNameColumn, lastNameColumn, emailColumn));
                }
            }
            studentsDataGridView1.DataSource = students; //  bind students list to studentsDataGridView1
        }


        // start of code for group1
        // select a student from studentsDataGridView1 by double clicking on it add it to the group1
        private void studentsDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {   // declare cell to be used from row selected 
            int idCell = 0;
            string firstNameCell = null;
            string lastNameCell = null;
            string emailCell = null;
            try
            {   // e is the event, which is double clicking on the cell. RowIndex is the row being clicked
                DataGridViewRow row = studentsDataGridView1.Rows[e.RowIndex];
                idCell = int.Parse(row.Cells[0].Value.ToString());
                firstNameCell = row.Cells[1].Value.ToString();
                lastNameCell = row.Cells[2].Value.ToString();
                emailCell = row.Cells[3].Value.ToString();

                //if group1 has 4 students dont allow anymore students
                if (group1.Count == 4)
                {
                    MessageBox.Show("You can`t add another student", "Maximum capacity Reached", MessageBoxButtons.OK);
                }
                else
                {
                    group1.Add(new Student(idCell, firstNameCell, lastNameCell, emailCell));
                }
            }
            catch (Exception) { }

            // remove students in group1 from students list
            FindStudentWithNoGroup(group1);
        }

        // compares students list with group1 SortedSet and returns that are in students list but in group 
        public void FindStudentWithNoGroup(SortedSet<Student> group)
        {
            List<Student> noGroup = /*(List<Student>)*/students.Where(aStudent => !group.Any(studentInGB =>
            studentInGB.Id == aStudent.Id && studentInGB.FirstName == aStudent.FirstName && studentInGB.LastName ==
            aStudent.LastName && studentInGB.FirstName == aStudent.FirstName && studentInGB.Email == aStudent.Email)).ToList();

            studentsDataGridView1.DataSource = null; // unbind students from the studentsDataGridView1
            students = noGroup; // assign students with no groups to students list
            studentsDataGridView1.DataSource = students;
        }

        private void DisplayMarkforGroup1_Click(object sender, EventArgs e)
        {
            if (group1.Count == 0)
            {
                MessageBox.Show("Add students to the group  first and calculate their marks\"", "No Students Added");
            }
            else
            {
                group1Marks = gp2.calculateMarks(group1);
            }
        }

        private void SaveGroup1_Click(object sender, EventArgs e)
        {
            if (group1.Count == 0 || group1Marks.Count == 0)
            {
                MessageBox.Show("Add students to the group  first and calculate their marks", "No Students Added");
            }
            else
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // FileMode.Create create the file and FileAccess.Write 
                Stream streamGroup1 = new FileStream("streamGroup1.txt", FileMode.Create, FileAccess.Write);
                Stream streamGroup1Marks = new FileStream("group1Marks.txt", FileMode.Create, FileAccess.Write);

                formatter.Serialize(streamGroup1, group1);
                formatter.Serialize(streamGroup1Marks, group1Marks);
                streamGroup1.Close();
                streamGroup1Marks.Close();
                MessageBox.Show("Done");
            }
        }

        private void RetrieveGroup1_Click(object sender, EventArgs e)
        {
            if (group1.Count == 0 || group1Marks.Count == 0)
            {
                MessageBox.Show("Add students to the group  first and serialise", "No file");
            }
            else
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream streamGroup1 = new FileStream("streamGroup1.txt", FileMode.Open, FileAccess.Read);
                FileStream streamgroup1Marks = new FileStream("group1Marks.txt", FileMode.Open, FileAccess.Read);

                //deserialise objects and casted them to their type
                var group1Students = (SortedSet<Student>)formatter.Deserialize(streamGroup1);
                var group1Marks = (List<int>)formatter.Deserialize(streamgroup1Marks);

                var group1AndTheirMarks = group1Students.Zip(group1Marks, (student, mark) => student.Id + " " +
                student.FirstName + " " + student.LastName + " " + student.Email + " " + mark);
                Console.WriteLine("\n");
                Console.WriteLine("Id" + " " + "FirstName" + " " + "LastName" + " " + "Email" + " " + "Mark");
                foreach (var studentMark in group1AndTheirMarks)
                {
                    Console.WriteLine(studentMark);
                }
            }
        }

        private void DisplayGroup1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n");
            if (group1.Count == 0)
            {
                MessageBox.Show("Add students to the group first", "No Students Added");
            }

            else
            {
                Console.WriteLine("Id" + " " + "FirstName" + " " + "LastName" + " " + "Email");
                foreach (Student student in group1)
                {
                    {
                        Console.WriteLine(student.Id + " " + student.FirstName + " " + student.LastName + " " + student.Email);
                    }
                }
            }
        }
        // end of code for group1



        // start of code for group3
        // bulk-assigns students to group3 from students list
       
        private void BulkAssignToGroups_Click(object sender, EventArgs e)
        {
            try
            {
                if (students.Count != 0)
                {
                    int counter = 4;
                    while (group3.Count < counter &  group3.Count < counter)
                    {
                        foreach (Student student1 in students)
                        {
                            group3.Add(student1);

                            if (group3.Count == counter)
                            {                               
                                break;
                            }
                        }
                    }
                    FindStudentWithNoGroup(group3);

                    while (group4.Count < counter)
                    {
                        foreach (Student student1 in students)
                        {
                            group4.Add(student1);

                            if (group4.Count == counter)
                            {
                                break;
                            }
                        }
                    }
                    FindStudentWithNoGroup(group4);
                }
                else
                {
                    MessageBox.Show("Please import students first", "No data");
                }
            }            catch (Exception) { }         
        }
     
        // display group3
        private void DisplayGroup3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n");
            if (group3.Count == 0)
            {
                MessageBox.Show("Add students to the group first", "No Students Added");
            }
            else
            {
                Console.WriteLine("Id" + " " + "FirstName" + " " + "LastName" + " " + "Email");
                foreach (Student student in group3)
                {
                    Console.WriteLine(student.Id + " " + student.FirstName + " " + student.LastName + " " + student.Email);
                }
            }
        }
        // display group mark for group3
        private void DisplayMarkforGroup3_Click(object sender, EventArgs e)
        {
            if (group3.Count == 0)
            {
                MessageBox.Show("Add students to the group first ", "No Students Added");

            }
            else
            {
                group3Marks = gp2.calculateMarks(group3);

            }
        }

        // save group 3
        private void SaveGroup3_Click(object sender, EventArgs e)
        {
            if (group3.Count == 0 || group3Marks.Count == 0)
            {
                MessageBox.Show("Add students to the group  irst and calculate their marks", "No Students Added");
            }
            else
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // FileMode.Create create the file and FileAccess.Write 
                Stream streamGroup3 = new FileStream("streamGroup3.txt", FileMode.Create, FileAccess.Write);
                Stream streamGroup3Marks = new FileStream("group3Marks.txt", FileMode.Create, FileAccess.Write);

                formatter.Serialize(streamGroup3, group3);
                formatter.Serialize(streamGroup3Marks, group3Marks);
                streamGroup3.Close();
                streamGroup3Marks.Close();
                MessageBox.Show("Done");
            }

        }

        // similar to RetrieveGroup1
        private void RetrieveGroup3_Click(object sender, EventArgs e)
        {
            if (group3.Count == 0)
            {
                MessageBox.Show("Add students to the group  first and serialise", "No file");
            }
            else
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream streamGroup = new FileStream("streamGroup3.txt", FileMode.Open, FileAccess.Read);
                FileStream streamMarks = new FileStream("group3Marks.txt", FileMode.Open, FileAccess.Read);

                var group3Students = (SortedSet<Student>)formatter.Deserialize(streamGroup);

                var group3Marks = (List<int>)formatter.Deserialize(streamMarks);

                var group3AndTheirMarks = group3Students.Zip(group3Marks, (student, mark) => student.Id + " " +
                student.FirstName + " " + student.LastName + " " + student.Email + " " + mark);
                Console.WriteLine("\n");
                Console.WriteLine("Id" + " " + "FirstName" + " " + "LastName" + " " + "Email" + " " + "Mark");
                foreach (var studentMark in group3AndTheirMarks)
                {
                    Console.WriteLine(studentMark);
                }
            }
        }

        // start of code for group4

        // similar to DisplayGroup1
        private void DisplayGroup4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n");
            if (group4.Count == 0)
            {
                MessageBox.Show(" Use bulk assign to add students to the group first", "No Students Added");
            }
            else
            {
                Console.WriteLine("Id" + " " + "FirstName" + " " + "LastName" + " " + "Email");
                foreach (Student student in group4)
                {
                    Console.WriteLine(student.Id + " " + student.FirstName + " " + student.LastName + " " + student.Email);
                }
            }
        }

        // similar to DisplayMarkforGroup1
        private void DisplayMarkforGroup4_Click(object sender, EventArgs e)
        {
            if (group4.Count == 0)
            {
                MessageBox.Show("Add students to the group first ", "No Students Added");

            }
            else
            {
                group4Marks = gp2.calculateMarks(group4);

            }
        }

        // similar to SaveGroup1
        private void SaveGroup4_Click(object sender, EventArgs e)
        {
            if (group4.Count == 0 || group4Marks.Count == 0)
            {
                MessageBox.Show("Add students to the group  irst and calculate their marks", "No Students Added");
            }
            else
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // FileMode.Create create the file and FileAccess.Write 
                Stream streamGroup4 = new FileStream("streamGroup4.txt", FileMode.Create, FileAccess.Write);
                Stream streamGroup4Marks = new FileStream("group4Marks.txt", FileMode.Create, FileAccess.Write);

                formatter.Serialize(streamGroup4, group4);
                formatter.Serialize(streamGroup4Marks, group4Marks);
                streamGroup4.Close();
                streamGroup4Marks.Close();
                MessageBox.Show("Done");
            }
        }

        // similar to RetrieveGroup1
        private void RetrieveGroup4_Click(object sender, EventArgs e)
        {
            if (group4.Count == 0)
            {
                MessageBox.Show("Add students to the group  first and serialise", "No file");
            }
            else
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream streamGroup = new FileStream("streamGroup4.txt", FileMode.Open, FileAccess.Read);
                FileStream streamMarks = new FileStream("group4Marks.txt", FileMode.Open, FileAccess.Read);

                var group4Students = (SortedSet<Student>)formatter.Deserialize(streamGroup);

                var group4Marks = (List<int>)formatter.Deserialize(streamMarks);

                var group3AndTheirMarks = group4Students.Zip(group4Marks, (student, mark) => student.Id + " " +
                student.FirstName + " " + student.LastName + " " + student.Email + " " + mark);
                Console.WriteLine("\n");
                Console.WriteLine("Id" + " " + "FirstName" + " " + "LastName" + " " + "Email" + " " + "Mark");
                foreach (var studentMark in group3AndTheirMarks)
                {
                    Console.WriteLine(studentMark);
                }
            }
        }

        
    }
}

//list2.Where(el2 => !list1.Any(el1 => el1.Title == el2.Title && el1.url == el2.url));
// https://stackoverflow.com/questions/29561968/how-to-find-the-difference-of-two-listobject-in-c-sharp-using-lambda-expressio