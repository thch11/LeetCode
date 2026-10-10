public class Solution {
    public int IsWinner(int[] player1, int[] player2) 
    {
        int player1sum = 0;
        int player2sum = 0;
        int multi = 0;
        for(int i = 0; i < player1.Length; i++)
        {
            bool MultiAchieved = false;
            if(player1[i] == 10)
            {
                MultiAchieved = true;
            }
            if(0 < multi)
            {
                player1sum += (player1[i] * 2);
                multi--; 
            }
            else
                player1sum += player1[i];
            if(MultiAchieved)
                multi = 2;
        }
        multi = 0;
        for(int i = 0; i < player2.Length; i++)
        {
            bool MultiAchieved = false;
            if(player2[i] == 10)
            {
                MultiAchieved = true;
            }
            if(0 < multi)
            {
                player2sum += (player2[i] * 2);
                multi--; 
            }
            else
                player2sum += player2[i];
            if(MultiAchieved)
                multi = 2;
        }

        if(player1sum < player2sum)
            return 2;
        else if(player2sum < player1sum)
            return 1;
        else
            return 0;

        
    }
}
//https://leetcode.com/problems/determine-the-winner-of-a-bowling-game
