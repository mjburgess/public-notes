# CHAPTER:    Collections
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using arrays and hashes, keep track of a shopping basket.
# TIME:       30 m


# QUESTIONS

# Q. create three hashes called ham, bacon, cheese
#... each hash should have a name, price and weight key

# Q. use a for loop to print out all of ham's details
#... ie. the name, price and weight

# Q. create an array called store
#... which contains the ham, bacon and cheese hashes


# Q. we now have a store we can populate customers baskets from
#... create an empty array called basket to hold one customer's shopping

# Q. now ask which items to put in it
#... loop over store
#... ask the user if they would like to add one of the items to their basket
# HINT: gets.chomp & accept Y or N as input, if Y push the item on to basket

# Q. now display their basket
#... providing all the info about their items


# Q. using all the data collections above, print the answer to these questions:
# a) what is the total cost of the user's basket?
# b) what is the average price of an item at the store?
# c) what were the last two items the user purchased?
  # HINT: use a slice

# Q. what items in the store did the user not purchase?


# EXTRA
# Q. revise the defintion of basket
#... so that a modification to basket[0] does not affect cart
cart = [
    ['Bread', 2.54],
    ['Milk', 2.33],
    ['Cheese', 3.45]
]

basket = cart
basket[0] = ['Fruit', 4.55]

p basket
p cart

basket[0][1] = 3.54     #ie., so this does not affect cart

p basket
p cart



## REVIEW: What did we learn from this exercise?
