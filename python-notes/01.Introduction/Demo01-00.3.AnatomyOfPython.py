#!/usr/bin/python               # HASH BANG

# ANATOMY OF PYTHON

import sys                      # LOAD MODULE

num_arguments = len(sys.argv)   # ASSIGNMENT and FUNCTION CALL

if num_arguments > 1:           # COLON-TERMINATED
    print(sys.argv)             # INDENTATION FOR CODE BLOCK
else:
    print('please pass some command-line arguments.')  # NEW-LINE TERMINATED STATEMENTS


""" NOVICE ASIDE:

Why understand the structure of python programs?

Programming languages include rules which determine how programs will look,
understanding the look of python programs helps us understand these rules,
and therefore understand how to read and write programs in the language.
 
"""

# functions are named processes. calling a function runs the process, taking input to output
numbers = [10, 20, 30]
total = sum(numbers)  # numbers is the input to sum ; the output is 60 ; so total is 60

# modules are named groups of names
import os

os.listdir('.')

print(sys.platform)

help(os.listdir)  # HELP is available on each identifier (module, function,..)

dir(__builtins__)  # dir() lists the contents of a namespace, the __builtins__ module has the default ns

# Try REPL ...
""" 
    >>> print("Hello World!?")
    Hello World!?
    
    >>> if 5 > 1 :
    ...     print("Five is greater than One")
    ... 
    Five is greater than One
    >>> 
"""


# Try chmod +x test.py

# Try python -v 
# Try python test.py


''' OUTPUT (01.Introduction/Demo01-00.3.AnatomyOfPython.py):
please pass some command-line arguments.
darwin
Help on built-in function listdir in module posix:

listdir(path=None)
    Return a list containing the names of the files in the directory.
    
    path can be specified as either str or bytes.  If path is bytes,
      the filenames returned will also be bytes; in all other circumstances
      the filenames returned will be str.
    If path is None, uses the path='.'.
    On some platforms, path may also be specified as an open file descriptor;\
      the file descriptor must refer to a directory.
      If this functionality is unavailable, using it raises NotImplementedError.
    
    The list is in arbitrary order.  It does not include the special
    entries '.' and '..' even if they are present in the directory.


'''
