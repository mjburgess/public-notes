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

# Q. define a list called details with two elements. 
# ... the first element should be a username, the second the correct password, 'test'.
# call your login function using this list.
# HINT: use the unpacking star

# Q. define a function called profile which defines two arguments, 
# ... a username and accepts a variable number of named arguments.
# ... this function should print the username then loop over the remainder


# Q. call your profile function, try:
# profile('test', age=27, height=1.81, fav_colour='purple')


# Q. Define two functions, print_details and change_details.
# ... print_details should print your details variable defined earlier.
# ... change_details should modify your details variable,
# changing each element so that it is uppercase.

# Q. change_details() then print_details()


''' OUTPUT (08.Functions/Exercise8-FunctionsB-Calling.py):

'''
