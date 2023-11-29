using System;
using System.Linq;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        before = String.Concat(before.OrderBy(ch=>ch));
        after = String.Concat(after.OrderBy(ch=>ch));
        if(before == after)
        {
            answer = 1;
        }
        else
        {
            answer = 0;
        }
        return answer;
    }
}