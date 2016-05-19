#!/bin/python3

import sys

n = int(input().strip())
a = []
for a_i in range(n):
    a_t = [int(a_temp) for a_temp in input().strip().split(' ')]
    a.append(a_t)

primary_diagonal_sum = 0
secondary_diagonal_sum = 0
for i in range(n):
    primary_diagonal_sum += a[i][i]
    secondary_diagonal_sum += a[i][n - i - 1]
print(abs(primary_diagonal_sum - secondary_diagonal_sum))
