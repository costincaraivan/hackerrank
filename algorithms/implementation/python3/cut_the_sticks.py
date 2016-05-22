#!/bin/python3

import sys


n = int(input().strip())
arr = [int(arr_temp) for arr_temp in input().strip().split(' ')]

def positive_min(arr):
    if arr == None or len(arr) == 0:
        return None
    min = sys.maxsize
    for element in arr:
        if min > element and element > 0:
            min = element
    return min

count = len(arr)
while count != 0:
    shortened = 0
    min = positive_min(arr)
    for index in range(len(arr)):
        if arr[index] > 0:
            if arr[index] - min <= 0:
                count -= 1
            shortened += 1
        arr[index] -= min
    print(shortened)
