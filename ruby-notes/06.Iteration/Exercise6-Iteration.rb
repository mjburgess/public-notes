# CHAPTER:    String Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using loop, while, until and each manage some hobbies.
# PROBLEM:    With .map, .reduce and .select, analyse some names and ages.
# TIME:       20 m * 2

# QUESTIONS

# PART 1 -- LOOPS
# PROBLEM:    Using loop, while, until and each manage some hobbies.

# Q.  request a username, full name, and age from the user
#...  if any input is empty or white space or less than 2 characters
#...  print a message and ask again
#...  HINT: loop, next

# Q. add all of the user information to a hash called user
#... , using, .each, print it

# EXTRA: rewrite the last two questions as one simple loop
#... which adds user info. to a hash



# Q. for each element of my_hobbies
#... print the type of hobby and its name on separate lines
my_hobbies = ['philosophy-mind', 'painting-acrylic']
# HINT: .each, .split

# Q. ask the user for a message
#... loop until the message starts with the correct_prefix,
#... and print the remainder
correct_prefix = 'Hello, '
message = ''

# Q. create a hash called hobbies with several string keys:
#... programming, photography, etc.
#... each key should have an empty array as its value

# Q. use loop {} to ask for the user's hobbies until they type 'DONE'
#... expect each input to be, eg. programming-python or photography-landscapes
#... append the hobby name to the relevant list in the dictionary above
# HINT: loop & break on DONE
# HINT: what does hobbies[k] << v  do?


# PART 2 -- COMBINATORS
# PROBLEM:    With .map, .reduce and .select, analyse some names and ages.

# Q. using .map and starting with the lists names and ages..
names = ['Sherlock Holmes', 'John Watson', 'John Adler', 'Irene Adler']
ages  = 20..30

# a) produce a new array, upper_names, of uppercased names
# b) produce a new array, twice_ages, of doubled ages
# c) produce a new array, first_names, of just the first names
# d) produce a new array, is_adler, of bools where True if person is an Adler

# Q. using .map, .all? and .any? answer the following:
# a) do all the names include an 'o' ?
# b) does any name have three parts ?

# Q. using .select and .reject
# a) produce a new array of Johns
# b) produce a new array with no adlers


# Q. what do the following reductions (folds) produce? Why?
p ages.reduce(:+) / ages.size
p names.reduce(:+)
p names.reduce { |t, e| t + ', ' + e }
p names.reduce(true) { |t, e| t && e.include?('John') }
p names.reduce(false) { |t, e| t || e.include?('John') }

# EXTRA

# Q. rewrite the first two questions as one loop
#... .each over info to ask the questions
#... then .each over user to check the details
#... use .map and .all? to check the details
# HINT: break next



## REVIEW: What did we learn from this exercise?
