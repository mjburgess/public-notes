# CLASSES
""" NOVICE ASIDE:

Why do we use class?

To define templates for creating objects. 
"""


class Person:
    pass


me = Person()

print(id(me))  # ID
print(type(me))  # TYPE 
print(dir(me))  # NAMESPACE
print(vars(me))  # STATE


class Dog:
    def speak(dog):
        print('Woof')


fido = Dog()
fido.speak()

print(id(fido))  # ID
print(type(fido))  # TYPE 
print(dir(fido))  # NAMESPACE
print(vars(fido))  # STATE


class Cat:
    def __init__(cat):
        cat.name = 'Fluffy'

    def speak(cat):
        print(cat.name + ' Meows!')


my_cat = Cat()
my_cat.speak()

print(id(my_cat))  # ID
print(type(my_cat))  # TYPE 
print(dir(my_cat))  # NAMESPACE
print(vars(my_cat))  # STATE


''' OUTPUT (11.OO/Demo11-4.2.Classes.py):
4327942576
<class '__main__.Person'>
['__class__', '__delattr__', '__dict__', '__dir__', '__doc__', '__eq__', '__format__', '__ge__', '__getattribute__', '__gt__', '__hash__', '__init__', '__le__', '__lt__', '__module__', '__ne__', '__new__', '__reduce__', '__reduce_ex__', '__repr__', '__setattr__', '__sizeof__', '__str__', '__subclasshook__', '__weakref__']
{}
Woof
4327942800
<class '__main__.Dog'>
['__class__', '__delattr__', '__dict__', '__dir__', '__doc__', '__eq__', '__format__', '__ge__', '__getattribute__', '__gt__', '__hash__', '__init__', '__le__', '__lt__', '__module__', '__ne__', '__new__', '__reduce__', '__reduce_ex__', '__repr__', '__setattr__', '__sizeof__', '__str__', '__subclasshook__', '__weakref__', 'speak']
{}
Fluffy Meows!
4327942968
<class '__main__.Cat'>
['__class__', '__delattr__', '__dict__', '__dir__', '__doc__', '__eq__', '__format__', '__ge__', '__getattribute__', '__gt__', '__hash__', '__init__', '__le__', '__lt__', '__module__', '__ne__', '__new__', '__reduce__', '__reduce_ex__', '__repr__', '__setattr__', '__sizeof__', '__str__', '__subclasshook__', '__weakref__', 'name', 'speak']
{'name': 'Fluffy'}

'''
