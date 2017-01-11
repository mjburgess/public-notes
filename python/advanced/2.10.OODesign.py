# 2.10.OODesign.py


# 1. Design

# Program design is a complex topic, and especially, the design of object-oriented programs.
# What ever the particular difficulties involved in a particular problem however, design always begins from principles.
# A difficult problem is one in which there are various competing design principles at work
# so that the best solution is hard to see.

# We aren't quite there with programming yet though: we've yet to really focus on any design principles at all,
# let alone a process which involves several competing ones. So let's review some.


# 2. Imperative Programs are divided into: state and state change

# "state" technically referes to the compelete set of stored information a program uses
# this is, simply, just its data:

name = "Michael Burgess"
age  = 27
location = "UK"
year = 2016

# but notice something interesting about this data: it *describes* a situation at a given moment in time
# for example, if we increase the year by one:

year += 1

# then

age += 1

# must follow


# and now the values:  name, age, location, year *describe* the world at another moment of time


# so state, or data, is about describing the "current situation", the "way things are now" in the program

# the other aspect of imperative programs is: state change

# above the operation += 1  is a state change.

# in simple programs like this data sits around waiting *to be changed* by some external force:
# in this case an operator, but there could easily be an add_one() function


# 3. The Control of State Change


# In a procedural program like the one above (or basically, one with data collections & functions)
# we divide the program up into two distinct aspects:

# data == state
person = {
    "name": "michael",
    "age": 27,
    "location": "UK"
}

current_year = 2016

# functions == stae change
def change_name(person, new_name):
    person['name'] = new_name


def change_location(person, new_location):
    person['location'] = new_location


# and so on...

# if we diligantly use "change_name" everytime we want to change a name of person
# then we can control how people's names change:

change_name(person, "Michael Burgess")

# suppose we go back and modify change_name() so it checks the length of the name,
# or suppose we modify person to include an email and change_name() to send an email when their details change

# if we have used change_name() everywhere then this process is simple

# in otherwords, we have found a simple mechanism to control state change:
# we always use functions to change the state of our program, and we make those well-behaved

# however, in the end, person is still a free-floating bit of data that could easily be changed
# by any old function in any old way, and that could violate our expectations

# consider,

player = {
    "name": "player1",
    "position": (0,0),
    "travelled": 0
}

def distance(to, from):
    x1, y1 = to
    x2, y2 = from

    return ((y2 - y1) ** 2 + (x2 - x1) ** 2) ** 0.5

def move(player, to):
    player['travelled'] = distance(to, player['position'])
    player['position'] = to


# so long as we use move, the "travelled" property of a player is well-behaved

move(player, (10, 10))
move(player, (2, 2))

print player

# so if we rely on that property later on, we won't run into problems

def calculate_points(player):
    return int(player['travelled'] / 10)


print "Player scored: ", calculate_points(player)


# but of course, we're not required to use move() and we can muck-about with
# the player's position any number of ways:

player['position'] = (0,0)


# 4. Objects control their own state

# If, rather than a dictionary, player were an object with methods particular to being a player
# *it* could control its own state change:


class Player:
    def __init__(self, name, start=(0,0)):
        self.name = name
        self.position = start
        self.travelled = 0

    def move(self, to):
        self.travelled = distance(to, self.position)
        self.position = to

    def points(self):
        return int(self.travelled / 10)


avatar = Player("Player2")
avatar.move(10, 10)
avatar.move(2, 2)

print avatar.name, "has", avatar.points()


# it may seem we have achived less than expected:
# we have shifted the responsibility of changing player's state to the *player itself*
# but we can still, fundamentally, mess up the program:


avatar.position = (0,0)

# and here is the reality of design:
# much of it is about phrasing programs that makes it easier to reason about how they work
# and thus *encourages disipline*

# functions, classes, etc. which are named corrected -- and "co-located" or grouped appropriately (into modules, classses, etc.)
# encourages a way of thinking about how a programs works and sets up a conceptual environment
# in which you are less likely to make mistakes of the above kind...

# since if every way you want to change player is a method on the player object,
# then it is to methods you will first look and consider, in a commmon place: a class


# 5. Putting Objects into Practice
# to explore design on a larger scale, we're going to need to consider a larger program
# the final section of these materials "4-Project" iteratively builds up a rougelike game
# explore this project and its design considerations
