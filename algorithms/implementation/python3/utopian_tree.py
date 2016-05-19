#!/bin/python3

import sys

t = int(input().strip())
for a0 in range(t):
    n = int(input().strip())

    height = 1
    
    for _ in range(n // 2):
        height = height * 2 + 1
    if n % 2 == 1:
        height = height * 2
            
    print(height)
