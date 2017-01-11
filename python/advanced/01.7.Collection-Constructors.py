# 1.7.Collection-Constructors.py

#1. collection construction

#Q. what type of collections are there?
#A. many...

#Q. which are the basic built in ones?
#A. str, list, dict, tuple, set

#AIDE: there are many others in addition, what do you think a frozenset() is?

#Q. how do you create collections?
#A. with constructor functions or composer syntax (the technical names for each)

#eg. calling the str constructor *function*
print str(10)

#eg. using str composer *syntax*
print "10"
print '10'
print """10"""
print '''10'''
print r'10'

# while each composer syntax above has differnt characteristics 
# they each create the same string
# compare with different ways of creating the same integer, ten

print 10        # decimal 10
print 0xA        # hex A = decimal 10
print 010 + 2     # octal 10 + decimal 2 = decimal 8 + decimal 2


# ASIDE: the int constructor takes a radix (or base) argument

#Q. What is hexidecimal A in decimal?
#A. 10

print int('A', 16) - 1



# all the composers and constructors
lst = ["Eggs", "Milk", "Tea", "Sony A7S", "Zeiss 24-70mm"]

dct = {"name": "sherlock", "profession": "detective"}

tpl = ('Michael', 27)

string = "Michael"

st = {"Dan", "James", "David", "David", "David"}


# without arguments the constructors create empty values of that type

print list()
print dict()
print tuple()
print str()
print set()



#with arguments, constructor functions take their input and "turn them into" their types

#eg.
print list("Delta Place")   #Q. what type is the return value of list()?
                            #A. list ...of course! 
                            #A... a list of characters
                            

#nb., the conversion is,  list(string) -> [string[0], string[1]...]

#Q., so what is... 

print list("Michael")[0]  #A., 'M'


#in general,  list(sequence) -> [sequence[0], ...]

# Q. what is list() ? (ie. with no arguments?)
# A. [] -- the empty list


print str(1) * 2 # 11 - Q. why? A. * is repertition on strings


# some type examples of using constructor functions..

print tuple("Michael")

print str(['Mi', 'ke'])        #Q. what do you expect?
                            #.. perhaps ''.join(['Mi', 'ke'])    ?
                            # the str() constructor does not join!
                
# the dict constructor will accept a list of two-valued tuples (ie. pairs) 

#Q. what do you think it does with them?

#Q cont. what will the return type be?
#A. a dictionary


print dict([
    ('username', 'michael'),
    ('email', 'michael@qa')
])

#A. therefore the dict() constructor takes the 0th element of each pair as the keys
# .. and the 1th element as the value

# the formula is...
# dict([a, b, c]) -> {a[0]: a[1],  b[0]: b[1], ... }


#AISDE: zip()

#Q. what function "pairs-up" lists
#ie. what function, takes arguments a, b and makes [(a[0], b[0]), ...] ?
#A. zip

basket = ['eggs', 'milk']
prices = [1.8, 2.8]

print dict(zip(basket, prices))


# more on zip() later!



