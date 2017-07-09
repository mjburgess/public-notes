# usually its static vs dynamic
# however in python static just means "using the class name"
# (with reference to other languages in which using the classname is static...)

class Person:
    def __init__(self, name, age):
        self.name = name
        self.age = age

    def speak(self):
        print("Hi, I am " + self.name)


class Student(Person):
    def __init__(self, name, age, gpa):
        Person.__init__(self, name, age)
        self.gpa = gpa

    def speak(self):
        Person.speak(self)
        print('.. with GPA={}'.format(self.gpa))


me = Student('M', 27, 4.0)
me.speak()


class Directions:
    NORTH = 1
    SOUTH = 2
    EAST = 3
    WEST = 4

    @staticmethod
    def get_direction(d):
        return [None, 'N', 'S', 'E', 'W'][d]


direction = Directions.NORTH

print(Directions.get_direction(direction))


''' OUTPUT (11.OO/Demo11-4.8.Statics.py):
Hi, I am M
.. with GPA=4.0
N

'''
