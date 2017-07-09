# CHAPTER:    Include
# OBJECTIVE:  Complete the following questions.
# PROBLEM:    Require and include a module for baking cakes.
# TIME:       20 m

# QUESTIONS


# STEP 1 -- Baking.rb

# Q. create a folder called library

# Q. save this file as library/Baking.rb

# Q. add an rdoc comment to this file

module Baking
  FLOUR = 100
  SUGAR = 100

  def mix(flour, sugar)
      print 'Mixing', flour + sugar, 'g mixture'
  end
end




# STEP 2 -- main.rb 

# Q. create a new file called main.rb in the parent folder

# Q. in main.rb, require this library (Baking.rb)

# Q. in main.rb, call the mix() function
#... pass FLOUR and SUGAR as arguments
# HINT: you'll need to include Baking




# STEP 3 -- Kitchin Mixin

# Q. in Baking.rb, define a class Kitchen which includes Baking

# Q. in the Kitchen class define a prepare method which calls mix with 200, 200

# Q. in main.rb, ask a Kitchen to prepare

## REVIEW: What did we learn from this exercise?