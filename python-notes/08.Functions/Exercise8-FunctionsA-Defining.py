# CHAPTER:    Functions
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Describe the processes involved in going shopping.
# TIME:       15m

# Q. write a login function which takes two arguments,
# a username and a password.
# if the password is 'test'
# then print username, "ALLOWED"
# otherwise print, username DENIED


# Q. define a function called make_password
# which randomly returns either 'test' or 'guest'
# HINT: import random
# HINT: return random.choice(['test', 'guest'])

# Q. add a documentation string to this function which describes what it does


# Q. call your login function several times, supplying a username and a password. 
# ... the password should be given by your password function.


# EXTRA: 
def basket(contents=[]):
    contents.append('Leaflet')  # every basket gets a leaflet

    return contents


basket()
basket()

# Q. What gets printed? Why?
print(basket())

# Q. Modify the defintion of basket() to produce the expected output.


''' OUTPUT (08.Functions/Exercise8-FunctionsA-Defining.py):
['Leaflet', 'Leaflet', 'Leaflet']

'''
