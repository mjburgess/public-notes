# CHAPTER:    Advanced Functions
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Write helper functions for repeating strings and remembering arguments. 
# TIME:       20m

def adder(x):
    def addX(y):
        return x + y

    return addX


# Q. use adder to create the functions addOne, addTwo, joinError
# a) addOne adds 1 to its input 
# b) addTwo adds 2 to its input
# c) joinError concatenates Error to its input 

addOne = adder(1)
addTwo = adder(2)
joinError = adder('Error')


# Q. write the function muler which makes multiplying functions 
# HINT: this function returns a function 
def muler(x):
    def mulX(y):
        return x * y

    return mulX


# Q. use muler to create repeatDash, which repeats a dash n times 
repeatDash = muler('-')

# Q. use repeatDash to print 10 dashes 
print(repeatDash(10))


# Q. call the say function 
# you will need to define a formatter function
# the formatter function should accept a string and return a string 
# eg. it can just uppercase it 

def say(message, formatter):
    print(formatter(message))


def formatter(inp):
    return inp.upper()


say('Hello', formatter)


# EXTRA
# Q. use modify() to *redefine* your formatter function 
# and call say() again

def modify(fn):
    def fmt(msg):
        return 'ERROR: ' + fn(msg)

    return fn


formatter = modify(formatter)

say('Hello', formatter)


# Q. can you explain the behaviour of the following function?
def remembers(value, arg=[]):
    arg.append(value)
    print(arg)


remembers("this")
remembers("that")
remembers("everything")


# Q. where does the default value for arg live?

# let's use this interesting property of default arguments 
# to build a decorator...

# Q. define a decorator function called remember_return
# this function should take *TWO* paramters, 
# the first is the function its going to decorate
#  the second should be an argument 
# with a parameter defaulted to a list. 

# ... the decorator function should return a function
# ... this inner-function should call the original function
# ... and "remember" its return value

def remember_return(fn, memory=[]):
    def replacement(*pargs, **kwargs):
        rtn = fn(*pargs, **kwargs)
        memory.append(rtn)
        return rtn

    return replacement


# Q. create a function to use this decorator, say, add(x, y)
@remember_return
def add(x, y):
    return x + y


# Q. call your decorated function a few times
add(5, 6)
add(6, 5)
add(50, 60)

# Q. print the default arguments of the remember_return function
print(remember_return.__defaults__)

""" REVIEW

What did we learn from this exercise?

"""


''' OUTPUT (14.Extra/SolutionX-AdvancedFunctions.py):
----------
HELLO
HELLO
['this']
['this', 'that']
['this', 'that', 'everything']
([11, 11, 110],)

'''
