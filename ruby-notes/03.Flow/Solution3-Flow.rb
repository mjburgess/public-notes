# CHAPTER:    Flow Control
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using boolean tests, determine whether you are going to a pub.
# PROBLEM:    Using if/elsif/else, display which pub was chosen.
# PROBLEM:    Using for and if, display selected pub information.
# TIME:       20 m


# PART 1 -- BOOLEAN TESTS
# PROBLEM: Using boolean tests, determine whether you are going to a pub.

# Q. define name, age, height, location for yourself
name = 'Sherlock'
age = 27
height = 1.81
location = 'London, UK'

# Q. for the following, print the question and the answer:
    p "# a) is the letter 'A' in your name?"
    p name.include? 'A'

    p "# b) are you an adult?"
    p age >= 18

    p "# c) are you an adult under retirement age?"
    p age >= 18 && age <= 65

    p "# d) is 'UK' in your location?"
    p location.include? 'UK'

    p "# e) are you over 1.8m tall?"
    p height >= 1.8

    p "# f) are you an adult and in the UK?"
    p age >= 18 && location.include?('UK')



bar_distance = 100
bar_crowd = 50
bar_beer = 5

# Q. using the above variables,
#... define is_busy, is_far, is_cheap:
    #... the bar is busy if there's more than 25 people present
    #... the bar is close if it is less than 500m away
    #... the bar is cheap if beer is less than 3.50

is_busy  = bar_crowd > 25
is_far   = bar_distance >= 500
is_cheap = bar_beer < 3.50


# Q. if the bar is near and not busy and cheap
#... print "GOING TO BAR"
#... otherwise print "NOT GOING TO BAR"

if !is_far && !is_busy && is_cheap
  p "GOING TO BAR"
else
  p "NOT GOING TO BAR"
end

# Q. if the bar is busy and near OR cheap
#... print "It'll do"
#... otherwise print "Nope, wont do!"

if is_busy && (!is_far || is_cheap)      # or, (is_busy && !is_near) || is_cheap)
  p "It'll do"                            # Q. which should it be?
else
  p "Nope, won't do!"
end


# PART 2 -- ELSIF
# PROBLEM:  Using if/elsif/else display which pub was chosen.
option = ['PubA', 'PubB', 'PubC', 'PubD'].sample

# Q. if the option is 'PubA' print 'Chose A',
#... and so on for B, C, D ...

if option == 'PubA'
  p 'Chose A'
elsif option == 'PubB'
  p 'Chose B'
elsif option == 'PubC'
  p 'Chose C'
else
  p 'Chose D'
end

# Q. Can you rephrase this to use one puts operation?


puts (if option == 'PubA'
  'Chose A'
elsif option == 'PubB'
  'Chose B'
elsif option == 'PubC'
  'Chose C'
else
  'Chose D'
end)

# EXTRA:
# Can you rephrase this to use a hash?
# HINT: knowing the option, you need a string to print 

messages = {
    'PubA' => 'Chose A',
    'PubB' => 'Chose B',
    'PubC' => 'Chose C',
    'PubD' => 'Chose D'
}

p messages[option]


# PART 3 -- FOR IF
# PROBLEM:  Using for and if display selected pub information.

# Q. modify the following loop to print the pub names
#... that begin with an 'f'
names = ["Finnegan's Wake", "The Horse and Boot", "Forgotten Tales"]
for name in names
   if name[0] == 'F'
      p name
   end
end 

# Q. modify the following loop to print the pubs > 150 years old
pubs = { finnegan: 130, horse: 185, forgotten: 140 }
for name, age in pubs
    if age > 150
      p name, age
    end
end 

## REVIEW: What did we learn from this exercise?