# CHAPTER 9:  Def

## WHY IS THIS IMPORTANT?: 
## 
## 


# PART 1

# PART 2


# SENDING MESSAGES TO OBJECTS

# reciever.message arguments
# reciever.method(arguments)
# object.method(arguments)

p Hash.methods.sort
p ({ height: 100, width: 200 }).methods.sort
p 1.methods.sort

p __callee__    # sym of current method


# METHODS
def message(string)             
    return string * 3
end

p message('Ho ')

def message(string); return string * 3; end

p message('Ho ')

# DEFINING METHODS 
def greeting time
    case time 
    when 'AM'
        'good morning'
    when 'PM'
        'good evening'
    else 
        'good day'
    end 
end

p greeting 'AM'

# and redefining..

def greeting(time)      # parentheses optional
    case time 
    when 'AM'
        'bon martain'
    when 'PM'
        'bon soir'
    else 
        'bonjour'
    end 
end

p greeting('AM')    # parentheses optional

# the return value is the last executed expression of the defintion 
# greeting has three return values:

p greeting 'AM'
p greeting 'PM'
p greeting nil 

# RETURNING AND CHAINING 
p greeting 'am'.upcase
p greeting('am').upcase     # dot binds tightlty (high prec.)

# and we can keep going
p greeting('am').upcase.reverse.split[-1].split('').shuffle.take(3)

def greeting; 'Good Day!'; end

p greeting.upcase.reverse.split[-1].split('').shuffle.take(3)


# SCOPE (PREVIEW)
#methods
result = 100

def get_result 
    if defined? result
        result
    else 
        200
    end 
end 

p get_result

$result = 100

def get_result 
    if defined? $result
        $result
    else 
        200
    end 
end 

p get_result



# ARGUMENTS 
# default arguments 
def message(string, times=3)
    string * 3
end 

p message('Ha! ', 2)    # pass by position

#named arguments with defalts 
def message(string: 'Ho ', times: 3)        # required to pass by name
    string * times 
end 

p message               # pass by default 
p message(times: 6)     # pass by name 


# PACKING ARGUMENTS 

def messages(*strs)
    p strs
end 

p messages('i', 'can', 'pass', 'many', 'arguments')

def messages(prefix="MESSAGE:", *strings)
    strings.map { |m| prefix + m }
end 

puts messages('i', 'can', 'pass', 'many', 'arguments')  # Q. What happens to prefix? A. prefix='i'


def config(**data)
    p data
end

config(name: 1, email: 2)    # pass many args by name 

# UNPACKING ARGUMENTS 

def config(name, email)
    p "configuring for #{name}, #{email}"
end 

data = ['moriarty', 'm@example.co.uk']

config(*data)


person = {
    name: 'moriarty',
    email: 'm@example.co.uk'
}

config(*person)             # not what you expect... 
config(*person.values)

# if defined to take named arguments ...
def config(name:, email:)
    p "configuring for #{name}, #{email}"
end 

config(**person)






# PART 2 -- PROCS, BLOCKS AND LAMBDA

name = begin 
    first = "John"
    second = "Watson"
    first + ' ' + second
end                         # this isnt a scope...

p name          # the last line of a block is its value 

# you cannot "grab hold of" (ie., assign) a block -- it is just a lexical reigon
# you *can* grab hold of a Proc..

get_name = Proc.new { |first, last|
    "#{first} #{last.upcase}"
}

p get_name.call('Sherlock', 'Holmes')
p get_name.call('John', 'Holmes')
p get_name.call('John', 'Watson')

# we can define methods to accept Procs...


def message(msg, &formatter)
    p formatter.call(msg)
end 

message('Ho ') { |str|
    str * 3
}

message('Ho ') do |str|
    str * 3
end

# the block is converted into a Proc, 
# ie., the reigion is intepreted as wrapping into an object which is passed as an argument 
# rather than as an immediately-invoked reigion of execution

# also, lambda 

formatter = ->(string) { string.upcase }
formatter = lambda { |string| string.upcase }           # older, uses block syntax

p formatter.call('hello?')

def format(formatter)
    p formatter.call('hello world')
end 

format(formatter)


message('hi', &formatter)  # &args are procs, use & to convert  


# YIELD REFRESH

def recieve_block
    p 'Error: ' + yield
end 


recieve_block { 'Message' }

recieve_block do 
    first_name = 'Sherlock'
    last_name = 'Holmes'
    first_name + ' ' + last_name
end 


def recieve_block_arg
    p 'Error: ' + yield(2)
end 

recieve_block_arg { |times| 'Message ' * times }



# SCOPE 

#methods
result = 100

def get_result 
    if defined? result
        result
    else 
        200
    end 
end 

p get_result

$result = 100

def get_result 
    if defined? $result
        $result
    else 
        200
    end 
end 

p get_result



#procs 
result = 300 

get_result = Proc.new { result }

p get_result.call

result = 400 

p get_result.call



# lambda 
result = 500 

get_result = ->() { result }

p get_result.call

result = 600 

p get_result.call 



# SCOPED BREAKING...

def lambda_test
  lam = lambda { return }
  lam.call
  puts "Hello world"
end

lambda_test               


def proc_test
  proc = Proc.new { return }        # terminates method 
  proc.call                         # (break terminates method-level loop, etc.)
  puts "Hello world"
end

proc_test 
