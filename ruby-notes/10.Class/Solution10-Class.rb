# CHAPTER:    Object Oriented Programming
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Use classes to describe a person and a room.
# PROBLEM:    Use inheritance to calculate the area of different shapes.
# PROBLEM:    Represent dogs and cats so that they can eat and speak. 
# TIME:       30m


# QUESTIONS

# PART 1 -- SYNTAX
class Person
    def initialize(name, age)
        @name = name
        @age  = age
    end 

    def describe
        print @name
    end
end 


# Q. modify Person
#... so that you can set its name and age when you construct it

#Q. create a Person with the name 'Sherlock' and the age 35
sherlock = Person.new("Sherlock", 35)

#Q. ask sherlock to describe himself
sherlock.describe

# Q. create a class Room that has a constructor (initialize)
#... the constructor should give each room a name and location
class Room
  def initialize(name, location)
    @name = name
    @location = location
  end

  def describe
    puts @name, @location
  end
end

# Q. on the room class,
#... include a describe() method that prints its details

# Q. create a room
r200 = Room.new("R 200", "UK")

# Q. ask it to describe itself
r200.describe



# PART 2 -- INHERITANCE

# Q. define a class called Shape
#... Give the class Shape one method, area.
#... the area method should have no implementation

class Shape
  def area

  end
end

# Q. Define a Rectangle which extends from Shape.
#... Rectangle should have an initialize method
#... which assigns a width and height.

class Rectangle < Shape
  def initialize(width, height)
    @width = width
    @height = height
  end
end

# Q. define a class Square which extends from Rectangle
#... add an area method to square which
#... returns the area of the particular square instance.
# HINT: formula for area is  width * height

class Square < Rectangle
  def area
    @width * @height
  end
end

#Q. print the area of various squares.
# HINT: create several square instances and call .area() on these

s55 = Square.new(5, 5)
s44 = Square.new(3, 3)
s33 = Square.new(3, 3)

p (s33.area + s44.area) == s55.area

#Q. is there something wrong with the definition of Square?

# Q. add a constructor to square that calls Rectangle's constructor 
#... call it so no misshapen squares can be made.. 

class Square < Rectangle
  def initialize(side)
    super(side, side)
  end
end



# PART 3 -- REVERSE

# Q. write the classes Dog and Cat
#... so that the following code runs without error

class Dog
  def initialize(name)
    @name = name
    @weight = 0
  end

  def speak
    puts "woof!"
  end
  def eat(amount)
    @weight += amount
  end
end


class Cat
  def initialize(name)
    @name = name
  end

  def speak
    puts "meow!"
  end
end

fido = Dog.new('fido')
fluffy = Cat.new('fluffy')

fido.eat(100)

fido.speak        # woof!
fluffy.speak      # purr!

puts 'Fido weighs... {fido.weight} g' # fido weighs 100 g

# Q. how could you use inheritance to simplify these definitions?

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

    def initialize
        @pieces = [Player.new] + [Path.new, Monster.new, Path.new] * 3
    end 

    def each(&block) 
        @pieces.each(&block)
    end 
end 

class Frame
  def initialize
    @board = Board.new
  end

  def to_s
    @board.map { |p| p.to_s }.join
  end
end

# Q. this should print the frame
puts Frame.new


## REVIEW: What did we learn from this exercise?