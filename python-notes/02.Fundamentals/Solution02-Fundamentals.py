# CHAPTER:    Fundamentals
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using strings, lists and dictionaries 
# ...         store and display information about yourself.
# TIME:       15m

# QUESTIONS

# Q. define a variable which refers to your name
name = "Sherlock Holmes"

# Q. define a title: your name concatenated to "'s Profile"
title = name + "'s Profile"

# Q. define a variable which refers to your height in cm
height = 181

# Q. define your ages as an integer number of whole years 
# plus a fraction of 12
# HINT:  if there is two months until your birthday, 
# ...     you're age is + ten twelvths
age = 30 + 7 / 12.0

# here we use input() to get a name from the user
first_name = input('First Name? ')

# Q. print the following:
# a) first_name
# b) first_name in upper case
# c) the number of characters in first_name
print(first_name)
print(first_name.upper())
print(len(first_name))

# Q. create a list of your hobbies
hobbies = ['Swimming', 'Photography']

# Q. print out this information and the last of your hobbies
# HINT: what is hobbies[-1] ?
print(hobbies[0], hobbies[1])
print(hobbies[-1])

# EXTRA
# Q. create a dictionary called 'me' with the keys: 
# name, height, age and hobbies
# and the values of the variables defined above 
me = {
    'name': name,
    'height': height,
    'age': age,
    'hobbies': hobbies
}

# Q. print out the name and age entires of me 
print(me['name'])
print(me['age'])

# PUZZLES 
a = 10
b = 0xA
c = 0b1010
d = 0o12

# Q. Without running the code, what is sum([a, b, c, d]) ?
# they are each different ways of writing ten, so sum == 40

""" REVIEW

What did we learn from this exercise?
    1. Simple variable assignment
    2. Floats need .0 , otherwise python will use integer division
    3. input() gets information from the user ('s keyboard)
    4. Lists are 0-indexed forwards and -1-indexed in reverse
    5. Dictionaries are comprised of keys and values. 
    6. Lists are integer indexed groups of values. 
    7. There are many ways of writing whole numbers (base-10, 16, 2, 8)
"""


''' OUTPUT (02.Fundamentals/Solution02-Fundamentals.py):
First Name? q
Q
1
Swimming Photography
Photography
Sherlock Holmes
30.583333333333332

'''
