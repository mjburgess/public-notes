# CHAPTER:    Multitasking
# OBJECTIVE:  Complete the following questions.
# PROBLEM:    Using the multitasking features of ruby, create a utility script.
# TIME:       20 m

# QUESTIONS

# PART 1 -- BLOCKING
# this is a utility script designed to be used from the command line 

# ARGV[1] is the first command line argument passed to this file
# try running this file passing message as the first command line argument 
# ie., ruby Exercise13-Multitasking.rb message 

case ARGV[1]
  when "message"
    loop {
      puts "Hello World!"
      sleep 1
    }
  else
    # Q. modify the following
    #... so that running this file with no argument prints "Hello World!"
    #... HINT: where does message go?

    system "#{RbConfig.ruby} #{__FILE__} "
end


# Q. trap the CTRL+C signal (INT)
#... exit with the message "...quitting"

# Q. add a condition above,
#... when ARGV[1] is 'll'
#... use a pipe to print the result of either
# UNIX (Lnx, Mac):      ls -lrt
# WINDOWS        :      dir 

# Q. using the commandline test
#... the message and ll options


# PART 2 -- NON-BLOCKING

# Q. create a new folder and add three files to it:
#... boilwater.rb, grindbeans.rb and prepcup.rb 
#... each file should contain:

puts "\nstarting: #{__FILE__}\n"; sleep 2; puts "\nfinished: #{__FILE__}\n"


# Q. create a new file

## REVIEW: What did we learn from this exercise?