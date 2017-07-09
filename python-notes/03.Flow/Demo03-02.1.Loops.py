# LOOPS


""" NOVICE ASIDE:

Why do we use loops?

In many situations we want to repeat an operation, or in otherwords, loop-around and do it again. 

One very common situation is with collections of information, eg. lists.

For example, we often want apply the same operation to each element of a list.. 
to, for example, print every element. 
"""

# ASIDE: you can use multiline strings to "comment-out" code...
# eg.,

"""
print "This will not"
"""

# or put put it back in..

# """
print("This will run!")
# """

# you may find it helpful to triple-quote some of the code below to "turn it off"


# 0. sys.exit and exit

# before looking at loops there is an important control flow option we need to consider:
# how to terminate a program.  

# the preffered method is to call the sys.exit function 
# which gracefully closes relevant connections and releases memory correctly, etc.

# the exit() function is less graceful and should only be used in a REPL session

"""
import sys
sys.exit("Error Message")      # terminates the program
"""

"""
exit()        # terminates a REPL session (always prefer sys.exit() !)
"""

# on to loops...

# 1. the while loop
print("the while loop")
# the while loop continues executing its body until it's condition becomes false

line = None  # Q. what does None indicate?
# A. An absence of value.

while line != "q":  # nb., line becoming 'q' makes line != 'q' False
    line = input("? ")  # nb., input() prompts a user for input, try it!
    print(line)  # nb., therefore this is a "print loop" it echo's what you send to it

# 2. jump statements (continue and break)
print("the while loop -- jumps")

line = None

while line != "q":
    line = input("? ")

    if line == 'damn':
        continue  # nb., skips the rest of the loop body

    print(line)  # nb., therefore every input other than "damn" is printed!

print("the while loop -- jumps")

line = None

while line != "q":
    line = input("? ")

    if line == 'quit':
        break  # nb., jumps out of the loop entirely

    print(line)  # nb., therefore terminates the loop if "quit" is entered

# AIDE: 'pass' means "do nothing" and is used when python's grammer requires a code block
print("the while loop -- pass")

line = None

while line != "q":
    line = input("? ")

    if line == 'damn':
        pass  # nb., pass applies to the if-statement here
        # so this has no effect!

    print(line)

# ASIDE: infinite loops

"""

while True:
    print "Running..."

#Q. how long does this loop run for?
#A. until the python interpreter is closed ("forever")
    
"""
print("the while loop -- jumps")

# Q. how long does this run for?

while True:
    some_input = input('? ')

    if some_input == 'q':
        break

    print(some_input)

# 3. looping over data

# Q. how do you find out what a function does, given its name?
# A. call help(name_of_function)


# Q. if x is a list, what does x.pop do?
# A. help(x.pop)


basket = ['cherries', 'bananna', 'lemonade']

while basket:  # Q. when is a list False, ie., bool(lst) is False?
    # A. when it's empty!
    print(basket.pop())

    # nb., .pop() removes last element

# "never" use while for looping over data structures
# python has a dedicated for-loop for doing just that!
# there's very limited use for "while" in any python program..


# Q. what is the type of basket?
# A. list

basket = ['cherries', 'bananna', 'lemonade']

for item in basket:  # nb., colon + indentation, as ever for code blocks
    print(item)

# this for loop assigns each element of basket to the name 'item'
# executing "print item" for each


# Q. what does range(0, 3) return?
# A. a list [0, 1, 2]

# Q. what is len(basket) ?
# A. 3


# Q. so, what does range(0, len(basket)) return?


for index in range(0, len(basket)):
    print(index)  # Q. what type is index?
    # A. an int

# 4. looping over multiple lists at once

# ASIDE: tuples

# tuples are immutable lists
point = (0, 1)

print(point[-1])  # Q. prints?

"""
point[0] = 1  #Q. why does this fail?
              #A. tuples are immutable
"""

# they can be unpacked (as can any sequence...)

(x, (y, z, (a,))) = ('michael', (90, 1.81, ('purple',)))

# Q. what's a? what's z?
# A. a is 'purple' and z is 1.81

# this is called destructuring
# and has the general form,            RHS-pattern = LHS-data-structure


# the data structure on the RHS of the above destructuring is called a tuple
# the pattern on the LHS says "extract x from the RHS at position 0, ..."




# here we have a list of tuples (a tuple of two elements is known as a pair)
# so we have a list of pairs

index_basket = [(0, 'cherries'), (1, 'banna'), (2, 'lemonade')]

# the for-loop supports destructuring on each element of the input list
# each element is a pair
for index, item in index_basket:
    print(index, item)  # so it is destructured into index = 0, item = 'cherries' ...

# Q. what does the enumerate(input) function return?
# A. produces a list of pairs

# Q. what does each pair contain?
# A. the first element of the pair is an integer, the second element is from the input
# ie.,  [(0, input[0]), (1, input[1]), ...]


print("enumerate")
for i, item in enumerate(basket):  # Q. what's the type of i?  A. int
    print(i, item)  # Q. what's printed?

# Q. what does the zip(xs, ys) function return?
# A. a list of pairs

# Q. what does each pair contain?
# A. (xs[0], ys[0])  for each element, 0, 1, 2...

prices = [1.50, 0.20, 2.50]

for price, item in zip(prices, basket):
    print(price, item)  # Q. type of price? A. float
    # A. type of item? A. str


# Q. what does zip(xs, ys, zs) return?
# A. a list of triples:  [(xs[0], ys[0], zs[0]), ...]



# Q. why do we use enumerate()?
# A. to loop over a list with the index position of each element


# Q. why do we use zip()?
# A. to loop over multiple lists at the same time


''' OUTPUT (03.Flow/Demo03-02.1.Loops.py):
This will run!
the while loop
? q
the while loop -- jumps
? q
the while loop -- jumps
? q
the while loop -- pass
? q
the while loop -- jumps
? lemonade
bananna
cherries
cherries
bananna
lemonade
0
1
2
1
0 cherries
1 banna
2 lemonade
enumerate
0 cherries
1 bananna
2 lemonade
1.5 cherries
0.2 bananna
2.5 lemonade

'''
