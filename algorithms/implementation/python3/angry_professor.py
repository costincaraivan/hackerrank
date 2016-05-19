#!/bin/python3

import sys


t = int(input().strip())
for a0 in range(t):
    n, k = input().strip().split(' ')
    n, k = [int(n),int(k)]
    a = [int(a_temp) for a_temp in input().strip().split(' ')]
    
    arrived_on_time = 0
    for student_arrival in a:
        if student_arrival <= 0:
            arrived_on_time += 1

    if arrived_on_time >= k:
        print("NO")
    else:
        print("YES")
