using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_IComparble_StephanieLopez
{
    internal class Student_SortGenEdGradeAsd : IComparer<Student>
    {
        public enum Order { Ascending, Descending }
        public Order SortingOrder = Order.Ascending;

        public Student_SortGenEdGradeAsd()
        {
            SortingOrder = Order.Ascending;
        }

        public Student_SortGenEdGradeAsd(Order sortingOrder)
        {
            SortingOrder = sortingOrder;
        }

        public int Compare(Student x, Student y)
        {
            if (SortingOrder == Order.Ascending)
            {
                if (x.GenEdGrade__ > y.GenEdGrade__) return 1;
                else if (x.GenEdGrade__ < y.GenEdGrade__) return -1;
                else return 0;
            }
            else
            {
                if (x.GenEdGrade__ < y.GenEdGrade__) return 1;
                else if (x.GenEdGrade__ > y.GenEdGrade__) return -1;
                else return 0;
            }
        }
    }
}
