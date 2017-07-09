# CHAPTER 10: Class

## WHY IS THIS IMPORTANT?: 
## 
## 

# CLASSES AND OBJECTS 

string = "Hello"

p string.class
p string.methods
p string.class.methods 

p String.new 
p string.class.new 
p string.methods - string.class.new.methods

# class is a factory object
# class.new is its production line 
# new_object = class.new   


# DEFINING CLASSES

Person = Class.new do
    def speak
        p 'Hello!'
    end
end 

me = Person.new 
me.speak

# or,

class Person 
    def speak
        p 'Hello!'
    end
end 

you = Person.new 
you.speak 


# CONSTRUCTORS AND ATTRIBUTES

class Person 
    def initialize(name)
        @name = name 
    end 

    def speak
        p "I am #{@name}"
    end
end 

john = Person.new 'John Watson'
john.speak

# john.name # ERROR:  name is not a valid message 

if john.respond_to? :name 
    p 'john can tell you its name'
else
    p 'john cannot tell you its name'
end 

p john.instance_variables
p john.instance_variable_get :@name

# there is nothing called 'name' only internal state accessible on @name 

class Person 
    def initialize(name)
        @name = name 
    end 

    def name
        "I am #{@name}"
    end

    def speak
        p self.name                 # self pseudo-variable
    end 
end 

sherlock = Person.new 'Sherlock Holmes'

p sherlock.name
p sherlock.instance_variables

# or,
class Person 
    attr_reader :name 

    def initialize(name)
        @name = name 
    end 
end 

hound = Person.new 'Baskerville'
p hound.name 



#and, to write:
class Person 
    attr_reader :name 
    attr_accessor :name             # or just, attr_accessor 

    def initialize(name)
        @name = name 
    end 
end 

hound = Person.new 'Baskerville'
hound.name = 'Woof!'
p hound.name 



# COMPOSITION

class ConsoleIO
    def initialize(title)
        @title = title 
    end 

    def get(prompt='$> ')
        puts
        puts @title 
        print prompt 
        gets.chomp
    end 
end 

class User
    attr_reader :name, :password 
    def initialize(name, password)
        @name = name 
        @password = password
    end 
end 

class Authenticator 
    def login(user)
        io = ConsoleIO.new 'Authenticator'
        user.password == io.get 
    end 
end 

me = User.new('Irene', 'TEST')
auth = Authenticator.new

if auth.login(me)
    p 'SUCCESS!'
else 
    p 'FAILURE'
end 

# INHERITANCE 

class Vehicle
    # pass 
end 

class Car < Vehicle
    # pass 
end 


class Bike < Vehicle
    # pass 
end 

my_veh = Vehicle.new 
my_car = Car.new 
my_bik = Bike.new 

p my_veh.is_a? Vehicle
p my_car.is_a? Car
p my_car.is_a? Vehicle
p my_bik.is_a? Car




class Animal
    def speak
        puts 'grunt'
    end
end 

class Bird < Animal
    def speak
        puts 'chirp'
    end 
end 

class Parrot < Bird 
    def speak 
        puts 'caww'
    end 
end 

class Human < Animal 
    def speak
        puts 'Hmmm?'
    end 
end 

animals = [Animal.new, Bird.new, Parrot.new, Human.new]

animals.each { |animal|
    print "#{animal.class} says "
    animal.speak
}




class Toy 
    def price
        10
    end 
end 

class CheapToy < Toy 
    def price 
        super - 5
    end 
end 


game = CheapToy.new 
p game.price



class House
    attr_reader :price 
    def initialize(price)
        @price = price 
    end 
end 

class ExpensiveHouse < House 
    def initialize(base_price, agency_fees)
        super(base_price + agency_fees)
    end 
end 


ahouse = ExpensiveHouse.new(1_000_000, 10_000)
p ahouse.price
p ahouse.price.to_s.reverse.scan(/\d{1,3}/).join(",").reverse


# METHOD ACCESS 

class House 
    def estimate
        price + 10_000
    end

    protected 
    def price 
        _price * 1.2
    end 

    private 
    def _price
        1_000_000
    end 
end 


class CheapHouse < House
    def price 
        super * 0.5
    end 
end 

ahouse = House.new
chouse = CheapHouse.new

p ahouse.estimate
p chouse.estimate
p ahouse.estimate.to_f / chouse.estimate
p (ahouse.estimate.to_f / chouse.estimate).round

# CLASS ATTRIBUTES 

class Moves
    LEFT, RIGHT, UP, DOWN = *0..3

    def Moves.direction(d)
        case d
        when Moves::LEFT 
            "left"
        when Moves::RIGHT
            "right"
        when Moves::UP
            "up"
        when Moves::DOWN
            "down"
        else 
            "?"
        end 
    end 
end 

move = Moves::UP            # scope resolution

p 'The player moved ' + Moves.direction(move)       




class ConsoleIO
    TITLE  = "enter your details"
    PROMPT = "$> "

    def initialize(title=TITLE)
        @title = title 
    end 

    def get(prompt=PROMPT)
        puts
        puts @title 
        print prompt 
        gets.chomp
    end 
end 


cio = ConsoleIO.new 
p cio.get



class Mover
    LEFT, RIGHT, UP, DOWN = *0..3

    class << self                       # self-class (eigenclass) 
        def direction(d)
            case d
            when LEFT 
                "left"
            when RIGHT
                "right"
            when UP
                "up"
            when DOWN
                "down"
            else 
                "?"
            end 
        end 
    end

    def move(m)
        p 'Moving ' + Moves.direction(m)
    end 
end 


me = Mover.new 
me.move(Mover::UP)


# SPECIAL METHODS: OPERATORS, COERSION, METHOD MISSING

class Account
    attr_accessor :balance

    def initialize(initial)
        @balance = initial
    end

    def balance_in_pence
        (balance * 100).to_i
    end   

    def balance_in_pence=(pence)
        @balance = pence / 100.0
    end  


    def +(other)
        if other.is_a? Account
            Account.new(balance + other.balance)
        elsif other.is_a? Numeric  
            Account.new(balance + other)
        else
            Account.new(nil)
        end
    end   
end


account_a = Account.new(1000.00) 
account_b = account_a + 1
account_c = account_a + account_b
p account_c.balance

an_account = Account.new(1000.00) 
an_account.balance_in_pence = 1234
p an_account.balance
p an_account.balance_in_pence


# DESIGN OF OO PROGRAMS 

# (SOME) DESIGN PRINCIPLES:
    # 1. Cohesion  -- everything is grouped logically
    # 2. Single Responsiblity -- there is one purpose
    # 3. Coupling -- dependencies between things are minimized
    # 4. Control  -- objects control their own data (via methods), not other objects
    # 5. Descriptive Accuracy -- carve-at-the-jointss