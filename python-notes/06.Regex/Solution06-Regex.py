# CHAPTER:    Regex
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Extract some information from a poem.
# TIME:       20 m

import re

poem = """
I shall not rest quiet in Montparnasse.
I shall not lie easy at Winchelsea.
You may bury my body in Sussex grass,
You may bury my tongue at Champmedy.
I shall not be there, I shall rise and pass.
Bury my heart at Wounded Knee.
"""

examples = [
    r"^.*$",
    r"[a-z]*,",
    r"[a-z]*,[^\n]",
    r"s",
    r"s{2,3}",
    r"s{2,3}[.,]",
    r"[Bb]ury",
    r"\n[Bb]ury",
    r"[bc][0-9]*",
    r"[bc][0-9]+",
    r"now*.",
    r"p*.ot",
]

# Q. without using python (only pen and paper)
# ... determine what each example will find in the poem
# ... you should ignore the newlines, 
# ie. treat the pattern as applying to the entire poem


# Q. now use python to confirm your answers
# HINT: loop over examples 
# on each re.search for the regex in poem
# if it matches, print poem[slice(m.start(), m.end())] 
# otherwise print 'NO MATCH'

for ex in examples:
    m = re.search(ex, poem)
    if m:
        print(m.start(), m.end())
        print(poem[slice(m.start(), m.end())])
    else:
        print('NO MATCH')

# Q. how would you match an IPv4 address?
# Q. does [0-9]{3}.[0-9]{3}.[0-9]{3}.[0-9]{3} work?

simple_ip_regex = "[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"

# --> is this *better* ? what would *better* mean?
more_accurate_ip_regex = "(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3} (?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)"

# Q. construct a pattern to describe a UK postcode:

"""
The format of a UK postcode is as follows:
One or two uppercase alphabetic characters
    followed by:     between one and two digits
    followed by:     an optional single uppercase alphabetic character
    followed by:     a single space
    followed by:    a single digit
    followed by:    two uppercase alphabetic characters
"""

postcode_regex = "[A-Z]{1,2}[0-9]{1,2}[A-Z]? [0-9][A-Z]{2}"

# EXTRA
# Q. How would you *extract* the second field of a comma-separated line?
# eg. 'two' in one,two,three,four

comma_regex = ",([^,]*),"

""" REVIEW

What did we learn from this exercise?

re module 
re.search 
.group(0) .groups()
.start() .end() .offset()

0. A regex means: find the 1st occurance of... 
1. Any character without a special meaning is literal
2. abc 123 - / etc. have no special meaning
3. . means ANY single character
4. ANY means 0 or more
5. SOME means 1 or more
6. [abc]  means match ONE character EITHER a b c 
7. [a-z]  means match ONE character in the RANGE a to z 
8. [^abc] means match ONE character NOT  a b c 
9. play(ing|er|able)  means play then EITHER ing OR er OR able
10. x{1, 4} means AT LEAST 1 x and AT MOST 4 x
11. x{0, 1} means x is optional (AT LEAST 0, AT MOST 1)
12. x{0,} means ANY amount of x  (AT LEAST 0, AT MOST infinite)
13. x{1,} means SOME amount of x (AT LEAST 1, AT MOST infinite)
14. x? means x{0,1}       x* means x{0,}        x+   means x{1,}
15. \s means [ \n\t\r]   \w means [a-bA-Z0-9_]  \d   means [0-9]
16. ^example.com    means THE FIRST CHARACTER IS e THEN x THEN a.. 
17. example.com$    means THE LAST CHARACTER IS m AFTER o AFTER c... 
18. (\w+)  REMEMBERS matched text
"""


''' OUTPUT (06.Regex/Solution06-Regex.py):
NO MATCH
108 114
grass,
167 174
there, 
3 4
s
36 38
ss
111 114
ss,
85 89
bury
196 201

Bury
68 69
c
NO MATCH
9 12
not
9 12
not

'''
