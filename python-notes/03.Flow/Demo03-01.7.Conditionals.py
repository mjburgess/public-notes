# CONDITIONAL STATEMENTS

""" NOVICE ASIDE:

Why do we use branching statements?

The problems we are describing contain conditional elements, 
ie. decisions are made based on at-the-time values. 

If we know, ahead of time, what the property of interest is going to be, 
we do not need the program to make the decision.

eg. if we know that we have to print 'Hello, Mr. Holmes!' 
because *we* have decided the application is for sherlock holmes
then we do not need to have the program make a decision.

However if it could be for two users, then maybe...

if user == 'sherlock':
    print "Hello, Mr. Holmes"
else:
    print "Hello, Mr. Watson"

This is conditional execution: certain actions will be taken only if certain conditions are true. 
"""

age = 21

if age < 18:
    print('You are a child!')
elif age > 65:
    print("You're nearing retirement!")
else:
    print("Get back to work!")

# Q. Why do we need conditional statements? 
# A. To make selections and decisions.

""" GENERAL STRUCTURE:

if      BOOLEAN-EXPRESSION   :
    DO-TRUE 
elif    BOOLEAN-EXPRESSION   :
    DO-TRUE 
else:
    DO-FALSE

"""

## NON-BOOLEAN VALUES IN CONDITIONAL CONTEXTS
# Q. have a guess: what is printed?
if '':
    print("the string wqas empty")
else:
    print("what do you think?")  # A. this one!

# Q. Why? 
# A. In conditional contexts, values are converted to boolean


## CONVERTING TO BOOL
# Q. How do you convert a value to a boolean?
# A. call the bool() function on it

print(bool(''))
print(bool(0))
print(bool([]))
print(bool({}))
print(bool(None))

print(bool('0'))
print(bool("Michael"))
print(bool(['Sherlock', 'Holmes']))

# .. therefore this is equivalent to the statement above
if bool('') is True:  # nb., is True is pointless here, but added for emphasis
    print("Yes")
else:
    print("No")

# bool() typically converts "empty" values to False and non-empty to True

user_input = ''  # Q. what's bool(user_input) ? 
# A. False

# Q. therefore what's "not user_input" ?
# A. True
if not user_input:
    print("was empty!")

    # the not operator "switches" boolean (True -> False, False -> True)

# Q. is 10 < 20?
if 10 < 20:
    print("10 < 20")

# Q. is the element '@' in the string 'michael@...' ?
if '@' in 'michael@mjburgess.co.uk':
    print("its an email!")

## EQUALITY VS IDENTITY
# Q. is True equal to 1?
# A. alas! Yes.
if True == 1:
    print("True equals 1")

if not True is 1:
    print("True is not 1")

if True is not 1:
    print("True is not 1")

# -- we should therefore distinguish between identity and equality
# equality (the == operator) means "equal in at least one respect"
# identity (the is operator) means "identical in every respect"
# identity in python very simply reduces down to "refering to the same object"


x = True
y = 1
z = True

print(x is y)  # False
print(x is z)  # True
print(x == y)  # True
print(x is y)  # False

# nb., the simple rule is when working with bools use 'is' 

# ASIDE: 'is' basically performs the operation:  id(x) == id(y) 



## BOOLEAN FUNCTIONS (PREDICATES)

# some functions return bools to indicate a condition has been met
# eg., 


user_input = 'michael.burgess@qa.com'

if user_input.startswith('burgess'):
    print("your email begins with your surname")
elif user_input.endswith('qa.com'):  # NB., the elif keyword indicates an additional condition
    print("you work for qa")
else:
    print("we have no idea!?")

## THE TERNARY OPERATOR

# a common pattern in programming is for a condition to determine a value 
# here we're determining the value of height...

height = None
room = '204'

if room == '200':  # if the room is 200 then height is 3
    height = 3
elif room == '204':
    height = 3.5
else:
    height = None  # we may be unable to determine the height
    # then the special value None is used to indicate 
    # "an absense of value"

    # Q. why wouldn't 0 be a suitble value?
    # A. 0 might be a valid height!

print("height is", height)

# since this is so common there is an operator for it...
#  .. if .. else .. 
# which takes three arguments (..)

height = (3 if room == '200' else 3.5)

# as the value of (1 + 2) is 3..
# the value of (3 if room == '200' else 3.5) is 3.5


# in general the ternay operator syntax is..

#         VALUE-IF-TRUE if CONDITION else VALUE-IF-FALSE

condition = 'm' in 'michael'  # for example

if condition:
    value = "some value"
else:
    value = "some other value"

value = "some value" if condition else "some other value"

value = "some " + ("" if condition else "other") + " value"

print(value)

## ANY AND ALL

print(all([0, 1, "", "Sherlock"]))  # bool(0) and bool(1) and bool("") and bool("Sherlock")
print(any([0, 1, "", "Sherlock"]))  # bool(0) or bool(1) or bool("") or bool("Sherlock")

input_data = ["name", "age", "height"]

if all(input_data):
    print("all data is non-empty")

## CHAINED COMPARISONS    
# finally, chained comaprisons = sequence of partial comparisons

print(2 < 3 < 4)

# Q. How is the above parsed?

# 1. 
print((2 < 3) < 4)

# or, 2. ?
print(2 < (3 < 4))

# NEITHER! Operator chaining breaks BODMAS rules -- brackets dont group 
# actually, it's...

# A.
print((2 < 3) and (3 < 4))

# Q. Why did (2 < 3) < 4 come out True?
# A.  (2 < 3) is True
# True == 1
# ... therefore, (2 < 3) < 4 means True  < 4 means 1 < 4 which is True!



name = "Michael"
age = 27.0
height = 1.81
quote = "western cvilization? I think it would be a good idea!"
email = "michael.burgess@qa.com"

if name == "Michael":
    print("you're michael")

if age > 18:
    print("you're allowed in the club!")

if height < 1.7:
    print("this is a small barn, you're going to bump your head")

if len(quote) >= 10:
    print("that's a long quote")

if (90.0 / (height ** 2)) <= 30:
    print("you're not obese yet")

if name != "guest":  # nb., != means "not equal to"
    print("you've successfully logged in!")

if '@' in email:
    print("that's a valid address!")

if name == "Michael" and (age > 18 or height > 1.7):  # nb., combinding conditions with and, or
    print("you're allowed to the convention of international Michaels")

message = "you're fat" if (90.0 / (height ** 2)) > 27 else "you're probably OK"

print(message)


''' OUTPUT (03.Flow/Demo03-01.7.Conditionals.py):
Get back to work!
what do you think?
False
False
False
False
False
True
True
True
No
was empty!
10 < 20
its an email!
True equals 1
True is not 1
True is not 1
False
True
True
False
you work for qa
height is 3.5
some  value
False
True
all data is non-empty
True
True
False
True
you're michael
you're allowed in the club!
that's a long quote
you're not obese yet
you've successfully logged in!
that's a valid address!
you're allowed to the convention of international Michaels
you're fat

'''
