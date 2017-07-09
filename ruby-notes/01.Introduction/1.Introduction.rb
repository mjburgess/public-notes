# CHAPTER 1:  INTRODUCTION

## WHY IS THIS IMPORTANT?: 
=begin
Why do we use programming languages?

Languages are *for* programmers. Programmers are humans, humans have an innate and powerful capacity of langauge.
Language easily describes problems.  


Why do we use ruby?

Ruby is a syntactically simple language. 

It describes many problems very well, and thus ruby programs often read well.

It has a significant community/library/functionality base which increases its power. 

It has a significant role on the web (via RoR) and in DevOps (via puppet, chef, etc.)
=end
## 




# RUNNING RUBY
# ruby -h 
# ruby --version 

# ruby version manager: rvm 
# rvm docs generate-ri
# rvm 

# -- REPL, tab completion
# echo "IRB.conf[:PROMPT_MODE] = :SIMPLE" > ~/.irbrc
"mjburgess@Michaels-MacBook-Pro:~$ irb
>> if 5 > 1
>> puts 'Hello'
>> end
Hello
=> nil
"



# WHAT IS RUBY?
# interpreted, scripting language 

puts RUBY_VERSION
puts "Hello"
puts "World"

# every value is an object which you send messages, and the object responds 
puts "Hello".send(:+, 'World')

# latent, but somewhat strong, typing 
puts "1" + 1




# TERMINOLOGY

# Object 
message = "Hello"  # the object "Hello" is referred to by the name "message"

# "Hello" has a class...

print "Hello".class  

# which defines everything Hello can do 
# "Hello" has data... 
print "Hello"
 
# "Hello" can respond to messages (methods)
print "Hello".upcase 




# ANATOMY

## WHY IS THIS IMPORTANT?: 
=begin
Why understand the structure of ruby programs?

Programming languages include rules which determine how programs will look,
understanding the look of python programs helps us understand these rules,
and therefore understand how to read and write programs in the language. 
=end
## 

# ARGV is the argument vector (an array of command line arguments) -- and this is a comment 
num_arguments = ARGV.size                  # assignment, call to .size method on ARGV

if num_arguments < 1                                # no parens, newline terminates
    abort('please supply an argument')      
else
    puts "Hello #{ARGV[0]}"
end                                                 # end keyword terminates blocks

# ...OR..

# puts if ARGV.size < 1 then 'more arguments!'; else "hello #{ARGV[0]}" end
puts (if ARGV.size < 1
        'more arguments!'
      else
        "hello #{ARGV[0]}"
      end)

print "Goodbye!"

print "Hello".methods.sort  # print to_s's an array,  puts prints every element on a new line

print (Object.constants + Kernel.methods + Kernel.global_variables).sort
# NB. Kernel is implied

# ObjectSpace.each_object(Class).to_a.map {|c| c.name }.sort
# NB. object space is a memory management class, arg to each_object filters all known objects 


# LIBRARIES

require 'date' # date is the name of the file ('library') imported

# Date is the name of the class in this file... there may be many (classes, modules, ...) defined in one library
now = Date.today # today is a method on Date

# a class is a named grouping of behaviour
# ASIDe: classes may be used to make particular objects which then have all the behaviours the class defines
p now 
print now


# SIMPLE IO 

print "text with no extras"
puts "text with a newline"
p "calls .inspect on its arguments & returns them", 'see: ', 1  # p also returns its arguments, everything else returns nil

print 5.inspect 
print 'hello'.inspect 

location = "Leeds, United Kingdom"
print "double quotes can interpolate: location = #{location}"

name = gets # includes newline
p name 

name = gets.chomp # chomp removes trailing $/ (\n , \r\n) 
# nb.,  .strip removes whitespace from both sides

p name 


# STRINGS
name = "Michael Burgess"
puts 'my #{name} is literal'
puts "my #{name} is interpolated"

# delimiters can be any matching characters (), [], {}, <> or any single character repeated !!, @@, etc.

puts %q{I am name}      # single quotes -- ie., literal
puts %Q{I am #{name}}   # double quotes -- ie., interpolating

print %w{michael sherlock watson}   # array of literal strings
puts %W{#{name} sherlock watson}    # array of interpolated strings 

# Q. what's the difference between puts and print? A. puts prints each element

print :symbol       # symbols are special literals, created with :
# print %s{symbol}  # or %s -- rarely used

print /\w+/.class   # regex
print %r{\w+}.class # regex

# SYMBOLS 

# symbols are efficient unique names only equal to themselves

name = :sherlock
profession = :detective 

p name == :john
p profession == :detective

# cf. 
name = "sherlock"
profession = "detective"

p name == "john"
p profession == "detective"

# in the former case we are comparing a single value (ruby uses a hidden integer representation internally)
# in the latter case we are comparing many values (each character)


# HELP 
# rdoc
# Class#method	    refers to an instance method		
# Class.method      refers to a class method (ie., static)
# Class::Constant	refers to a class constant
# -- NOT syntax!
"
mjburgess@Michaels-MacBook-Pro:~$ ri

Enter the method name you want to look up.
You can use tab to autocomplete.
Enter a blank line to exit.

>> Array#join
>> Array.join
>> Array::join
Nothing known about Array::join
>> 
"



# Style Guide  -- github.com/bbatsov/ruby-style-guide
    # Use 2-space indentation - NEVER use tabs
    # Use spaces around operators
    # But no spaces after or before brackets (), [], {}
    # Code in paragraphs
    # Avoid line continuation on anything except string concatenation
    # Vertically align where possible

# Ruby Versions
# Installing Ruby



##  ASIDE:  The Grammar of Programs

""" WHY IS THIS IMPORTANT?:

Why do we need to make grammatical distinctions?

They help us to identify what the computer is doing when it reads something fitting into a particular grammatical category.
They also help determine which programs are syntax-valid. 
"""

# LITERALS:
# A literal is any data written literally, as in, it is written in the code. 
# Each of the following identifiers are assigned literal values. 

name = "Michael"
age = 27
location = 'UK'
height = 1.81


# EXPRESSIONS:
# An expression is any valid syntatical phrase (sequence of symbols) that calculates a value. 
# We're very familiar with mathematical expressions 5 + 1 , 7 * 2, etc. 

# In programming language very many phrases like this actually "calculate values" meaning that, 
# when the computer reads them it replaces them with the value it calculates.

# For example if I say, "I am 5*5 years old" we can read that to mean "I am 25 years old":
    # to understand what "5 * 5 years old" means replace the expression 5 * 5 with the value it calcualtes.

# Another defintion of expression is "anything you can put on the RHS of an assigment..."


full_name = 'Michael' + ' ' + 'Burgess'  
working_years = 65 - age                 
address = 'London,' + location           
weight = 12 * (14/2.2)  
bmi =  weight / (height ** 2)            


# STATEMENTS:
# Statements are any syntactical phrase which does not calculate a value,
    # i.e., which performs an action. 

# Each of the above lines is, in total, a statement. The action it perfoms is assignment.

# While, in each case, a variable is *given* a value -- the line itself has no value (or, technically, nil). 
# Other kinds of statements include the print statement:

puts                                   # prints a newline
puts "Some Information About You"      
puts "Your name is #{full_name}"
puts "Your age is #{age}"
puts 


#  FUNCTION CALLS  (MESSAGES):

# The expressions we have used above calculate values using operators, eg. 14/2.2 

# However it also possible to use *named* predefined machines which can calculate values for us.
# These machines apply some recipie (or algorithm) to some data

print "Michael".size    # prints 7 because there are 7 letters in Michael
