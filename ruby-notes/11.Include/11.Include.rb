# CHAPTER 10: Include


## WHY IS THIS IMPORTANT?: 
## 
## 

# PART 1 -- MODULES 

# MODULES AND NAMESPACES 
# a module is a named grouping of names.. a namespace 
# typically requires include to access contents of namespace
module Baking
  CAKE_FLOUR, CAKE_SUGAR, CAKE_BUTTER = 100, 100, 100

  def prepare
    p "preparing cake"
    p "amount: #{CAKE_FLOUR + CAKE_BUTTER + CAKE_SUGAR}"
  end
end

# error # Baking.prepare

include Baking
prepare

# and also:
Baking.prepare


# modules can group arbitrary kinds of definition
#eg. other modules, and classes.. 

module API
  class REST
    def post
      p "POST"
    end
  end

  module Verbs
    def get
      p "GET"
    end
  end
end

include API
include API::Verbs # required, and note ::

r = API::REST.new #or,  REST.new
r.get

API::Verbs.get #or, get

# MODULE METHODS AND ACCESS 
# modules can be defined without requiring include
module Cooking
  CAKE_FLOUR = 200

  def Cooking.prep # module-level def.
    # cannot call perpare() here
    p Cooking::CAKE_FLOUR
  end

  # error # class Cooking.Oven; end
end

Cooking.prepare

# these forms of definition do not interact very well
# eg. you cannot call a include-level defintion from a module-level defintion


# and modules can use the traditional access control keywords
module System
  private
  def _prepare_credentials
    p "module: #{self.class.name}:: #{__method__}"
  end

  public
  def login
    _prepare_credentials
    p "module: #{self.class.name}:: #{__method__}"
  end

  protected
  def update_credentials
    login
    p "module: #{self.class.name}:: #{__method__}"
    _prepare_credentials
  end
end

# MODULES VS CLASSES
# a module is essentially paired with an include 
# the purpose of a module is therefore primarily to provide 
# a named grouping of defintions

# a class also groups defintions *but* in order to create objects 
# classes cannot be included

# classes are extended using inheritance 
# modules can be extended after defintion using the .extend method

module Mover
  def walk
    p "Walking"
  end
end

module Runner
  def run
    p "Running"
  end
end

Mover.extend(Runner)

include Mover
Mover::run

# ASIDE: confusingly...
Class is derived from Object
Module is derived from Class

#ie., a class is a kind of object 
#a module is a kind of class 


# INCLUDING MODULES (MIXINS)

# modules may be included within files OR within classes!

module Eater
  def eat
    p "Eating " + food() # resolved within calling-scope
  end
end

class Human
  include Eater

  def food
    "beef"
  end

  def talk
    p "Hi!"
  end
end

class Plant
  include Eater

  def food
    "minerals"
  end

  def bloom
    p "Blooming!"
  end
end

me = Human.new
orchid = Plant.new

me.eat
orchid.eat
me.talk


# PART 2 -- LIBRARIES

# LIBRARY

# the term 'library' just refers to a .rb file used to provide defintions
# typically bounded with a module

# REQUIRING LIBRARIES

# all equivalent
require './User'
require_relative 'User.rb'
require_relative 'User'



require 'mufile'

require './local'

require_relative 'myfile'


# also works however load is used primarily for running other files
# without the intention of importing their names
load 'asd.rb'

# explicitly
load 'test', wrap: true   # wrap: true  prevents name imports


# FINDING LIBRARIES
# array containing a list of directories searched
$LOAD_PATH << './mylibdir'
$: << './mylibdir'

# does not include the current directory by default
# or use RUBYLIB env var.

# LIBRARY DOCUMENTATION
# RDoc is bundled with the Ruby standard library
# A command-line program called rdoc
# With no parameters, generates documentation for Ruby and c files in the current directory
# See also rdoc --help

#uses begin/end style comments:

=begin
some documentation!
=end