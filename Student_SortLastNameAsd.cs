using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_IComparble_StephanieLopez
{
    internal class Student_SortLastNameAsd : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.LastName__.CompareTo(y.LastName__);
        }
    }
}
