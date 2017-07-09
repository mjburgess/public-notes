# CHAPTER:    Include
# OBJECTIVE:  Complete the following questions.
# PROBLEM:    Require and include a module for baking cakes.
# TIME:       20 m

# STEP 2 -- main.rb 
# Q. create a new file called main.rb in the parent folder

# Q. in main.rb, require this library (Baking.rb)
require_relative 'library/Baking'           # OR, require './library/Baking.rb'


# Q. in main.rb, call the mix() function
#... pass FLOUR and SUGAR as arguments
# HINT: you'll need to include Baking
include Baking
Baking.mix(Baking::FLOUR, Baking::SUGAR)



# STEP 3 -- Kitchin Mixin

# Q. in main.rb, ask a Kitchen to prepare
myk = Kitchen.new
myk.prepare

# OR, just 
Kitchen.new.prepare


## REVIEW: What did we learn from this exercise?