""" NOVICE ASIDE:

Why do we need to make grammatical distinctions?

They help us to identify what the computer is doing when it reads something fitting into a particular grammatical category.
They also help determine which programs are syntax-valid. 
"""

# LITERALS:
# A literal is any data written literally, as in, it is written in the code. 
# Each of the following identifiers are assigned literal values. 

name = "Michael"
age = 27
location = 'UK'
height = 1.81

# EXPRESSIONS:
# An expression is any valid syntactical phrase (sequence of symbols) that calculates a value.
# We're very familiar with mathematical expressions 5 + 1 , 7 * 2, etc. 

# In programming language very many phrases like this actually "calculate values" meaning that, 
# when the computer reads them it replaces them with the value it calculates.

# For example if I say, "I am 5*5 years old" we can read that to mean "I am 25 years old":
# to understand what "5 * 5 years old" means replace the expression 5 * 5 with the value it calcualtes.

# Another definition of expression is "anything you can put on the RHS of an assigment..."


full_name = 'Michael' + ' ' + 'Burgess'
working_years = 65 - age
address = 'London,' + location
weight = 12 * (14 / 2.2)
bmi = weight / (height ** 2)

# STATEMENTS:
# Statements are any syntactical phrase which does not calculate a value,
# i.e., which performs an action. 

# Each of the above lines is, in total, a statement. The action it performs is assignment.

# While, in each case, a variable is *given* a value -- the line itself has no value. 
# Other kinds of statements include the print statement:

print()  # prints a newline
print("Some Information About You")
print("Your name is", full_name)
print("Your age is", age)
print()

# with print statements *AND PRINT STATEMENTS ALONE*
# the comma means print a space

# the comma symbol takes on a different meaning in other contexts


#  FUNCTION CALLS:

# The expressions we have used above calculate values using operators, eg. 14/2.2 

# However it also possible to use *named* predefined machines which can calculate values for us.
# These machines or "functions" apply some recipie (or algorithm) to some given input. 

# For example, the function named len takes in a collection and tells you how may things are in it. 

print(len("Michael"))  # prints 7 because there are 7 letters in Michael

# The identifier which we use to run the function is incidental..

mylen = len

print(mylen("Michael"))  # it does the same thing!

# equally, we can change the object the identifier 'len' refers to:
len = 5

print(len * len)  # prints 25

# len is just an identifier like any other, 
# when you use it you tell python to find the object it refers to


''' OUTPUT (01.Introduction/Demo01-00.4.AnatomyOfPrograms.py):

Some Information About You
Your name is Michael Burgess
Your age is 27

7
7
25

'''
