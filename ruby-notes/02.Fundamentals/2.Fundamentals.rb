# CHAPTER 2: Fundamentals

# PART 1
  # IDENTIFIERS
  # OBJECTS
  # EQUALITY
  # TYPE CHECKING
  # MUTABILITY
  # DUPLICATION
  # OTHER IDENTIFIERS
  # UNDEFINED VARIABLES
  # OPERATORS
  # ASSIGNMENT

# PART 2
  # DATA LITERALS
  # SYMBOLS
  # INTEGER LITERALS
  # ARRAYS
  # PARALLEL ASSIGNMENT
  # HASHES
  # BLOCKS
  # METHODS
  # CONVERSIONS

# PART 1 -- IDENTIFIERS, VARIABLES and OBJECTS

# IDENTIFIERS (VARIABLE NAMES)
## WHY IS THIS IMPORTANT?: 
=begin
Why do we use identifiers?

To name data. 
Data represents properties of interest. 
We need to name these properties in order to operate on them in the program.
AND in order that the program correctly describes the problem.
=end
## 

#Q. What are identifers?
#A. Names which refer to objects. 

name = "Michael"
another = "Michael"         # name and another refer to different objects despite having the same data
p name.object_id
p another.object_id         # the object_id is the "true name" of the object
                            # a variable is just a way of referring to it
                            # (which the object does not know about)

yet_another = name          # Q. these refer to the same object -- whats the difference?
p yet_another.object_id     # A. we can read " " as *creating* an object (a string)
p name.object_id




# OBJECTS
# Q. so, what are objects?

""" WHY IS THIS IMPORTANT?:
Why do we use objects?
To group behaviour and data.
"""

p name.object_id # A. objects have a place in memory 
p name           # A. objects have state (remembered data)
p name.upcase    # A. objects can respond to messages, here we send the upcase message to name
p name.class     # A. objects have a class which determines what messages they can respond to 

# ASIDE: 
p name.class.methods.sort # ... here are all the messages 
p name.send(:upcase)  # ... and we can be explicit

# Q. what does the . operator do?
# A. send a message 


# EQUALITY
# a == b      -- equal values
# a === b     -- equal cases
# a eql? b    -- equal keys
# a equal? b  -- equal identity


# TYPE CHECKING

p name.is_a? String 
p name.is_a?(String)        # Q. what do the parentheses do? A. group arguments, the dot "calls"

# Q. why would we ever want to know the class?
#... the class is only determine the total set of valid messages...
# we would in any given situation only have one or two in mind.. so, better ask directly:

p name.respond_to? :upcase 
#theref. we can 
p name.upcase

# this is called duck typing: if it quacks like a duck...
# ( ASIDE: if we were to statically type this code it would be highly polymorphic / structurally typed...)



# MUTATION 
# strings are mutable...

p name
name[0] = 'm'

p name 

# integers are not..

age = 26
p age

age += 1 
p age 

# Q. so why does age change? does "26" change to 27? Nope. 
# A. the '=' assignment operation changes where a variable refers to, age refered to 26 now 27. 

your_age = 27
my_age   = 27 

p my_age.object_id
p your_age.object_id      # they refer to the same object! 

#all values are objects

#Q. what's a value?
#A. anything you can assign to a variable...




# DUPLICATION

employee_id = "X100Y"
p employee_id

your_id = employee_id
your_id[0] = "A"

p your_id
p employee_id   # oops! both change 

your_id = employee_id.dup       # duplicate
your_id[-1] = "A"

p employee_id
p your_id

# OR,
your_id = employee_id
employee_id.freeze      # freeze *the object* 

# then, 
# your_id[0] = "1"      # RuntimeError: can't modify frozen String


# OTHER IDENTIFIERS

local_name = "Ldn"
$global_name = "London, UK"  # globals are prefixed with the $ sigil
ConstantLocation = "London"

# other sigils include @ and @@ which are used in class-defintion contexts

_private = "private by convention"

# you cannot undefine variables in ruby (cf. python, php et al.) however you can set them to nil

$global_name = nil


# UNDEFINED VARIABLES 

# ERROR: undefined local variables and constants do not exist, accessing is an error
# p undef_var
# p UndefinedConst

# undefined globals do, they default to nil:

p $undefined_gloabl 





# OPERATORS

# the term 'operator' isn't very well defined
# it typically means a "special symbol which works like a function but isn't called like one"

#Q. what is the meaning of the plus-symbol here?
p 3 + 4    #A. addition

#Q. what is the meaning here?
p '3' + '4'    #A. concatenation

#nb., Distinguishing between the name of the symbol (plus) 
# and it's meaning (addition, concatenation) highlights that while one symbol is used in both cases
# it's job changes (the general name for this is polymorphism)
# -- the object decides how it will respond to the message

p (3 + 4).class    #Q. type?  
p ('3' + '4').class #Q. type? 

