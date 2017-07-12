# CHAPTER:    Fundamentals
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Store and display information about yourself.
# TIME:       20m


# QUESTIONS
# Q. define a variable which refers to your name
name = "Sherlock"

# Q. define a title which is
# your name concatenated to "'s Profile"
title = name + "'s Profile"

# Q. define a variable which refers to your height in cm
height = 181

# Q. define your age as a whole number of years plus a fraction of 12
# HINT:  if there is two months until your birthday, you're age is + 10/12
age = 27 + 10.0/12

# Q. Use gets.chomp to get a first_name from the user.
first_name = gets.chomp

# Q. print the following:
# a) first_name
puts first_name

# b) first_name in upper case.
puts first_name.upcase

# c) the number of characters in first_name.
puts first_name.size

# Q. create an array of your hobbies
hobbies = %w{photography programming painting}        # OR,
hobbies = ['photography', 'programming', 'painting']  # OR,
hobbies = 'photography', 'programming', 'painting'    # etc.

# Q. print out this information and the last of your hobbies
puts hobbies
puts hobbies[-1]

# EXTRA
# Q. create a hash called 'me' with the symbolic keys:
#... name, height, age and hobbies
#... and values as defined above

me = {
    name: name,
    age: age,
    height: height,
    hobbies: hobbies
}

# Q. add username and password entries to 'me'
me[:username] = 'sherlock'
me[:password] = 'pa$$'

# Q. Without running the code, what is a + b + c + d ?
a = 10
b = 0xA
c = 0b1010
d = 012

p a + b + c + d     # 40