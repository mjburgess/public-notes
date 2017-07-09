# CHAPTER:    Multitasking
# OBJECTIVE:  Complete the following questions.
# PROBLEM:    Using the multitasking features of ruby, create a utility script.
# TIME:       20 m

# QUESTIONS

case ARGV[0]
  when "message"
    loop {
      puts "Hello World!"
      sleep 1
    }

  when "ll"
    IO.popen(["ls", "-lrt"]).each { |line| puts line }

  when "spawn"
    spawn(RbConfig.ruby, "./#{__FILE__} ls")
    spawn(RbConfig.ruby, "./#{__FILE__} message")

  else
    # Q. modify the following
    #... so that running this file prints "Hello World!"
    #... HINT: where does message go?

    system "#{RbConfig.ruby} #{__FILE__} message"
end



# Q. trap the CTRL+C signal (INT)
#... exit with the message "...quitting"
Signal.trap("INT") {
  abort "...quitting"
}



# Q. add a condition above,
# when ARGV[1] is 'll' use a pipe to print the result of ls -lrt

# Q. add a condition above,
# when ARGV[1] is 'spawn'
# run this script asynchronously (once each for ls and message)

# Q. using the commandline test the message, ls and spawn options

## REVIEW: What did we learn from this exercise?