using System;


public class Task3_1
{
    public class Worker
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
        }
        int rate;
        public int Rate
        {
            get
            {
                return rate;
            }
        }
        int days;
        public int Days
        {
            get
            {
                return days;
            }
        }

        public int Salary()
        {
            return rate * days;
        }

        public string Fullname()
        {
            return name + " " + surname;
        }

        public Worker(string name, string surname, int rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }
    }

    static void Main()
    {
        Worker worker = new Worker("Диана", "Мамзер", 4000, 100);
        Console.WriteLine($"Зарплата работника {worker.Fullname()}: {worker.Salary()}.");
    }
}