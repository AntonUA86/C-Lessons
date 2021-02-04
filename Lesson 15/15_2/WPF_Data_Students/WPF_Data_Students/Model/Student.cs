using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Data_Students.Model
{
    class Student : INotifyPropertyChanged, IComparable
    {
        private string name;
        private string surname;
        private string city;
        private string faculty;
        private int course;
        private double gpa;
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged("city");
            }
        }
        public string Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                faculty = value;
                OnPropertyChanged("faculty");
            }
        }
        public int Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
                OnPropertyChanged("course");
            }
        }
        public double GPA
        {
            get
            {
                return gpa;
            }
            set
            {
                gpa = value;
                OnPropertyChanged("gpa");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public int CompareTo(object o)
        {
            Student p = o as Student;
            if (p != null)
                return this.Name.CompareTo(p.Name);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
