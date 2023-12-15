using System;

public class Solution {
    public long solution(string numbers) {
        long answer = 0;
        string[] number = new String[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        
        for(int i = 0; i < number.Length; i++)
        {
            numbers = numbers.Replace(number[i], i.ToString());
        }
        answer = long.Parse(numbers);
        return answer;
    }
}