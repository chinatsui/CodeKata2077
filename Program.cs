using System;
using CodeKata2077.Algorithm.DP;
using CodeKata2077.LeetCode;
using CodeKata2077.LeetCode.Entity;

Runner.RunMedium1234();
Console.ReadLine();

static class Runner
{
    public static void RunMedium1234()
    {
        Utils.Show(Medium1234.BalancedString("ERERQQQQQQQQQQQQQQWWWWEE"));
    }
    public static void RunLevenshteinDistance()
    {
        string strA = "mitcmu";
        string strB = "mtacnuss";
        Utils.Show(LevenshteinDistance.Calculate(strA, strB));
    }

    public static void RunEasy1() 
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        Utils.Show(Easy1.TwoSum(nums, target));
    }

    public static void RunMedium2() 
    {
        ListNode num1 = ListNode.Deserialize(2, 4, 3);
        ListNode num2 = ListNode.Deserialize(5, 6, 4);
        ListNode result = Medium2.AddTwoNumbers(num1, num2);
        Utils.Show(ListNode.Serialize(result));
    }

    public static void RunEasy2042() 
    {
        Utils.Show(Easy2042.AreNumbersInAscending("1 box has 3 blue 4 red 6 green and 12 yellow marbles"));
    }

    public static void RunMedium2023() 
    {
        string[] nums = { "777", "7", "77", "77" };
        string target = "7777";
        Utils.Show(Medium2023.NumOfPairs(nums, target));
    }
}

static class Utils 
{
    public static void Show(object value) 
    {
        Console.WriteLine(value);
    }
}
