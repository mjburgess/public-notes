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


# Q. write the function muler which makes multiplying functions 
# HINT: this function returns a function

# Q. use muler to create repeatDash, which repeats a dash n times 

# Q. use repeatDash to print 10 dashes

# Q. call the say function 
# you will need to define a formatter function
# the formatter function should accept a string and return a string 
# eg. it can just uppercase it


# EXTRA
# Q. use modify() to *redefine* your formatter function 
# and call say() again

def modify(fn):
    def fmt(msg):
        return 'ERROR: ' + fn(msg)

    return fn


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


# Q. create and decorate function to use with this decorator, say, add(x, y)

# Q. call your decorated function a few times

# Q. print the default arguments of the remember_return function


""" REVIEW

What did we learn from this exercise?

"""


''' OUTPUT (14.Extra/ExerciseX-AdvancedFunctions.py):
['this']
['this', 'that']
['this', 'that', 'everything']

'''
