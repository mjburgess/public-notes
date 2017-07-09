# CHAPTER:    Errors
# OBJECTIVE:  Complete the following questions.
# PROBLEM:    Handle errors caused by an authentication processes.
# TIME:       15m

# QUESTIONS

# Q. define a YourOrganizationError which is a kind of Exception
class YourOrganizationError < Exception; end

# Q. define an AuthenticationError which is also a YourOrganizationError
class AuthenticationError < YourOrganizationError; end

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


begin
  login('usr', 'testpwd', {})
  login('usr', 'testpwd', {'usr' => 'test'})
rescue ArgumentError => err
  puts "#{err} cannot be found"
end


begin
  login('usr', 'testpwd', {'usr' => 'test'})
  login('usr', 'testpwd', {})
rescue YourOrganizationError => err
  puts 'Unknown Organization Error!'
end


# EXTRA

# Q. get the user dictionary from a yaml file you have created

# Q. call login
#... add one rescue condition which catches all exceptions
#... and prints the error
#... add an ensure block to close any open file handles

require 'yaml'


IO.write('data.yaml', {
    'usr' => 'testpwd'
}.to_yaml) # or write a yaml file manually



dataf = open('data.yaml')
begin
  login('usr', 'pass', YAML.load(dataf))
rescue Exception => err
  puts err.class, err
ensure
  dataf.close
end


## REVIEW: What did we learn from this exercise?