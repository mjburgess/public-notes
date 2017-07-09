# DEFINING FUNCTIONS 

""" NOVICE ASIDE:

Why do we use functions?

1. To describe processes.
... then... 

To group related operations.
To group repeated operations. 

"""

# Why do we use functions?
# Q. which of the following is preferable, A or B?

# A
flour = 100
sugar = 200
print(flour + sugar)
print('baking!')


# B
def bake(f, s):
    print(f + s)
    print('baking!')


bake(100, 200)

# ASIDE: Q. what is the return value here?  None
print(type(bake(100, 200)))


# Uses of functions: 
# reuse (potential, actual); maybe refficiency; easy variation of behaviour; debugging, readability

# KEY REASON: to describe processes (ie. as technique in translating processes)

# 1. functions

# defines the function bmi
def bmi(weight, height):
    return weight / height ** 2


# which means it creates a *callable* name "bmi"
# when you call the name bmi, the code block associated with the function is run..

print(bmi(70, 1.82))

# bmi is a function of two arguments, weight and height
# these arguments are variables that take the value that they are given when the function is called
# and only exist while the function is being called
# -- or we can read parameters as substitution rules 

# the functions "return value" is given by the expression following the return keyword
# this expression defines what value the function produces when it is called


# NAMESPACES (preview)


population = 1000


def increase_population(population):
    population += 1


# Q. how many variables are there? -- A. two; population in the function is NOT the same as population in the outer reigion 
# Q. how do we get info. out of a function?  RETURN. 
# Q. how do we get info. into a function? PASS-AS-PARAM

# DOCSTRINGS

def bmi(weight, height):
    """ calculate the body-mass index given a weight and height """
    return weight / height ** 2


print(help(bmi))
print(bmi.__doc__)

# 2. passing styles

# arguments may be passed by position
# ie., the first value is assigned to the first parameter, and so on
print(bmi(80, 1.81))

# or by keyword
print(bmi(height=1.81, weight=90))


# if you specify the name of the parameter when you call the funciton
# you can supply the paramters in any order


# 3. default arguments

# when fuctions are defined their arguments may be given default values
def login(username="guest", pwd="test"):
    print(username, "has logged in with pwd", pwd)


# if a vlaue is not supplied when the function is called
# its default is used
login(username="mjburgess")


# Q. which argument uses its default value -- and what is that value?
# A. pwd  "test"




def f(arg='something'):
    pass


print(dir(f))
print(f.__name__)
print(f.__doc__)
print(f.__defaults__)


''' OUTPUT (08.Functions/Demo08-03.1.DefiningFunctions.py):
300
baking!
300
baking!
300
baking!
<class 'NoneType'>
21.132713440405748
Help on function bmi in module __main__:

bmi(weight, height)
    calculate the body-mass index given a weight and height

None
 calculate the body-mass index given a weight and height 
24.41927902078691
27.471688898385274
mjburgess has logged in with pwd test
['__annotations__', '__call__', '__class__', '__closure__', '__code__', '__defaults__', '__delattr__', '__dict__', '__dir__', '__doc__', '__eq__', '__format__', '__ge__', '__get__', '__getattribute__', '__globals__', '__gt__', '__hash__', '__init__', '__kwdefaults__', '__le__', '__lt__', '__module__', '__name__', '__ne__', '__new__', '__qualname__', '__reduce__', '__reduce_ex__', '__repr__', '__setattr__', '__sizeof__', '__str__', '__subclasshook__']
f
None
('something',)

'''
