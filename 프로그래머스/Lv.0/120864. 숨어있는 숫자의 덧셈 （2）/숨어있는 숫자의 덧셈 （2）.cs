using System;

public class Solution {
    public int solution(string my_string) {
        string temp =my_string.ToLower();
        
        for (int i=0; i < temp.Length; i++)
        {
            if (temp[i] >= 'a' && temp[i]<='z')
            {
                temp = temp.Replace(temp[i],' ');
            }
        }
        
        string[] arr = temp.Split(" ");
        int sum = 0;
         for(int i=0; i<arr.Length; i++)
         {
             if (arr[i] != "")
             {
                 sum = sum + int.Parse(arr[i]);
             }
         }
        return sum;
    }
}