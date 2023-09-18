using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        char[] arr1 = my_string.ToCharArray();
        char[] arr2 = new char [arr1.Length * n];
        
        for(int i = 0 ;i < arr1.Length * n;i++)
        {
            for(int j = 1;j < n;j++)
            {
                arr2[i] = arr1[i/n];
            }
        }
        string str = new string(arr2);
        answer = str;
        return answer;
    }
}