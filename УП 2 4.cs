using System;

public class Task4
{
    static void Main()
    {
        String numStringVersion = "MCXLIX";
        char[] numCharVersion = numStringVersion.ToCharArray();
        int count = 0;
        
        for (int i = 0; i < numCharVersion.Length; i++)
        {
            if (numCharVersion[i] == 'I') //I-----------------------------
            {
                if ((i < numCharVersion.Length - 1) && 
                    (numCharVersion[i + 1] == 'V'))
                {
                    count += 4;
                    i++;
                }
                else if ((i < numCharVersion.Length - 1) &&
                         (numCharVersion[i + 1] == 'X'))
                {
                    count += 9;
                    i++;
                }
                else
                {
                    count += 1;
                }
            }
            else if (numCharVersion[i] == 'V') //V-------------------------
            {
                count += 5;
            }
            else if (numCharVersion[i] == 'X') //X-------------------------
            {
                if ((i < numCharVersion.Length - 1) && 
                    (numCharVersion[i + 1] == 'L'))
                {
                    count += 40;
                    i++;
                }
                else if ((i < numCharVersion.Length - 1) && 
                         (numCharVersion[i + 1] == 'C'))
                {
                    count += 90;
                    i++;
                }
                else
                {
                    count += 10;
                }
            }
            else if (numCharVersion[i] == 'L') //L-------------------------
            {
                count += 50;
            }
            else if (numCharVersion[i] == 'C') //I-------------------------
            {
                if ((i < numCharVersion.Length - 1) && 
                    (numCharVersion[i + 1] == 'D'))
                {
                    count += 400;
                    i++;
                }
                else if ((i < numCharVersion.Length) && 
                         (numCharVersion[i + 1] == 'M'))
                {
                    count += 900;
                    i++;
                }
                else
                {
                    count += 100;
                }
            }
            else if (numCharVersion[i] == 'D') //D-------------------------
            {
                count += 500;
            }
            else if (numCharVersion[i] == 'M') //M-------------------------
            {
                count += 1000;
            }
        }
        Console.Write(count);
    }
}