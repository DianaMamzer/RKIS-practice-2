using System;
using System.Collections.Generic;

public class Task2_1
{
    public class Student
    {
        private string secondName;
        private DateTime dateOfBirth;
        private int group;
        private List<int> marks = new List<int>();


        public void PrintInfo()
        {
            Console.Write($"Фамилия: {secondName} \nГруппа: {group} \nДата рождения: {dateOfBirth} \nОценки: ");
            foreach (int a in marks)
            {
                System.Console.Write($"{a} ");
            }
        }
        
        public void Changeinfo(string secondName)
        {
            this.secondName = secondName;
        }
        public void Changeinfo(string secondName, DateTime dateOfBirth)
        {
            this.secondName = secondName;
            this.dateOfBirth = dateOfBirth;
        }
        public void Changeinfo(string secondName, DateTime dateOfBirth, int group)
        {
            this.secondName = secondName;
            this.dateOfBirth = dateOfBirth;
            this.group = group;
        }

        public Student(string secondName, DateTime dateOfBirth, int group, List<int> marks)
        {
            this.secondName = secondName;
            this.dateOfBirth = dateOfBirth;
            this.group = group;
            this.marks = marks;
        }
    }

    static void Main()
    {
        Student diana = new Student("Familia", new DateTime(2003, 05, 03), 414, new List<int> {4, 5, 5, 5, 4});
        diana.Changeinfo(secondName: "Mamzer", dateOfBirth: new DateTime(2004,06,17), group: 621);
        diana.PrintInfo();
    }
}