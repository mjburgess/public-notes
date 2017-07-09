# COMPOSITION
""" NOVICE ASIDE:

Why do we compose objects?

We need to bring objects together in order for each to do their specific job. 

Composition:
    1. Arguments to a Function 
    2. Arguments to a constructor them REMEMBERED on self. 
    3. Creating an object within a method

"""


class ConsoleIO:
    def __init__(self, title):
        self.title = title

    def get(self, prompt):
        print(self.title)
        print()

        return input(prompt)


class User:
    def __init__(self, name, password):
        self.name = name
        self.password = password


class Authenticator:
    def login(self, user, password):
        if user.password == password:
            print('LOGGED IN!')


io = ConsoleIO('Login User')
password = io.get('Password? ')

me = User('michael', 'pa$$w0rd')

auth = Authenticator()
auth.login(me, password)

"""
class TvProgramme:
    def show(self):
        print(self.name)

class Television:
    def show(self, channel):
        self.channels[channel].show()

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


''' OUTPUT (11.OO/Demo11-4.4.Composition.py):
Login User

Password? 
'''
