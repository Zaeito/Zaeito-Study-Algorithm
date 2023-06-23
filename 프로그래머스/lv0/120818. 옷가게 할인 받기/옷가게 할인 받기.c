#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int price) {
    int answer = 0;
    if(price >= 500000)
    {
        answer = (float)price - ((float)price/5);
    }
    else if(price >= 300000)
    {
        answer = (float)price - ((float)price/10);
    }
    else if(price >= 100000)
    {
        answer = (float)price - ((float)price/20);
    }
    else
    {
        answer = price;
    }
    
    return answer;
}