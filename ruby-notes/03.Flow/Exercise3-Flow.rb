# CHAPTER:    Flow Control
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using boolean tests, determine whether you are going to a pub.
# PROBLEM:    Using if/elsif/else, display which pub was chosen.
# PROBLEM:    Using for and if, display selected pub information.
# TIME:       10 m  * 3


# PART 1 -- BOOLEAN TESTS
# PROBLEM: Using boolean tests, determine whether you are going to a pub.

# Q. define name, age, height, location for yourself

# Q. for the following, print the question and the answer:
    # a) is the letter 'A' in your name?
    # b) are you an adult?
    # c) are you an adult under retirement age?
    # d) is 'UK' in your location?
    # e) are you over 1.8m tall?
    # f) are you an adult and in the UK?



bar_distance = 100
bar_crowd = 50
bar_beer = 5

# Q. using the above variables,
#... define is_busy, is_far, is_cheap:
    #... the bar is busy if there's more than 25 people present
    #... the bar is close if it is less than 500m away
    #... the bar is cheap if beer is less than 3.50

# Q. if the bar is near and not busy and cheap
#... print "GOING TO BAR"
#... otherwise print "NOT GOING TO BAR"

# Q. if the bar is busy and near OR cheap
#... print "It'll do"
#... otherwise print "Nope, wont do!"




# PART 2 -- ELSIF
# PROBLEM:  Using if/elsif/else display which pub was chosen.
option = ['PubA', 'PubB', 'PubC', 'PubD'].sample

# Q. if the option is 'PubA' print 'Chose A',
#... and so on for B, C, D ...

# Q. Can you rephrase this to use one puts operation?


# EXTRA: 
# Can you rephrase this to use a hash?
# HINT: knowing the option, you need a string to print 



# PART 3 -- FOR IF
# PROBLEM:  Using for and if display selected pub information.

# Q. modify the following loop to print the pub names
#... that begin with an 'f'
names = ["Finnegan's Wake", "The Horse and Boot", "Forgotten Tales"]
for name in names
    p name 
end 

# Q. modify the following loop to print the pubs > 150 years old
pubs = { finnegan: 130, horse: 185, forgotten: 140 }
for name, age in pubs
    p name, age
end 

## REVIEW: What did we learn from this exercise?