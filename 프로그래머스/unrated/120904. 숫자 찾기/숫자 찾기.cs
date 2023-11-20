using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = 0;
        string temp = num.ToString();
        string ks = k.ToString();
        for(int i = 0; i < temp.Length; i++)
        {
            if(temp[i].ToString() == ks)
            {
                answer = i+1;
                break;
            }
            else
            {
                answer = -1;
            }
        }
        return answer;
    }
}