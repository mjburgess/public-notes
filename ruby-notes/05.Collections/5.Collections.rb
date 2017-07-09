# CHAPTER 5:  Collections

## WHY IS THIS IMPORTANT?: 
## 
## 


# OVERVIEW: ARRAY vs. HASH

# collection types: strings, hashes, arrays, ranges, sets.. 

# arrays and hashes are both types of collections or groupings of data 
# arrays typically represent plurals (many people, many pets, etc.)

pets = ['Fido', 'Spot', 'Fluffy']

# hashes represent relationships, which can be plural "many peoples pets":

peoples_pets = {
    'sherlock' => 'fido',
    'watson'   => 'spot',
    'irene'    => 'fluffy'
}

# or they can represent a single datum with many properties

person = {
    'name' => 'sherlock',
    'pet'  => 'fido',
    'location' => 'london'
}


# in each case a hash allows you to 'lookup the X for Y'
# eg., lookup the NAME of that PERSON... lookup the PET for SHERLOCK

p person['name']
p peoples_pets['sherlock']

# whereas an array just groups in sequence:

p pets[0]
p pets[1]
p pets[-1]
p pets[-2]


# ARRAYS 

#may be hetrogenous
house_numbers = [30, '32', nil]


# each element has two indices
basket = ["Cherries", "Lemonade", "Eggs"]

puts basket[0]
puts basket[-1]
puts basket[-3]


basket.push("Ham")
p basket

# build up an array
new_basket = []
new_basket << "milk"        # add to the end (.push)
new_basket << "water"
new_basket << "pineapple"
p new_basket

# new array by adding arrays
total_basket = new_basket + basket
p total_basket

# or, 
total_basket.concat(basket)
p total_basket

# or, 

total_basket += basket
p total_basket

# new array from constructor 
row = Array.new(5, '.')
p row 
p row.join ' '

# create an array of string literals 
pets = %w(fido spot fluffy)

p pets


# SLICING
cart = %w(lemonade cherries cake tea coffee cherries milk)
p cart 
p cart[-4]

#the subscript operator can take more than one argument
# x[start-position, amount]
# x[start..end]
# and returns multiple chars 

p cart[0, 2]
p cart[-6, 6]

p cart[3..-7] 
p cart[-6..-1]

# a strange range 
p cart[2..-1]


# ASSINING TO A SLICE

cart[-2, 2] = ['berries', 'cream']
p cart

# ADDING AND REMOVING ELEMENTS

chores = ['cleaning', 'cooking']

p chores.shift 'baking' # add at beggining
p chores 

p chores.unshift        # remove from beggining
p chores

p chores.push 'cleaning' # add at end
p chores 

p chores.pop            # remove from end
p chores 

# and multiple..
p chores.pop(2)
p chores.push('wining', 'dinning')
p chores

# removing a known element, or known position

chores.delete 'cleaning' 
p chores 

chores.delete_at 1
p chores 

# syntax..
chores *= 3
chores << 'washing'
chores += ['driving', 'styling']

# SORTING 
nums = %w(34 2 123 9 1000)
puts "#{nums.sort}"
puts "#{nums.sort{ |a, b| a.to_i <=> b.to_i}}"


names = %w(cheddar Cheshire Yarg Stilton)
names.sort
names.sort{ |a, b| a.upcase <=> b.upcase}

# SET OPERATIONS 
people = %w(fred wilma sherlock watson vlad moriarty)
bad_people = %w(vlad moriarty imhotep)

p people - bad_people   # people without bad_people
p people | bad_people   # union (or concat)
p people & bad_people   # intersection (in both)

# ASIDE: SETS
require 'set'
p Set.new(people) ^ bad_people  # sym. diff: unique in both , requires Set 
                                # (a - b) | (b - a)

# other key methods: add, merge, delete, to_a 

cart = Set.new
cart.add('milk')
cart.add('milk')
cart.add('bread')

p cart 
# ARRAY METHODS 

names = ["Michael", "Adam", "Alex"]

puts names.include? "Adam"


puts names.first
puts names.first 2

puts names.last

cheese = %w[Cheddar Cheshire Stilton Cheshire]

puts cheese.count 'Cheshire'
puts cheese.count {|val| val[0] == 'C'}

puts cheese.index 'Cheshire'
cheese.index {|val| val[0] != 'C'}

cheese.reverse!
p cheese 

# HASHES


person = {
	name: "Michael",
	location: "UK",
	numEyes: 2,
}

building = {
	name: "The Shard",
	location: "London"
}

p person[:name]
p building[:location]


locations = Hash.new('unknown location')
puts 'Dracula lives at ' + locations['dracula']


food_type = Hash['Tomato', 'Vegetable', 'Orange', 'Fruit']  # k, v, k, v...
p food_type['Tomato']



ca = { :Australia=>'Canberra', :Japan=>'Tokyo', :US=>'New York'}
ce = { Eire: 'Dublin', France: 'Paris', UK: 'London', Finland: 'Helsinki', US: 'Washington'}
     
ca.merge!(ce)

p ca.length
p ca.join ' '


capitals = {'Australia' => 'Canberra', 
            'Eire' => 'Dublin',
            'UK'  =>  'London', 
            'US' =>   'Washington'}
          
# HASH ACCESS
myhash.fetch('Reykjavik', 'Where?')
myhash.fetch('Reykjavik')


p capitals.keys
p capitals.values


if capitals.key? 'Iceland'
    puts "Iceland is here"
end
if capitals.value? 'Reykjavik'
    puts "Reykjavik is here"
end


# BLOCKS

name = begin 
    first = "John"
    second = "Watson"
    first + ' ' + second
end                         # this isnt a scope...

p name          # the last line of a block is its value 


names = ['Sherlock', 'Holmes'].map do |name|                # blocks can recieve values
    name.upcase
end                                                         # this recieves values from map 

p names


p ['Sherlock', 'Holmes'].map { |name| name.upcase }     # blocks can use braces


# BLOCKS: ARRAY CONSTRUCTOR 
attendees = Array.new(42) { 'unknown' }
puts attendees
nums = Array.new(6) { |i| 'x' * i }
puts nums
nums = Array.new(6) do |i| 
  'x' * i 
end
puts nums

# BLOCKS: HASH CONSTRUCTOR 

file_sizes = Hash.new { |hash, key| hash[key] = File.size(key) }
file_sizes['5.Collections.rb']
file_sizes['1.Introduction.rb']
puts file_sizes

file_sizes = Hash.new
Dir.glob('*.rb').each { |fname| file_sizes[fname] = File.size(fname) }
puts file_sizes


# RANGES

range = 0..10
LEFT, RIGHT, UP, DOWN = *0..3

p range
p range.methods.sort

p LEFT 
p RIGHT

if range.include? 5 
    p '5 is in the range'
end 

p (0..10).take 2
p range.drop 3

(0..10).each { | number |
    puts number ** 2
}





# FOR LOOPS

for n in ['fido', 'spot', 'fluffy']
  p n
end

for k, v in { uk: 'London', fr: 'Paris'}
  p k, v
end

for i in 10..20
  p i
end