# CHAPTER:    String Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using string methods, analyse and display some quotes.
# TIME:       15m

fictional_quote = "What's this? What's this? I have possibly gone daffy? What's this?"
fictional_author = "- Jack Skellington"

political_quote = "History will be kind to me for I intend to write it."
political_author = "- Winston Churchill"

unknown_quote = " ? "
unknown_author = " ? "

quotables = """
    Oscar Wilde, 
    Albert Einstein,
    William Shakespeare
"""

author = {
    'name': 'Oscar Wilde',
    'era': 'Victorian',
    'type': 'Wit'
}

# Q. if fictional_author ends with 'Skellington'
# ... print the fictional_quote and the first name of the author
if fictional_author.endswith('Skellington'):
    print(fictional_quote)
    print(fictional_author.split(' ')[0])

# Q. display the longest quote 
if len(fictional_quote) > len(political_quote):
    print(fictional_quote)
else:
    print(political_quote)

# Q. print 30 dashes then the fictional_author and quote, 
# then 30 dashes
print('-' * 30)
print(fictional_quote, fictional_author)
print('-' * 30)

# Q. split apart quotables into respective authors
# HINT: what symbol separates each author?
authors = quotables.split(',')

# Q. loop over the authors, and print each without paddding
# HINT: .strip
for a in authors:
    print(a.strip())

# Q. if all the characters of fictional_author are not alphabetical, 
# print it
if not fictional_author.isalpha():
    print(fictional_author)

# Q. if the unknown_quote is not spaces, 
# print it and the author on one line 
if not unknown_quote.isspace():
    print(unknown_quote, unknown_author)

# PUZZLE

# Q. print out all the author information using .format
# HINT: what does '0[name]'.format(author) do?
print('{0[name]} {0[era]} {0[type]}'.format(author))

# use range(), ord() and chr() to print the letters A to Z on one line
A, Z = ord('A'), ord('Z')

for c in range(A, Z + 1):
    print(chr(c), end=' ')

""" REVIEW

What did we learn from this exercise?

String library functions:

    split -- 
    join 

    strip 
    +
    *

    format 

    isspace, isalpha

    ord, chr
"""


''' OUTPUT (04.Strings/Solution04-StringsA-printing.py):
What's this? What's this? I have possibly gone daffy? What's this?
Jack
What's this? What's this? I have possibly gone daffy? What's this?
------------------------------
What's this? What's this? I have possibly gone daffy? What's this? - Jack Skellington
------------------------------
Oscar Wilde
Albert Einstein
William Shakespeare
- Jack Skellington
 ?   ? 
Oscar Wilde Victorian Wit
A B C D E F G H I J K L M N O P Q R S T U V W X Y 
'''
