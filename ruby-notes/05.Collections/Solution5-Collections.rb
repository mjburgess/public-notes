# CHAPTER:    Collections
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using arrays and hashes, keep track of a shopping basket.
# TIME:       30 m


# QUESTIONS

# Q. create three hashes called ham, bacon, cheese
#... each hash should have a name, price and weight key
ham = {
    name: "Cured Ham",
    price: 3.51,
    weight: 100
}

bacon = {
    name: "Smoked Bacon",
    price: 3.51,
    weight: 100
}

cheese = {
    name: "Cheddar Cheese",
    price: 3.51,
    weight: 100
}

# Q. use a for loop to print out all of ham's details
#... ie. the name, price and weight
for key, value in ham:
  print key
  print ' = '
  print value
end

# OR,
puts ham[:name], ham[:price], ham[:weight]  #etc.

# Q. create an array called store
#... which contains the ham, bacon and cheese hashes
store = [ham, bacon, cheese]

# Q. we now have a store we can populate customers baskets from
#... create an empty array called basket to hold one customer's shopping
basket = []

# Q. now ask which items to put in it
#... loop over store
#... ask the user if they would like to add one of the items to their basket
# HINT: gets.chomp & accept Y or N as input, if Y push the item on to basket
for item in store
  puts "Would you like to add #{item[:name]} (Y|N)? "
  if gets.chomp.upcase.start_with? 'Y'      # OR, == 'Y', etc. -- Q. why use this test?
    basket << item
  end
end

# Q. now display their basket
#... providing all the info about their items
for item in basket
  puts item[:name], item[:price], item[:weight]   # etc.
end

# Q. using all the data collections above, print the answer to these questions:
# a) what is the total cost of the user's basket?
total = 0
for item in basket
  total += item[:price]
end

#, OR, using combinators,
total = basket.map { |i| i[:price] }.reduce(:+)


# b) what is the average price of an item at the store?
average = total / basket.size

# c) what were the last two items the user purchased?
  # HINT: use a slice
last_two = basket[-2..-1]

# Q. what items in the store did the user not purchase?
remainder = store - basket

p total
p average
p last_two
p remainder

# EXTRA
# Q. revise the defintion of basket
#... so that a modification to basket[0] does not affect cart

cart = [
    ['Bread', 2.54],
    ['Milk', 2.33],
    ['Cheese', 3.45]
]

basket = cart.dup
basket[0] = ['Fruit', 4.55]

p basket 
p cart

basket[0][1] = 3.54     #ie., so this does not affect cart

p basket
p cart



## REVIEW: What did we learn from this exercise?
