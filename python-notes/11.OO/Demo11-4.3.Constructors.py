# CONSTRUCTORS


""" NOVICE ASIDE:

Why do we use constructors?

To determine what data each object of a type should be given, 
    ie., to construct those objects. 

"""


class Person:
    def __init__(person):
        person.name = 'Michael'


me = Person()
print(me.name)
print(vars(me))

you = Person()
print(you.name)


class Dog:
    def __init__(self):
        self.name = 'Fido'


my_pet = Dog()
print(my_pet.name)


class Cat:
    def __init__(self, name):
        self.name = name


your_cat = Cat('Fluffy')
my_cat = Cat('Whiskers')

print(your_cat.name)
print(my_cat.name)


class Employee:
    def __init__(self, name, age, ni):
        self.name = name
        self.age = age
        self.ni = ni


john = Employee('John', 35, 'JH 00 00 00 B')
jane = Employee('Jane', 45, 'GA 00 00 00 B')

print(john.name, john.ni)
print(jane.name, jane.ni)


''' OUTPUT (11.OO/Demo11-4.3.Constructors.py):
Michael
{'name': 'Michael'}
Michael
Fido
Fluffy
Whiskers
John JH 00 00 00 B
Jane GA 00 00 00 B

'''
