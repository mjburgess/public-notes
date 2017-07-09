# CHAPTER:    Error Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using except, handle errors caused by an authentication processes.
# PROBLEM:    Using custom exceptions, define errors caused by an authentication processes.
# TIME:       20m

# PART 1 -- SYNTAX 

# Q. prevent the programming from terminating when setup_database() is called
# ... ie, use a try-except block to handle the error
# ... and print the error message given 

def setup_database(db):
    if len(db) == 0:
        raise ValueError("a database is required to have data")


try:
    setup_database({})
except ValueError as ve:
    print(ve)

print("still runnning...")


# Q. what kind of error occurs if you supply an integer for the argument?

# Q. call setup_database again with the argument 0 
# ... handle both error conditions


try:
    setup_database(0)
except TypeError as te:
    print(te)
except ValueError as ve:
    print(ve)

# PART 2 

# Q. define a YourOrganizationError which is a kind of Exception
class YourOrganizationError(Exception):
    pass


# Q. define an AuthenticationError which is also a YourOrganizationError
class AuthenticationError(YourOrganizationError):
    pass


# Q. define a function authenticate which accepts a username, a password , and a database 


# this function should call setup_database and then require the username/password arguments to be 'test' and 'pa$$'
# if those are not valid, raise an AuthenticationError

# ... call authenticate to cause two kinds of error. catch a ValueError and a YourOrganizationError
# ... the messages should say '{} user could not be found', or 'Unknown Organization Error!'


def authenticate(username, password, db={}):
    setup_database(db)

    if username != 'test' and password != 'pa$$':
        raise AuthenticationError(username)


try:
    authenticate('test', 'pa$$')
    authenticate('test', 'pa$$', {'test': 'TEST'})
except KeyError as ke:
    print(ke, ' user could not be found')
except YourOrganizationError as ye:
    print('Unknown Organization Error: ' + ye)

try:
    authenticate('test', 'pa$$', {'test': 'TEST'})
    authenticate('test', 'test')
except KeyError as ke:
    print(ke, ' user could not be found')
except YourOrganizationError as ye:
    print('Unknown Organization Error: ' + ye)

# EXTRA

# Q. does the author of the authenticate function
# know what to do when an invalid username/password is supplied?
# ie., will this error always be handled the same way?

# No. The authenticate function just tests a username and password. 
# This funciton will be called in many differnet situations where failure will have different implications. 



# Q. consider several scenarios in which a program might need an authentication function,
# ... can you identify two in which the program recovers from this error differnetly?
# eg. authenticate()ing to use a coffee machine, and authenticate()ing to access a safe.

# in the former case the program may not care that you didnt enter the right password, and continue without failure 
# in the latter case the program might care and terminate all together 



# Q. raise AuthenticationError  could be replaced with return False 
# ... what are the advantages to using exceptions? 

# 'False' means that some description isnt accurate (ie. some condition isnt met) *it does not indicate failure*
# it can be reused for this pupose but then you have several issues:
# you do not know what type of error was caused, you have no error message, and you have to use lots of if/elses in your code:


# compare, 

if setup_db():
    if authenticate():
        if login():
            print("Allowed In!")
        else:
            print('handling bad login')
    else:
        print('handling bad auth')
else:
    print('handling bad db')

# with,
try:
    login()
except LoginError:
    print('handling login')
except AuthenticationError:
    print('hanlding auth')
except DbError:
    print('handling db')

# in the former case you may even forget to add an else condition, 
# and then the error would pass *silently*
# a return value is silently ignored.. and exception cannot be ignored and 
# you are forced to add error handling code to silence it

""" REVIEW
What did we learn from this exercise?
"""


''' OUTPUT (12.Errors/Solution12-ErrorHandling.py):

'''
