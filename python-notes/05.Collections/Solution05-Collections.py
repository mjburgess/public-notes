# CHAPTER:    Collections
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using lists and dictionaries, keep track of a shopping basket.
# TIME:       20 m

# Q. create three dictionaries called item_ham, item_bacon, item_cheese
# ... each dictionary should have 'name', 'price' and 'weight' key
item_ham = {
    'name': 'Cured Ham',
    'price': 3.50,
    'weight': 200
}

item_bacon = {
    'name': 'Smoked Bacon',
    'price': 3.50,
    'weight': 200
}

item_cheese = {
    'name': 'Cured Ham',
    'price': 3.50,
    'weight': 200
}

# Q. using a for-loop, print out all of ham's details
# in the form 'name = ...' 
for key in item_ham:
    print(key, '=', item_ham[key])

# Q. create a list called store which contains all the items 
# HINT: each element in the list should be 
# item_ham, item_bacon, item_cheese respectively

store = [item_ham, item_bacon, item_cheese]

# Q. print out every item in store
# HINT: for every item, run the above for loop 
# ie., place the above for loop inside a loop over store
for item in store:
    print()
    for key in item:
        print(key, '=', item[key])

# Q. we now have a store we can populate customers baskets from
# ... create an empty array called basket to hold one customer's shopping
basket = []

# Q. append a few items defined above to the basket 
# HINT: .append 
basket.append(item_bacon)
basket.append(item_cheese)

# Q. print out every item in the basket 
# HINT: copy the above loop for the store, now with basket 
for item in basket:
    print()
    for key in item:
        print(key, '=', item[key])

# Q. remove the last item,
# and print "Removing... " with its name 
print('Removing...', basket.pop())

# EXTRA
# Q. now ask the user to add items to the basket. 
# ... loop over store
# ... ask the user if they would like to add one of the items

# HINT: input & accept Y or N as input,
# ....   if Y append the item on to basket
for item in store:
    response = input('Would you like to add {0[name]} to the store?'.format(item))

    if response.lower().startswith('Y'):
        basket.append(item)

    if response == 'DONE':
        break

    # Q. now display their basket
print('In your basket...')
for item in basket:
    print()
    for key in item:
        print(key, item[key])

# using the data collections above, print the answer to these questions:
# Q. print the total cost of the user's basket
total = 0
for item in basket:
    total += item['price']

print(total)

# Q. print the average price of an item at the store
average = total / len(basket)

# Q. using a slice, print the last two items the user purchased?
# HINT: ie., from the second-to-last element to the end 
print(basket[-2:])

""" REVIEW

What did we learn from this exercise?

looping over a dictionary gives you the keys 
looping over a list gives you the elements 

empty sets created with set()

append lists
add sets 

- set differece

slices 

"""


''' OUTPUT (05.Collections/Solution05-Collections.py):
price = 3.5
name = Cured Ham
weight = 200

price = 3.5
name = Cured Ham
weight = 200

price = 3.5
name = Smoked Bacon
weight = 200

price = 3.5
name = Cured Ham
weight = 200

price = 3.5
name = Smoked Bacon
weight = 200

price = 3.5
name = Cured Ham
weight = 200
Removing... {'price': 3.5, 'name': 'Cured Ham', 'weight': 200}
Would you like to add Cured Ham to the store?Would you like to add Smoked Bacon to the store?Would you like to add Cured Ham to the store?In your basket...

price 3.5
name Smoked Bacon
weight 200
3.5
[{'price': 3.5, 'name': 'Smoked Bacon', 'weight': 200}]

'''
