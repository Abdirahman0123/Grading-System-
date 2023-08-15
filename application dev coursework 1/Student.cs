using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics;

namespace application_dev_coursework_1
{
    [Serializable]
    public class Student 
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;        
        
        public Student(int studentId, string studentFirstName, string studentLastName, string studentEmail)
        {
            id = studentId;
            firstName = studentFirstName;
            lastName = studentLastName;
            email = studentEmail;           
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }       
    }
}

