# CHAPTER:    Flow Control
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using while and for loops, manage some hobbies.
# TIME:       20m

ideas = {
    'photography': ['landscape', 'cyanotype'],
    'programming': ['python', 'haskell']
}

# Q. modify the following loop to print the first idea
# in each hobby only 
for hobby in ideas:
    print(hobby)
    print(ideas[hobby][0])

# Q. request a username, firstname, and age from the user
# Q. store all the user information in a dictionary called user
user = {
    'username': input('Username? '),
    'firstname': input('First Name? '),
    'age': input('Age? ')
}

# Q. if the age is less than 18, print NOT ALLOWED
# HINT: int()
if int(user['age']) < 18:
    print('NOT ALLOWED')

# Q. use a while loop to ask for five hobbies:
# store each in a list

# HINT:
# ... 1. first create an empty list to store the hobbies
# ... 2. in the loop, append an input'd hobby to that list
# ... 3. hobbies.append(hobby) adds hobby to the list hobbies
# ... 4. what will len(hobbies) be when you're doing?
hobbies = []
while len(hobbies) < 5:
    hobby = input('Hobby? ')
    hobbies.append(hobby)

""" ALSO:
i = 0
while i < 5:
    i += 1
    hobbies.append(input('Hobby? '))
"""

# Q. use a for loop to do the same thing
# HINT:  range(5)
hobbies = []
for i in range(5):
    hobbies.append(input("Hobby? "))

# EXTRA:
# Q. print out each hobby with an index
# HINT: enumerate
for i, hobby in enumerate(hobbies):
    print(i, hobby)

# Q. use a while-True loop to ask for the user's hobbies 
# break out of the loop when they type 'DONE'
hobbies = []
while True:
    hobby = input('Hobby? ')

    if hobby == 'DONE':
        break

    hobbies.append(hobby)

# Q. print out the hobbies using a for-loop
for hobby in hobbies:
    print(hobby)

# Q. print the user dictionary using a for-loop
# ... each printed line should read, eg., firstname = Sherlock
for key in user:
    print(key, '=', user[key])

""" REVIEW

What did we learn from this exercise?

1. Comparison operators: !=  < 
2. len(x) number of elements in x 
3. Boolean expressions go in the "conditional slots" (contexts) of if/while/etc. statements 
4. while loops repeat code until a condition becomes False
5. Conditions in loops are usually sensitive to the body of the loop (ie. they change)
6. for-loops iterate over data structures (eg. lists, dictionaries, .. "iterables")
7. iterating over a list gives you each element 
8. iterating over a dictionary gives you each key
9. range(n) creates a list of n items, 0 to n 
"""


''' OUTPUT (03.Flow/Solution03-FlowC-Loops.py):
programming
['python', 'haskell']
photography
['landscape', 'cyanotype']
Username? First Name? Age? 
'''
