using System;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = new string[strArr.Length];
        string temp;
        for(int i = 0; i < strArr.Length; i++)
        {
            if(i % 2 == 0)//홀수번째(배역의 첫 인덱스는0이기 때문)
            {
                temp = strArr[i].ToLower();
                answer[i] = temp; 
            }
            else//짝수번째
            {
                temp = strArr[i].ToUpper();
                answer[i] = temp; 
            }
        }
        return answer;
    }
}