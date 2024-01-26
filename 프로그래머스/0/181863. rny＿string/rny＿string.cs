using System;

public class Solution {
    public string solution(string rny_string) {
        string answer = "";
        for(int i = 0; i < rny_string.Length; i++)
        {
            if(rny_string[i].ToString() == "m")
            {
                answer = String.Concat(answer,"rn");
            }
            else
            {
                answer = String.Concat(answer,rny_string[i]);
            }
        }
        return answer;
    }
}