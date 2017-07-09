# SETS

# 1. sets

# sets are collections without repetition

names = {
    "Sherlock",
    "Sherlock",
    "Watson",
    "Mycroft",
    "Watson"
}

print(names)

# 2. the set constructor

print({})
print(type({}))  # Q. what type is {} ?
# A. a dictionary!

# dictionaries and sets both use {}
# so to create an empty set you need to call the constructor function

empty_set = set()
empty_dict = {}

# dictionary exmple for comparison
user = {
    'username': 'michael',
    'email': 'michael.burgess@qa.com'
}

# nb., dictionary syntax is {k: v, ...}
# and  set syntax is  {v1, v2, ...}

# the set constructor fuction is useful for creating sets out of other sequence types...

print(list("Hannah"))  # a list of characeters
print(set("Hannah"))  # a set of characters

# 2. set operations

# sets are particularly useful for their operations

people = {
    'brooks',
    'burgin',
    'greenslade',
    'thorn',
    'burgess'
}

blacklist = {'thorn', 'burgin', 'voldemort'}

print(people - blacklist)  # people without blacklist 
print(people | blacklist)  # people with blacklist (aprox. "set concatentaion")

print(people & blacklist)  # people in both sets 
print(people ^ blacklist)  # people not repeated across sets = (a | b) - (a & b) = total - repetitions

# 3. sets as intermediaries


# often you will start with lists (or some other data structure) 
# and wish to, say, get only the unique elements of the list
# or to get a difference of elements between lists
# but you will utimately still want a list

people = ['zoe', 'zoe', 'michael', 'pete']
bad = ['zoe', 'pete']

# so you can use the set as an intermediate data type 

print(list(set(people) - set(bad)))

# set(people)                       list -> set
# set(bad)                         list -> set
# set(people) - set(bad)        set
# list(...)                     set -> list    




# 4. dictionaries are sets!

print(dict({  # calling dict() on a set of pairs (a set of 2-tuples)
    ('key1', 'value1'),
    ('key2', 'value2')
}))


''' OUTPUT (05.Collections/Demo05-02.6.Sets.py):
{'Mycroft', 'Watson', 'Sherlock'}
{}
<class 'dict'>
['H', 'a', 'n', 'n', 'a', 'h']
{'h', 'a', 'H', 'n'}
{'brooks', 'greenslade', 'burgess'}
{'burgin', 'voldemort', 'thorn', 'brooks', 'greenslade', 'burgess'}
{'burgin', 'thorn'}
{'voldemort', 'greenslade', 'burgess', 'brooks'}
['michael']
{'key2': 'value2', 'key1': 'value1'}

'''
