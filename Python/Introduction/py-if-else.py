#!/bin/python3

import math
import os
import random
import re
import sys

def isWeird(number):
    if number % 2 != 0 :
        return True
    else :
        if number >= 6 and number <= 20 :
            return True
        else: 
            return False

if __name__ == '__main__':
    n = int(input().strip())
    print("Weird" if isWeird(n) else "Not Weird")    
