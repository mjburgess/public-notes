# IDIOMS REVIEW
cart = ['cherries', 'lemonade', 'apples', 'apples']
prices = [5, 3, 4, 4]

people = {'Sherlock': 'Detective', 'Watson': 'Doctor'}

# LOOPING IDIOMS
for item in cart:
    print(item)

for item, price in zip(cart, prices):
    print(item, price)

for i, item in enumerate(cart):
    print(i, item)

for key in people:
    print(key)
    print(people[key])

for i in range(5):
    print(i)

for i in range(5):  # PYTHON3 -- forget xrange 
    print(i)

while True:
    line = input('Say? ')

    if line.startswith('q'):
        break

    print(line)

# DATA TYPE TRANSLATIONS 

basket = dict(list(zip(cart, prices)))
print(basket['cherries'])

item_set = list(set(cart))
for item in item_set:
    print(item)


''' OUTPUT (05.Collections/Demo05-02.8.Idioms.py):
cherries
lemonade
apples
apples
cherries 5
lemonade 3
apples 4
apples 4
0 cherries
1 lemonade
2 apples
3 apples
Sherlock
Detective
Watson
Doctor
0
1
2
3
4
0
1
2
3
4
Say? 5
cherries
lemonade
apples

'''
