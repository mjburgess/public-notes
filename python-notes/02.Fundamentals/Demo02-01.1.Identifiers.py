# IDENTIFIERS 

""" NOVICE ASIDE:

Why do we use identifiers?

To name data. 
Data represents properties of interest. 
We need to name these properties in order to operate on them in the program.
AND in order that the program correctly describes the problem.

"""

# 1. defining an identifier
# ... or "binding a name to a value"

name = "Michael"
another = "Michael"

# Q. what are identifiers?
# A. lexical names (words in written code) which refer to objects

print(id(name))  # Q. why do these functions print the same value?
print(id(another))  # A. the names refer to the same object!

# 2. naming conventions

# an underscore implies to the person reading (or using)
# the code that the variable is not to be used (read to or written from) externally
# it's only for use by this bit of code...

_private = "my favourite colour is purple!"

# eg., perhaps a _private (by convention) variable is only used locally because
# it's value changes all the time and you dont want any one else to use it

_password = "changes all the time"

password = "stable"  # use this one!

# python additionally has __x-style varaibles whose name will be changed by the interpreter
# nb., best to stay away from using double-underscores (__) unless you know what you're doing

__really_private = "hello"

# the identifier __name__ is provided by the interpreter (eg., python.exe)
# it contains the name of the currently running module
# here's it's just an example of how python uses __x__-style names to indicate
# that it's a language (vs. user-provided) feature

print(__name__)

# 3. deleting identifiers

# ASIDE: Q. how many names refer to an object?

import sys  # the sys module provides python-system (ie. VM-related) information & tools

print(sys.getrefcount(name))  # the number of names which refer to "Michael"

del another  # recall that 'name' and 'another' refer to "Michael`"

print(sys.getrefcount(name))  # so now there's one less

# Q. what does del do?
# A. it unbinds ("unassigns") a name


# 5. ASIDE: Q. what are all the names defined locally?

print(locals())  # A. locals() returns a list of them

''' OUTPUT (02.Fundamentals/Demo02-01.1.Identifiers.py):
4354450968
4354450968
__main__
5
4
{'password': 'stable', '__name__': '__main__', 
'__file__': '02.Fundamentals/Demo02-01.1.Identifiers.py', 
'sys': <module 'sys' (built-in)>, '__really_private': 'hello', 
'_private': 'my favourite colour is purple!', '__cached__': None, 
'__builtins__': <module 'builtins' (built-in)>, 
'_password': 'changes all the time', 
'__doc__': ' NOVICE ASIDE:\n\nWhy do we use identifiers?\n\n
To name data. \nData represents properties of interest. \n
We need to name these properties in order to operate on them in the program.
\nAND in order that the program correctly describes the problem.\n\n', 
'__spec__': None, '__package__': None, 'name': 'Michael', 
'__loader__': <_frozen_importlib_external.SourceFileLoader object at 0x10379e828>}

'''
