test_cases = int(input())

for _ in range(test_cases):
    a, b = [ int(_) for _ in input().split(" ") ]
    
    count = 0
    for index in range(b):
        if index ** 2 >= a and index ** 2 <= b:
            count += 1
        if index ** 2 > b:
            break
    print(count)
