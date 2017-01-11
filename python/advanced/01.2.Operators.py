# 1.2.Operators.py

#1. operators as symbols

# the term 'operator' isn't very well defined
# in python it typically means a "special symbol which works like a function but isn't called like one"

# we could have an add(x, y) funciton... or, just use the plus (+) symbol

#Q. what is the meaning of the plus-symbol here?
print 3 + 4    #A. addition

#Q. what is the meaning here?
print '3' + '4'    #A. concatenation

#nb., Distinguishing between the name of the symbol (plus) 
# and it's meaning (addition, concatenation) highlights that while one symbol is used in both cases
# it's job changes (the general name for this is polymorphism)


print type(3 + 4)    #Q. type?  

print type('3' + '4') #Q. type? 


# ** is "raise to the power"

print 8 ** 3


user_age = '18'

#Q. how do you add 1 to the string 18?
#A. convert it to an integer first
print int(user_age) + 1        

#Q. what does the * (star) operator do on numbers? 
#A. multiplication

print str(10) * 10 #Q. what does it do to strings?


#2. precedence

print 3 * 10 + 4 * 5 - 3 * 2  #Q. how does this group?

print (3 * 10) + (4 * 5) - (3 * 3)  #.. OR

print 3 * (10 + 4) * (5 - 3) * 3  #.. ?


#A. it comes down to which operator has higher precedence
#A. operators with higher precedence are eval'd first or "bind their arguments more tightly"
#A. BODMAS = Div then Mul then Add then Sub 
#A. so * binds more tightly than + and -


print 3*10         +         4*5         -         3*2  

#        30        +        20                    6
#        30+20                        -        6
#        50                            -        6
#=    44



#3. gotchas

# / on ints is integer division
print 9 / 2

# / on floats is floating-point division
print 9.0 / 2

#Q. What's the difference?


# a leading 0 implies base-8 (ie. octal)

#Q. What is 8 in base 8?
#A. 10

print 010 ** 3 # therefore, Q. what's printed?
