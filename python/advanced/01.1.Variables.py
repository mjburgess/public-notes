# 1.1.Variables.py

#1. variable assignment
#... or "binding a name to a value"

name = "Michael"
another = "Michael"


#Q. what are varaibles?
#A. lexical names (words in written code) which refer to objects

print id(name)            #Q. why do these functions print the same value?
print id(another)        #A. the names refer to the same object!


#2. naming conventions

# an underscore implies to the person reading (or using)
# the code that the variable is not to be used (read to or written from) externally
# it's only for use by this bit of code...

_private = "my favourite colour is purple!"

# eg., perhaps a _private (by convention) variable is only used locally because
# it's value changes all the time and you dont want any one else to use it

_password = "changes all the time"

password = "stable" # use this one!


# python additionally has __x-style varaibles whose name will be changed by the interpreter
#nb., best to stay away from using double-underscores (__) unless you know what you're doing

__really_private = "hello"



# the variable __name__ is provided by the interpreter (eg., python.exe)
# it contains the name of the currently running module
# here's it's just an example of how python uses __x__-style names to indicate
# that it's a language (vs. user-provided) feature

print __name__


# 3. objects

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
