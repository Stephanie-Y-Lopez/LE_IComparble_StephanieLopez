using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_IComparble_StephanieLopez
{
    internal class Student_SortFirstNameDcs : IComparer<Student>
    {
        int IComparer<Student>.Compare(Student x, Student y)
        {
            return x.FirstName__.CompareTo(y.FirstName__) * -1;
        }
    }
}
