# DECORATORS 


""" NOVICE ASIDE:

Why do we use decorators?

To glue-togther different kinds of functionality without modifying the defintion of either. 

"""

# before looking at decorators we need to establish, or review,
# some properties of names (ie., identifiers) and functions in python

# 1a. Functions are single objects.
# &.. The names of funtions are references to these objects

print(locals())  # Q. which names are defined?


def log():
    return "Log"


print(locals())  # Q. which names are defined now?
# A. all the builtins + the name 'log'

# the name log refers to a function object
# when we call the name, ie. append the calling operator ()
# we call the funciton object the name refers to

print(log())

# more than one name can refer to this same function object
another_log = log

# and this, equally, may be called
print(another_log())

# ASIDE: we could even delete the original name from the local namespace

del log

# we then have only 'another_log' to refer to it...

# ASIDE: the original name of another_log is preserved in .__name__

print(another_log.__name__)


# since .__name__ is a property of the function object reffered to



# 2a. You can define function within functions.

def logger(message):
    def log(msg):  # the name log denotes a function object
        return msg  # *local* to the function logger

    # we call the function we have just defined
    return log(message.upper())


print(logger("my message"))


# 2b. You can return a function from a function.

def my_logger(msg):
    return msg.upper()


def get_logger():
    return my_logger  # returns the function object 'my_logger'


fn = get_logger()  # Q. what is the type of fn?
# A. function!


# fn is just another name for my_logger
# so,
print(fn("another message"))


# 2c. You can return a function defined within a function.

def getlog():
    def log(message):
        return message.lower()

    return log  # return the log function defined above


f = getlog()  # f refers to the log() function defined in getlog()

# therefore,
print(f("A CALL TO F!"))


# 3. functions can take otehr functions as arguments

def formatter(msg):
    return msg.upper()


def printer(log, msg):  # log is a function
    print(log("LOG:" + msg))  # log is called in the body of printer


printer(formatter, "Hello")


# 4. THE CONCLUSION:
# ... functions can take "old functions" as arguments and make new functions

# some intial function we wish to add some features to
def original_messenger():
    return "MESSAGE"


# we can either modify the body of original_messenger OR
# supply original_messenger to make_new_messenger...


def make_new_messenger(old_fn):
    def new_fn():  # defines a new function
        return "Logging: " + old_fn()  # calls the original one we passed
        # but! adds the "Logging: " 'feature'

    return new_fn  # return the new function


new_messenger = make_new_messenger(original_messenger)

print(original_messenger())  # no "Logging: "
print(new_messenger())  # now has "Logging: " attached

# what if we didnt want original_messenger any more?
# ie., we always wanted "Logging: "...
# we could:  del original_messenger

# and just use new_messenger from now on... OR

original_messenger = make_new_messenger(original_messenger)

# rebind the original name to a new function object
# ie., reassign the variable
# so now it appears we're using the original...

print(original_messenger())


# however we've actually changed the underlying function it refers to


# 5. ... WHY?!

# using this mechanism of programatically changing the behaviour of functions
# we can add features to functions without modifying the original function body
# and we can add the same feature to multiple functions without repeating code

# ( this is known as "aspect-oriented programming" )


# suppose we have some functions that perform a small, coherent, well-defined task

def say_hello():
    print("hello")


def say_goodbye():
    print("goodbye")


# we wouldnt want to pollute the definition by adding responsiblities to these functions
# we wouldnt, for example, want them to connect to a db or write to a file
# this adds a lot of fragility and complexity to the function defintion


# therefore we define a *decorator* a function which modifes functions

def add_logging(say_fn):  # take an original
    def new_printer():  # make a new one
        print("Logging!")  # add a feature
        return say_fn()  # call the original

    return new_printer  # return the new one


say_hello = add_logging(say_hello)
say_goodbye = add_logging(say_goodbye)

# now we can use say_hello, say_goodbye exactly as we would do
# and gain the extra logging feature (which could, for example, connect to a db)

say_hello()
say_goodbye()


# 6. The @-syntax

# this style of programming is so common in python that it has a special syntax to support it


@add_logging
def say_woof():
    print("woof")


# the @add_logging says to python:
# call add_logging(say_moo)
# and set the name 'say_moo' to the function returned!
@add_logging
def say_moo():
    print("moo")


''' OUTPUT (14.Extra/Demo14-05.4.Decorators.py):
{'__cached__': None, '__package__': None, '__name__': '__main__', '__loader__': <_frozen_importlib_external.SourceFileLoader object at 0x105962828>, '__doc__': ' NOVICE ASIDE:\n\nWhy do we use decorators?\n\nTo glue-togther different kinds of functionality without modifying the defintion of either. \n\n', '__builtins__': <module 'builtins' (built-in)>, '__file__': '14.Extra/Demo14-05.4.Decorators.py', '__spec__': None}
{'__cached__': None, '__package__': None, '__name__': '__main__', '__loader__': <_frozen_importlib_external.SourceFileLoader object at 0x105962828>, '__doc__': ' NOVICE ASIDE:\n\nWhy do we use decorators?\n\nTo glue-togther different kinds of functionality without modifying the defintion of either. \n\n', '__builtins__': <module 'builtins' (built-in)>, 'log': <function log at 0x105a900d0>, '__file__': '14.Extra/Demo14-05.4.Decorators.py', '__spec__': None}
Log
Log
log
MY MESSAGE
ANOTHER MESSAGE
a call to f!
LOG:HELLO
MESSAGE
Logging: MESSAGE
Logging: MESSAGE
Logging!
hello
Logging!
goodbye

'''
