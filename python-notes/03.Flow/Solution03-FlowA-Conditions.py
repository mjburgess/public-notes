# CHAPTER:    Flow Control
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using boolean tests, determine whether you are going to a pub.
# TIME:       10 m

# Q. define name, age, height, location for yourself
name = 'michael'
age = 27
height = 1.8
location = 'Delta PLace, UK'

# Q. for each of the following questions 
# print the question and the answer:

# a) is the letter 'a' in your name?
print('is the letter a in your name?')
print('a' in name)

# b) are you an adult?
print('are you an adult?')
print(age >= 18)

# c) are you of retirement age?
print('are you of retirement age?')
print(age >= 65)

# d) is 'UK' in your location?
print("is 'UK' in your location?")
print('UK' in location)

# e) are you over 1.8m tall?
print('are you over 1.8m tall?')
print(height > 1.8)

# f) are you an adult and in the UK? 
print('adult in uk?')
print((age >= 18) and ('UK' in location))

bar_distance = 100
bar_crowd = 50
bar_beer = 5

# Q. using the above variables,
# ... define is_busy, is_far, is_cheap:
# ... the bar is busy if there's more than 25 people present
# ... the bar is close if it is less than 500m away
# ... the bar is cheap if beer is less than 3.50

is_busy = bar_crowd > 25
is_far = bar_distance >= 500
is_cheap = bar_beer < 3.5

# Q. if the bar is near and not busy and cheap
# ... print "GOING TO BAR"
# ... otherwise print "NOT GOING TO BAR"

if (not is_far) and (not is_busy) and is_cheap:
    print("GOING TO BAR")
else:
    print("NOT GOING TO BAR")

# Q. if the bar is busy and near OR cheap
# ... print "It'll do"
# ... otherwise print "Nope, wont do!"
if is_busy and (not is_far or is_cheap):
    print("It'll do!")
else:
    print("Nope! Won't do!")

# or, (is_busy and not is_near) or is_cheap
# Q. which should it be?

""" REVIEW

What did we learn from this exercise?

1. Comparison expressions evaluate to True or False. 
2. Logical expressions combine True and False (with and, or, not).
3. Comparison and Logical expressions are both boolean: they evaluate to True, or evaluate to False. 
4. Comparison operators test values.
5. Logical operators combine tests.  
6. A boolean expression can be assigned to a variable, like any other expression.  

"""


''' OUTPUT (03.Flow/Solution03-FlowA-Conditions.py):
is the letter a in your name?
True
are you an adult?
True
are you of retirement age?
False
is 'UK' in your location?
True
are you over 1.8m tall?
False
adult in uk?
True
NOT GOING TO BAR
It'll do!

'''
