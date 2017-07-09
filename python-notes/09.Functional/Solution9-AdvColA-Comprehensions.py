# CHAPTER:    Advanced Collections
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Analyse a list of fictional characters. 
# TIME:       15m

# Q. starting with the lists names and ages..

names = ['Sherlock Holmes', 'John Watson', 'John Adler', 'Irene Adler']
ages = list(range(20, 30))

# 1. produce a new list, upper_names, of uppercased names 
new_list = [n.upper() for n in names]

# 2. produce a new list, twice_ages, of doubled ages 
twice_ages = [a * 2 for a in ages]

# 3. produce a new list, first_names, of just the first names
first_names = [name.split()[0] for name in names]

# 4. produce a new list, is_adler, of bools where True if person is an Adler
is_adler = ['Adler' in name for name in names]

# ...and other ways...
is_adler = [name.split()[1] == 'Adler' for name in names]

# PUZZLES

# Q. what do the following comprehensions produce? Why?
a = ['{1}, {0}'.format(*name.split()) for name in names]
b = [age * 2 for age in ages if 20 < age < 25]
c = {n: a for n, a in zip(names, ages)}
d = {n.split()[0] for n in names}
e = {n.split()[1] for n in names}

# EXTRA
# Q. create a range from 0 to 5
five = list(range(0, 5))

# Q. transform that range to a list of '.' (dots)
dots = ['.' for _ in five]

# Q. join each element on a space, and print it out
# .. ie., so that you're printing a string of dots
print(' '.join(dots))
print()

# Q. transform a range(5) again, instead of '.' for every element, have your previous list, call this grid
# ... that is, every element of five should now be a list of dots
grid = [dots for _ in five]

# Q. write this in one line, without using any intermediate variables (ie. nest for-comprehensions)
grid = [['.' for _ in range(0, 5)] for _ in range(0, 5)]

# Q. join this grid: each row should be joined together by ' ', and all the rows by \n
# HINTS:
# start by transforming your list of lists (grid) into a single list of strings
# then join these with a newline

rows = [' '.join(row) for row in grid]
print('\n'.join(rows))

""" REVIEW

What did we learn from this exercise?

syntax:
new_list = [ expression(old_element) for old_element in old_list ]


with "guards"
new_list = [ expression(old_element) for old_element in old_list if test_on_element(old_list) ]


comprehensions are translations from old data to new data by appling 
a transformation to each element of old to make a new 
"""


''' OUTPUT (09.Functional/Solution9-AdvColA-Comprehensions.py):
. . . . .

. . . . .
. . . . .
. . . . .
. . . . .
. . . . .

'''
