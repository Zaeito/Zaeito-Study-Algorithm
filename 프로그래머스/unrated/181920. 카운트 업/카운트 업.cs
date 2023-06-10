using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int start, int end) {
        List<int> answer = new List<int>();
        
        for (int i = start; i <= end; i++)
        {
            answer.Add(i);
        }
        return answer.ToArray();
    }
}