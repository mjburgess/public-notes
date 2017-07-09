# CHAPTER:    Functions
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Write functions for handling user login.  
# TIME:       15m
import random


def login(username, password):
    if password == 'test':
        print(username, 'ALLOWED')
    else:
        print(username, 'DENIED')


def make_password():
    return random.choice(['test', 'guest'])


# Q. call the login function again, 
# this time specify the password first then the username.
# HINT: pass the arguments by keyword

login(password=make_password(), username='sherlock')

# Q. define a list called details with two elements. 
# ... the first element should be a username, the second the correct password, 'test'.
# call your login function using this list.
# HINT: use the unpacking star

details = ['watson', 'test']
login(*details)


# Q. define a function called profile which defines two arguments, 
# ... a username and accepts a variable number of named arguments.
# ... this function should print the username then loop over the remainder

def profile(username, **info):
    print(username)
    for data in info:
        print(data, info[data])


# Q. call your profile function, try:
profile('test', age=27, height=1.81, fav_colour='purple')


# Q. Define two functions, print_details and change_details.
# ... print_details should print your details variable defined earlier.
# ... change_details should modify your details variable, changing each element so that it is uppercase.

def print_details():
    print(details)


def change_details():
    details[0] = details[0].upper()
    details[1] = details[1].upper()


# Q. change_details() then print_details()
change_details()
print_details()

# PUZZLE
# Q. use map() and lambda to make every element of details uppercase.



""" REVIEW

What did we learn from this exercise?

f(*l)  calls as  f(l[0], l[1], l[2]) etc. ie., unpacks list into postn arguments 
f(**d) calls as f(name=d['name'], arg=d['arg']) etc., ie. unpacks dicts into named arguments 

functions can read identifiers from their parent namespace
if identifiers refer to mutable objects, they can modify their parent namespace

can pass arguments out-of-order if named 
"""


''' OUTPUT (08.Functions/Solution8-FunctionsB-Calling.py):
sherlock ALLOWED
watson ALLOWED
test
height 1.81
fav_colour purple
age 27
['WATSON', 'TEST']

'''
