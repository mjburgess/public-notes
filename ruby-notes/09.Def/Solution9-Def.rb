# CHAPTER:    Def
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Define methods to describe the processes involved in shopping.
# TIME:       20 m

# QUESTIONS

# Q. write a login function which takes two arguments
#... a username and a password.
#... if the password is 'test'
#... then print username, "ALLOWED"
#... otherwise print, username DENIED

def login(username, password)
  if password == 'test'
    print username, 'ALLOWED'
  else
    print username, 'DENIED'
  end
end

# Q. define a function called generate_password
#... which randomly returns either 'test' or 'guest'
# HINT: ['test', 'guest'].sample

def generate_password
  ['test', 'guest'].sample
end


# Q. call your login function several times,
#... supplying a username and a password.
#... the password should be given by your password function.

login('usr', generate_password)
login('usr', generate_password)
login('usr', generate_password)

# Q. define a array called details with two elements.
#... the first element should be a username,
#... the second the correct password, 'test'.
#... call your login function using this array.
# HINT: use the unpacking star

details = ['testusr', 'test']
login(*details)


# Q. redefine and call the login function again,
# so that this time *when calling*
# the password is first then the username.
# HINT: pass the arguments by keyword

def login(username:, password:)
  if password == 'test'
    print username, 'ALLOWED'
  else
    print username, 'DENIED'
  end
end


login(password: generate_password, username: 'testusr')

# Q. define a function called profile which defines two arguments, 
#... a username and accepts a variable number of named arguments.
#... this function should print the username then loop over the remainder

def profile(username, **info)
  print username
  info.each { |k, v| puts "#{k} = #{v}" }
end

#Q. call your profile function, try:
# profile(username, age: 27, height: 1.81, fav_colour: 'purple')

profile('test', age: 27, height: 1.81, fav_colour: 'purple')


# EXTRA

# Q. Define two functions, print_details and change_details.
#... print_details should print your details variable defined earlier
#... (you will have to change the definition of details)
#... change_details should modify your details variable,
#... changing each element so that it is uppercase.

$details = details

def print_details
  puts $details
end

def change_details
  $details = $details.map { |i| i.upcase }

  # OR,
  $details = $details.map(&:upcase)
end

# Q. change_details() then print_details()

change_details
print_details


# compare with,
#
#    new_details = change_details(old_details)
#    print_details(new_details)
#
# where input/output into function uses parameters 
# and return values
#...
#... which is better?

## REVIEW: What did we learn from this exercise?