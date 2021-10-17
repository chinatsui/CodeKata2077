using System;
using CodeKata2077.LeetCode;

// Easy 2042
Utils.Show(new Easy2042().AreNumbersInAscending("1 box has 3 blue 4 red 6 green and 12 yellow marbles"));

// Medium 2023
string[] nums = { "777", "7", "77", "77" };
string target = "7777";
Utils.Show(new Medium2023().NumOfPairs(nums, target));

// The class with a set of utility methods.
static class Utils 
{
    public static void Show(object value) 
    {
        Console.WriteLine(value);
    }
}
