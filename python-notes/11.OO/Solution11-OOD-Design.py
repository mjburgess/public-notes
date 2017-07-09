# SUPPLEMENTAL EXERCISE 

# CHAPTER:    Object Oriented Programming
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Write a program that registers delegates as they enter a classroom. 
# TIME:       15m
"""
Write a small application which describes...

Registering delegates as they enter a classroom.

Questions:
    What single objects are there?                
            -- Classes with single(scalar) properties

        What properties do these objects have?    
            -- __init__ properties

    What changes to these objects are there?      
        -- Methods

    What groups of objects are there?             
        -- Classes with listy (aggregate) properties

"""


class Room:
    def __init__(self, name):
        self.name = name
        self.delegates = []

    def accept(self, delegate):
        self.delegates.append(delegate)

    def describe(self):
        for d in self.delegates:
            print(d.name)


class Delegate:
    def __init__(self, name, cohort):
        self.name = name
        self.cohort = cohort

    def __str__(self):
        return self.name


r109 = Room('109')
r202 = Room('202')

kat = Delegate('Katherine', 5)
michael = Delegate('Michael', 99)

r109.accept(kat)
r202.accept(michael)

r109.describe()
r202.describe()

# EXTRA
"""
Q. look around the room:
    What things are there? 
        For each type of thing create a class.

    What do they *do*?
        For each thing they do add a method to the class?

    What do they *have*?
        For each kind of data they have, 
            add a property to their constructor 

        (ie., in the __init__ add a self.something = )


Do this for 4 or 5 very different kinds of object.
"""

""" REVIEW

What did we learn from this exercise?

How to translate from the problem domain to application domain using OO syntax. 
"""


''' OUTPUT (11.OO/Solution11-OOD-Design.py):
Katherine
Michael

'''
