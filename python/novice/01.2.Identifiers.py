
"""
    Let's start by looking at the grammar and semantics of identifier defintion.

    Identifier defintion is also called 
        "variable assignment" or "binding a name to a value" or "giving an object a name".

    
    For now treat the word "object" as meaning any thing the computer remembers. 
    5 is an object, "Hello" is an object and the function sum() is an object. 

    Each is just something the computer can remember.  
"""

# identifier assign literal 

name = "Michael"
age = 27
location = 'UK'
height = 1.81

# identifier assign expression

""" EXPRESSIONS:

An expression is any valid syntatical phrase (sequence of symbols) that calculates a value. 

We're very familiar with mathematical expressions 5 + 1 , 7 * 2, etc. 

In programming language very many phrases like this actually "calculate values" meaning that, 
when the computer reads them it replaces them with the value it calculates.

For example if I say, "I am 5*5 years old" we can read that to mean "I am 25 years old":
    to understand what "5 * 5 years old" means replace the expression 5 * 5 with the value it calcualtes.

Another defintion of expression is "anything you can put on the RHS of an assigment..."
"""

full_name = 'Michael' + ' ' + 'Burgess'  # 'Michael' JOINED-TO ' ' JOINED-TO 'Burgess'
working_years = 65 - age                 # 65 SUBTRACT age
address = 'London,' + location           # 'London,' JOINED-TO location
weight = 12 * (14/2.2)  
bmi =  weight / (height ** 2)            # weight DIVIDE height SQUARED


""" STATEMENTS:

Statemens are any syntatical phrase which does not calculate a value, 
    i.e., which performs an action. 

Each of the above lines is, in total, a statement. The action it perfoms is assignment.

While, in each case, a variable is *given* a value -- the line itself has no value. 


Other kinds of statements include the print statement:
"""

print                                   # prints a newline
print "Some Information About You"      
print "Your name is", full_name
print "Your age is", age
print 

# with print statements *AND PRINT STATEMENTS ALONE*
# the comma means print a space

# the comma symbol takes on a different meaning in other contexts


""" FUNCTION CALLS:

The expressions we have used above calculate values using operators, eg. 14/2.2 

However it also possible to use *named* predefined machines which can calculate values for us.
These machines or "functions" apply some recipie (or algorithm) to some given input. 

For example, the function named len takes in a collection and tells you how may things are in it. 
"""

print len("Michael")    # prints 7 because there are 7 letters in Michael

""" reading right-to-left:

    PASS STRING "Michael"
    TO OBJECT len 
    RUN len THEN
    PASS RESULT TO
    PRINT
"""

# often function calls are better read right-to-left 
# the first step, before we can run the print operation is to calculate len("Michael")
# so len("Michael") is run first: we can cross this out in our heads and replace it with 7 
# then this 7 is sent to print 

# The identifer which we use to run the function is incidental.. 

mylen = len 

print mylen("Michael")  # it does the same thing!

""" 
Remember the identifier len just means 'LOOKUP THE OBJECT NAMED len'
if we say 'mylen = len' then we say that the-very-same-object is also named 'mylen'


Just like Michael and Mike are two names, or identifiers, which refer to the same person. 

Tell Mike to add 5 and 7.   is the same as   Tell Michael to add 5 and 7.  
"""

# equally, we can change the object the identifier 'len' refers to:
len = 5 

print len * len       # prints 25

# len is just an identifier like any other, 
# when you use it you tell python to find the object it refers to

#NAMING CONVENTIONS FOR IDENTIFIERS

# an underscore implies to the person reading (or using)
# the code that the variable is not to be used outside the reigion its defined in 
# it's a way of saying "this should only be used for this bit of code"

_private = "my favourite colour is purple!"

# why?, perhaps a _private (by convention) variable is only used locally because
# it's value changes all the time and you dont want any one else to use it

_password = "changes all the time" # read as: don't use this

password = "stable" #read as: use this one instead!


# python additionally has __x-style varaibles whose name will be changed by the interpreter
#nb., best to stay away from using double-underscores (__) unless you know what you're doing

__really_private = "hello"      # python scrambles the identifier name outside this file 


# finally, the variable __name__ is defined by the interpreter (eg., python.exe)
# it contains the name of the currently running file (module)
# here's it's just an example of how python uses __x__-style names to indicate
# that it's a language (vs. user-provided) feature

print __name__

# __name__ is still an IDENTIFIER even though it comes pre-defined... it is possible to change:

__name__ = 'TEST

print __name__ 

# but its a very bad idea to change anything python defines 