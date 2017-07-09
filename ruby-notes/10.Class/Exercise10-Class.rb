# CHAPTER:    Object Oriented Programming
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Use classes to describe a person and a room.
# PROBLEM:    Use inheritance to calculate the area of different shapes.
# PROBLEM:    Define classes so that dogs and cats can eat and speak.
# TIME:       10 m * 3


# QUESTIONS

# PART 1 -- SYNTAX
# PROBLEM:    Use classes to describe a person and a room.

class Person
    def initialize
        @name = 'NAME'
        @age  = 30
    end 

    def describe
        print @name
    end
end 


# Q. modify Person
#... so that you can set its name and age when you construct it

#Q. create a Person with the name 'Sherlock' and the age 35

#Q. ask sherlock to describe himself

# Q. create a class Room that has a constructor (initalize)
#... the constructor should give each room a name and location 

# Q. on the room class,
#... include a describe() method that prints its details

# Q. create a room

# Q. ask it to describe itself 




# PART 2 -- INHERITANCE
# PROBLEM:    Use inheritance to calculate the area of different shapes.

# Q. define a class called Shape
#... Give the class Shape one method, area.
#... the area method should have no implementation

# Q. Define a Rectangle which extends from Shape.
#... Rectangle should have an initialize method
#... which assigns a width and height.

# Q. define a class Square which extends from Rectangle
#... add an area method to square which
#... returns the area of the particular square instance.
# HINT: formula for area is  width * height


#Q. print the area of various squares.
# HINT: create several square instances and call .area() on these

#Q. is there something wrong with the definition of Square?

# Q. add a constructor to square that calls Rectangle's constructor 
#... call it so no misshapen squares can be made.. 





# PART 3 -- REVERSE
# PROBLEM:    Define classes so that dogs and cats can eat and speak.

# Q. write the classes Dog and Cat
#... so that the following code runs without error

fido = Dog.new('fido')
fluffy = Cat.new('fluffy')

fido.eat(100)

fido.speak        # woof!
fluffy.speak      # purr!

puts 'Fido weighs... {fido.weight} g' # fido weighs 100 g




# EXTRA -- SPECIAL METHODS

# Q. define a class Frame, every frame should have a Board
# when an object of type Frame is printed (ie., converted to string)
# it should output every piece on the Board separated by a space
# use the fact that each piece has a to_s defined, and that Board defines each

class Piece; end

class Path < Piece
    def to_s
        '.'
    end 
end 

class Player < Piece
    def to_s
        'P'
    end 
end 

class Monster < Piece
    def to_s
        'M'
    end 
end


class Board
    include Enumerable

    def initalize
        @pieces = [Player.new] + [Path.new, Monster.new, Path.new] * 3
    end 

    def each(&block) 
        @pieces.each(&block)
    end 
end 


# Q. this should print the frame
puts Frame.new


## REVIEW: What did we learn from this exercise?