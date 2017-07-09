# SUPPLEMENTAL PROBLEM

# CHAPTER:    String Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:  Using loops and string functions, manage a user profile.
# TIME:       15m

# Q.  request a username and age from the user
# ...  if any input is empty or white space or less than 2 characters
# ...  print a message and ask again
# ...  HINT: while True + continue
while True:
    user_name = input('U. Name? '),
    user_age = input('Age? ')

    if ((user_name.isspace() or len(user_name) < 2) or
            (user_age.isspace() or len(user_age) < 2)):
        continue

    # Q. add all of the user information to a dictionary called user
# with the keys 'name' and 'age'
user = {
    'name': user_name,
    'age': user_age
}

# Q. print 30 dashes
print('-' * 30)

# Q. using .format() print "{}'s Profile" where {} is the username
print("{}'s profile".format(user['name']))

# Q. print 30 dashes
print('-' * 30)

# Q. print the user dictionary
for key in user:
    print(key, user[key])

# Q. for each element of my_hobbies 
# print the type of hobby followed by a space for 
# expected output:  
"""
    philosophy 
    mind

    painting 
    acrylic
"""

my_hobbies = ['philosophy-mind', 'painting-acrylic']
for hobby in my_hobbies:
    info = hobby.split('-')
    print(info[0])
    print(info[1])

# Q. loop until a message from user input starts with correct_prefix 
# then print the message
# HINT: while-True break 

correct_prefix = 'hello, '
while True:
    message = input('Question?')
    if message.startswith(correct_prefix):
        break

print(message)

# EXTRA: 
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

""" REVIEW
What did we learn from this exercise?

startswith, endswith 

how to use string tests and loops to build user interaction
"""


''' OUTPUT (04.Strings/Solution04-StringsB-withLoops.py):
U. Name? Age? 
'''
