# ADVANCED SUPPLEMENTAL 

# CHAPTER:    Object Oriented Programming
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Complete the defintions of the given classes.
# TIME:       20 m

# Q. for each of the following code snippets below
# define the revelant classes so that the snippets 
# run without error 
# ... (uncomment them when you're done)

class Person:
    def __init__(self, name, age, weight):
        self.name = name
        self.age = age
        self.weight = weight

    def eat(self, w):
        self.weight += w

    def marry(self, p):
        self.name += '-' + p.split()[1]

    def age(self, y):
        self.age += y


""" <- REMOVE 
# Q
me = Person('Sherlock Holmes', 27, 70)
me.eat(0.5)
me.marry('Irene Adler')
me.age(1)

print me.name, 'is', me.age, 'years old' # Sherlock Holmes-Adler is 28 years old 
print 'weighing', me.weight, 'kg'        # weighing 70.5 kg
"""


class Room:
    def __init__(self, name, location):
        self.name = name
        self.location = location
        self.occupants = []

    def enter_room(self, person):
        self.occupants.append(person)

    def throw_out_last(self):
        return self.occupants.pop()


"""
# Q
delta = Room("Delta", "UK")
delta.enter_room("Michael")
delta.enter_room("Sherlock")
delta.enter_room("Watson")

print delta.throw_out_last()    # prints 'Watson'
"""


class ConsoleIO:
    def __init__(self, title):
        self.title = title
        print(title)

    def get(self, question):
        return input(question)


class User:
    def __init__(self, name, password):
        self.name = name
        self.password = password


class Authenticator:
    def login(self, user, password):
        return user.password == password


"""
# Q
io = ConsoleIO('Login User')
password = io.get('Password? ')

auth = Authenticator()
print auth.login(User('michael', 'pa$$w0rd'), password)
"""


# EXTRA

class Remote:
    def __init__(self, tv):
        self.tv = tv

    def turn_on(self):
        print("ON!")

    def channel(self, channel):
        return self.tv.show(channel)


class Signal:
    def __init__(self, tvp):
        self.programme = tvp

    def show(self):
        return self.programme.show()


class TvProgramme:
    def __init__(self, name):
        self.name = name

    def show(self):
        print(self.name)


class Television:
    def __init__(self, signals):
        self.channels = signals

    def show(self, channel):
        self.channels[channel].show()


"""
# Q
horizon = TvProgramme('Horizon')
sherlock = TvProgramme('Sherlock')

noise = Signal(None)
bbc2 = Signal(horizon)
bbc1 = Signal(sherlock)

my_tv = Television([noise, bbc1, bbc2])

remote = Remote(my_tv)
remote.turn_on()
remote.channel(1)       # prints 'Sherlock'
"""

""" REVIEW
What did we learn from this exercise?
"""


''' OUTPUT (11.OO/Solution11-OOE-Extended.py):

'''
