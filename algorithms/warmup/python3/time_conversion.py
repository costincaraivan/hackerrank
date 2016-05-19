#!/bin/python3

import sys

time = input().strip()

# 12AM = 00:00
# 12PM = 12:00
# 01PM = 13:00

meridian = time[-2:]
time = time[:-2]
hour, minute, second = time.split(":")
hour = int(hour, 10)

if meridian == "PM":
    if hour != 12:
        hour += 12
else:
    if hour == 12:
        hour = 0

print("{:0>2d}:{}:{}".format(hour, minute, second))
