# CHAPTER:    String Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using loop, while, until and each manage some hobbies.
# PROBLEM:    With .map, .reduce and .select, analyse some names and ages.
# TIME:       30m

# QUESTIONS

# PART 1 -- LOOPS
# PROBLEM:    Using loop, while, until and each manage some hobbies.

# Q.  request a username, full name, and age from the user
#...  if any input is empty or white space or less than 2 characters
#...  print a message and ask again
#...  HINT: loop, next, break

loop {
  puts "Username? "
  username = gets.chomp
  if username.strip.empty? || username.size < 2
    next
  end


  puts "Name? "
  fullname = gets.chomp
  if fullname.strip.empty? || fullname.size < 2
    next
  end

  puts "Age? "
  age = gets.chomp
  if age.strip.empty? || age.size < 2
    next
  end

  break
}


# Q. add all of the user information to a hash called user
#... , using, .each, print it
user = {
    username: username,
    fullname: fullname,
    age: age
}

user.each { |k, v|
  puts v
}

# Q. for each element of my_hobbies
#... print the type of hobby and its name on separate lines
# HINT: .each, .split

my_hobbies = ['philosophy-mind', 'painting-acrylic']

my_hobbies.each { |h|
  puts h.split('-')
}

# Q. ask the user for a message
#... loop until the message starts with the correct_prefix,
#... and print the remainder
correct_prefix = 'Hello, '
message = ''

until message.start_with? correct_prefix
  message = gets.chomp
end

# Q. create a hash called hobbies with several string keys:
#... programming, photography, etc.
#... each key should have an empty array as its value
hobbies = {
  'programming' => [],
  'photography' => []
}

# Q. use loop {} to ask for the user's hobbies until they type 'DONE'
#... expect each input to be, eg. programming-python or photography-landscapes
#... append the hobby name to the relevant list in the dictionary above
# HINT: loop & break on DONE
# HINT: what does hobbies[k] << v  do?

loop {
  puts 'Hobby? '
  input = gets.chomp
  if input == 'DONE'
    break
  else
    type, name = input.split('-')
    hobbies[type] << name
  end
}

# PART 2 -- COMBINATORS
# PROBLEM:    With .map, .reduce and .select, analyse some names and ages.

# Q. using .map and starting with the lists names and ages..
names = ['Sherlock Holmes', 'John Watson', 'John Adler', 'Irene Adler']
ages  = 20..30

# a) produce a new array, upper_names, of uppercased names
upper_names = names.map { |n| n.upcase }   #, OR,
upper_names = names.map(&:upcase)

# b) produce a new array, twice_ages, of doubled ages
twice_ages = ages.map { |a| a * 2 }

# c) produce a new array, first_names, of just the first names
first_names = names.map { |n| n.split.first }             # , OR,  split(' ')[0]

# d) produce a new array, is_adler, of bools where True if person is an Adler
is_adler = names.map { |n| n.split.last.equal? 'Adler' }  #, OR, split(' ')[0] == "Adler"
# etc.


# Q. using .map, .all? and .any? answer the following:
# a) do all the names include an 'o' ?
p names.map { |n| n.include? 'o'}.all?

# b) does any name have three parts ?
p names.map { |n| n.split.size >= 3 }.any?

# Q. using .select and .reject
# a) produce a new array of Johns
p johns = names.select { |n| n.include? 'John'}

# b) produce a new array with no adlers
p noadlers = names.reject { |n| n.include? 'Adler' }

# Q. what do the following reductions (folds) produce? Why?
p ages.reduce(:+) / ages.size
p names.reduce(:+)
p names.reduce { |t, e| t + ', ' + e }
p names.reduce(true) { |t, e| t && e.include?('John') }
p names.reduce(false) { |t, e| t || e.include?('John') }


# EXTRA
# Q. rewrite the first two questions as one loop
#... .each over info to ask the questions and collect the data
#... then use .map and .all? to check the details
# HINT: break next

info = ['username', 'fullname', 'age']
user = {}

loop do
  info.each { |i|
    print i, ' ?'
    user[i] = gets.chomp
  }

  if user.map { |k, v| !v.strip.empty? && v.size > 2 }.all?
    break
  else
    next
  end
end


## REVIEW: What did we learn from this exercise?
