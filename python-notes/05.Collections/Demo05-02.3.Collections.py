# COLLECTIONS

""" NOVICE ASIDE:

"""

# CREATING COLLECTIONS

# Q. what type of collections are there?
# A. many...

# Q. which are the basic built in ones?
# A. str, list, dict, tuple, set

# AIDE: there are many others in addition, what do you think a frozenset() is?

# Q. how do you create collections?
# A. with constructor functions or composer syntax (the technical names for each)


# eg. calling the str constructor *function*
print(str(10))

# eg. using str composer *syntax*
print("10")
print('10')
print("""10""")
print('''10''')
print(r'10')

# while each composer syntax above has differnt characteristics 
# they each create the same string
# compare with different ways of creating the same integer, ten

print(10)  # decimal 10
print(0xA)  # hex A = decimal 10
print(0o10 + 2)  # octal 10 + decimal 2 = decimal 8 + decimal 2

# ASIDE: the int constructor takes a radix (or base) argument

# Q. What is hexidecimal A in decimal?
# A. 10

print(int('A', 16) - 1)

# all the composers and constructors
lst = ["Eggs", "Milk", "Tea", "Sony A7S", "Zeiss 24-70mm"]
dct = {"name": "sherlock", "profession": "detective"}
tpl = ('Michael', 27)
string = "Michael"
st = {"Dan", "James", "David", "David", "David"}

# without arguments the constructors create empty values of that type
print(list())
print(dict())
print(tuple())
print(str())
print(set())

# with arguments, constructor functions take their input and "turn them into" their types
# eg.
print(list("Delta Place"))  # Q. what type is the return value of list()?
# A. list ...of course! 
# A... a list of characters


# nb., the conversion is,  list(string) -> [string[0], string[1]...]

# Q., so what is... 
print(list("Michael")[0])  # A., 'M'

# in general,  list(sequence) -> [sequence[0], ...]

# Q. what is list() ? (ie. with no arguments?)
# A. [] -- the empty list

print(str(1) * 2)  # 11 - Q. why? A. * is repertition on strings

# some type examples of using constructor functions..
print(tuple("Michael"))
print(str(['Mi', 'ke']))  # Q. what do you expect?
# .. perhaps ''.join(['Mi', 'ke'])    ?
# the str() constructor does not join!

# the dict constructor will accept a list of two-valued tuples (ie. pairs) 

# Q. what do you think it does with them?

# Q cont. what will the return type be?
# A. a dictionary

print(dict([
    ('username', 'michael'),
    ('email', 'michael@qa')
]))

# A. therefore the dict() constructor takes the 0th element of each pair as the keys
# .. and the 1th element as the value

# the formula is...
# dict([a, b, c]) -> {a[0]: a[1],  b[0]: b[1], ... }


# AISDE: zip()

# Q. what function "pairs-up" lists
# ie. what function, takes arguments a, b and makes [(a[0], b[0]), ...] ?
# A. zip

basket = ['eggs', 'milk']
prices = [1.8, 2.8]

print(dict(list(zip(basket, prices))))

## OTHER ITERABLES... 

# collections are not the only kind of data type you can use in a for-loop
# the general name for an object that can be iterated over in a for-loop is an iterables

f = open('/etc/hosts')  # f is a file object

for line in f:  # f is iterable
    print(line)  # f is a sequence of lines

# the range function gives you a list    
print(list(range(0, 100)))

# the xrange function gives you an xrange object
print(range(0, 100))

for i in range(0, 3):  # xrange()s are iterable
    print(i)

# xrange objects, like file objects, give you "one element at a time, on demand"
# whereas, for example, lists are stored in their entireity up-front

# range(-2000000000, 2000000000) -- not enough memory!

wide_range = range(-2000000000, 2000000000)  # -- just fine

# PROPERTIES
# recall the collection types...

lst = ["eggs", "tea", "milk"]
tpl = ("detective", 27)
dct = {"name": "watson", "profession": "dr"}
st = {"sherlock", "watson"}

# Q. Which one is missing?
string = "A string is a collection!"

# 1. ORDERED
# A collection is ordered if there is a well-defined "previous element" and "next element"

# in python all ordered collections have monotonically increasing integer indexes, 
# ie., x is ordered if x[0], x[1], x[2], ...

# if a collection is ordered then the way it is written in code is the way it is stored

# Q. which collection types are ordered?

name = "Sherlock"

print(name[0])  # this better be 'S' !  
print(name[1])  # if strings were unordered there'd be no guarantee what we'd get here
print(name[-1])

# A. so strings are ordered

basket = ["eggs", "tea", "milk"]

print(basket[0])
print(basket[-1])

