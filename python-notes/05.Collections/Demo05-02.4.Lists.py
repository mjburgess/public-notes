# LISTS

""" NOVICE ASIDE:

Why do we use lists?

To group data sequentially.

To represent lists (of things..).
"""

## SLICING

# recall string slicing...
quote = "I only have my wit to declare!"

print(quote[0:6])

print(quote[:6])

print(quote[-8:])

# syntax:   quote[ start position :  end position ]

basket = ['eggs', 'bread', 'cherries', 'ham']
# slicing is possible on any sequence type, eg. lists
print(basket[0:2])

# and for mutable data types, you can *assign* to a slice...
print(basket)

basket[0:2] = ['peas', 'beans']
print(basket)

# which modifies the original


# Q. if -1 is the last element, what is :0?
# A. a non-existent "first element"

basket[:0] = ['limes']
print(basket)

# if that's confusing, just remember that x[:0] = y  prepends y to x




## COPYING

# when you read from a slice you take a copy of the data

basket = ['eggs', 'ham', 'cherries']

another = basket[0:2]  # another points to a new list composed of basket[0], basket[1]

another.append('cheese')  # so modifying another does not modify basket

print(basket)
print(another)

# using this mechanism we can take copies of entire lists

more = basket[:]  # slice from the start position until the end position

more.append('lemonade')

print(more)
print(basket)

# however this is a shallow copy, it copies *the list* 
# it does not make new copies of each element...


# when your elements are strings this doesnt matter..
# but when your elements are mutable, eg. they're lists, it does:


baskets = [
    ['eggs', 'ham'],
    ['cheese', 'milk']
]  # list of lists

carts = baskets[:]  # copy baskets

print(baskets)
print(carts)

baskets.append(['lemonade', 'coke'])  # append to *baskets*

print(baskets)
print(carts)  # carts is unmodified beause *baskets* was changed

# however what if we change an element of baskets...

baskets[0][1] = 'bread'

# then both change!
print(baskets)
print(carts)

# why ?

print(carts is baskets)  # False, as expected.

print(carts[0] is baskets[0])  # True!

# the name carts refers to a differet list, but the objects of that list are the same!




"""
'append', 'count', 'extend', 'index', 'insert', 'pop', 'remove', 'reverse', 'sort'
"""

cart = ['eggs', 'milk', 'eggs']
print(cart.count('eggs'))

cart.append('milk')
print(cart)

cart.extend(['cheese', 'bread'])
print(cart)

print(cart.index('cheese'))

cart.insert(3, 'ham')
print(cart)

cart.pop()
cart.pop(0)
print(cart)

cart.reverse()
print(cart)

cart.sort()
print(cart)

names = ['michael', 'adma']
print(names + ['sherlock', 'watson'])
print(names)

names += ['sherlock', 'watson']
print(names)

print('\n' * 5)

print(cart)

basket = cart[:]
cart[0] = 'eggs'

print(basket[0])


''' OUTPUT (05.Collections/Demo05-02.4.Lists.py):
I only
I only
declare!
['eggs', 'bread']
['eggs', 'bread', 'cherries', 'ham']
['peas', 'beans', 'cherries', 'ham']
['limes', 'peas', 'beans', 'cherries', 'ham']
['eggs', 'ham', 'cherries']
['eggs', 'ham', 'cheese']
['eggs', 'ham', 'cherries', 'lemonade']
['eggs', 'ham', 'cherries']
[['eggs', 'ham'], ['cheese', 'milk']]
[['eggs', 'ham'], ['cheese', 'milk']]
[['eggs', 'ham'], ['cheese', 'milk'], ['lemonade', 'coke']]
[['eggs', 'ham'], ['cheese', 'milk']]
[['eggs', 'bread'], ['cheese', 'milk'], ['lemonade', 'coke']]
[['eggs', 'bread'], ['cheese', 'milk']]
False
True
2
['eggs', 'milk', 'eggs', 'milk']
['eggs', 'milk', 'eggs', 'milk', 'cheese', 'bread']
4
['eggs', 'milk', 'eggs', 'ham', 'milk', 'cheese', 'bread']
['milk', 'eggs', 'ham', 'milk', 'cheese']
['cheese', 'milk', 'ham', 'eggs', 'milk']
['cheese', 'eggs', 'ham', 'milk', 'milk']
['michael', 'adma', 'sherlock', 'watson']
['michael', 'adma']
['michael', 'adma', 'sherlock', 'watson']






['cheese', 'eggs', 'ham', 'milk', 'milk']
cheese

'''
