using System;

public class Solution {
    public string solution(string polynomial) {
        string answer = "";
        string temp = "";
        string[] str = polynomial.Split(" ");
        int xin = 0;
        int num = 0;
        
        for(int i = 0; i < str.Length; i+=2)
        {
            if(str[i].Contains("x"))
            {
                temp = str[i].Replace("x", string.Empty);
                if(temp == "")
                {
                    xin += 1;
                }
                else
                {
                    xin += int.Parse(temp);
                }
            }
            else
            {
                num += int.Parse(str[i]);
            }
        }
        if(num == 0)
        {
            if(xin == 1)
            {
                answer = "x";
            }
            else
            {
                answer = xin.ToString() + "x";
            }
        }
        else
        {
            if(xin == 0)
            {
                answer = num.ToString();
            }
            else if(xin == 1)
            {
                answer = "x " + "+ " + num.ToString();
            }
            else
            {
                answer = xin.ToString() + "x " + "+ " + num.ToString();
            }
        }
        return answer;
    }
}