# A. lists are ordered

person = ("mycroft holmes", "british intelligence", 35)

print(person[1])
print(person[-3])

# A. tuples are orderd

# a ordered collection is also called a 'sequence'
# looping over a sequence will always give you the same expected order of elements

for element in person:
    print(element)

# ordering also means that the history of a collection's
# modification is preserved    
print(basket)

basket.append('cherries1')
basket.append('cherries2')
basket.append('cherries3')

print(basket)

# UNORDERED

# a collection is unordered if there's no well-defined "next and previous" element
# in python this means if x is unoredered then x[0] (or any integer) will be an error

# Q. which collections are unordered?
user = {"username": "sholmes", "email": "sh@example.com", "address": "Baker St."}

for key in user:
    print(key, user[key])  # not printed in the order its defined!

# A. so dictionaries are unordered
uniques = {"sherlock", "watson", "sherlock"}

for element in uniques:
    print(element)

# A. as are sets



# IMMUTABLE
# a data type is immutable if values of that type cannot be changed

# name[0] = 's'                    # ERROR - strings are immutable
# person[0] = "Mycroft Holmes"     # ERROR - tuples are immutable


# MUTABLE
# a data type is mutable if values (objects) of that type can be changed

# Q. which collections are mutable?

basket = ["eggs", "tea", "milk"]
print(basket)

basket.append('coffee')
print(basket)

# A. lists

user = {"username": "sholmes", "email": "sh@example.com"}
print(user)

user.update({'profession': 'detective'})
print(user)

# A. dictionaries



names = {"sherlock", "watson"}
print(names)

names.add("sherlock")
names.add("mycroft")
print(names)

# A. and sets!


# recall that in python variables denote objects
# you dont "mutate" names, you mutate (change) the objects they refer to


another_basket = basket
print(another_basket)

# we now have two names refering to the same object (basket, another_basket)
# we change another_basket...
another_basket.append('sugar')

# and basket is also changed 
print(basket)

# ASIDE: this isnt a problem for strings because they're immutable..
name = "Sherlock"
another_name = "Sherlock"

print(name is another_name)

# SUMMARY:

# ORDERED:      list, str, tuple
# UNORDERED:    dict, set
# UNIQUE:       set
# IMMUTABLE:    tuple, str
# MUTABLE:      list, set, dict


# REVIEW
basket = ['eggs', 'milk', 'ham']

user = {
    'username': 'mjburgess',
    'email': 'michael.burgess@qa.com'
}

ports = {80, 443, 22, 3306}

address = ('27 Bath Road', 'Cheltenham', 'UK')

name = "Michael"

# Q. What is the first element?
for e in basket:  # A. the first element of basket, basket[0]
    print(e)
    break

for e in user:  # A. UNDEFINED! -- it's a key but there's no defined "first"
    print(e)
    break

for e in ports:  # A. UNDEFINED! -- it's a value but there's no defined "first"
    print(e)
    break

for e in address:  # A. the first elment of address, address[0]
    print(e)
    break

for e in name:  # A. the first character of name, name[0]
    print(e)
    break


''' OUTPUT (05.Collections/Demo05-02.3.Collections.py):
10
10
10
10
10
10
10
10
10
9
[]
{}
()

set()
['D', 'e', 'l', 't', 'a', ' ', 'P', 'l', 'a', 'c', 'e']
M
11
('M', 'i', 'c', 'h', 'a', 'e', 'l')
['Mi', 'ke']
{'email': 'michael@qa', 'username': 'michael'}
{'milk': 2.8, 'eggs': 1.8}
##

# Host Database

#

# localhost is used to configure the loopback interface

# when the system is booting.  Do not change this entry.

##

127.0.0.1	localhost

255.255.255.255	broadcasthost

::1             localhost 

[0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99]
range(0, 100)
0
1
2
S
h
k
eggs
milk
british intelligence
mycroft holmes
mycroft holmes
british intelligence
35
['eggs', 'tea', 'milk']
['eggs', 'tea', 'milk', 'cherries1', 'cherries2', 'cherries3']
email sh@example.com
address Baker St.
username sholmes
sherlock
watson
['eggs', 'tea', 'milk']
['eggs', 'tea', 'milk', 'coffee']
{'email': 'sh@example.com', 'username': 'sholmes'}
{'email': 'sh@example.com', 'profession': 'detective', 'username': 'sholmes'}
{'sherlock', 'watson'}
{'sherlock', 'watson', 'mycroft'}
['eggs', 'tea', 'milk', 'coffee']
['eggs', 'tea', 'milk', 'coffee', 'sugar']
True
eggs
email
80
27 Bath Road
M

'''
