def solution(arr, queries):
    result = []
    for query in queries:
        temp = []
        for i in range(query[0], query[1] + 1):
            if arr[i] > query[2]:
                temp.append(arr[i])
        try:   
            result.append(min(temp))
        except:
            result.append(-1)
    return result