p '3'.send(:+, '4')
p 3.send :+, 4      # parens optional

# ERROR: #       '3'.send(:+, 4)

# ** is "raise to the power"
p 8 ** 3


user_age = '18'

#Q. how do you add 1 to the string 18?
#A. convert it to an integer first
p user_age.to_i + 1        

#Q. what does the * (star) operator do on numbers? 
#A. multiplication

print user_age * 10 #Q. what does it do to strings?



# ASSIGNMENT

# the assignment operator is the = symbol 
# it means (re)define this LHS identifer to refer to the value on the RHS 

population = 0

# AUGMENTED ASSIGNMENTS (compound)

population = population + 10    #  NEW = OLD + 10

# eqv. to.. 
population += 10    # read as, "update population, increase by 10"


# PRECEDENCE
p 3 * 10 + 4 * 5 - 3 * 2          #Q. how does this group?

p (3 * 10) + (4 * 5) - (3 * 3)    #.. OR

p 3 * (10 + 4) * (5 - 3) * 3      #.. ?


#A. it comes down to which operator has higher precedence
#A. operators with higher precedence are eval'd first or "bind their arguments more tightly"
#A. BODMAS = Div then Mul then Add then Sub 
#A. so * binds more tightly than + and -


p 3*10         +         4*5         -         3*2  

#        30        +        20                    6
#        30+20                        -        6
#        50                            -        6
#=    44


# GOCHAS

# / on ints is integer division
print 9 / 2

# / on floats is floating-point division
print 9.0 / 2





## PART 2 -- DATA

# DATA LITERALS 

operation = :message
age = 10
population = 1_000_000
height = 1.81
name = "Sherlock Holmes"
people = ["Sherlock", "Watson"]

me = {
    name: "Michael",
    location: "United Kingdom"
} 

options = 1..4

p operation.class 

p age.is_a? Integer
p age.class         # Int = Fixnum | Bignum

p height.class 
p name.class 
p people.class  
p me.class  
p options.class 



## WHY IS THIS IMPORTANT?:
=begin
Why do we use each data type?

Integers  == whole numbers used for representing quantities. discrete data.
Strings   == textual data. 
Floats    == partial quantities, continuous data.

Why do we use complex data types?

To group values.

Arrays        == Sequence of values, one after the other. 
Hashes        == Look up changeable values, given known fixed values.
=end 
## 


# now we'll introduce each a little more...


# SYMBOLS 

#recall: symbols are efficient unique names only equal to themselves

name = "sherlock"
profession = :detective 

p name == "sherlock"            # many-many 
p profession == :detective      # one-one   comparsion 



# INTEGER LITERALS
# Q. what is an integer? A. a whole number  
# whole numbers can be represented many ways 

p 12   # decimal 12
p 0d12 # decimal 12
p 0xC  # hex C == decimal 12 
p 012  # Q. octal 012 is ?    decimal 10 
p 0b101


# ARRAYS 

cart = ['bread', 'cheese']

p cart 
p cart[0]
p cart[-1]

baskets = [cart, cart]

p baskets[0][1]

# PARALLEL ASSIGNMENT


first_item, second_item = cart 

adler = 'Irene', 35, 'London'

p adler
p first_item

name, age, location = adler
name, age, location = 'Watson', 35, 'London'

p name 
p location 



name, *locations, age = 'Sherlock', 'London', 'Paris', 30
p locations 

teenager, adults = 17..21
p teenager
p adult 

# HASHES 

person = {
    name: 'Sherlock',
    age: 27
}

p person 
p person[:name]
p person[:age]

person_address = {
    'sherlock' => 'london',
    'watson' => 'london',
    'irene' => 'paris'
}

p person_address['sherlock']

sherlock, watson, irene = *person_address

p sherlock, watson, irene




# BLOCKS PREVIEW

name = begin 
    first = "John"
    second = "Watson"
    first + ' ' + second
end                         # this isnt a scope...

p name          # the last line of a block is its value 


names = ['Sherlock', 'Holmes'].map do |name|                # blocks can recieve values
    name.upcase
end

p names


#  METHODS PREVIEW

def login(username, password)
    if password == 'test'
        p "#{username} is allowed"
    end
end 


# CONVERSIONS 

p 5.to_s + 5.to_s
p 9/2
p 9.to_f / 2
p 9.0 / 2
p 9.0.to_i / 2


# p [[:name, :email], ['John', 'j@example.com']].to_h    #  ruby 2.1
# p { name: 'John', email: 'j@example.com'}.to_a         #  ruby 2.1


## WHY IS THIS IMPORTANT?:
=begin
Why do we need to convert between data types?

Each type has its own special characteristics, eg. string vs integer addition. 
Different types represent different properties in the problem domain better. 

eg. A bool cannot represent a population.
It could represent if that population is High or Low, eg. is_high = true 
=end
## 


# ERROR HANDLING: PREVIEW 
