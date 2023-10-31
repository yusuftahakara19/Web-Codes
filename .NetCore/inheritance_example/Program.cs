using System;

namespace inheritance_example
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public virtual void Intro()
        {
            Console.WriteLine($"ad : {this.Name} surname : {this.Surname}");
        }
    }

    class Student : Person
    {
        public string StudentNumber { get; set; }
        public Student(string name, string surname, string studentNumber) : base(name, surname)
        {
            this.StudentNumber = studentNumber;
        }

        public override void Intro()
        {
            Console.WriteLine($"ad : {this.Name} surname : {this.Surname} no : {this.StudentNumber}");
        }
    }

    class Teacher : Person
    {
        public string Branch { get; set; }
        public Teacher(string name, string surname, string branch) : base(name, surname)
        {
            this.Branch = branch;
        }

        public override void Intro()
        {
            Console.WriteLine($"ad : {this.Name} surname : {this.Surname} branch : {this.Branch}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("yusuf", "kara", "19");
            st.Intro();
            Teacher t = new Teacher("Ahmet", "Elbir", "Computer Science");
            t.Intro();
        }
    }
}
