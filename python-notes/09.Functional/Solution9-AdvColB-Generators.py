# CHAPTER:    Advanced Collections
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Write a version of xrange() that handles floating-point numbers.
# TIME:       15m


# implement a version of xrange() called frange() with the following signature:
# frange(start, stop, step=0.25)

def frange(start, stop, step=0.25):
    curr = float(start)

    while curr < stop:
        yield curr
        curr += step


# test with the following... 

print(list(frange(1, 3)))
print(list(frange(1, 3, 0.33)))
print(list(frange(1, 3, 1)))  # should print [1.0, 2.0]
print(list(frange(3, 1)))  # should print an empty list
print(list(frange(-1, -0.5, 0.1)))

for num in frange(3.142, 12):
    print("{:05.2f}".format(num))


# EXTRA:
# the range function allows a single argument to be supplied which signifies the end of the sequence, the start then defaults to zero, and the step defaults as before.
# Q. implement this in your frange function

def frange(start, stop=None, step=0.25):  # NB. redefintion of any identifier is valid 
    if stop is None:
        stop = start
        curr = 0.0
    else:
        curr = float(start)

    while curr < stop:
        yield curr
        curr += step


one = list(frange(0, 3.5, 0.25))
two = list(frange(3.5))

if one == two:
    print("defaults worked!")
else:
    print("oops!")
    print("one:", one)
    print("two:", two)

""" REVIEW

What did we learn from this exercise?

yield 
list(gen) -- converts gen to list 

generators are 'stopped functions', or, functiinos with memory
"""


''' OUTPUT (09.Functional/Solution9-AdvColB-Generators.py):
[1.0, 1.25, 1.5, 1.75, 2.0, 2.25, 2.5, 2.75]
[1.0, 1.33, 1.6600000000000001, 1.9900000000000002, 2.3200000000000003, 2.6500000000000004, 2.9800000000000004]
[1.0, 2.0]
[]
[-1.0, -0.9, -0.8, -0.7000000000000001, -0.6000000000000001, -0.5000000000000001]
03.14
03.39
03.64
03.89
04.14
04.39
04.64
04.89
05.14
05.39
05.64
05.89
06.14
06.39
06.64
06.89
07.14
07.39
07.64
07.89
08.14
08.39
08.64
08.89
09.14
09.39
09.64
09.89
10.14
10.39
10.64
10.89
11.14
11.39
11.64
11.89
defaults worked!

'''
