import sys;
import os;
def GetFactorialTerm (n):
    if n < 2:
        return n;
    return GetFactorialTerm(n-2) + GetFactorialTerm(n-1);
print(GetFactorialTerm(int(sys.argv[1])));
