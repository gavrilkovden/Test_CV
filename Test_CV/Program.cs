﻿using Test_CV;

class Program
{
    static void Main()
    {
        List<int> inputNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        NumberReplacer replacer = new NumberReplacer(inputNumbers);
        List<object> outputNumbers = replacer.ReplaceNumbers();

        foreach (var item in outputNumbers)
        {
            Console.WriteLine(item);
        }
    }
}
