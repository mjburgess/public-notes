# CHAPTER:    File Handling
# OBJECTIVE:  Complete the following questions. 
# PROBLEM:    Sanitize a file: replace bad-words for good-words. 
# TIME:       15m

search_words = ['bad', 'awful', 'terrible', 'ugly']
replace_words = ['nice', 'wonderful', 'lovely', 'pretty']

message = """
    The world is bad. 
    People are awful. 
    Everyone is terrible. 
    And nature is ugly.
"""

# Q. use the 'with-as' syntax to write the above message to a file called document.txt 
with open('document.txt', 'w') as document:
    document.write(message)

# Q. ask the user if they want to add a keyword to the list above
# ... if so, ask them what keyword and what replacement word and append to the relevant lists 
# ... keep asking until they type 'DONE'
while True:
    search_word = input('Search Word? ')

    if search_word == 'DONE':
        break
    else:
        search_words.append(search_word)
        replace_words.append(input('Replace Word? '))

# Q. ask the user for a file to save the final message to & create it 
save_file = open(input('Save File? '), 'w')

# Q. loop over the document file line by line
# ... in this loop, move through the keywords list and the replacements list *together*
# ... use line.replace() to replace the keyword for the replacement word
# ... print the cleand line and write the cleaned line to an output file 
# HINT: zip(keywords, replacements)
# HINT: line = line.replace(search, replace)
for line in open('document.txt'):
    for search, replace in zip(search_words, replace_words):
        line = line.replace(search, replace)

    print(line)
    save_file.write(line)

# Q. remember to close the output file connection
save_file.close()

""" REVIEW

What did we learn from this exercise?

with-as context manager handls closing file connections
.replace() on strings 

using files to store and retrive data
"""


''' OUTPUT (07.Files/Solution07-FilesB-Process.py):
Search Word? Replace Word? Search Word? Replace Word? Search Word? Replace Word? Search Word? Replace Word? Search Word? Replace Word? 
'''
