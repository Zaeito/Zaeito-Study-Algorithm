def solution(b, c):
    answer = []
    for a in range(b, c+1):
        if not set(str(a)) - {'0','5'}:
            answer.append(a)
    return answer if answer else [-1]