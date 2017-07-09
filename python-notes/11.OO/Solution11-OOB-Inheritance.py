# CHAPTER:    Object Oriented Programming
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Use inheritance to calculate the area of different shapes.
# TIME:       15m


# Q. define a class called Shape
# ... Give the class Shape one method, area.
# ... the area method should have no implementation
# HINT: pass

class Shape:
    def area(self):
        pass

    # Q. Define a Rectangle which extends from Shape.


# Rectangle should have an __init__ method 
# which assigns a width and height.
class Rectangle(Shape):
    def __init__(self, width, height):
        self.width = width
        self.height = height

    # Q. define a class Square which extends from Rectangle


# ... add an area method to square which
# ... returns the area of the particular square instance.
# HINT: formula for area is  width * height
class Square(Rectangle):
    def area(self):
        return self.width * self.height

    # print the area of various squares.


# HINT: create several square instances and call .area() on these

small = Square(2, 2)
large = Square(250, 250)

print('small', small.area())
print('large', large.area())


# EXTRA:
# Q. is there something wrong with the definition of Square?

# Q. add a constructor to square that calls Rectangle's constructor 
# ... call it so no misshapen squares can be made.. 


class Square(Rectangle):
    def __init__(self, side):
        Rectangle.__init__(self, side, side)

    def area(self):
        return self.width * self.height


""" REVIEW

What did we learn from this exercise?

syntax:
    class Child(Parent)

objects are made from blueprints 
blueprints can be "glued together" (inheritance)
so that objects get all their methdos from Child + Parent
where child's defintions take priority 
"""


''' OUTPUT (11.OO/Solution11-OOB-Inheritance.py):
small 4
large 62500

'''
