# CHAPTER:    String Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Using string methods, analyse and display some quotes.
# TIME:       15m

fictional_quote = "Everybody seems so happy, have I possibly gone daffy? What's this?"
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
# HINT: endswith

# Q. display the longest quote: either the fictional or the political

# Q. print 30 dashes then the fictional_author and quote, 
# then 30 dashes

# Q. split apart quotables into respective authors
# HINT: what symbol separates each author?

# Q. loop over the authors, and print each without padding
# HINT: .strip

# Q. if all the characters of fictional_author are not alphabetical, 
# print it

# Q. if the unknown_quote is not spaces, 
# print it and the author on one line


# PUZZLE
# Q. print out all the author information using .format
# HINT: what does '0[name]'.format(author) do?

# use range(), ord() and chr() to print the letters A to Z on one line


''' OUTPUT (04.Strings/Exercise04-StringsA-printing.py):

'''
