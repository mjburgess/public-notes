# CHAPTER 6:  Iteration

## WHY IS THIS IMPORTANT?: 
## 
## 

# BLOCKS REFRESH
# YIELDING WITH BLOCKS 

# BLOCKS REFRESH
name = begin 
    first = "John"
    second = "Watson"
    first + ' ' + second
end                         # this isnt a scope...

p name          # the last line of a block is its value 


names = ['Sherlock', 'Holmes'].map do |name|                # blocks can recieve values
    name.upcase
end

p names

# BLOCKS IN DETAIL 


# blocks can be passed to iterators 
# (ruby definintion: method that can recieve a block)

def recieve_block
    p 'Error: ' + yield
end 


recieve_block { 'Message' }

recieve_block do 
    first_name = 'Sherlock'
    last_name = 'Holmes'
    first_name + ' ' + last_name
end 


def recieve_block_arg
    p 'Error: ' + yield(2)
end 

recieve_block_arg { |times| 'Message ' * times }

#ASIDE: blocks can be passed as arguments (get promoted to a Proc) -- a block is syntax, like an if statement 

def run_last_argument(message, &formatter) 
    p formatter.class                       # Proc 
    p formatter.call(message)
end 

run_last_argument('Hello') { |m| m.upcase }

#...more on this later...

# LOOP 

loop  do
    puts "Hello"
    break
end


loop {
    puts "Hello"
    break
}



iter1 = %w[one two three four].each
iter2 = (1..4).each

loop do
  puts iter1.next
  puts iter2.next
end 


# LOOP CONTROL 
x = 0
loop {
  x += 1
  break if x > 8
  puts x
}

x = 0
loop do
  x += 1
  next if x > 8         # CONTINUE
  puts x
end

# WHILE LOOPS  
line = ""

while line != 'done'
  print 'Type "done" to complete: '
  line = gets.chomp
  puts "<#{line}>"
end
begin
  print '(2) Type "done" to complete: '
  line = gets.chomp
  puts "<#{line}>"
end while line != 'done'

line = ""

until line == 'done'
  print 'Type "done" to complete: '
  line = gets.chomp
  puts "<#{line}>"
end

begin p 1; sleep 1 end while true

num = 0
puts "#{num += 1}" while num < 3

num = 6
puts "#{num -= 1}" until num < 3


# ITERATION: FOR LOOPS  

for cname in ["Bill Brewer","Jan Stewart","Peter Gurney"] do
  initial = cname[0]
  surname = cname[cname.index(' ')..-1]
  puts "#{initial}.#{surname}"
end

# ITERATION: ITERATOR METHODS 
["Bill Brewer","Jan Stewart","Peter Gurney"].each do |cname|
  initial = cname[0]
  surname = cname[cname.index(' ')..-1]
  puts "#{initial}.#{surname}"
end


5.times {
    puts "Hello"
}

1.upto(5) {
    puts "GoodBye"
}


0.step(50, 5) {
    puts "NOthing!"
}


0.step(50, 5) {
    | number |

    puts number
}


10.downto(0) do | number | puts number end

"the basket came to $1000 $2000".scan(/\d+/) { | n |
    p n
}

require 'date'

Date.today.step(Date.today + 6){ | day |  
  p Date::DAYNAMES[day.wday] 
}


# ITERATION: ENUMERABLE METHODS 


a = [2, 1, 2, 3]
p a.reduce(0) {|sum, item| sum + item}      # or inject


p ['cherries', 'lemoade'].map.with_index { |v, i| "#{i}: #{v}" }

alphas =  %w(alpha bravo charlie delta echo foxtrot golf  
          hotel india juliet kilo lima mike november
          oscar papa quebec romeo sierra tango uniform
          victor whisky xray yankee zulu) 
codes = alphas.map {|word| [word[0].upcase, "#{word} "]}

c = %w(Australia Eire France Finland UK US)
r = c.grep(/[A-Z]i/)

c = %w(Australia Eire France Finland UK US)
r = c.grep(/[A-Z]i/) {|c| capitals[c]}


# ASIDE: .lazy 
# lazy on any enumerator creates an Enumerator::Lazy object
# Applied to the end of the block
