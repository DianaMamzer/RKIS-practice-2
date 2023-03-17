/*//1 задание.
using System;
class HelloWorld {
  static void Main() {
    int count = 0;
    String S = "ab";
    String J = "aabbccd";
    
    char[] chS = S.ToCharArray();
    char[] chJ = J.ToCharArray();
    
    for (int i = 0; i < chS.Length; i++)
    {
        for (int j = 0; j < chJ.Length; j++)
        {
            if (chS[i] == chJ[j])
            {
                count++;
            }
        }
    }
    Console.WriteLine(count);
  }
}*/




/*//2 задание
using System;
using System.Collections.Generic;
class HelloWorld {
    static void Main() {
        List<int> candidates = new List<int>(){3, 1, 2, 1, 2};
        List<int> result = new List<int>();
        int target = 5;
        
        for (int i = 0; i < candidates.Count; i++)
        {
            int temp = 0;
            result.Clear();
            for (int j = 0; j < candidates.Count; j++)
            {
                if (i != j)
                {
                    temp += candidates[j];
                    result.Add(candidates[j]);
                }
                if (temp > target)
                {
                    break;
                }
                else if (temp == target)
                {
                    for (int q = 0; q < result.Count; q++)
                    {
                        Console.Write($"{result[q]}\t");
                    }
                    Console.Write($"\n");
                }
            }
        }
    }
}*/



/*
//3 задание
using System;
class HelloWorld {
    static void Main() {
        const int N = 5;
        int[] nums = new int[N] { 8, 5, 9, 1, 2};
        int count = 0;
        
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if ((i != j) && (nums[i] == nums[j]))
                {
                    count++;
                }
            }
        }
        if (count > 0)
        {
            Console.WriteLine($"True");
        }
        else
        {
            Console.WriteLine($"False");
        }
        
    }
}
*/