# 1.13.Functions.py

#1. functions

# defines the function bmi
def bmi(weight, height):
    return weight / height ** 2


# which means it creates a *callable* name "bmi"
# when you call the name bmi, the code block associated with the function is run..

print bmi(70, 1.82)


# bmi is a function of two arguments, weight and height
# these arguments are variables that take the value that they are given when the function is called
# and only exist while the function is being called

# the functions "return value" is given by the expression following the return keyword
# this expression defines what value the function produces when it is called


# DOCSTRINGS

def bmi(weight, height):
    """ calculate the body-mass index given a weight and height """
    return weight / height ** 2
 
print help(bmi)
print bmi.__doc__


#2. passing styles

# arguments may be passed by position
# ie., the first value is assigned to the first parameter, and so on
print bmi(80, 1.81)


# or by keyword
print bmi(height=1.81, weight=90)

# if you specify the name of the parameter when you call the funciton
# you can supply the paramters in any order


#3. default arguments

# when fuctions are defined their arguments may be given default values
def login(username="guest", pwd="test"):
    print username, "has logged in with pwd", pwd


# if a vlaue is not supplied when the function is called
# its default is used
login(username="mjburgess")

# Q. which argument uses its default value -- and what is that value?
# A. pwd  "test"


#4. unpacking arguments

# the bmi function takes two paramters
# there is a "similarity" between a sequence of two values and a parameter list of two arguments

info = (75, 1.81)

print bmi(info[0], info[1])

# wouldn't it be nice just to have python positionally pass each element of info in the right order?

# the unpacking star does this
print bmi(*info)        # unpacking by position

# Q. can you come up with a formula for ow the unpacking star works? f(*seq) -> ... ?
# A. f(*seq) -> f(seq[0], seq[1]..., seq[len(seq) - 1])


# similarly, we might have a dictionary with the same keys as our argument names...

user = {
    'username': 'michael',
    'pwd': 'TESTING'
}

login(username=user['username'], pwd=user['pwd'])

# there's an unpacking star for dictionaries that does exactly this...

login(**user) # unpacking by keyword, ie. unpacking a dictionary



#5. variadic functions: packing arguments

# functions can be *defined* with *packing* stars in their argument list

def write(*strs):
    for string in strs:    # strs is a tuple containing all the *positional* arguments passed
        print string

write("any", "number", "of", "arguments")



def writeKeys(**messages):
    for key in messages:    # messages is a dictionary containing all the *keyword* arguments passed
        print key, messages[key]

writeKeys(any="number of arguments", aslong="as theyre keyword")


# these can be combined into a function that accepts any number of positional arguments
# and "tuples them up"
# and any number of keyword arguments
# and "dictionarys them up"

def writeAnything(*positionals, **keywords):
    print positionals
    print keywords


writeAnything(True, False, 1, 2, "hello", this="is a ", message="for you")



#6. functions are objects


# a def statement creates a new name (ie., variable, identifier) which refers to a function object

def f(x):
    return x ** 2

def h(x):
    return x ** 2

g = f    # g refers to the same function object as f

print g(10)

print g is f # True. Q. Why? A. g = f
print h is f # False. Q. Why?

#A. The names h, f do not point to the same object
#.. function objects are uniquely created when def'd
#.. multiple names can refer to them using assignment (eg. g = f)
#.. but two functions having the same return expression does not make them the same


print type(f)
print type(g)    # f and g are functions


#Q. what makes an object a function object?
#A. it's callable.  x is a function if x() (or x(args, ...)) is valid


print f            # the function object
print f(10)        # calling the function object


#7. funciton objects store their default arguments

def add_to_basket(basket=[]):
    basket.append('eggs')
    return basket

print add_to_basket()
print add_to_basket()
print add_to_basket()


# you might expect each funciton call to use a new copy of the default
# ie. you might expect each function call to start from an empty list
# but it doesnt!

# the value of the default argument, intially the empty list [], is stored on the function object

print add_to_basket.__defaults__

# when the function is called, add_to_basket.__defaults__[0] is modified!


# take away point: don't use mutable defaults!

def add_basket(basket=None):
    basket = [] if basket is None else basket
    bask.append('eggs')
    return basket


print add_basket()    # use empty list each time
print add_basket()
print add_basket()


basket = []
print add_basket(basket) # pass an existing list
print add_basket(basket)
print add_basket(basket)




#8. lambda

# sometimes a function will want to take another function as an argument

# for example, suppose we have several functions which format strings

def my_formatter_a(string):
    return 'LOGGING: ' + string.upper()

def my_formatter_b(string):
    return 'warning: ' + string.lower()

# when we want to log a message sometimes we want to use _a, sometimes _b
# so, ...

def log(message, format):    # format is a function object
    print format(message)    # we call format inside log
                            # this lets the *caller* of log decide how the message will look


log("hello", my_formatter_a)
log("hello", my_formatter_b)


# the lambda keyword in python let's you define "inline functions"
# or more directly, it creates annoymous function objects: functions with no name

log("Hello", lambda x: x.upper())

# here we pass, as a second argument, a function that takes an argument x and returns x.upper()

# more on lambdas later...
