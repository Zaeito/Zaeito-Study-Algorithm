using System;

public class Solution {
    public string solution(string str1, string str2) {
        string answer = "";
        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();
        char[] arr3 = new char[arr1.Length*2];
               
        for(int i=0; i<arr1.Length*2; i++)
        {
            if(i%2 == 0)
            {
                arr3[i] = arr1[i/2];
            }
            else if(i%2 == 1)
            {
                arr3[i] = arr2[i/2];
            }
        }
        string str3 = new string(arr3);
        answer = str3;
        return answer;
    }
}