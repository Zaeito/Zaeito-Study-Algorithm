def solution(intStrs, a, b, c):
    answer = []
    
    for i in intStrs:
        if int(i[b:b+c]) > a:
            answer.append(int(i[b:b+c]))
    
    return answer