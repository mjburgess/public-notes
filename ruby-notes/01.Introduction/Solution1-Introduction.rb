# CHAPTER:    INTRODUCTIONS
# OBJECTIVE:  Run ruby code from the command line, repl and explore the Dir module.
# PROBLEM:    
# TIME:       20 m

# INTRODUCTION TO EXERCISES 

# most questions are solved by writing code in the file
# and then running the file
# solutions are provided --
# you can have a look at these if you get stuck
# however its best to try on your own
# and wait until the instructor solves the exercise

# before you start an exercise,
# save a copy to *your home folder*
# to keep track of your own solutions

# INTRODUCTION TO SOLUTIONS

# almost every question
# can be answered correctly in multiple ways
# sometimes more than one of the major ways is provided ("OR")
# 'etc.' is sometimes used to indicate
# that you will likely have answered differently

# QUESTIONS

# Q. from the command line,
#... determine which version of ruby is being used.

# ruby --version

# Q. from irb,
#... determine which version of ruby is being used.

RUBY_VERSION

# Q. define two variables one for your first name
#... and another for your last name.

first = "Sherlock"
last = "Homles"

#OR,
first, last = "Sherlock", "Holmes"

# Q. display them using print with a space between each one.
print first + ' ' + last  #, OR,
print "#{first} #{last}"  #, OR

print first
print ' '
print last

#etc.

# Q. run this script from the command-line
# ruby Solution1-Introduction.rb


# EXTRA

# The ruby standard library has a object called Dir.
# Dir provides information
# and access to directory-related operating system commands.

# Q. Use the Dir.entries function to list
#... the contents of the present working directory.
# HINT: '.' is the current directory

Dir.entires('.')  # parens are optional


# Q. Use the Dir.chdir function to change
#... the present working directory to your home folder.
Dir.chdir('/home/qa')

# Q. Use the Dir.entries function to list
#... the contents of the present working directory.

Dir.entires('.')


## REVIEW: What did we learn from this exercise?
