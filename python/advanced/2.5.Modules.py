# 2.5.Modules.py

#1. Modules

# Q. What is a module?
# A. an object just like any other...


import os       # creates a module object called os
                # ie., it adds a name, os, to the current namespace
                # and os refers to an object....

# look! ..
print type(os)
print dir(os)


print os.listdir('.')


# this is equivlaent to something like,

time = __import__('time') # the __import__() function takes the name of module
                          # and returns a module object

print time.time()



# a module object is just like any other, excpet it's namespace typically comes from a file
# that is, all the names inside the module object are put there as a result of running a .py file


# __name__ is a predefined variable in python
#
print __name__
