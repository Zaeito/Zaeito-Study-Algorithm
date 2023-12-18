using System;

public class Solution {
    public int solution(int balls, int share) {
        long answer = 1;
        int Index = 1;
        for(int i = share+1; i <= balls; i++)
        {
            answer = answer * i;
            answer = answer / Index;
            Index++;
        }        
        return (int)answer;
    }
}