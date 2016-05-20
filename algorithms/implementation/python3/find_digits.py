#!/bin/python3

import sys


t = int(input().strip())
for a0 in range(t):
    n = int(input().strip())

    count = 0
    digits = str(n)
    for digit in digits:
        if int(digit) != 0:
            if n % int(digit) == 0:
                count += 1
    print(count)
