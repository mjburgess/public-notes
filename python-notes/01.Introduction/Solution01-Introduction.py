# CHAPTER:    Introduction to Python
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Run python code from the repl and command line. 
# PROBLEM:    Use the os module to browse the file system.  
# TIME:       15 m 

# INTRODUCTION TO EXERCISES 

# most questions are solved by writing code in the file
# and then running the file
# solutions are provided --
# you can have a look at these if you get stuck
# however its best to try on your own
# and wait until the instructor solves the exercise

# before you start an exercise,
# save a copy to *your home folder*
# to keep track of your own solutions


# Q. from the command line
# determine which version of python is being used.
# HINT: python --help 

# python -v 


# Q. define two identifiers (ie., variables)
# one containing your first name 
# and another containing your last name

first_name = 'Sherlock'
last_name = 'Holmes'

# Q. display them using print with a space between each one
# HINT: what does the comma do with the print statement?

print(first_name, last_name)

# Q. run this script
# a)	from a command-line
# b)	From IDLE


# EXTRA 

# the python standard library has a module called os
# the os module provides information and access 
# to operating system commands

# Q. use the os.listdir function 
# to list the contents of the present working directory. 
# HINT: you will need to import os 
# HINT: what symbol means the current directory in file paths?

import os

os.listdir('.')

# Q. use the os.chdir function 
# to change the present working directory 
# to your home folder
os.chdir('/home')

# Q. now list the present directory again
os.listdir('.')

""" REVIEW
What did we learn from this exercise?

1. Two modes for running python: REPL and Interpreter
2. Basic use of variables and print
3. Import statement to import a module by name
4. Using a module's functions with the . operator 
5. Calling functions
6. Basics of using chdir() and listdir()
"""


''' OUTPUT (01.Introduction/Solution01-Introduction.py):
Sherlock Holmes

'''
