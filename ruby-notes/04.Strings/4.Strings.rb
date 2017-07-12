# CHAPTER 4:  Strings

## WHY IS THIS IMPORTANT?: 
=begin
Why do we use complex string operations?
To format and analyse text. 
=end
## 

# STRINGS
# INTERPOLATION
# ENCODING
# CONCATENATION
# FORMATTING
# SLICING
# SPLIT, JOIN
# METHODS
# TESTS


# STRINGS
name = "Moriarty"

p name.class 
p name.methods.sort 


# simplest literal use of otherwise special characters
p %q(Text containing \, " and ' chars)

p 'Text containing \\, " and \' chars'

p "Text containing \\, \" and ' chars"

p %Q(Text containing \\, " and ' chars)


# INTERPOLATION 
full_name = "Professor #{name}" # double are interpolating

p full_name
p 'Professor #{name}'       # single are literal 

basket = ['bread', 'cheese', 'lemonade']
p "The last item in the basket is #{basket[-1].upcase}"


# ENCODING 
p "\u20ac"

p 'hello'.encoding 
p "\u20ac".encoding 

p 65.chr 
p '20ac'.hex
p 'A'.ord

# CONCATENATION

address = ""

p address.object_id 

address << "8 Walworth Road" << $/
address << "Southwark, London" << $/
address.concat "SE1 6EH"                # same as <<
address.prepend "Strata SE1\n"          # neither create a new object! 

p address
puts address

p address.object_id

# compare to,

name = 'Moriarty'
full_name = 'Prof. ' + name 

p name.object_id
p full_name.object_id

full_name += ', PhD'

p full_name.object_id
p full_name

# which creates a new object

# Q. which should you use in a loop?  A. <<  -- far more efficient


# FORMATTING

planets = { "Mercury" => 57.91,
            "Venus"   => 108.2,
            "Earth"   => 149.597870,
            "Mars"    => 227.94 }

planets.each_with_index do |(planet, distance), i|
  printf "%2d %-10s %06.2f Gm\n", i, planet, distance 
end

format = "%2d %-10s %06.2f Gm"

planets.each_with_index do |(planet, distance), i|
  puts format % [i, planet, distance]
end

puts "${name} is at ${distance}" % {name: 'Mars', distance: 227} 

# SLICING
quote = "be the change you wish to see in the world!"

p quote[0]
p quote[-1]

#the subscript operator can take more than one argument
# x[start-position, amount]
# x[start..end]
# and returns multiple chars 

p quote[0, 2]
p quote[-6, 6]

p quote[3..-7] + 'bank'
p 'hello ' + quote[-6..-1]

# a strange range 
p quote[2..-1]

# ASSIGNING TO A SLICE: RHS SLICES

quote[-6..-1] = 'room!'
p quote

# SPLITTING AND JOINIG
location = 'paris, france'
p location.split(',')[-1]

countries = ['france', 'england', 'scotland']
p countries.join 

p countries.join ', '

# METHODS 

p name.methods.sort 
''.methods.sort.select { |m| m.to_s.include? '!' }  # mutators 

p quote.each_byte.to_a
p quote.each_char.to_a

p '-' * 20 


# TESTS

p ''.methods.sort.select { |m| m.to_s.include? '?' }

pegasus_cluster = 'Cúmulo de Pegaso' 

p pegasus_cluster.ascii_only?		
p pegasus_cluster.count 'o'
p pegasus_cluster.empty?
p pegasus_cluster.end_with? 'so'
p pegasus_cluster.eql? 'Somewhere'
p pegasus_cluster.include? 'Peg'
p pegasus_cluster.start_with? 'Cúmulo'
p pegasus_cluster.valid_encoding?

person = "Sherlock is 35"
professon = 'detective'

p (person[-2..-1].to_i - 5)

profession_person = {
    detective: 'sherlock',
    doctor:  'watson'
}

p profession_person[:doctor]
p profession_person[professon.to_sym]


p profession.length
p profession.size       
p '  hello world   '.strip