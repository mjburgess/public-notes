# CHAPTER:    Flow Control
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using if/elif/else display which pub was chosen.
# TIME:       10 m

import random

option = random.choice(['PubA', 'PubB', 'PubC', 'PubD'])

# Q. if the option is 'PubA' print 'Chose A', 
# and so on for B, C, D ... 

if option == 'PubA':
    print('Chose A')
elif option == 'PubB':
    print('Chose B')
elif option == 'PubC':
    print('Chose C')
else:
    print('Chose D')

# Q. request a password, if the password is not correct_password,
# print “INCORRECT PASSWORD”
# HINT: input
correct_password = 'TEST'

user_password = input('Password? ')
if user_password != correct_password:
    print('INCORRECT PASSWORD')

# EXTRA

# Q. can you rephrase this to use a dictionary?
# HINT: knowing the option, you need a string to print 

option_message = {
    'PubA': 'Chose A',
    'PubB': 'Chose B',
    'PubC': 'Chose C',
    'PubD': 'Chose D'
}

print(option_message[option])

# rather than print “INCORRECT PASSWORD” above, call sys.exit()
# HINT: you will need to import sys 


""" REVIEW
What did we learn from this exercise?

1. if elif else are the branching keywords
2. indentation assocaites a codeblock with the preceeding keyword
3. if/elif/elses that select values can often be replaced with dictionaries 
"""


''' OUTPUT (03.Flow/Solution03-FlowB-Branches.py):
Chose B
Password? INCORRECT PASSWORD
Chose B

'''
