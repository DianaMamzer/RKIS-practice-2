using System;

public class Task2_3
{
    public class WorkWithNums
    {
        private int num1;
        private int num2;

        public void Print()
        {
            Console.WriteLine($"Первое число: {num1}\nВторое число: {num2}");
        }

        public void Change(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public void Sum()
        {
            Console.WriteLine($"Сумма первого и второго числа: {num1 + num2}");
        }

        public void FindMore()
        {
            if (num1 > num2)
            {
                Console.WriteLine($"Большее число это: {num1}");
            }
            else
            {
                Console.WriteLine($"Большее число это: {num2}");
            }
        }
        
        public WorkWithNums(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
    }

    static void Main()
    {
        WorkWithNums nums = new WorkWithNums(1000, 144);
        Console.Write($"Нужно ли вывести текущие числа? (Y/N): ");
        string questInput = Console.ReadLine();
        while ((questInput1 != "Y") || (questInput1 != "N"))
        {
            if (questInput1 == "Y")
            {
                nums.Print();
                break;
            }
            else
            {
                break;
            }
        }
        
        Console.Write($"Нужно ли изменить эти числа? (Y/N): ");
        string questInput2 = Console.ReadLine();
        while ((questInput2 != "Y") || (questInput2 != "N"))
        {
            if (questInput2 == "Y")
            {
                Console.Write($"\nВведите значение для первого числа: ");
                int changeNum1 = int.Parse(Console.ReadLine());
                Console.Write($"\nВведите значение для второго числа: ");
                int changeNum2 = int.Parse(Console.ReadLine());
                nums.Change(changeNum1, changeNum2);
                break;
            }
            else
            {
                break;
            }
        }

        Console.Write($"Сумма чисел равна: ");
        nums.Sum();
        Console.Write($"\nБольшее из двух чисел является число: ");
        nums.FindMore();
    }
}

