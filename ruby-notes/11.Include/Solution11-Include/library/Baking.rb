# CHAPTER:    Include
# OBJECTIVE:  Complete the following questions.
# PROBLEM:    Require and include a module for baking cakes.
# TIME:       20 m

# STEP 1 -- Baking.rb

# Q. create a folder called library
# Q. save this file as library/Baking.rb

# Q. add an rdoc comment to this file (Baking)
=begin
    This is a solution to Exercise 11 -- Include. 
=end
module Baking
  FLOUR = 100
  SUGAR = 100

  def mix(flour, sugar)
    puts
    print 'Mixing ', flour + sugar, 'g mixture'
  end
end



# STEP 3 -- Kitchin Mixin

# Q. in Baking.rb, define a class Kitchen which includes Baking
# Q. in the Kitchen class define a prepare method which calls mix with 200, 200

class Kitchen
  include Baking

  def prepare
    puts
    mix(200, 200)
  end
end

## REVIEW: What did we learn from this exercise?