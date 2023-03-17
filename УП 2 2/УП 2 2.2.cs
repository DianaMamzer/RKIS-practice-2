using System;
using System.Collections.Generic;

public class Task2_2
{
    public class Train
    {
        private string stantion;
        public int num
	{
	    get;
	    private set;
        }
        private DateTime depatureTime;
        public void PrintInfo()
        {
            Console.WriteLine($"Станция: {this.stantion} \n№ поезда: {this.num} \nВремя отправления: {this.depatureTime}");
        }
        public Train(string stantion, int num, DateTime depatureTime)
        {
            this.stantion = stantion;
            this.num = num;
            this.depatureTime = depatureTime;
        }
    }

    static void Main()
    {
        List<Train> trains = new List<Train>()
        {
            new Train("Москва", 1, new DateTime(year : 2023, month : 03, day : 08, hour: 11, minute : 00, second : 00)),
            new Train("Санкт-Петербург", 2, new DateTime(year : 2023, month : 04, day : 13, hour: 14, minute : 30, second : 00)),
            new Train("Томск", 3, new DateTime(year : 2023, month : 05, day : 17, hour: 10, minute : 45, second : 00))
        };
        Console.Write($"Введите номер поезда: ");
        int itemNum = int.Parse(Console.ReadLine());
        foreach(Train train in trains)
        {
            if (train.num == itemNum)
                train.PrintInfo();
        }
    }
}