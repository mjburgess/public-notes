""" NOVICE ASIDE:

Why do we use programming languages?

Languages are *for* programmers. Programmers are humans, humans have an innate and powerful capacity of langauge.
Language easily describes problems. 
"""

"""
Let's image we have a LANGAUGE:

    0 means stand-up
    1 means sit-down
    2 90C means turn 90 degrees clockwise
    2 90A means turn 90 degrees anti-clockwise
    3 means repeat the last operation

then imagine we have the PROGRAM:

    0
    2 90C
    3
    1

This instructs a person to stands up, turn around and sit down. 

We could have another "semantics" for this language 
    (ie., we can assign a different meaning to these symbols):

    0 means enter the bar
    1 means leave the bar
    2 90C means drink 90cl of wine 
    3 means repeat the last operation

So the program above, with this new semantics, 
now means enter the bar and drink several bottles of wine!

1. LANGUAGES
A langauge is a syntax + a semantics.

The syntax determines what symbols are valid (eg. 2) and what patterns these symbols must follow (a grammar),
eg. that either 90A or 90C must follow a 2. 

The syntax is comptible with different *semantics* or what the symbols mean. 
For programming languages, we usually take the meaning of the symbols just 
to be what the computer *does* when it sees them.  


2. PROGRAMS
Now let's look at programms.

A program is some valid combination of the symbols, 
as the language defines them, into a meaningful sequence of operations. 

an example program:         0   2 90C   3   1

We can make lexical observations about this program, ie. what it looks like without knowing what it does.
And semantic observations: considerations based on what it does. 

Lexically, for example, we can say the symbols 0, 3, 1 are complete commands where as 2 is a partial command: 
2 90C is complete.

The idea of a "complete command" or a "complete thought" is very important in language. 
In english, complete thoughts are sentences -- in programming language complete thoughts we'll call "statements". 

0 is a statement, and 2 90C is a statement -- but 2 is not. 2 alone is invalid. 

For a lanauge as small as the one above we can just learn all
the "complete thoughts" and all the ways to combine them by wrote. 

For language like english, and many programming languages, the combinations are far larger -- 
so we have to learn simple rules for how to fit all the parts together.  

3. Python Grammar

Programming language typically have four kinds of valid symbol:
    identifiers, keywords, operators and literals

These symbols refer to the way the programs *are written* -- they have nothing to do with how they are run.

For example, we can say -- of the language above -- that its symbols are integers (1, 2,..) and letters (A, C). 


Identifiers are any names (the names of variables, functions, etc.) that refer to objects. 
The object any identifier refers to can be changed by the programmer. (eg. my_name )

Keywords look like identifiers (eg. print, return) but rather than name some object 
they have some special meaning within the syntax of the language. They are more like operators...

Operators are non-alphabetical symbols that have some special meaning in the language (eg., + * - )

Literals are any raw piece of data whose value can just be read-off the code (eg. 5, 'hello', True).

4. COMPLETE THOUGHTS IN PYTHON

The first example of a complete thought in python is this very piece of text. 

The three-double quote symbols " " "  which begin this block of text define a multi-line string 
the three-double quotes which end this block terminate this defintion.  
"""

# here are some other complete thoughts in python

# variable assignment
""" GRAMMAR:
IDENTIFIER OPERATOR LITERAL
"""
name = "Michael"

""" SEMANTICS:
LOOKUP-OBJECT  name                 -- all identifiers just mean "lookup the object by this name"
ASSIGN                              -- the equals sign (=) means "change what object this name refers to"
MKSTRING  Michael                   -- double-quotes mean "make a string"
"""

# printing an uppercase'd string
"""
KEYWORD IDENTIFIER OPERATOR IDENTIFIER
"""
print(name.upper())

"""SEMANTICS:
WRITE-STRING:                       -- the print keyword means "write a string to the standard output"
    LOOKUP-OBJECT name              -- recall: all identifiers just mean "lookup the object by this name"
    IN-OBJECT name                  -- the dot operator is more complex, it says the object on the LHS
        LOOKUP-OBJECT upper         -- is the place to find the object on the RHS
    
    RUN-OBJECT upper                -- the two parentheses mean 'run' when next to an identifer
                                    -- here then the object 'upper' refers to is a function
"""

# another equally good semantics for the same syntax would be

"""
WRITE-STRING:
    CALCULATE-STRING:
        ASKING OBJECT name 
        TO RUN OBJECT upper
"""

# or, we could read right-to-left

"""
    CALCULATE 
        FIND upper 
        IN name 
    WRITE RESULT
"""


# often programming syntax will read clearest right-to-left


'''

ASSIGN name TO NEW-OBJECT STRING "sherlock"

LOOKUP name 
    THEN 
        LOOKUP upper 
    THEN 
        RUN 
    THEN 
        ADD NEW-OBJECT STRING "holmes"



'''

''' OUTPUT (14.Extra/Demo14-06.S.GrammarSemantics.py):
MICHAEL

'''
