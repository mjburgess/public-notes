# FUNCTIONS


result = len("Michael")




# DATA

""" NOVICE ASIDE:

Why do we use each data type?

Integers  == whole numbers used for representing quantities. discrete data.
Strings   == textual data. 
Floats    == partial quantities, continuous data. 
"""

## Simple Data Types

# Q. how would you find out the type of these?

age = 27  # int
name = "Michael"  # str
height = 1.81  # float

# A. the type() function...

print(type(age))
print(type(name))
print(type(height))

## Integers 
ten = 0xA

print(ten)
print(hex(10))
print(bin(9))

""" NOVICE ASIDE:

Why do we use complex data types?

To group values.

Lists        == Sequence of values, one after the other. 
Dictionaries == Look up changable values, given known fixed values. 
"""

## Complex Data Types 
# nb., there'll be more on these later...


## LIST
# a list is defined with square brackets
names = ["Sherlock", "Moriarty", "Watson"]

# the first element of the list is available at position 0, the second at 1...
# you look up a position using the subscript [] operator
print(names[0])  # look up the element 0 in the list names

# the last element of the list is at -1
print(names[-1])

# equally you can think of lists as 0-indexed moving forwards
# and -1-indexed moving backwards, so that -2 is "Moriarty" in the list above


# strings are list-like (they behave like a list of characters)
detective = "Sherlock Holmes"

print(detective[-3])  # Q. if -1 is 's' what is -3?

# elements of lists can be over-written
names[1] = "Hudson"  # replace the second element with "Hudson"
# nb., first = 0, second = 1, third = 2, ... be careful!


print(names)

# finally, lists have a length which is just the number of elements they contain

print(len("Michael"))  # len() can be applied to any sequence which includes strings
print(len(names))  # and lists

print(names[0], names[1])  # Q. what does the comma do (in a print statement)?
# A. joins with a space



# as you have seen above using the subscript operator you can associate integers with values
# that is, you can lookup "Hudson" in the list names with the key 1 
# ie.,  mylist[key] = "value" -- asssociates key with "value"


## TUPLES 

# tuples as read-only versions of lists (ie., immutable sequences)
names = 'Sherlock', 'Watson'

print(names[0], names[1])

# ERROR:   names[0] = 'Irene'

# sometimes parentheses are put around tuple defintions..
cart = ('eggs', 'bacon', 'ham')  # but these are option.. it is the comma which creates the tuple

## DICTIONARIES
# dictionaries can associate other kinds of keys (non-integers, and especially strings) with values
professions = {  # nb., braces
    "detective": "sherlock",  # nb., colons and commas
    "doctor": "watson"
}

# Q. what type is professions?
# A. dict  -- the type of dictionaries

# Q. how do you look-up 'doctor' in professions ?
# A. use the subscript operator...

print(professions['doctor'])

# Q. how do you add new elements to a dictionary?
# A. use the subscript operator...


professions['mathematician'] = 'moriarty'

print(professions)


''' OUTPUT (02.Fundamentals/Demo02-01.3.Data.py):
<class 'int'>
<class 'str'>
<class 'float'>
10
0xa
0b1001
Sherlock
Watson
m
['Sherlock', 'Hudson', 'Watson']
7
3
Sherlock Hudson
Sherlock Watson
watson
{'detective': 'sherlock', 'doctor': 'watson', 'mathematician': 'moriarty'}

'''
