public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        IList<string> ReturnList = new List<string>();

        if (digits.Length == 0)
        {
            return ReturnList;
        }

        Dictionary<char, string> Phone = new Dictionary<char, string>();
        Phone.Add('2', "abc");
        Phone.Add('3', "def");
        Phone.Add('4', "ghi");
        Phone.Add('5', "jkl");
        Phone.Add('6', "mno");
        Phone.Add('7', "pqrs");
        Phone.Add('8', "tuv");
        Phone.Add('9', "wxyz");

        Generate(0,  "", digits, Phone, ReturnList);
        void Generate(int index, string current, string digits, Dictionary<char, string> Phone, IList<string> ReturnList)
        {
            if (current.Length == digits.Length)
            {
                Console.WriteLine(current);
                ReturnList.Add(current);
                return;
            }

            string choices = Phone[digits[index]];

            foreach (char letter in choices)
            {
                Generate(index + 1, current + letter, digits, Phone, ReturnList);
            }
        }
        return ReturnList;
    }
}
//https://leetcode.com/problems/letter-combinations-of-a-phone-number
//Jeg har skrevet koden selv, men må indrømme at AI har guidet mig lidt. Det er første gang jeg har arbejdet med recursion, så er stadig lidt stolt over at få det til at virke. 
