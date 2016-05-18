#!/bin/python3

import sys


n = int(input().strip())

for i in range(n):
    line = ""
    for j in range(n):        
        if j < (n - i - 1):
            line = line + " "
        else:
            line = line + "#"
    print(line)
