# CHAPTER:    Advanced Types
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Use python's types to change its objects.  
# TIME:       10m

# Q. use the str type to uppercase "Hello World!", print it
print(str.upper('Hello World'))

# Q. use the __len__ method of "Hello World!" to print its length
print(str.__len__('Hello World'))

# Q. use the __add__ method of 1 to add it to 3, print the result 
# HINT: to access methods on its, wrap them in parens: (1)
print((1).__add__(3))

# Q. use the __add__ method of the int type to add 2 and 3 
print(int.__add__(2, 3))

# EXTRA 
# Q. str.__dict__ is the namespace of str
# use str.__dict__ to uppercase "Hello World!"
print(str.__dict__['upper']('Hello World'))

""" REVIEW
What did we learn from this exercise?
"""


''' OUTPUT (11.OO/Solution11-AdvancedTypes.py):
HELLO WORLD
11
4
5
HELLO WORLD

'''
