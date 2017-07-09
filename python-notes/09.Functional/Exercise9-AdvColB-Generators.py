# CHAPTER:    Advanced Collections
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Write a version of xrange() that handles floating-point numbers.
# TIME:       15m

# Q. implement a version of xrange() called frange() with the following signature:

def frange(start, stop, step=0.25):
    pass

# test with the following... 

print(list(frange(1, 3)))
print(list(frange(1, 3, 0.33)))
print(list(frange(1, 3, 1)))  # should print [1.0, 2.0]
print(list(frange(3, 1)))  # should print an empty list
print(list(frange(-1, -0.5, 0.1)))

for num in frange(3.142, 12):
    print("{:05.2f}".format(num))

# EXTRA

# the range function allows a single argument to be supplied
# which signifies the end of the sequence,
# the start then defaults to zero, and the step defaults as before.

# Q. implement this in your frange function


# testing:
one = list(frange(0, 3.5, 0.25))
two = list(frange(3.5))

if one == two:
    print("defaults worked!")
else:
    print("oops!")
    print("one:", one)
    print("two:", two)


''' OUTPUT (09.Functional/Exercise9-AdvColB-Generators.py):

'''
