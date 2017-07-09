# CONVERSIONS 

""" NOVICE ASIDE:

Why do we need to convert between data types?

Each type has its own special characteristics, eg. string vs integer addition. 
Different types represent different properties in the problem domain better. 

eg. A bool cannot represnet a population. 
It could represent if that population is High or Low, eg. is_high = True 
"""

## TYPES 

# each object an identifer refers to has a type. 
# in python part of what the computer remembers, when it stores and object, is its type


name = "Sherlock"
age = 27
city = 'UK'
location = 'London, ' + city
height = 1.81
weight = 70.0
is_adult = True

# we can call (or run, or execute) the function named 'type' to find out what type 

print(type(name))  # type str or "string"
print(type(age))  # int
print(type(city))  # string
print(type(location))  # string
print(type(height))  # float
print(type(weight))  # float
print(type(is_adult))  # bool

# python uses the object's type, primarily, to know what to do with it 
# for example,

print(name * 2)  # prints SherlockSherlock
print(age * 2)  # prints 52

# in each case the * operation does something different and python uses the type to work out what 

# we can also see types as a way of telling us what group something belongs to 
# to say x is an integer is to say it belongs in the group of all things which are whole-numbers  

# type also give you a way to understand what patterns the language allows, 
# for example you cannot write "name / 2" because name is a string -- this syntax is an error 
# but you can write "weight / 2" since weight is a float 

# in this way types are also a way of getting a feel what what is possible and what is not possible 
# python can sometimes give you an error if it expects an object of a different type 

# errors are good! they tell you when you've written something that's broken 
# types, then, also help python tell you when something is broken


## CONVERTING BETWEEN TYPES

# we can convert between types using the name of a type like a function..


print(5 + 5)
print(str(5) + str(5))
print(int('5') + int('5'))
print(float(9) / 2)
print(bool(0))
print(bool(1))


''' OUTPUT (02.Fundamentals/Demo02-01.4.Conversions.py):
<class 'str'>
<class 'int'>
<class 'str'>
<class 'str'>
<class 'float'>
<class 'float'>
<class 'bool'>
SherlockSherlock
54
10
55
10
4.5
False
True

'''
