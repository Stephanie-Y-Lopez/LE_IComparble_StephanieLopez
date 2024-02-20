using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_IComparble_StephanieLopez
{
    public enum SortOrder
    {
        Ascending,
        Descending
    }
    internal class Student_SortCSIGrade : IComparer<Student>
    {
        private SortOrder sortOrder;

        public Student_SortCSIGrade(SortOrder order = SortOrder.Ascending)
        {
            sortOrder = order;
        }

        public int Compare(Student x, Student y)
        {
            if (sortOrder == SortOrder.Ascending)
            {
                return x.CSIGrade_.CompareTo(y.CSIGrade_);
            }
            else
            {
                return y.CSIGrade_.CompareTo(x.CSIGrade_);
            }
        }
    }
}
