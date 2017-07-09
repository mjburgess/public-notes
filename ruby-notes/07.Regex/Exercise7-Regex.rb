# CHAPTER:    Regex
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Extract some information from a poem.
# TIME:       20 m


# QUESTIONS

poem = "
I shall not rest quiet in Montparnasse.
I shall not lie easy at Winchelsea.
You may bury my body in Sussex grass,
You may bury my tongue at Champmedy.
I shall not be there, I shall rise and pass.
Bury my heart at Wounded Knee.
"

examples = [
    /^.*$/,
    /[a-z]*,/,
    /[a-z]*,[^\n]/,
    /s/,
    /s{2,3}/,
    /s{2,3}[.,]/,
    /[Bb]ury/,
    /\n[Bb]ury/,
    /[bc][0-9]*/,
    /[bc][0-9]+/,
    /now*./,
    /p*.ot/,
]

# Q. without using ruby (only pen and paper)
#... determine what each example will find in the poem
#... you should ignore the newlines,
#... ie. treat the pattern as applying to the entire poem


# Q. now use ruby to confirm your answers
# HINT: what is poem[m.begin(0)..m.end(0)] ?


#Q. how would you match an IPv4 address?
#Q. does [0-9]{3}.[0-9]{3}.[0-9]{3}.[0-9]{3} work?

#Q. construct a pattern to describe a UK postcode:

# The format of a UK postcode is as follows:
# One or two uppercase alphabetic characters
  #  followed by:     between one and two digits
  #  followed by:     an optional single uppercase alphabetic character
  #  followed by:     a single space
  #  followed by:    a single digit
  #  followed by:    two uppercase alphabetic characters



# EXTRA

#Q. how would you *extract* the second field of a comma-separated line?
#eg. two in one,two,three,four




## REVIEW: What did we learn from this exercise?