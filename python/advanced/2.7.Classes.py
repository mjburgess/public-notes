# 2.7.Classes.py

#1. combining data and behaviour

# most programs have two basic aspects: data and behaviour

# data is used to describe the state of the world -- how things are
# behaviour is used to describe how the state of the world changes -- how things change

# for each object in the world that we want to capture we could define a dictionary
# where each entry described some feature of that object of interest

# suppose we're interested in a problem concerning types of transport
# for example, how efficient they are
# then we want to describe the basic features of each type of transport of interest...

triumph = {
    'name': 'Triumph',
    'type': 'bike',
    'mileage': 0
}

audi = {
    'name': 'Audi'
    'type': 'car',
    'mpg': 30,
    'mileage': 0
}

rover = {
    'name': 'Rover'
    'type': 'car',
    'mpg': 30,
    'mileage': 0
}

# each variable here describes one type of transport...
# to make it more convenient to create various types we could define a function to construct these data structures for us

def car(name, mpg, mileage):
    return  {
        'name': name,
        'type': 'car',
        'mpg': mpg,
        'mileage': mileage
    }

# these also ensures that each representation of a car in our program has the same structure
# ie. the dictionary is laid out in the same way
bmw = car('BMW', 0, 1000)




# now we should define some behaviour, ie. describe how our data will change
# for example, moving increases the mileage of each car..
def car_move(car, miles):
    car['mileage'] += miles


car_move(rover, 10)
car_move(bmw, 100)

# and we can invisage some more behaviour associated with this kind of data..

def car_engine_start(car):
    pass

# or with bikes...

def bike_peddle_faster(bike):
    pass


# this style of programming is known as procedural: data and behaviour are separated
# car_move() is *done to* bmw, rather than more typically in python...

"Michael".upper()

# "Michael" is asked to upper() itself.. not:  upper("Michael")


# in general we want to be able create our own kinds of data which itself knows how to behave

# So that we can write,

"""

audi = Car("Audi", 30, 0)
audi.move(10)
audi.start_engine()

"""


# the class keyword creates a special kind of object called a class
# a class is callable, ie. it can be called like a function
# calling Car, ie. Car(), produces objects of type Car
# (just like str() produces of objects of type str...)

class Car:
    def __init__(self, mpg, mileage):  # these objects are given their properties here
        self.mpg = mpg                 # the __init__ method takes an empty Car as the first parameter
        self.mileage = mileage         # and gives it data (state)

    def move(self, miles):             # we can define behaviour on Car that all particular cars have
        self.mileage += 10


freddie = Car(50, 0)    # new object of type Car
print type(freddie)

zelda  = Car(50, 0)
print type(zelda)


freddie.move(10)    # each particular object can call methods defined on the class Car
                    # these *methods* (aka functions) take the particular object as their first parameter

# so that,

zelda.move(5) # is the same operation as
freddie.move(5) # but on a different object, ie. on different data (/state)


# this way of designing programs models the world in a particular way
# it phrases problems as "objects behaving"

# that is, when desigining our program we list objects of interest,
# their properties
# and the changes they undergo

# for each kind of object we create a class

# some examples...


class Player:
    def __init__(self, name, health, skill):
        self.name = name
        self.health = health
        self.skill = skill

    def attack(self, enemy):
        if self.skill > enemy.skill:
            enemy.health -= 5
        else:
            self.health -= 5


me = Player("Michael", 100, 10)
you = Player("Sherlock", 100, 7)

me.attack(you)

print me.health
print you.health



class Room:
    def __init__(self, name, location):
        self.name = name
        self.location = location
        self.occupants = []

    def enter_room(self, person):
        self.occupants.append(person)

    def throw_out(self):
        return self.occupants.pop()



delta = Room("Delta", "UK")
delta.enter_room("Michael")
delta.enter_room("Sherlock")
delta.enter_room("Watson")

print delta.throw_out()





# and we can combine these..


player1 = Player("Merlin", 100, 100)
dungeon = Room("Evil Lair", "Hell")
dungeon.enter_room(player1)




# ASIDE:

# How does this mechanism work?

# 1. methods really are defined on class objects
# that is, class objects have -- as with all objects -- a namespace which contains methods
# and two special properties:
# a. they can be called, and calling them creates new objects of that particular type
# b. whenever you call a method on a particular object of that type, the method call is rewirtten to:

Car.move(freddie, 10)

#cf.

freddie.move(10)

# so the move method is really on the class object, *NOT* on the particular instance -- that would be very inefficient!


# eg.

"Hello".upper()

# translates to...

str.upper("Hello")


# which translates to...

str.__dict__['upper']('hello')  

# look !  is't just a dictionary (str.__dict__ , str's namepsace)  AND a function __dict__['upper']
# procedurally working on 'hello' !

#


