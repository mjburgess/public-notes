# CHAPTER:    Object Oriented Programming
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Use classes to describe a person and a room.
# TIME:       15m

class Person:
    def __init__(person, name, age):
        person.name = name
        person.age = age

    def describe(person):
        print(person.name)


# Q. modify Person
# ... so that you can set its name and age when you construct it

# Q. create a Person with the name 'Sherlock' and the age 35
p = Person('Sherlock', 30)

# Q. ask sherlock to describe himself
p.describe()


class Room:
    def __init__(person, name, location):
        person.name = name
        person.location = location

    def describe(person):
        print(person.name)


# Q. create a class Room that has a constructor (__init__ method)
# ... when you create a room, set it's name and location

# Q. include, on the room class, a describe() method that prints its details


# Q. create a room
r109 = Room('109', 'DeltaP')

# Q. ask it to describe itself
r109.describe()

""" REVIEW

What did we learn from this exercise?

syntax:
class def __init__ 
every method begins with an argument of the class's type 

constructors give each newly-made object its data 
when you make an object, you tell it what particular data it will have 
"""


''' OUTPUT (11.OO/Solution11-OOA-Constructors.py):
Sherlock
109

'''
