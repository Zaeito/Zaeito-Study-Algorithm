using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        String temp = "";
        String storage ="";
        for(int i = 0; i < array.Length; i++)//int를 string로 변환
        {
            temp = String.Concat(temp,array[i].ToString());
        }
        for(int j = 0; j < temp.Length; j++)
        {   storage = temp[j].ToString();
            if(storage.ToString() == "7")
            {
                answer += 1;
                storage ="";
            }
        }
        return answer;
    }
}