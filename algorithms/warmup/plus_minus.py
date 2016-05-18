#!/bin/python3

import sys


n = int(input().strip())
arr = [int(arr_temp) for arr_temp in input().strip().split(' ')]

positives = 0
negatives = 0
for _ in arr:
    if _ > 0:
        positives += 1
    elif _ < 0:
        negatives += 1
print('{:4f}'.format(positives / n))
print('{:4f}'.format(negatives / n))
print('{:4f}'.format((n - positives - negatives) / n))
