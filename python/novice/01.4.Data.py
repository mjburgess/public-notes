"""
Let's talk about objects in more detail.

An object is any thing  python remembers, anything you can grab-hold-of with an identifier. 
"""

name = "Michael"
another = "Michael"

"""
Here name and another are identifiers which refer to the object "Michael".  
"""


# 3. objects
print id(name)            #Q. why do these functions print the same value?
print id(another)        #A. the names refer to the same object!


print "properties of objects"
print
print

#all values are objects

#Q. what's a value?
#A. anything you can assign to a variable...

obj = "Michael"

# Q. obj is a name (ie. a variable); what does this variable refer to?
# A. the object "Michael"

# Q. what are the properties of objects?

print id(obj)        #A. they have a place in memory (more generally, an identity)
print obj            #A. they have state (ie. data that they contain)
print type(obj)        #A. they have a type that determines their capabilities
print dir(obj)        #A. they have a namespace
print obj.upper()    #A. 'upper' is a name in obj's namespace -- it denotes a function

#Q. what does the . operator do?
#A. looks up a name in a namespace

#Q. what does the ()-operator do (when placed after a name, eg. x() ) ?
#A. calls the function refered to by x


#4. ASIDE: Q. how many names refer to an object?


import sys        # the sys module provides python-system (ie. VM-related) information & tools

print sys.getrefcount(name)        # the number of names which refer to "Michael"

del another                        # recall that 'name' and 'another' refer to "Michael`"

print sys.getrefcount(name)        # so now there's one less

#Q. what does del do?
#A. it unbinds ("unassigns") a name


#5. ASIDE: Q. what are all the names defined locally?

print locals() #A. locals() returns a list of them
