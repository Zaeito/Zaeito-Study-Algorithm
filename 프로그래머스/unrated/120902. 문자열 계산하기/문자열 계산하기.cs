using System;

public class Solution {
    public int solution(string my_string) {
        string[] str = my_string.Split(" ");
        int answer = int.Parse(str[0]);
        
        for(int i = 1; i < str.Length; i++)
        {
            if(i % 2 != 0)
            {
                if(str[i].Equals("+"))//+ 인지 - 인지 판단
                {
                    answer += int.Parse(str[i + 1]);
                }
                else
                {
                    answer -= int.Parse(str[i + 1]);
                }
            }    
        }
        return answer;
    }
}