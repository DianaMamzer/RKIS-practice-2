using System;
using System.Collections.Generic;

public class Task3_3
{
    public class Calculation
    {
        private string calculationLine;
        public void SetCalculationLine(string line)
        {
            calculationLine = line;
        }
        
        public string GetCalculationLine()
        {
            return calculationLine;
        }

        public void SetLastSymbolCalculationLine(char words)
        {
            calculationLine = calculationLine + words;
        }
        
        public char GetLastSymbol()
        {
            return calculationLine[calculationLine.Length - 1];
        }

        public void DeleteLastSymbol()
        {
            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
        }
    }

    static void Main()
    {
        Calculation calculation = new Calculation();
        calculation.SetCalculationLine("Мамзер");
        calculation.SetLastSymbolCalculationLine('D');
        Console.WriteLine(calculation.GetCalculationLine());
        Console.WriteLine(calculation.GetLastSymbol());
        calculation.DeleteLastSymbol();
        Console.WriteLine(calculation.GetCalculationLine());
    }
}