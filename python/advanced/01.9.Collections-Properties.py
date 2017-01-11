# 1.9.Collections-Properties.py

#0. collections

# recall the collection types...

lst = ["eggs", "tea", "milk"]
tpl = ("detective", 27)
dct = {"name": "watson", "profession": "dr"}
st  = {"sherlock", "watson"}

#Q. Which one is missing?

string = "A string is a collection!"


#1. ORDERED
# A collection is ordered if there is a well-defined "previous element" and "next element"

# in python all ordered collections have monotonically increasing integer indexes, 
# ie., x is ordered if x[0], x[1], x[2], ...

# if a collection is ordered then the way it is written in code is the way it is stored

# Q. which collection types are ordered?

name = "Sherlock"

print name[0]        # this better be 'S' !  
print name[1]        # if strings were unordered there'd be no guarantee what we'd get here
print name[-1]

#A. so strings are ordered

basket = ["eggs", "tea", "milk"]

print basket[0]
print basket[-1]

#A. lists are ordered


person = ("mycroft holmes", "british intelligence", 35)

print person[1]
print person[-3]

#A. tuples are orderd

# a ordered collection is also called a 'sequence'
# looping over a sequence will always give you the same expected order of elements

for element in person:
    print element

    

# ordering also means that the history of a collection's
# modification is preserved    
print basket

basket.append('cherries1')
basket.append('cherries2')
basket.append('cherries3')

print basket



# UNORDERED

# a collection is unordered if there's no well-defined "next and previous" element
# in python this means if x is unoredered then x[0] (or any integer) will be an error

# Q. which collections are unordered?

user = {"username": "sholmes", "email": "sh@example.com", "address": "Baker St."}

for key in user:
    print key, user[key]        # not printed in the order its defined!


#A. so dictionaries are unordered

uniques = {"sherlock", "watson", "sherlock"}

for element in uniques:
    print element

    
#A. as are sets


    
# IMMUTABLE
# a data type is immutable if values of that type cannot be changed

# name[0] = 's'                    # ERROR - strings are immutable
# person[0] = "Mycroft Holmes"  # ERROR - tuples are immutable


# MUTABLE
# a data type is mutable if values (objects) of that type can be changed

#Q. which collections are mutable?

basket = ["eggs", "tea", "milk"]
print basket

basket.append('coffee')
print basket

#A. lists



user = {"username": "sholmes", "email": "sh@example.com"}
print user

user.update({'profession': 'detective'})
print user

#A. dictionaries



names = {"sherlock", "watson"}
print names


names.add("sherlock")
names.add("mycroft")
print names

#A. and sets!


# recall that in python variables denote objects
# you dont "mutate" names, you mutate (change) the objects they refer to


another_basket = basket
print another_basket

# we now have two names refering to the same object (basket, another_basket)
# we change another_basket...
another_basket.append('sugar')

# and basket is also changed 
print basket


#ASIDE: this isnt a problem for strings because they're immutable..

name = "Sherlock"
another_name = "Sherlock"

print name is another_name


# SUMMARY:

# ORDERED:         list, str, tuple
# UNORDERED:    dict, set
# UNIQUE:        set
# IMMUTABLE:    tuple, str
# MUTABLE:        list, set, dict


#0. review


basket = ['eggs', 'milk', 'ham']

user = {
    'username': 'mjburgess',
    'email': 'michael.burgess@qa.com'
}

ports = {80, 443, 22, 3306}

address = ('27 Bath Road', 'Cheltenham', 'UK')

name = "Michael"

#Q. What is the first element?

for e in basket:        #A. the first element of basket, basket[0]
    print e
    break

for e in user:            #A. UNDEFINED! -- it's a key but there's no defined "first"
    print e
    break
    
for e in ports:            #A. UNDEFINED! -- it's a value but there's no defined "first"
    print e
    break
    
for e in address:        #A. the first elment of address, address[0]
    print e
    break
    
for e in name:            #A. the first character of name, name[0]
    print e
    break
    
    

#1. slicing    

# recall string slicing...

quote = "I only have my wit to declare!"

print quote[0:6]

print quote[:6]

print quote[-8:]


# syntax:   quote[ start position :  end position ]

# slicing is possible on any sequence type, eg. lists

print basket[0:2]


# and for mutable data types, you can *assign* to a slice...

print basket

basket[0:2] = ['peas', 'beans']
print basket

# which modifies the original


#Q. if -1 is the last element, what is :0?
#A. a non-existent "first element"

basket[:0] = ['limes']
print basket

# if that's confusing, just remember that x[:0] = y  prepends y to x




#2.  Copying

# when you read from a slice you take a copy of the data

basket = ['eggs', 'ham', 'cherries']

another = basket[0:2]      #    another points to a new list composed of basket[0], basket[1]

another.append('cheese') #     so modifying another does not modify basket

print basket
print another


# using this mechanism we can take copies of entire lists

more = basket[:] #slice from the start position until the end position

more.append('lemonade')

print more
print basket

# however this is a shallow copy, it copies *the list* 
# it does not make new copies of each element...


# when your elements are strings this doesnt matter..
# but when your elements are mutable, eg. they're lists, it does:


baskets = [ 
    ['eggs', 'ham'], 
    ['cheese', 'milk'] 
] #list of lists

carts = baskets[:] # copy baskets

print baskets
print carts

baskets.append(['lemonade', 'coke']) # append to *baskets*

print baskets
print carts            # carts is unmodified beause *baskets* was changed


# however what if we change an element of baskets...

baskets[0][1] = 'bread'

# then both change!
print baskets
print carts

# why ?

print carts is baskets  # False, as expected.

print carts[0] is baskets[0] # True!

# the name carts refers to a differet list, but the objects of that list are the same!


#3. iterables
# collections are not the only kind of data type you can use in a for-loop
# the general name for an object that can be iterated over in a for-loop is an iterables

f = open('messier.txt') # f is a file object

for line in f:            # f is iterable
    print line            # f is a sequence of lines


# the range function gives you a list    
print range(0, 100)

#the xrange function gives you an xrange object
print xrange(0, 100)

for i in xrange(0, 3):        # xrange()s are iterable
    print i
    

# xrange objects, like file objects, give you "one element at a time, on demand"
# whereas, for example, lists are stored in their entireity up-front

# range(-2000000000, 2000000000) -- not enough memory!

wide_range = xrange(-2000000000, 2000000000) # -- just fine
 
 
#3. map, filter, (..reduce)

user_input = ['sholmes', '', '0']
ages_input = ['18', '22', '30']

print map(bool, user_input)
print map(int, ages_input)
print filter(bool, user_input)


#Q. what arguments does map() and filter() take?
#A. a function and a sequence

#Q. what do they do?

# ...more on these later...


