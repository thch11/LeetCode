public class Solution
{
    public int MySqrt(int x)
    {

        long i = 1;
        while (true)
        {
            if(i * i == x)
            {
                return Convert.ToInt32(i);
            }
            else if (x < i * i)
            {
                return Convert.ToInt32(i -1);
            }
            i++;
        }
    }
}
