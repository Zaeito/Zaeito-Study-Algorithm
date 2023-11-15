using System;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        int index = 1;
        for(int i = 1; i <= cipher.Length / code; i++)
        {
            answer = String.Concat(answer,cipher[index * code - 1]);
            index +=1;
        }
        return answer;
    }
}