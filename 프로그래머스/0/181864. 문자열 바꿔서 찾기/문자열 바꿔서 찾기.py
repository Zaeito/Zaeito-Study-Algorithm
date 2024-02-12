def solution(myString, pat):
    temp = "".join(["B" if char == "A" else "A" for char in myString])
    return 1 if pat in temp else 0