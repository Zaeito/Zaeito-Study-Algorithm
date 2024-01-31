def solution(arr, delete_list):
    answer = []
    for i in delete_list:
        try:
            arr.remove(i)
        except:
            pass
    return arr
    return answer