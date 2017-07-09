# CHAPTER:    Functions
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Describe the proceeses involved in going shopping. 
# TIME:       15m

# Q. write a login function which takes two arguments, a username and a password.
# ... if the password is 'test' then print username,"ALLOWED" otherwise print, username DENIED

def login(username, password):
    if password == 'test':
        print(username, 'ALLOWED')
    else:
        print(username, 'DENIED')


# Q. define a function called make_password which randomly returns either 'test' or 'guest'
# ... add a documentation string to this function which describes what it does
# HINT: import random
# HINT: return random.choice(['test', 'guest'])

import random


def make_password():
    return random.choice(['test', 'guest'])


# Q. call your login function several times, supplying a username and a password. 
# ... the password should be given by your password function.

login('sherlock', make_password())
login('sherlock', make_password())
login('sherlock', make_password())


# EXTRA: 
def basket(contents=[]):
    contents.append('Leaflet')  # every basket gets a leaflet

    return contents


basket()
basket()

# Q. What gets printed? Why?
print(basket())


# Q. Modify the definition of basket() to produce the expected output.
def basket(contents=None):
    if contents is None:
        contents = []

    contents.append('Leaflet')  # every basket gets a leaflet

    return contents


basket()
basket()

print(basket())

""" REVIEW

What did we learn from this exercise?

Default arguments are remembered at define-time. 

syntax: 

def func_name(IN):
    return OUT

foutput = func_name(finput)

random
.choice()


"""


''' OUTPUT (08.Functions/Solution8-FunctionsA-Defining.py):
sherlock ALLOWED
sherlock ALLOWED
sherlock ALLOWED
['Leaflet', 'Leaflet', 'Leaflet']
['Leaflet']

'''
