# CHAPTER:    Advanced Collections
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Analyse a list of fictional characters. 
# TIME:       15m

# Q. starting with the lists names and ages..

names = ['Sherlock Holmes', 'John Watson', 'John Adler', 'Irene Adler']
ages = list(range(20, 30))

# Q. produce a new list, upper_names, of uppercased names
# Q. produce a new list, twice_ages, of doubled ages
# Q. produce a new list, first_names, of just the first names
# Q. produce a new list, is_adler, of bools where True if person is an Adler


# PUZZLES

# Q. what do the following comprehensions produce? Why?
a = ['{1}, {0}'.format(*name.split()) for name in names]
b = [age * 2 for age in ages if 20 < age < 25]
c = {n: a for n, a in zip(names, ages)}
d = {n.split()[0] for n in names}
e = {n.split()[1] for n in names}


# EXTRA
# Q. create a range from 0 to 5

# Q. transform that range to a list of '.' (dots)

# Q. join each element on a space, and print it out
# .. ie., so that you're printing a string of dots

# Q. transform a range(5) again, instead of '.' for every element, have your previous list, call this grid
# ... that is, every element of five should now be a list of dots

# Q. write this in one line, without using any intermediate variables (ie. nest for-comprehensions)

# Q. join this grid: each row should be joined together by ' ', and all the rows by \n
# HINTS:
# start by transforming your list of lists (grid) into a single list of strings
# then join these with a newline


''' OUTPUT (09.Functional/Exercise9-AdvColA-Comprehensions.py):

'''
