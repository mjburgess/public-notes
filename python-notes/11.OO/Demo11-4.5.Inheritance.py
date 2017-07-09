# INHERITANCE

""" NOVICE ASIDE:

Why do we use inheritance?

(GOOD) To expand on simple rules: eating requires food, but there are many types of food. 
(BAD)  To share functionality across objects: everything which is a person can also do everything a human can do.
"""


# 1. inheritance

# in the real world objects do not have a single principle type
# for example, a human being might also be: an employee, husband, mother, sister, solider, etc.

# this is also the case in programs designed with objects

class Vehicle:
    pass


class Car(Vehicle):  # this says "all Cars are also Vehicles"
    pass


class Bike(Vehicle):  # all bikes are Vehicles
    pass


v = Vehicle()  # create a particualr Vehicle v, which belongs to the class Vehicle
c = Car()  # create a particular Car c, which belongs to both the classes Car and Vehicle
b = Bike()

print(isinstance(v, Vehicle))  # is v an example of class Vehicle?
print(isinstance(c, Car))  # is c an example of class Car?
print(isinstance(c, Vehicle))  # is c an example of class Vehicle?
print(isinstance(c, Bike))  # is c an example of class Bike?


# another example

class Shape:
    def area(self):
        pass  # there's no sensible defintion of "area" for every shape


class Rectangle(Shape):  # all Rectangles are Shapes
    def __init__(self, width, height):
        self.width = width
        self.height = height

    def area(self):
        return self.width * self.height


class Square(Rectangle):  # all Squares are Rectangles
    pass


mysq = Square(10, 10)
mysq.area()  # note that Square does not define an "area" method itself
# since all Squares are Rectangles,
# all squares have access to (inherit) Rectangle's methods


# inheritance & namespacing rules...

# a particular object has its own state:

print(vars(mysq))  # mysq is empty

# everything else comes from its type

print(vars(Square))
print(vars(Rectangle))
print(vars(Shape))


# so you can think of Shape as the largest namespace, which includes Rectangle which includes Square
# and all particular objects of type Square "live side" the Square namespace, which means they also live inside Rectange and Shape


# python supports multiple inheritance

class Mover:
    def move(self):
        print("moving!")


class Animal:
    pass


class Pig(Animal, Mover):  # all Pigs are Movers and Animals
    pass


class Cat(Animal, Mover):  # all Cats are also Movers and Animals
    pass


class Sponge(Animal):  # a Sponge is just an Animal
    pass


mysponge = Sponge()
mykitten = Cat()

mykitten.move()

"""NOPE:

mysponge.move()

"""


# multiple inheritance is quite dangeours however, since it leads to complex and convoluted designs
# it's unclear where methods come from, and how state changes occur

# the biggest obstacle to reasoning easily about the behaviour of a program is state change
# state (eg. object data) changing in unpredicable or obscure ways makes it hard to understand what a program is doing

# therefore if you keep state out of your "additional parents" multiple inheritance isn't so bad

# these stateless parents are known as "mixins" because there merely mix-in fuctionality
# as with Mover above:  Mover provides a move() functionality


# 2. polymorphism

# in python we almost never care whether a particular object belongs to a class (or multiple)
# rather we care if an object can behave in a certain way:

# consider here several totally independent classes each which provide a get_name method

class User:
    def get_name(self):
        return 'Michae'


class Fruit:
    def get_name(self):
        return 'Bannan'


class Galaxy:
    def get_name(self):
        return 'M52'


# we define a function which accepts a sequence of get_name-having objects:

def format(namers):
    out = []
    for nameable in namers:
        out.append(nameable.get_name().upper())  # we call get_name on each
        # the particular behaviour of get_name however depends on the actual type of nameable

    return out


print(format([User(), Fruit(), Fruit(), Galaxy()]))  # we pass objects of disparate types, but this works!


# or..

class Page:
    def write(self):
        print("SOME TEXT")


class HtmlPage(Page):
    def write(self):
        print("<p>HTML PAGE</p>")


class CliPage(Page):
    def write(self):
        pass


particular_html_page = HtmlPage()
particular_html_page.write()

isinstance(particular_html_page, Page)


def output(pages):
    for p in pages:
        p.write()  # the behaviour of .write() depends on the type of p


output([Page(), HtmlPage(), CliPage()])

# this type-depedent behaviour is known as polymorphism
# the lack of explicit typing (ie., requiring a particualar named type) is called duck typing

# PROCEDURAL VERSION:

page = {'type': 'page', 'message': 'Hello'}
html = {'type': 'html', 'message': 'Hello'}
cli = {'type': 'cli', 'message': 'Hello'}


def page_write(message):
    print(message + ' -- page')


def html_write(message):
    print(message + ' -- html')


def cli_write(message):
    print(message + ' -- cli')


def _output(pages):
    fns = {'page': page_write, 'html': html_write, 'cli': cli_write}

    for page in pages:
        fns[page['type']](page)


''' OUTPUT (11.OO/Demo11-4.5.Inheritance.py):
True
True
True
False
{'height': 10, 'width': 10}
{'__module__': '__main__', '__doc__': None}
{'__module__': '__main__', '__init__': <function Rectangle.__init__ at 0x109a5b1e0>, 'area': <function Rectangle.area at 0x109a5b268>, '__doc__': None}
{'__module__': '__main__', '__weakref__': <attribute '__weakref__' of 'Shape' objects>, '__doc__': None, 'area': <function Shape.area at 0x109a5b158>, '__dict__': <attribute '__dict__' of 'Shape' objects>}
moving!
['MICHAE', 'BANNAN', 'BANNAN', 'M52']
<p>HTML PAGE</p>
SOME TEXT
<p>HTML PAGE</p>

'''
