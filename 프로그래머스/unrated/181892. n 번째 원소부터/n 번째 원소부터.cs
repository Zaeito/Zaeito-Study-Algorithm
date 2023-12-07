using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length - n + 1];
        answer = num_list.Skip(n - 1).ToArray();
        return answer;
    }
}