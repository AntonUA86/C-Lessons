using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPF_Data_Students.Model;

namespace WPF_Data_Students.ViewModel
{
    class StudentViewModel : INotifyPropertyChanged

    {
        private Student selectedStudent;
        public ObservableCollection<Student> students { get; set; }
        public Student SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                OnPropertyChanged("selectedStudent");
            }
        }
      
        public StudentViewModel()
        {
            students = new ObservableCollection<Student>
        {
            new Student { Name="Оля", Surname="Осадчая", City="Суммы", Faculty="Кибернетика",Course=5, GPA=3.5 },
            new Student { Name="Эмма", Surname="Мартирасян", City="Донецк",Faculty="Борщ",Course=3, GPA=3.7  },
            new Student { Name="Антон", Surname="Калинник", City="Донецк",Faculty="Физико-математический", Course=5, GPA=4.8 }
        };
           
        }
        public void AddStudent()
        {
            Student student = new Student();
            students.Insert(0, student);
            SelectedStudent = student;
        }
        public void DeleteStudent()
        {
            if (selectedStudent != null)
            {
                students.Remove(SelectedStudent);
            }
        }
      



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
