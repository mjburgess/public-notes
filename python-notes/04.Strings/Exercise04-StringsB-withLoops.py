# SUPPLEMENTAL PROBLEM

# CHAPTER:    String Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:  Using loops and string functions, manage a user profile.
# TIME:       15m

# Q.  request a username and age from the user
# ...  if any input is empty or white space or less than 2 characters
# ...  print a message and ask again
# ...  HINT: while True + continue

# Q. add all of the user information to a dictionary called user
# with the keys 'name' and 'age'

# Q. print 30 dashes

# Q. using .format() print "{}'s Profile" where {} is the username

# Q. print 30 dashes

# Q. print the user dictionary



my_hobbies = ['philosophy-mind', 'painting-acrylic']
# Q. for each element of my_hobbies 
# print the type of hobby followed by a space for 
# expected output:  
"""
    philosophy 
    mind

    painting 
    acrylic
"""

# Q. loop until a message from user input starts with correct_prefix
# then print the message
# HINT: while-True break 

correct_prefix = 'hello, '

# EXTRA
hobbies = {
    'programming': [],
    'photography': []
}

while True:
    hobby = input('Hobby? ')

    if hobby == 'DONE':
        break

    hobby_type, hobby_name = hobby.split('-')
    hobbies[hobby_type].append(hobby_name)

print(hobbies)

# Q. what format of user input does the above loop expect?

# Q. run the above code, 
# add several hobbies in the programming category


''' OUTPUT (04.Strings/Exercise04-StringsB-withLoops.py):
Hobby? 
'''
