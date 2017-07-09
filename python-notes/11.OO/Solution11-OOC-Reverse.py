# CHAPTER:    Object Oriented Programming
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Represent dogs and cats so that they can eat and speak. 
# TIME:       15m


class Dog:
    def __init__(self, name):
        self.name = name
        self.weight = 0

    def speak(self):
        print('Woof!')

    def eat(self, amount):
        self.weight += amount


class Cat:
    def __init__(self, name):
        self.name = name

    def speak(self):
        print('Purr!')


# Q. write the classes Dog and Cat
# ... so that the following code runs without error
fido = Dog('fido')
fluffy = Cat('fluffy')

fido.eat(100)

fido.speak()  # woof!
fluffy.speak()  # purr!

print('Fido weighs... {} g'.format(fido.weight))  # fido weighs 100 g

# EXTRA:

# Q. how could you use inheritance to simplify these definitions?


""" REVIEW

What did we learn from this exercise?

How to think abotu defining classes in terms of what you want the final code to look-like.

You can start by sketching how objects will work together and then work backwards to class defiintions. 
"""


''' OUTPUT (11.OO/Solution11-OOC-Reverse.py):
Woof!
Purr!
Fido weighs... 100 g

'''
