#!/bin/python3

import sys


t = int(input().strip())
for a0 in range(t):
    n, c, m = input().strip().split(' ')
    n, c, m = [int(n),int(c),int(m)]
    
    total_chocolates_bought = n // c    
    chocolates_bought = total_chocolates_bought

    wrappers_left = 0
    while(chocolates_bought >= m):
        total_chocolates_bought += (chocolates_bought // m)
        wrappers_left = chocolates_bought % m
        chocolates_bought = (chocolates_bought // m) + wrappers_left
    
    print(total_chocolates_bought)
