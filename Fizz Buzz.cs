public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        IList<string> returnList = new List<string>();
        for (int i = 1; i < n + 1; i++)
        {
            if(i % 5 == 0 && i % 3 == 0 )
                returnList.Add("FizzBuzz");
            else if (i % 5 == 0)
                returnList.Add("Buzz");
            else if (i % 3 == 0)
                returnList.Add("Fizz");
            else
                returnList.Add(i.ToString());
        }
        returnList.Reverse();
        return returnList;
    }
}
//https://leetcode.com/problems/fizz-buzz/
