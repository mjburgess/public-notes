# COMPREHENSIONS


""" NOVICE ASIDE:

Why do we use comprehensions?

     To translate between different kinds of (plural) data, ages to heights, etc. 
     To irrelevant data: to filter children from a list. 

"""

# 1. transformations

# a lot of  programming problems (almost every) can be phrased as transforms on data

# the intial data represents the current state of the world (who has what name, what location, etc.)
# the tranformations represent the processes which change the state of the world (getting older, moving, etc.)

# transforming data is such a common operation that python has special syntax for making it easier and clearer

# let's look at a more familiar syntax first...

# a transformation

basket = ["eggs", "bacon", "ham"]  # starting state (data source)

new_basket = []  # final state  (data output)

for item in basket:
    new_basket.append(item.upper())  # add to final output
    # input transformed by .upper()

print(new_basket)


# let's look at the general pattern above...

def transform(item):  # so there is some function that transforms a single element of a data source
    return item.upper()


def applyTransformation(source, transformFn):
    new = []

    for old_element in source:
        new.append(transformFn(old_element))  # we apply that to each element
        # and collect them up
    return new


source = basket
result = applyTransformation(source, transform)  # general pattern for transformations

# 2. list comprehensions

new_basket = [item.upper() for item in basket]

# or equally,

new_basket = [

    item.upper()

    for item in basket
]

# compare with the pattern...

"""
NEW = [

    TRANSFORM(element)          # some function which transforms an element

    FOR element IN              # expression which defines the name of an element obtained from...
        OLD                     # the data source
]
"""

"""
NEW = [
    NEW_TO_OLD(element)

    FOR element IN OLD
]
"""

new_basket = [
    old_item.upper()  # how do we get from  old_item to new_item ?

    for old_item in basket
]

# examples

emails = ['a@qa.com', 'b@gmail.com', 'c@outlook.com']
print([e.split('@')[0] for e in emails])

ages = list(range(0, 69))
print([str(e) for e in ages if e < 18])  # the IF filters the input source

names = ["Mr. Michael Burgess", "Ms. Edith Quine", "Mr. John Doe"]

out = ['{2}, {0} {1}'.format(*n.split()) for n in names if n.startswith('Mr')]

# 2. set comprehensions

# set comprehensions follow a similar syntax to list comprehensions, producing sets:

Nat = set(range(0, 10))  # set of natural numbers from 0 to 10

Odd = {(2 * k + 1) for k in Nat}  # set of odd numbers from 0 to 21
Even = {2 * k for k in Nat}  # set of even numbers from 0 to 20

# we can translate between lists and sets with a comphrension

users = ["Michael", "John", "Matt"] * 3  # simulate list with repetitions

good_users = {n for n in users if n.startswith('M')}

# 3. dictionary comprehension

# thus far we have needed one variable available in the tranformation part of a comprehension
# now we need two, one for the key and one for the value

keys = ['username', 'password']
values = ['guest', 'test']

user = {k: v for k, v in zip(keys, values)}  # convert two lists into a dictionary

# or we could reuse the same variable

names = ["Mr. Michael Burgess", "Ms. Edith Quine", "Mr. John Doe"]

last_first = {n.split()[2]: n.split()[1] for n in names}

# 4. generators

# we can create comprehensions that lazily return their values..
# ie. calculate one at a time

squares = (x ** 2 for x in range(0, 1000000))

for sq in squares:
    print(sq)

    if sq > 100:
        break


''' OUTPUT (09.Functional/Demo09-05.2.Comprehensions.py):
['EGGS', 'BACON', 'HAM']
['a', 'b', 'c']
['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14', '15', '16', '17']
0
1
4
9
16
25
36
49
64
81
100
121

'''
