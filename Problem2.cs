namespace daily_problems;

/*
Given an array of integers, return a new array such that each element at index i of the new array
is the product of all the numbers in the original array except the one at i.
   
For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24].
If our input was [3, 2, 1], the expected output would be [2, 3, 6].
 */

public class Problem2
{
    public List<int> ReturnProductOfAllExcept(List<int> original)
    { 
        List<int> newList = new List<int>();
        for (int i = 0; i < original.Count;i++)
        {
            int currentIndex = 0;
            int currentAmount = 1;
            foreach (var number2 in original)
            {
                if (i != currentIndex)
                {
                    currentAmount *= number2;
                }
                currentIndex++;
            }
            newList.Add(currentAmount);
        }

        return newList;
    }
}