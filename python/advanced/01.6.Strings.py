# 1.6.Strings.py

import sys

#0. the print statement (or function)

# compare the following uses of the print statement with the function calls which follow

#Q. what does the comma do in between arguments?
#Q. what does the comma do at the end of the print statement?
#Q. what does the >> operator do?

print "michael"
print "michael", "burgess"
print "hello",
print "world"
print >> sys.stderr, "Hello World!"


sys.stdout.write("michael" + "\n")
sys.stdout.write("michael" + " " + "burgess" + "\n")
sys.stdout.write("hello" + " ")
sys.stdout.write("world" + "\n")

sys.stderr.write("Hello World!" + "\n")


#A. the comma instructs the print statement to join the arguments with a space
#A. at the end of the print statement the comma supresses the final \n usually output
#A. the >> operator redirects the print output to a different file object
 

""" PYTHON3...
# in python3 the print statement is a function
# the print function -- the joining separator, terminator, and file are more easily customised:

print("logging", "message")
print("logging", "message", sep=' ', end='\n', flush=False, file=sys.stdout)    # equivalent to the above

import sys
print("logging", "message", sep=':', end='\nDONE\n', flush=True, file=sys.stderr) #writes to stderr
"""


#1. strings

print "\nHello\n\tIndented"
print r"C:\new\table"
print "C:\new\table"

print '\nHello\n\tIndented' 

print "there's no difference between single and double quotes"
print 'excpet... "it is easier to use the other kind inside" '

# multiline

blog_page = """
TITLE:
I like programming

BODY:
Programming in python is fun!
"""

print blog_page

print '''
again, no difference with single quotes
in fact, it's easy to use aprostrophies and "quotes"
inside both kinds of triple-quoted strings 
'''


#the r-modifier denotes a "raw string", 
#one in which escape characters (eg. \n) are not substituted


#the u-modifier creates unicode strings

# print u'\N{euro sign}' # -- will not work with cmd.exe (try IDLE or Linux)

print u'\u0041' # prints 'A'

#Q. how do you move from a list of strings to a single string?
#A. join

names = ["sherlock", "mycroft", "watson"]

csv = ', '.join(names)

print csv


    
#Q. why is the following a bad idea?

out = ''

for name in names:
    out += name
    

#A. strings are immutable, string concatenation (+) creates new ones!
#... so this is very memory inefficient!


#Q. how do you move from a string to a list of strings?
#A. split

first_split = 'username:michael,email:michael.burgess@qa.com'.split(',')
print first_split

second_split = first_split[0].split(':')
print second_split[1]    #Q. Why does this print michael? 
                    
                    
print csv
print csv.split(', ')[-2]


#Q. what does the star operator (*) do to a string? 

print  '-'  * 20
 
#A. repeates it !


#2. string slicing
quote = "be the change you wish to see in the world!"

#Q. what does the subscript operator do?
#A. looks up an element at a given index
print quote[0]
print quote[-1]


#the subscript operator can take more than one argument
# x[start-position:end-position]
# and returns multiple elements if need

print quote[0:2]    #Q. what does this return?

#nb., this is called slicing


#slicing from the start until the -6th position...
print quote[0:-6] + 'universe'


#omitting the first argument implies the start (ie. a 0)...
print quote[:-6] + 'room'

print quote[:7] + 'best'

#ommitting the last argument implies the end
print 'i hate ' + quote[2:]


#there is a third argument...
#Q. what do you think this does?

print quote[::-1]

#A. reverses the string

#nb., the third argument defines the "movement" of the slice
# -1 = backwards one element at a time
# -2 = backwards two elements at a time



#ASIDE: ...

#Q. what does this do?
print quote[:]

#A. returns the entire string




#Q. why is the following True?
print quote[:] is quote

#A. all references to the same string are identical



#3. string methods

text = 'hello world'

print text.count('o')

if text.startswith('hell'):
    print "It begins with hell"

if text.isalpha():
    print 'every char is alphabetical'

white_text = ' \t\r\n'
if white_text.isspace():
    print 'this string is just whitespace'


print text.upper()
print text.lower()


# strings are immutable (they chanot change)

#... therefore .replace returns a new string
new_text = text.replace('hello', 'goodbye')

print text        #text is unchanged
print new_text  



# string formatting python 2.7+, 3 

#format a string by position, each {} is an argument in turn
"{} {} is a {}".format("sherlock", "holmes", "detective")


#format a string by named position -- here the 0th argument is used after the 1th
"{1}, {0} is a {2}".format("sherlock", "holmes", "detective")

#format a string by keyword

"{name} is a {profession}".format(name="sherlock", profession="detective")

# this enables a straightforward use of dictionaries when formating...

person = {
    'name': 'sherlock',
    'profession': 'detective'
}


print "{name} is a {profession}".format(**person) 
#nb., two stars = unpack dictionary into keyword arguments
# more on this operator later..



#more complex formatting is possible
planets = {'Mercury': 57.91,
           'Venus': 108.2,
           'Earth': 149.597870,
           'Mars': 227.94}

           
for i, key in enumerate(planets.keys(), 1):
    print "{0:2d} {1:<10s} {2:06.2f} Gm".format(i, key, planets[key])


# in the above the syntax is     {position:formatting}
# d means decimal number
# s means string
# f means float

# 2d means a number occupying two characters in size, padding with a space if it doesnt
# <10s means a string occupying ten characters in size, padding with a space TO THE RIGHT if it doesnt
# .2f means a floating point number with two decimal places
# 06.2f means a float occupying six chatacters, padding with 0s if not

# NB. compare the output of this command with descriptions above 



