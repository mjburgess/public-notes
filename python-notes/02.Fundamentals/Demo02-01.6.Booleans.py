# BOOLEANS

age = 27
allowed_age = 68

condition = age > allowed_age

# Q. what is the type of condition?
# A. bool

# Q. if a variable is type bool which of two values must it be?
# A. {True, False}        -- this notation is valid python, it defines a set (more on that later..)

# ASIDE: Q. if a variable is type int what set of values must it be in?
# A. the set {-1 * sys.maxint, ... 0 ..., sys.maxint}
# ie., {-2147483648, -2147483647, ... 0 ..., 2147483647}

# you could make this set in python with  set(range(-2147483648, 2147483647))
# Q. why is that not, in practice, possible? -- try it!

# ... a general understanding of types is that they denote sets of objects with a common property
# , that is, bool is just the set {True, False} to be a bool is just to be one of those values


# Q. what is printed?
print(condition)

# Q. therefore... what's printed?

if condition:
    print("You are allowed into the cruise!")  # nb. indentation defines code-block
else:
    print("Please see the travel agent!")  # nb., each code block is "associated with" the clause that preceedes it
    # ie., the else:

# 5. logical operators
# Q. what do these print?

print(not True)  # not = select other bool
print(not False)

print(True or False)  # or = at least one is True
print(False or True)
print(False or False)

print(True and True)  # and = every one is True
print(True and False)
print(False and False)

# ... these can be "chained" (as all boolean operators can..)


print(True and True and True and True and True)
print(True and True and True and True and False)
print(False or False or False or True)


''' OUTPUT (02.Fundamentals/Demo02-01.6.Booleans.py):
False
Please see the travel agent!
False
True
True
True
False
True
False
False
True
False
True

'''
