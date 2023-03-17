using System;

public class Task2_5
{
    public class Class
    {
        private string color;
        private int num;

        public Class()
        {
            color = "purple";
            num = 20;
        }

        public void Print()
        {
            Console.WriteLine($"Свойство первое (цвет) = {color}\nСвойство второе (число) = {num}");
        }
        
        public void Default(string color, int num)
        {
            this.color = color;
            this.num = num;
        }
        
        ~Class()
        {
            Console.WriteLine("Объект удалён");
        }
        
    }

    static void Main()
    {
        Class run = new Class();
        
        Console.WriteLine("Текущее значение свойств: ");
        run.Print();
        
        Console.WriteLine("\nЗначение свойств после инициализации: ");
        run.Default("White", 0);
        run.Print();
    }
}