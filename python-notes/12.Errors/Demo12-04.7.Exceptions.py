# EXCEPTIONS
""" NOVICE ASIDE:

Why do we use exceptions?

Errors as values. 
"""

# 1. exceptions

# thus far in python code, if an error has occured the program terminates...

"""

10/0 #causes program to stop

"""

# we can however catch the error before it causes termination...

try:

    10 / 0  # code which might cause an error

except:

    print("handling error")  # code which executes if error occurs, rather than terminating program

# or...

try:
    10 / 0
except ZeroDivisionError:  # here we say handle only errors of the ZeroDivisionError kind
    print("handling error")

# we can handle different kinds of errors:

dct = {}

try:
    dct['missing']  # causes a KeyError
    2 + 3
    5 ** 2
    10 / 0
    1 + 4

except ZeroDivisionError:  # the first matching block is executed -- this doesnt match
    print("handling error")

except KeyError:  # this does
    print("handling key error")

# when an error occurs in a python program an object called an exception is generated
# exception objects store information about the kind of error which was caused
# so that you can make programatic decisions within the code


# for example in the code above the error type is actually a class
# and the class specified is being compared to the type of the exception object

dct = {}

try:
    dct['missing']  # causes a KeyError
except KeyError as ke:  # ke is an identifier (name) of our choosing, it holds the exception object
    print("handling key error")
    print(ke.args)  # args is a field of ke which contains the error args
    # in the case of KeyErrors the error args is the key which caused the error
    # here, for example, it is 'missing'

# all errors extend from the base class Exception

isinstance(ZeroDivisionError(), Exception)

# so that the most general error you can catch is an Exception..

dct = {}

try:
    dct['missing']
    2 + 3
    5 ** 2
    10 / 0
    1 + 4

except ZeroDivisionError:  # handles a /0 error
    print("handling error")

except Exception as err:  # handles anything else
    print("handling everything else")
    print(err.args)  # Q. what will this print?
    # A. "missing" because err is a KeyError


# you may raise (or throw) your own exceptions:

def my_error_prone_func():
    raise ValueError("DONT DO THAT!")


try:
    my_error_prone_func()  # this causes a ValueError to be raised
except ValueError as e:
    print(e)  # str(e) is the error args


# the code in the try block may itself call a function which calls a function (... which calls a function...)
# that causes the exception to be raised

def make_pretty_name():  # no explicit raise
    my_error_prone_func()  # here is where the exception is thrown
    return 'PRETTY NAME'


try:
    make_pretty_name()  # this begins running make_pretty_name()
except ValueError:  # as soon as the raise statement is hit, execution jumps to this point
    pass


# thus a 'raise' statement is a bit like a flow control statement
# it redirects the program to continue running from the closest compatible except-condition
# if none is found, the program terminates


# as you can raise exceptions yourself, you can also define custom exceptions to raise..

# you being by extending from the base exception class Exception...

class QaError(Exception):  # you may now raise a QaError
    pass


class DbError(QaError):  # DbError is a kind of QaError
    pass


class DoorError(QaError):
    pass


class DoorLockedError(DoorError):
    pass


# we can now filter on each kind of error we've defined

# suppose we want to model a siutaiton in which a door is locked by a pin
# the function we wantis: open_door_auth() which takes a pin and tells us if a user can pass through a door

# this function will call open_door() if the pin matches
# if no pin is supplied it will call is_guest_allowed() to see if guests are allowed
# this function might access a database to determine, for example, if a door should be open at a certain time of day

# finally if a pin is supplied but it isnt the right one, then it will raise a DoorLockedError

def open_door():
    raise DoorError('Door Jamed!')


def is_guest_allowed():
    raise DbError()


def open_door_auth(pin=None):
    if pin == 1234:
        return open_door()
    elif pin is None and is_guest_allowed():
        return True
    else:
        raise DoorLockedError()


# so when we call open_door_auth() we may get several kinds oof error which should be handled differently

try:
    open_door_auth(4321)  # this raises three kinds of exception
except DoorLockedError:  # we can deal with this
    print("WRONG PIN!")
except DoorError as de:  # we can deal with this
    print(de.args)

# we can't deal with a db error at the moment,
# since this bit of code is only about opening a door
# we let the db error "bubble up" or otherwise continue to any exception block which can handle it

# in general you should only except errors when you have enough information to handle them properly
# you should not try to except every kind of error a function may raise
# doing this silences errors which should really be visibile or otherwise handled by another exception block




# the other clauses...

# there are additional conditions we can place on try blocks...


try:
    10 / 0
except ZeroDivisionError:
    pass
else:
    print("always if no error")
finally:
    print("always if error")

print("always executed if no error")  # code after a try block always runs if there's no error
# so there's not much point in the "else" block above
# though it could make some code clearer, its quite rare



# the finally block however is useful...

"""

try:
    f.write()
    f.write()
    something_causes_ERROR()
except:
    pass
finally:
    f.flush()
    f.close()
"""

# above it ensures everything written to the file is actually flush'd (ie. all the bufers are transfered to disk)
# and closes the connection

# in the case of file hamdling though, the context manager system ( with (... as ... )) is preffered





# asking for forgiveness vs. asking for persmission

# we can try to avoid errors before the happen
# this is called asking for permission

dct = {}

if 'name' in dct:  # ask if the key is in the dict before using it
    print(dct['name'])

try:
    dct['name']  # here we just use it
except KeyError:
    pass  # and then ask for forgivness if it goes wrong

# python developers are encouraged to use the second style
# that is, write code assuming its all going to work -- not peppered with if/elses
# then later error-check



# ASIDE: a raise should never directly appear inside a try block...

try:
    if 5 < 10:
        raise ValueError()
except ValueError:
    print()

# this is just equivalent to...

if 5 < 10:
    print()




# a raise inside a try will either always be executed or conditionally executed
# which is just the same as writing the code without it.


''' OUTPUT (12.Errors/Demo12-04.7.Exceptions.py):
handling error
handling error
handling key error
handling key error
('missing',)
handling everything else
('missing',)
DONT DO THAT!
WRONG PIN!
always if error
always executed if no error



'''
