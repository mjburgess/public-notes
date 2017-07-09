# CHAPTER:    Error Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using except, handle errors caused by an authentication processes.
# PROBLEM:    Using custom exceptions, define errors caused by an authentication processes.
# TIME:       20m

# PART 1 -- SYNTAX 

# Q. prevent the programming from terminating when setup_database() is called
# ... ie, use a try-except to handle the error 
# ... and print the error message given 

def setup_database(db):
    if len(db) == 0:
        raise ValueError("a database is required to have data")


setup_database({})

print("still runnning...")

# Q. what kind of error occurs if you supply an integer for the argument?

# Q. call setup_database again with the argument 0 
# ... handle both error conditions



# PART 2 

# Q. define a YourOrganizationError which is a kind of Exception

# Q. define an AuthenticationError which is also a YourOrganizationError


# Q. define a function authenticate which accepts a username, a password , and a database 
# this funciton should call setup_database and then require the username/password arguments to be 'test' and 'pa$$'
# if those are not valid, raise an AuthenticationError

# ... call authenticate to cause two kinds of error. catch a ValueError and a YourOrganizationError
# ... the messages should say '{} user could not be found', or 'Unknown Organization Error!'



# EXTRA

# Q. does the author of the autenticate function 
# know what to do when an invalid username/password is supplied?
# ie., will this error always be handled the same way?



# Q. consider several scenarios in which a program might need an authentication function,
# ... can you identify two in which the program recovers from this error differnetly?


# Q. raise AuthenticationError  could be replaced with return False 
# ... what are the advantages to using exceptions? 

# Q. investigate the exception hook and traceback features of python.
# ... add logging to every exception.


''' OUTPUT (12.Errors/Exercise12-ErrorHandling.py):

'''
