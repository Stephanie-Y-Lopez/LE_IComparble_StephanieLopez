using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_IComparble_StephanieLopez
{
    internal class Student : IComparable<Student>
    {
        //Fields
        public string FirstName_;
        public string LastName_;
        public double CSIGrade_;
        public double GenEdGrade_;

        //Constructor
        public Student(string FirstName, string LastName)
        {
            FirstName_ = FirstName;
            LastName_ = LastName;
            Random rand = new Random();
            CSIGrade_ = rand.Next(40, 101); //To generate random grade between 40 and 101.
            GenEdGrade_ = rand.Next(60, 102); //Generates random grade between 60 and 102.
        }

        //Properties
        public string FirstName__ { get => FirstName_; set => FirstName_ = value; }
        public string LastName__ { get => LastName_; set => LastName_ = value; }
        public double CSIGrade__ { get => CSIGrade_; set => CSIGrade_ = value; }
        public double GenEdGrade__ { get => GenEdGrade_; set => GenEdGrade_ = value; }

        //Method
        public override string ToString()
        {
            return $"{FirstName_} {LastName_} - CSI Grade: {CSIGrade_} - Gen Ed Grade: {GenEdGrade_}";
        }

        public int CompareTo(Student other)
        {
            if (CSIGrade_ < other.CSIGrade_) return 1;
            else if (CSIGrade_ > other.CSIGrade_) return -1;
            else return 0;
        }
    }
}
