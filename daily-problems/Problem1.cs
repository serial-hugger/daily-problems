using System.Globalization;

namespace daily_problems;

/*
Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
   
For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
   
Bonus: Can you do this in one pass?
 */

public class Problem1
{
    public static bool CheckForPair(List<int> numbers, int k)
    {
        int i1 = 0;
        int i2 = 0;
        foreach (var number1 in numbers)
        {
            i2 = 0;
            foreach (var number2 in numbers)
            {
                if (number1 + number2 == k && i1!=i2)
                {
                    return true;
                }
                i2++;
            }
            i1++;
        }

        return false;
    }
}