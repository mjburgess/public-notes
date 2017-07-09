# CHAPTER:    Errors
# OBJECTIVE:  Complete the following questions.
# PROBLEM:    Using rescue, handle errors caused by an authentication processes.
# PROBLEM:    Using custom exceptions, define errors caused by an authentication processes.
# TIME:       15 m * 2

# QUESTIONS
# PART 1 -- SYNTAX 
# Q. prevent the programming from terminating when login() is called
#... ie, use a begin-rescue block to handle the error 
#... and print the error message given 

def login(db)
  if db.empty?
    raise ArgumentError, "a database is required to have data"
  end
end

login({})

puts "still runnning..."

# Q. what kind of error occurs if you supply an integer for the argument?

# Q. call login again with the argument 0 
#... handle both error conditions

# Q. add an ensure-block 
#... in the ensure block print the present time
# HINT: puts Time.now


# PART 2 -- CUSTOM EXCEPTIONS
# Q. define a YourOrganizationError which is a kind of Exception

# Q. define an AuthenticationError which is also a YourOrganizationError

# login below can raise two kinds of error:
# an ArgumentError and an AuthenticationError

# Q. call login to cause both kinds of error.
#... catch an ArgumentError and a YourOrganizationError
#... the messages should say:
#... "#{user} could not be found",
#... or 'Unknown Organization Error!'

def login(user, password, data)
    if data[user].nil?
      raise ArgumentError, user
    end

    if data[user] != password
        raise AuthenticationError, user
    end
end




# EXTRA

# Q. get the user dictionary from a yaml file you have created

# Q. call login
#... add one rescue condition which catches all exceptions
#... and prints the error
#... add an ensure block to close any open file handles


## REVIEW: What did we learn from this exercise?