# TUPLES

""" NOVICE ASIDE:

Why do we use tuples?

To represent single objects with several parts,

person = ('Sherlock', 30)

OR 

To represent groups of data which will never change. 
"""

x = 10
y = 20

x, y = y, x

sherlock = ('Sherlock', 30, ('London', 'UK'))

(name, age, (city, country)) = sherlock

x = 10,

print('this', 'is', 'a', 'test')

message = 'this', 'is', 'a', 'test'

print(message)


''' OUTPUT (05.Collections/Demo05-02.5.Tuples.py):
this is a test
('this', 'is', 'a', 'test')

'''
