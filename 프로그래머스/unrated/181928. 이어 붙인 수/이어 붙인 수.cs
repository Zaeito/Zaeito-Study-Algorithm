using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        string odd = "";//홀수
        string even = "";//짝수
        string temp = "";
        for(int i = 0; i < num_list.Length; i++)
        {
            if(num_list[i] % 2 == 0)//짝수
            {
                temp = num_list[i].ToString();
                even = String.Concat(even,temp);
                temp = "";
            }
            else//홀수
            {
                temp = num_list[i].ToString();
                odd = String.Concat(odd,temp);
                temp = "";
            }
        }
        answer = int.Parse(even) + int.Parse(odd);
        return answer;
    }
}