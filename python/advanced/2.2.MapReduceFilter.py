# 2.2.MapReduceFilter.py

# most programming problems can be phrased as transformations on data
# that is we have some initial input (perhaps a list of raw_input()s)
# which represent the starting data and we wish to apply a series of operations
# or functions generally that produce our output data (perhaps a list of messages)

# so that we have
# input_data -> output_data

# if the input is a simple value and the output a simple value
# we have a very obvious pattern

# output = f(input)

# that is, whatever operation we wish to use -- f -- we pass as an argument to a function
# and the return value of this function is our output

def format(input):
    return "Message: " + str(input) * 2 + "\n"


input = 100
output = format(input)

print output


# but suppose the input is a more complex data type, say a list of messages
# and the output desired is a list of messages


input = [100, 200, 300]
# we would like output = ["Message: 100100\n", "Message: 200200\n", ..]

output = format(input) # this is therefore, incorrect!

print output


# in order to apply our function (format) to this new data type (a list)
# we require some help 


# in python, the map function takes a starting sequence (eg. list, tuple, string...)
# and produces a new sequence from the old one 
# where each element of this new sequence is a function applied to each element of the old

# new_seq = map(fn, old_seq)

# thus we may write,

input = [100, 200, 300]
output = map(format, input)

print output # now we have what we want


# the movement between old data and new data via a transforming funciton
# is a very common pattern in programming

# python provides three functions which work on sequences to simplify this

# MAP: 
# new_seq = map(fn, old_seq)
# len(new_seq) == len(old_seq)

# FILTER:
# new_seq = filter(fn, old_seq)
# len(new_seq) <= len(old_sequence)

# REDUCE:
# single_value = reduce(fn, old_seq, start)


print range(0, 10)        # list of ints
print map(str, range(0, 10)) # list of strings

# ''.join([1, 2, 3]) # -- ERROR! Q. Why? A. ints cannot be concatenated

# so let's convert every element of our range list to strings
print ''.join(map(str, range(0, 10)))

# or bools 

bool_list = map(bool, [True, False, None, 1, 0])
print bool_list


# or formated strings
print map(format, map(str, range(100, 500, 100)))



# FILTER: 
# produces a new sequence from an old one using a test (or "predicat funciton")
# ie., a function which returns a bool
# if the return value is true, the element is preserved; if it is false, thrown away


user_input = ['michael', 0, '', None, 'UK']

#Q. what is the bool value of each element?
#A.
print map(bool, user_input)

#now let's remove from user input each element that is bool()-False

print filter(bool, user_input)


# or we can use our own function

#Q. why do you think this is called a predicate function?

def isAdult(person): 
    return person['age'] >= 18
    
input = [
            {'name': 'Sherlock Jnr.', 'age': 15},
            {'name': 'Sherlock', 'age': 27},
            {'name': 'Watson', 'age': 35}
        ]
# a list of dictionaries
# each element is a dictionary with two keys: name and age

print filter(isAdult, input) # removes Sherlock Jnr!



# finally, REDUE: combines every value together to produce a single, aggregate value

# for every operator in python there is a corresponding function
# available in the operator module

import operator

#for example, the + operator

print operator.add(10, 20)        # integer addition
print operator.add("10", "20")    # string concatenation
print operator.add((10, 20), (10, 20)) # tuple concatentation


# we can apply the add function to a starting number 
# and then every in a sequence to get a total

total = 0 # the starting number
input = [2, 3, 5] 

total += input[0]
total += input[1]
total += input[2]

print total

# OR, equally

total = 0

total = operator.add(total, input[0])
total = operator.add(total, input[1])
total = operator.add(total, input[2])

print total

# reduce performs this repetition for us...

print reduce(operator.add, range(0, 10), 0)
# adds all the numbers from 0 to 10, starting with an initial aggregate/total 0



# recall, the example user input from before

user_input = ['michael', 0, '', None, 'UK']
bool_list = map(bool, user_input)

# we can now ask: is every value in bool list True?
print reduce(operator.__and__, bool_list, True)

#is *any* value True?
print reduce(operator.__or__, bool_list, False)


#Q. why in the case of 'and' is the initial value True?
#Q. why in the case of 'or' is the initial value False?



# the combination of these map and reduce operations are available as,

print any(user_input)    # is any bool()-True ?
print all(user_input)    # are all bool()-True ?




