# OBJECTS

""" NOVICE ASIDE:

Why do we use values?

Values are the data the program works with. 
Values are more than just data. 
Values are objects. 
Objects contain the data of interest, but also other information the program needs.
 
"""

print("properties of objects")
print()
print()

# all values are objects

# Q. what's a value?
# A. anything you can assign to a variable...

obj = "Michael"

# Q. obj is a name (ie. a variable); what does this variable refer to?
# A. the object "Michael"

# Q. what are the properties of objects?

print(id(obj))  # A. they have a place in memory (more generally, an identity)
print(obj)  # A. they have state (ie. data that they contain)
print(type(obj))  # A. they have a type that determines their capabilities
print(dir(obj))  # A. they have a namespace
print(obj.upper())  # A. 'upper' is a name in obj's namespace -- it denotes a function

# Q. what does the . operator do?
# A. looks up a name in a namespace

# Q. what does the ()-operator do (when placed after a name, eg. x() ) ?
# A. calls the function referred to by x


# Q. what is 'obj', the identifier?
# A. an entry in the present namespace for that object


''' OUTPUT (02.Fundamentals/Demo02-01.2.Objects.py):
properties of objects


4347053536
Michael
<class 'str'>
['__add__', '__class__', '__contains__', '__delattr__', '__dir__', '__doc__', '__eq__', '__format__', '__ge__', '__getattribute__', '__getitem__', '__getnewargs__', '__gt__', '__hash__', '__init__', '__iter__', '__le__', '__len__', '__lt__', '__mod__', '__mul__', '__ne__', '__new__', '__reduce__', '__reduce_ex__', '__repr__', '__rmod__', '__rmul__', '__setattr__', '__sizeof__', '__str__', '__subclasshook__', 'capitalize', 'casefold', 'center', 'count', 'encode', 'endswith', 'expandtabs', 'find', 'format', 'format_map', 'index', 'isalnum', 'isalpha', 'isdecimal', 'isdigit', 'isidentifier', 'islower', 'isnumeric', 'isprintable', 'isspace', 'istitle', 'isupper', 'join', 'ljust', 'lower', 'lstrip', 'maketrans', 'partition', 'replace', 'rfind', 'rindex', 'rjust', 'rpartition', 'rsplit', 'rstrip', 'split', 'splitlines', 'startswith', 'strip', 'swapcase', 'title', 'translate', 'upper', 'zfill']
MICHAEL

'''
