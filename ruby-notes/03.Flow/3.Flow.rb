# CHAPTER 3:  FLOW

## WHY IS THIS IMPORTANT?: 
## 
## 

# BOOLEANS
# LOGICAL OPERATORS
# COMPARISON OPERATORS
# BRANCHING: IF, UNLESS
# BRANCHING: CASE-WHEN
# BRANCHING: STATEMENT MODIFIERS

# BOOLEANS

age = 27
allowed_age = 68

condition = age > allowed_age

p condition 

#Q. what is the type of condition?
#A. TrueClass or FalseClass 

p condition.class  

[TrueClass, FalseClass].include? mybool.class



#Q. if a variable is type bool which of two values must it be?
#A. 

p [true, false].include? condition 


# BOOLEAN OPERATORS: LOGICAL OPERATORS

p true 
p false 

p !true 
p !false 

p true && true 
p true && false 
p false && true 
p false && false 

p true || true 
p true || false 
p false || true 
p false || false 


# BOOLEAN OPERATORS: COMPARSION OPERATORS 
age = 27 
allowed_age = 18

name = "Sherlock"

is_allowed = age <= allowed_age

p is_allowed && name.downcase == "sherlock"

p 1 == true 
p 0 == false 

p 'sherlock' != 'sherlock'
p 'a' < 'z'

# BRANCHING STATEMENTS

## WHY IS THIS IMPORTANT?:
=begin
Why do we use branching statements?

The problems we are describing contain conditional elements, 
ie. decisions are made based on at-the-time values. 

If we know, ahead of time, what the property of interest is going to be, 
we do not need the program to make the decision.

eg. if we know that we have to print 'Hello, Mr. Holmes!' 
because *we* have decided the application is for sherlock holmes
then we do not need to have the program make a decision.

However if it could be for two users, then maybe...

if user == 'sherlock'
    print "Hello, Mr. Homles"
else
    print "Hello, Mr. Watson"

This is conditional execution: certain actions will be taken only if certain conditions are true. 
=end
## 

if defined? name 
    p name 
else  
    p "Name is not defined!"
end 

amount = 0
if amount
    p 'the amount is #{amount}'
else 
    p 'amount is false or nil'
end 


option = 'quit'

if option == 'quit' || option == 'exit'
    p 'leaving..'
elsif option == 'open' || option =='go'
    p 'joining...'
elsif option.nil?
    p 'unknown'
else 
    p 'try again?'
end


unless option.nil?
    p "option was #{option}"
end 



## GENERAL STRUCTURE:
=begin
if      BOOLEAN-EXPRESSION   
    DO-TRUE 
elsif    BOOLEAN-EXPRESSION  
    DO-TRUE 
else
    DO-FALSE
=end
##


# first form -- traditional case comparsion 
case option 
    when 'quit'
        p '..leaving'
    when 'open'
        p '..joining'
    else 
        p 'unknown'
end 


# second form, rephrasing an if-else 

case 
    when ['quit', 'exit'].include?(option)          # leaving off parens causes parsing issues...!
        p '...leaving...'
    when ['open', 'go'].include?(option)
        p '...going...'
    else
        p '..unknown..'
end 



# STATEMENT MODIFIERS

p 'sherlock is allowed' if is_allowed
p 'sherock is not allowed' unless is_allowed


# THERE ARE NO BOOLEAN CONTEXTS
# ruby prefers emptyness (falsity) tests to be explicit...
amount = 0
username = ''
password = nil 

if amount.zero?
    p 'zero'
end 

if username.empty?
    p 'empty'
end 

if password.nil?
    p 'nil'
end 

# SELECTION STATEMENTS

colour = if name == 'sherlock' 
            'blue'
        else 
            'green'
        end

p colour 

p colour == 'blue' ? 'the fav. colour is blue' : 'the fav. colour is green'     # ternary 



# and case too...


message = case option
    when 'quit'
        '..leaving'
    when 'open'
        '..joining'
    else
        'unknown'
end


p message


# SELECTION OPERATORS: REUSING LOGICAL OPERATORS

user = defined? user || 'guest'

p user or 'guest'
p user and 'guest'

is_allowed or p 'allowed'
is_allowed and p 'allowed'


# user ||= 'GUEST'

# UNCONDITIONAL FLOW

# exit      -- graceful exit from app: raises exception & at_exit hoks run
# exit!     -- ungraceful exit: stops without hooks
# abort     -- exit method without running at_exit hooks


at_exit {
    p "exiting from the application"
}

exit