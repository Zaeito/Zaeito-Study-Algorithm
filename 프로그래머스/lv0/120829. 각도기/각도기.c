#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int angle) {
    int answer = 0;
    if(angle>0 && angle<90)
    {
        answer = 1;
        return answer;
    }
    else if(angle == 90)
    {
        answer = 2;
        return answer;
    }
    else if(angle>90 && angle<180)
    {
        answer = 3;
        return answer;
    }
    else
    {
        answer = 4;
        return answer;
    }
    
}