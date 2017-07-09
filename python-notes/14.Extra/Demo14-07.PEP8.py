#  NAMING CONVENTIONS
# class names in CapWords
# methods, functions and variables names in lowercase_with_underscores
# "internal" methods and properties start with _single_underscore
# enforced private methods with __double_underscore
# to use reserved word as an identifier add a _ to the end (e.g. class_)
# always use self for the first argument to instance methods
# always use cls for the first argument to class methods

# IDENTATION, LINE LENGTH
# always use 4 spaces for indentation
# write in ASCII in Python 2 and UTF-8 in Python 3
#  max line-length: 72 characters (especially in comments)
# always indent wrapped code for readablility

# IMPORTS
# no wildcards
# use absolute imports over relative ones
# when using relative imports, be explicit (with .)
# do not import multiple packages per line

# WHITESPACE
# 2 blank lines before top-level function and class definitions
# 1 blank line before class method definitions
# do not use whitespace to line up assignment operators (=, :)
# spaces around = for assignment
# no spaces around = for default parameter values


# COMMENTS
# write in whole sentences
# use inline comments sparingly & avoid obvious comments
# all public functions, classes and methods should have docstrings
# docstrings should start and end with """


""" 

# GOOD
result = some_function_that_takes_arguments(
    'argument one,
    'argument two',
    'argument three'
)

# GOOD
import os
import sys
from mypkg.sibling import example
from subprocess import Popen, PIPE # Acceptable
from .sibling import example # Acceptable

# BAD
import os, sys # multiple packages
import sibling # local module without "."
from mypkg import * # wildcards

"""


''' OUTPUT (14.Extra/Demo14-07.PEP8.py):

'''
