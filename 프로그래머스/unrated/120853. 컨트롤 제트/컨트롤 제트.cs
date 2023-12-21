using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        string[] temp = s.Split(" ");
        int index = 0;
        
        for(int i = 0; i < temp.Length; i++)
        {
            if(temp[i] == "Z")
            {
                if(index == 0)
                {
                    continue;
                }
                index--;
                answer -= int.Parse(temp[index]);
            }
            else
            {
                answer += int.Parse(temp[i]);
                index = i + 1;
            }
        }
        return answer;
    }
}