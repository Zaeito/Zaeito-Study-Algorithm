using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 2;
        foreach(string dicA in dic)
        {
            bool what = true;
            foreach(string spellA in spell)
            {
                if(dicA.IndexOf(spellA) == -1)
                {
                    what = false;
                    break;
                }
            }
            if(what == true)
            {
                answer = 1;
                break;
            }
        }
        return answer;
    }
}