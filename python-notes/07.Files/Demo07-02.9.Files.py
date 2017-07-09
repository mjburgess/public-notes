# FILES

# ASIDE: __file__ is the full path of the current script -- a magic constant
import os
this_dir = os.path.dirname(os.path.realpath(__file__))

messier_data = this_dir + 'Xtra05-messier.txt'

# 1. file objects

# messier is a file object
messier = open(messier_data)

# it has methods, eg. .read()
contents = messier.read()

# it represents a connection to a stream of data
messier = open(messier_data, 'r')  # READ MODE

# the stream has a cursor, like a text editor
# writing moves the cursor along, and so does reading

print(messier.readline())  # gets the first line
print(messier.readline())  # gets the *second* line!
# .readline() moves the cursor along one line!

# Q. where is the cursor?
# A. f.tell()

print(messier.tell())

# Q. how do you move the cursor manually?
# A. f.seek()

messier.seek(458)

print(messier.read(100))  # read 100 bytes @ position 458

# using .seek(), .tell() and .read() you can read small amounts from any point in a file
# so if your file is 4GB you don't need to load it all into memory!


# 2. iterating over file objects

# typically you don't need to .read(), .readline() on a file object
# file objects are iterable, and can be used in a for loop

for line in open(messier_data):
    print(line)
    break  # causes loop to break after the first line

# 3. writing to files

data = open('data.txt', 'w')  # WRITE MODE

baskets = [
    ['ham', 'milk'],
    ['cherries', 'lemonade']
]

for basket in baskets:
    data.write(','.join(basket) + "\n")

data.close()

# write mode opens a file for writing
# and sets the curosr position to the start of the file
# and will overwrite any existing files!


# if you want to append to the end of an existing file, use the append mode

print("bacon, tomato", file=open('data.txt', 'a'))  # APPEND MODE

# Q. what does the >> operator do?
# A. redirects the output of a print statement to a given file object


# context management

with open('foo.txt', 'w') as f:
    f.write('Message')


# MODES

"""
r   READ
w   WRITE
a   APPEND
r+  READ-WRITE (existing)
w+  READ-WRITE (new)
a+  APPEND (new)
"""

## STANDARD STREAMS 


import sys

sys.stdout.write('Hello World? ')
sys.stdout.flush()

reply = sys.stdin.readline()
print(reply)

# OR, 
print(input('Hello World? '))

# DELETEing
import os

os.unlink('foo.txt')
os.unlink('data.txt')


''' OUTPUT (07.Files/Demo07-02.9.Files.py):

'''
