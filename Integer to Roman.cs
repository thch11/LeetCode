public class Solution {
    public string IntToRoman(int num) 
    {
        string output = "";
        while(num >= 1000)
        {
            output += "M";
            num -= 1000;
        }
        if(num > 899 && num < 1000)
        {
            output += "CM";
            num -= 900;
        }
        if(num >= 500)
        {
            output += "D";
            num -= 500;
        }
        if(num > 399 && num < 500)
        {
            output += "CD";
            num -= 400;
        }
        while(num >= 100)
        {
            output += "C";
            num -= 100;
        }
        if(num > 89 && num < 100)
        {
            output += "XC";
            num -= 90;
        }
        if(num >= 50)
        {
            output += "L";
            num -= 50;
        }
        if(num > 39 && num < 50)
        {
            output += "XL";
            num -= 40;
        }
        while(num >= 10)
        {
            output += "X";
            num -= 10;
        }
        if(num == 9)
        {
            output += "IX";
            return output;
        }
        if(num >= 5)
        {
            output += "V";
            num -= 5;
        }
        if(num == 4)
        {
            output += "IV";
            return output;
        }
        while(num > 0)
        {
            output += "I";
            num--;
        }
        return output;        
    }
}
//https://leetcode.com/problems/integer-to-roman/
