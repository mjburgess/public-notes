# SPECIAL METHODS 
""" NOVICE ASIDE:

Why do we need special object behaviour?

Objects can be treated in all sorts of ways: as lists, as strings, as containers, as bools, as ints, as...abs
Special methods provide objects with the ability to control how they behaviour when treated in these different ways. 
"""


class Animal:
    pass


class Mammal(Animal):
    pass


class Hawk(Animal):
    def __str__(self):
        return 'SCREATCH!'


class Lion(Mammal):
    def feed(self):
        print('Feeding the Lion')

    def __str__(self):
        return 'Raww'


class Wolf(Mammal):
    def feed(self):
        print('Feeding the Wolf')

    def __str__(self):
        return 'HowWooo'


class Zoo:
    def __init__(self):
        self.animals = [Lion(), Wolf(), Lion(), Hawk()]

    def __len__(self):
        return len(self.animals)

    def __contains__(self, animal):
        return any([isinstance(a, animal.__class__) for a in self.animals])

    def __iter__(self):
        return iter(self.animals)


def describe_zoo(zoo):
    print('there are', len(zoo), 'animals')
    print()

    if Lion() in zoo:
        print('There are lions in the zoo!')

    feed_everything(zoo)


def feed_everything(zoo):
    for animal in zoo:
        print()
        if hasattr(animal, 'feed'):
            animal.feed()  # duck typing

        print(animal)


describe_zoo(Zoo())


''' OUTPUT (11.OO/Demo11-4.6.SpecialMethods.py):
there are 4 animals

There are lions in the zoo!

Feeding the Lion
Raww

Feeding the Wolf
HowWooo

Feeding the Lion
Raww

SCREATCH!

'''
