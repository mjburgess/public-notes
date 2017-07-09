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
    print(ideas[hobby])


# Q. request a username, firstname, and age from the user
# Q. store all the user information in a dictionary called user

# Q. if the age is less than 18, print NOT ALLOWED
# HINT: int()

# Q. use a while loop to ask for five hobbies: 
# store each in a list

# HINTs:
# ... 1. first create an empty list to store the hobbies
# ... 2. in the loop, append an input'd hobby to that list
# ... 3. hobbies.append(hobby) adds hobby to the list hobbies 
# ... 4. what will len(hobbies) be when you're done?

# Q. use a for loop to do the same thing
# HINT:  range(5)


# EXTRA:
# Q. print out each hobby with an index
# HINT: enumerate


# Q. print the user dictionary using a for-loop
# ... each printed line should read, eg., firstname = Sherlock


# Q. use a while-True loop to ask for the user's hobbies 
# break out of the loop when they type 'DONE'


# Q. print out the hobbies using a for-loop



''' OUTPUT (03.Flow/Exercise03-FlowC-Loops.py):
programming
['python', 'haskell']
photography
['landscape', 'cyanotype']

'''
