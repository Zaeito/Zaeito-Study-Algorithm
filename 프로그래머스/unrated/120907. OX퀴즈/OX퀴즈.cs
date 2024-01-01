using System;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.Length];
        for(int i = 0; i < quiz.Length; i++)
        {
            answer[i] = ox(quiz[i].Split(" "));
        }
        return answer;
    }
    
    public string ox(string[] str)
    {
        int num = int.Parse(str[0]);
        
        for(int i = 1; i < str.Length; i++)
        {
            if(i % 2 != 0)
            {
                if(str[i].Equals("+"))
                {
                    num += int.Parse(str[i + 1]);
                }
                else if(str[i].Equals("-"))
                {
                    num -= int.Parse(str[i + 1]);
                }
                else
                {
                    if(int.Parse(str[i + 1]) == num)
                    {
                        return "O";
                    }
                    else
                    {
                        return "X";
                    }
                }
            }
        }        
        return "";
    }
}