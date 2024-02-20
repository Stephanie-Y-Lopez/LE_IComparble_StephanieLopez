using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LE_IComparble_StephanieLopez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            TheStudents();

            //Student_SortGenEdGradeAsd grade = new Student_SortGenEdGradeAsd(Student_SortGenEdGradeAsd.Order.Descending);

            //Student_SortFirstNameDcs firstNameDsc = new Student_SortFirstNameDcs();

            //students.Sort(firstNameDsc);
            DisplayStudent();
        }

        List<Student> students = new List<Student>();
        void TheStudents()
        {
            students.Add(new Student("Will", "Cram"));
            students.Add(new Student("Yolis", "Chavoya"));
            students.Add(new Student("Manjula", "Manjula"));
            students.Add(new Student("Yolanda", "Chavoya"));
            students.Add(new Student("Pedro", "Lopez"));
            students.Add(new Student("Oswaldo", "Hernadez"));
            students.Add(new Student("Diana", "Flor"));
            students.Add(new Student("Nico", "Loa"));
        }

        void DisplayStudent()
        {
            Lb_Students.Items.Clear();

            foreach(Student student in students)
            {
                Lb_Students.Items.Add(student);
            }
        }

        void B_FirstName_Click(object sender, RoutedEventArgs e)
        {

        }

        void B_CSIGrade_Click(object sender, RoutedEventArgs e)
        {

        }

        public void B_GenEd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
