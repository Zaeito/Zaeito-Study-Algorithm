using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> temp = new List<int>();
        
        for(int i=0; i<arr.Length; i++)
        {
            if(temp.Count==0)
            {
                temp.Add(arr[i]);
            }
            else
            {
                if(temp[temp.Count-1]<arr[i])
                {
                    temp.Add(arr[i]);
                }else
                {
                    temp.RemoveAt(temp.Count -1);
                    i--;                  
                }
            }           
        }        
        return temp.ToArray();
    }
}