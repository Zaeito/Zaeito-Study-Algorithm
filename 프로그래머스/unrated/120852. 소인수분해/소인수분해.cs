using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        List<int> temp = new List<int>();
        for(int i = 2; i <= n; i++)
        {
            while(n % i == 0)
            {
                temp.Add(i);
                n /= i;
            }
        }
        int[] answer = temp.Distinct().ToArray();
        return answer;
    }
}