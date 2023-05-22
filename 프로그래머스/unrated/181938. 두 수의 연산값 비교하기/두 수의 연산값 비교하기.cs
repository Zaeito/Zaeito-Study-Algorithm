using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        String a1 = a.ToString();
        String b1 = b.ToString();
        String temps = String.Concat(a1,b1);
        int tempi = int.Parse(temps);
        if(tempi > (2 * a * b))
        {
            answer = tempi;
        }
        else
        {
            answer = 2 * a * b;
        }
        return answer;
    }
}