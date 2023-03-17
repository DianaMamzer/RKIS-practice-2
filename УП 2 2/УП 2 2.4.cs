using System;

public class Task2_4
{
    public class Count
    {
        private int count;

        public void Print()
        {
            Console.WriteLine($"Значение счётчика равно: {count}");
        }
        
        public Count()
        {
            count = 0;
        }
        
        public void ChangePlusOne()
        {
            count++;
        }

        public void ChangeMinusOne()
        {
            count--;
        }

        public void ChangeCount(int count)
        {
            this.count = count;
        }
        
        public Count(int count)
        {
            this.count = count;
        }
    }

    static void Main()
    {
        Count count = new Count(7);
        count.Print();
        Console.WriteLine($"Нужно ли изменить значение счётчика? (Y/N): ");
        string questInput1 = Console.ReadLine();
        while ((questInput1 != "Y") || (questInput1 != "N"))
        {
            if (questInput1 == "Y")
            {
                Console.Write($"\nВведите значение: ");
                int changeNum1 = int.Parse(Console.ReadLine());
                count.ChangeCount(changeNum1);
                break;
            }
            else
            {
                break;
            }
        }
        
        Console.Write($"Значение счётчик + 1 = ");
        count.ChangePlusOne();
        count.Print();
        Console.Write($"\nЗначение счётчик - 1 = ");
        count.ChangeMinusOne();
        count.Print();
    }
}