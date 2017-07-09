# CHAPTER 10: Errors

## WHY IS THIS IMPORTANT?: 
## 
## 

# PART 1 -- HANDLING ERRORS


# STOPPING TERMINATION

abort("hard exit")    # exit with message

exit                  # without a message

# EXCEPTION SYNTAX
begin
  fh = open('not-there.txt')
rescue SystemCallError => err
  STDERR.puts "ERROR: #{err}"
else
  puts "file opened OK"
ensure
  fh.close if fh
end


# MULTIPLE CONDITIONS
def cat(filename)
  begin
    fh = open(filename)
    fh.each { |line| puts line.chomp }

  rescue SystemCallError, IOError => err
    STDERR.puts err

  rescue TypeError => err
    STDERR.puts filename, err

  ensure
    fh.close if fh
  end
end



['not-there.txt', 42].each {
    |fname| cat(fname)
}


# ELSE, ENSURE, RETRY 
def print_array(arg)
  arg.each {|x| puts x}
end

def method_A
  begin
    print_array(42)
  ensure
    STDERR.puts "1. ensuring within A"
  end
end

begin
  method_A
rescue NoMethodError => err   # each not defined on 42
  STDERR.puts "2. error over A", err
ensure
  STDERR.puts "3. ensuring over A"
end

puts "4. done"


# RAISING ERRORS
def printlazy(arg)
  if not arg.respond_to?(:lazy)
    raise ArgumentError, "lazy is required"
  end
end

begin
  printlazy(42)
rescue ArgumentError => err
  STDERR.puts err
end



# PART 2 -- CUSTOM ERRORS

# CUSTOM EXCEPTIONS 
class MyError < RuntimeError; end

def trysomething
  raise MyError, "Didnt work!"
end


trysomething


# CATCH AND THROW
def collect_input(input)
  print "input? "
  var = gets.chomp

  if var.empty?
    throw :enough_already
  else
    input << var
  end
end

data = []
catch :enough_already do
  loop { collect_input data }
end


p data



