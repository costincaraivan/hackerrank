#!/bin/python3

import sys

import itertools

t = int(input().strip())
for a0 in range(t):
    n = int(input().strip())

    length = n
    while(length % 3 !=0):
        length -= 5
    
    if length < 0:
        print(-1)
    else:
        print("{}{}".format(length * "5", (n - length) * "3"))
