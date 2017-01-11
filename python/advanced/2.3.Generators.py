# 2.3.Generators.py

# 1. efficient (lazy) data structures


# compare

"""
print open('messier.txt').read()
"""

# with

"""
for line in open('messier.txt'):
    print line
"""

# in the first case the entire file is loaded into memory (using, eg. 1GB of RAM)
# in the second case only one line at a time is loaded into memory (using, eg., 1KB of RAM)


# in general, we would like this behaviour for abitary data structures
# that is, we would like to provide only one calculated item at a time --
# rather than calculating the entire data structure ahead of time, then iterating over that


# compare

lst = range(0, 10)

def next_number():
    return lst.pop()


print next_number()
print next_number()
print next_number()

# with

number = 0

def next_number_lazy():
    global number
    number += 1
    return number


print next_number_lazy()
print next_number_lazy()
print next_number_lazy()


# the behaviour of the functions is more important than their implementation

# next_number() returns increasing intergers but does so by returning from a pre-calculated list
# next_number_lazy() uses only one variable to store a present item and then calculates the next each call (by ++'ing)

# python has a special syntax for creating these lazy data-structures called generators...

# this defines a strange function...

def next_num():
    yield 9
    yield 8
    yield 7


# when you call it you get an object that can be iterated over
# on each iteration you get 9 then 8 then 7

print "WITH GENERATOR"
nn = next_num()         # calling the function produces a "generator object"

print type(nn)

# we can call "next()" explicity on the generator to produce each value in turn

print next(nn)
print next(nn)
print next(nn)      # the generator is exhausted when all of its yields are complete

# generator objects lazily calculate their next values -- using only one-value's worth of memory:

# or we can use the generator directly in a for-loop (which just calls next())
print "FOR LOOPS WITH GENERATORS"

for num in next_num():
    print num


# we do not often write an explicity yield for each value we want to return
# but typically yield within a loop.. this has the effect of having many yields..

def from_file():
    for line in open('messier.txt'):
        yield line.upper()


for line in from_file():
    print line



# ...or we can write,

g = (line.upper() for line in open('messier.txt' ))


# more on this next!


# https://github.com/crazyguitar/pysheeet/blob/master/docs/notes/python-generator.rst
