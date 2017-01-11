# 1.3.Data.py

# 3. simple data types

#Q. how would you find out the type of these?

age = 27            # int
name = "Michael"    # str
height = 1.81        # float

#A. the type() function...

# ints 

ten = 0xA

print ten
print hex(10)
print bin(9)


#4. complex data types 
#nb., there'll be more on these later...

# a list is defined with square brackets
names = ["Sherlock", "Moriarty", "Watson"]

# the first element of the list is available at position 0, the second at 1...
# you look up a position using the subscript [] operator

print names[0]        # look up the element 0 in the list names


# the last element of the list is at -1
print names[-1]

#equally you can think of lists as 0-indexed moving forwards
# and -1-indexed moving backwards, so that -2 is "Moriarty" in the list above


# strings are list-like (they behave like a list of characters)

detective = "Sherlock Holmes"

print detective[-3] # Q. if -1 is 's' what is -3?


# elements of lists can be over-written
names[1] = "Hudson"            # replace the second element with "Hudson"
                            #nb., first = 0, second = 1, third = 2, ... be careful!

                            
print names


# finally, lists have a length which is just the number of elements they contain

print len("Michael")    # len() can be applied to any sequence which includes strings 
print len(names)        # and lists 


print names[0], names[1]    #Q. what does the comma do (in a print statement)?
                            #A. joins with a space



# as you have seen above using the subscript operator you can associate integers with values
# that is, you can lookup "Hudson" in the list names with the key 1 
#ie.,  mylist[key] = "value" -- asssociates key with "value"

# dictionaries can associate other kinds of keys (non-integers, and especially strings) with values

professions = {                        #nb., braces
    "detective": "sherlock",        #nb., colons and commas
    "doctor": "watson"
}

#Q. what type is professions?
#A. dict  -- the type of dictionaries

#Q. how do you look-up 'doctor' in professions ?
#A. use the subscript operator...

print professions['doctor']        

# Q. how do you add new elements to a dictionary?
# A. use the subscript operator...


professions['mathematician'] = 'moriarty'

print professions