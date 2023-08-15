using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application_dev_coursework_1
{
    [Serializable]
    //helps to compare student objects in groups by their last names
    public class SortingHelper : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {   // compares two students bases on thier last names them in ascendign order.
            return String.Compare(s1.LastName, s2.LastName);
        }
    }
}
